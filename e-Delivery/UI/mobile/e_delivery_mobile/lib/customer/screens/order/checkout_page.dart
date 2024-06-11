import 'dart:convert';
import 'package:e_delivery_mobile/customer/screens/home/customer_entry_point.dart';
import 'package:fluttertoast/fluttertoast.dart';
import 'package:http/http.dart' as http;
import 'package:e_delivery_mobile/customer/screens/home/dto/restaurant_get_dto.dart';
import 'package:e_delivery_mobile/customer/screens/order/allergies_section.dart';
import 'package:e_delivery_mobile/customer/screens/order/api/order_service.dart';
import 'package:e_delivery_mobile/customer/screens/order/delivery_details_section.dart';
import 'package:e_delivery_mobile/customer/screens/order/dto/orderDto.dart';
import 'package:e_delivery_mobile/customer/screens/order/payment_details_section.dart';
import 'package:e_delivery_mobile/storage_service.dart';
import 'package:flutter/material.dart';
import 'package:e_delivery_mobile/customer/screens/order/dto/orderitem_dto.dart';
import 'package:flutter_stripe/flutter_stripe.dart';

import '../../../.env';

class CheckoutPage extends StatefulWidget {
  final List<OrderItem> orderItems;
  final RestaurantViewModel restaurant;
  final Function()? onPaymentCompleted;
  String? stripeSk;
  CheckoutPage(
      {Key? key,
      required this.orderItems,
      required this.restaurant,
      this.onPaymentCompleted})
      : super(key: key) {
    stripeSk = const String.fromEnvironment("stripeSecretKey",
        defaultValue: stripeSecretKey);
  }

  @override
  _CheckoutPageState createState() => _CheckoutPageState();
}

class _CheckoutPageState extends State<CheckoutPage> {
  late List<OrderItem> _orderItems;
  final OrderService _orderService = OrderService();
  final Map<int, Future<Map<String, dynamic>>> _orderItemFutures = {};
  Map<String, String>? _addressDetails = {};
  String? _allergies;
  String? _address;
  int _paymentMethod = 1;
  final StripePaymentHandle _stripePaymentHandle = StripePaymentHandle();
  bool _paymentInProgress = false;

  late RestaurantViewModel _restaurant;
  @override
  void initState() {
    super.initState();
    _orderItems = List.from(widget.orderItems);
    _restaurant = widget.restaurant;
    _initializeOrderItemFutures();
  }

  void _initializeOrderItemFutures() {
    for (var orderItem in _orderItems) {
      _orderItemFutures[orderItem.foodItemId] = _fetchOrderItemData(orderItem);
    }
  }

  Future<Map<String, dynamic>> _fetchOrderItemData(OrderItem orderItem) async {
    final foodItemName =
        await _orderService.getFoodItemNameById(orderItem.foodItemId);
    List<String> sideDishNames = [];
    try {
      sideDishNames =
          await _orderService.getSideDishNames(orderItem.sideDishIds);
    } catch (e) {
      print("Failed to load side dishes: $e");
    }
    return {
      'foodItemName': foodItemName,
      'sideDishNames': sideDishNames,
    };
  }

  void _updateOrderItemQuantity(OrderItem orderItem, int newQuantity) {
    setState(() {
      if (newQuantity == 0) {
        _showDeleteConfirmationDialog(orderItem);
      } else {
        final unitPrice = orderItem.cost / orderItem.quantity;
        orderItem.quantity = newQuantity;
        orderItem.cost = unitPrice * newQuantity;
      }
    });
  }

  void _showDeleteConfirmationDialog(OrderItem orderItem) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: const Text('Delete Item'),
          content: const Text('Are you sure you want to delete this item?'),
          actions: [
            TextButton(
              child: const Text('No'),
              onPressed: () {
                Navigator.of(context).pop();
              },
            ),
            TextButton(
              child: const Text('Yes'),
              onPressed: () {
                setState(() {
                  _orderItems.remove(orderItem);
                  if (_orderItems.isEmpty) {
                    Navigator.of(context).pop();
                    Navigator.pop(context);
                  } else {
                    Navigator.of(context).pop();
                  }
                });
              },
            ),
          ],
        );
      },
    );
  }

  double _calculateTotalPrice() {
    return _orderItems.fold(0, (sum, item) => sum + item.cost);
  }

  double getTotalAmount() {
    double itemsTotal = _calculateTotalPrice();
    double deliveryCharge = _restaurant.deliveryCharge;
    return itemsTotal + deliveryCharge;
  }

  void _updateAddressDetails(Map<String, String> newAddressDetails) {
    setState(() {
      _addressDetails = newAddressDetails;
    });
  }

  void _updatePaymentMethod(int paymentMethod) {
    setState(() {
      _paymentMethod = paymentMethod;
    });
  }

  Future<String> _getCityIdFromUserData() async {
    final userData = await StorageService.storage.read(key: 'userData');
    if (userData != null) {
      final userDataJson = jsonDecode(userData);
      final cityId = userDataJson['cityId'].toString();
      return cityId;
    } else {
      throw Exception('User data is not available');
    }
  }

  Future<void> _createOrder() async {
    if (_address == null || _address!.isEmpty) {
      if (mounted) {
        ScaffoldMessenger.of(context).showSnackBar(
          CustomSnackBar(message: 'Address cannot be empty'),
        );
      }
      return;
    }

    if (_addressDetails == null ||
        _addressDetails!['latitude'] == null ||
        _addressDetails!['latitude']!.isEmpty) {
      if (mounted) {
        ScaffoldMessenger.of(context).showSnackBar(
          CustomSnackBar(message: 'Latitude cannot be empty'),
        );
      }
      return;
    }

    if (_addressDetails == null ||
        _addressDetails!['longitude'] == null ||
        _addressDetails!['longitude']!.isEmpty) {
      if (mounted) {
        ScaffoldMessenger.of(context).showSnackBar(
          CustomSnackBar(message: 'Longitude cannot be empty'),
        );
      }
      return;
    }

    try {
      final cityId = await _getCityIdFromUserData();
      final orderDto = OrderDto(
        paymentMethod: _paymentMethod,
        totalCost: _calculateTotalPrice() + _restaurant.deliveryCharge,
        allergies: _allergies ?? '',
        restaurantId: _restaurant.id,
        cityId: int.parse(cityId),
        latitude: _addressDetails!['latitude'] ?? '',
        longitude: _addressDetails!['longitude'] ?? '',
        address: _address ?? '',
        orderItems: _orderItems.map((item) {
          return OrderItemDto(
            foodItemId: item.foodItemId,
            sideDishIds: item.sideDishIds,
            quantity: item.quantity,
            cost: item.cost,
          );
        }).toList(),
      );

      await _orderService.createOrder(orderDto.toJson());

      if (mounted) {
        ScaffoldMessenger.of(context).showSnackBar(
          CustomSnackBar(message: 'Success'),
        );
        await Future.delayed(Duration(seconds: 2));
        Navigator.pushReplacement(context,
            MaterialPageRoute(builder: (_) => const CustomerEntryPoint()));
      }
    } catch (e) {
      print('Failed to create order: $e');
      if (mounted) {
        ScaffoldMessenger.of(context).showSnackBar(
          CustomSnackBar(message: 'Failed to create order'),
        );
      }
    }
  }

  void _showConfirmationDialog() {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: const Text('Confirm Order'),
          content: const Text('Are you sure you want to create your order?'),
          actions: [
            TextButton(
              child: const Text('No'),
              onPressed: () {
                Navigator.of(context).pop();
              },
            ),
            TextButton(
              child: const Text('Yes'),
              onPressed: () async {
                Navigator.of(context).pop();
                await _createOrder();
              },
            ),
          ],
        );
      },
    );
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Checkout'),
        leading: IconButton(
          icon: const Icon(Icons.arrow_back),
          onPressed: () => Navigator.pop(context, _orderItems),
        ),
      ),
      body: Stack(
        children: [
          SingleChildScrollView(
            child: Padding(
              padding: const EdgeInsets.all(12.0),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  const Text(
                    'Your Order',
                    style: TextStyle(fontSize: 24, fontWeight: FontWeight.bold),
                  ),
                  const SizedBox(height: 16),
                  ListView.builder(
                    shrinkWrap: true,
                    physics: NeverScrollableScrollPhysics(),
                    itemCount: _orderItems.length,
                    itemBuilder: (context, index) {
                      final orderItem = _orderItems[index];
                      return FutureBuilder(
                        future: _orderItemFutures[orderItem.foodItemId],
                        builder: (context, snapshot) {
                          if (snapshot.connectionState ==
                              ConnectionState.waiting) {
                            return const Center(
                                child: CircularProgressIndicator());
                          } else if (snapshot.hasError) {
                            return Center(
                                child: Text('Error: ${snapshot.error}'));
                          } else {
                            final data = snapshot.data as Map<String, dynamic>;
                            return _buildOrderItemRow(orderItem,
                                data['foodItemName'], data['sideDishNames']);
                          }
                        },
                      );
                    },
                  ),
                  const SizedBox(height: 16),
                  AllergiesSection(
                    allergies: _allergies,
                    onSave: (value) {
                      setState(() {
                        _allergies = value;
                      });
                    },
                  ),
                  const SizedBox(height: 16),
                  const Divider(thickness: 2),
                  DeliveryDetailsSection(
                    address: _address,
                    addressDetails: _addressDetails,
                    onAddressSelected: (value) {
                      setState(() {
                        _address = value;
                      });
                      print(_address);
                    },
                    onAddressDetailsUpdated: _updateAddressDetails,
                  ),
                  const SizedBox(height: 16),
                  const Divider(thickness: 2),
                  PaymentDetailsSection(
                    paymentMethod: _paymentMethod,
                    onPaymentMethodChanged: _updatePaymentMethod,
                  ),
                  SizedBox(height: 16),
                  Divider(
                    color: Colors.green[800],
                    thickness: 2,
                  ),
                  Container(
                    color: Colors.grey[200],
                    padding: const EdgeInsets.all(16),
                    child: _buildSummarySection(),
                  ),
                  const SizedBox(height: 80),
                ],
              ),
            ),
          ),
          Positioned(
            bottom: 0,
            left: 0,
            right: 0,
            child: Container(
              padding: const EdgeInsets.all(16),
              child: ElevatedButton(
                onPressed: _paymentInProgress
                    ? null
                    : () {
                        if (_paymentMethod == 2) {
                          _showConfirmationDialog();
                        } else {
                          _startPaymentProcess();
                        }
                      },
                style: ElevatedButton.styleFrom(
                  primary: Colors.green,
                  padding: const EdgeInsets.symmetric(vertical: 16),
                  shape: RoundedRectangleBorder(
                    borderRadius: BorderRadius.circular(16),
                  ),
                ),
                child: const Text(
                  'Confirm Order',
                  style: TextStyle(fontSize: 18),
                ),
              ),
            ),
          ),
        ],
      ),
    );
  }

  Widget _buildSummarySection() {
    final double deliveryFee = _restaurant.deliveryCharge;
    final double totalPrice = _calculateTotalPrice();

    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        const Text(
          'Summary',
          style: TextStyle(fontSize: 24, fontWeight: FontWeight.bold),
        ),
        const SizedBox(height: 16),
        Container(
          padding: const EdgeInsets.all(16),
          decoration: BoxDecoration(
            color: Colors.grey[200],
            borderRadius: BorderRadius.circular(8),
          ),
          child: Column(
            children: [
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  const Text('Products'),
                  Text('KM ${totalPrice.toStringAsFixed(2)}'),
                ],
              ),
              const SizedBox(height: 8),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  const Text('Delivery Fee'),
                  Text('KM ${deliveryFee.toStringAsFixed(2)}'),
                ],
              ),
              const Divider(thickness: 1),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  const Text(
                    'TOTAL',
                    style: TextStyle(fontWeight: FontWeight.bold),
                  ),
                  Text(
                    'KM ${(totalPrice + deliveryFee).toStringAsFixed(2)}',
                    style: const TextStyle(fontWeight: FontWeight.bold),
                  ),
                ],
              ),
            ],
          ),
        ),
      ],
    );
  }

  Widget _buildOrderItemRow(
      OrderItem orderItem, String foodItemName, List<String> sideDishNames) {
    return Column(
      children: [
        Container(
          color: Colors.grey[200],
          padding: const EdgeInsets.symmetric(horizontal: 16, vertical: 8),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              Row(
                children: [
                  Text(
                    '${orderItem.quantity}x',
                    style: const TextStyle(
                        fontSize: 16, fontWeight: FontWeight.bold),
                  ),
                  const SizedBox(width: 16),
                  Expanded(
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Text(
                          foodItemName,
                          style: const TextStyle(
                              fontSize: 16, fontWeight: FontWeight.bold),
                        ),
                        const SizedBox(height: 4),
                        Text(
                          sideDishNames.isNotEmpty
                              ? sideDishNames.join(', ')
                              : 'No side dishes',
                          style:
                              TextStyle(fontSize: 14, color: Colors.grey[700]),
                        ),
                      ],
                    ),
                  ),
                  Text(
                    'KM ${orderItem.cost.toStringAsFixed(2)}',
                    style: const TextStyle(
                        fontSize: 16, fontWeight: FontWeight.bold),
                  ),
                ],
              ),
              const SizedBox(height: 8),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  IconButton(
                    icon: const Icon(Icons.remove, color: Colors.orange),
                    onPressed: () => _updateOrderItemQuantity(
                        orderItem, orderItem.quantity - 1),
                  ),
                  IconButton(
                    icon: const Icon(Icons.add, color: Colors.orange),
                    onPressed: () => _updateOrderItemQuantity(
                        orderItem, orderItem.quantity + 1),
                  ),
                ],
              ),
            ],
          ),
        ),
        const Divider(),
      ],
    );
  }

  Future<void> _startPaymentProcess() async {
    setState(() {
      _paymentInProgress = true;
    });

    double totalAmount = getTotalAmount();

    try {
      await _stripePaymentHandle.stripeMakePayment(
          context, _createOrder, widget.stripeSk!, totalAmount.toString());
    } catch (e) {
      print("Error: $e");
    } finally {
      setState(() {
        _paymentInProgress = false;
      });
    }
  }
}

class StripePaymentHandle {
  Map<String, dynamic>? paymentIntent;

  Future<void> stripeMakePayment(BuildContext context,
      Function()? onPaymentSuccess, String stripeSk, String amount) async {
    try {
      paymentIntent = await createPaymentIntent(amount, 'BAM', stripeSk);
      await Stripe.instance
          .initPaymentSheet(
              paymentSheetParameters: SetupPaymentSheetParameters(
                  paymentIntentClientSecret: paymentIntent!['client_secret'],
                  style: ThemeMode.dark,
                  merchantDisplayName: 'Ikay'))
          .then((value) {});

      displayPaymentSheet(context, onPaymentSuccess, stripeSk);
    } catch (e) {
      Fluttertoast.showToast(msg: e.toString());
    }
  }

  displayPaymentSheet(BuildContext context, Function()? onPaymentSuccess,
      String stripeSk) async {
    try {
      await Stripe.instance.presentPaymentSheet();

      Fluttertoast.showToast(msg: 'Payment successfully completed');

      onPaymentSuccess!();

      Navigator.pop(context);
    } on Exception catch (e) {
      if (e is StripeException) {
        Fluttertoast.showToast(msg: '${e.error.localizedMessage}');
      } else {
        Fluttertoast.showToast(msg: 'Unforeseen error: $e');
      }
    }
  }

  createPaymentIntent(String amount, String currency, String stripeSk) async {
    try {
      Map<String, dynamic> body = {
        'amount': calculateAmount(amount),
        'currency': currency,
      };

      var response = await http.post(
        Uri.parse('https://api.stripe.com/v1/payment_intents'),
        headers: {
          'Authorization': 'Bearer $stripeSk',
          'Content-Type': 'application/x-www-form-urlencoded'
        },
        body: body,
      );
      return json.decode(response.body);
    } catch (err) {
      throw Exception(err.toString());
    }
  }

  String calculateAmount(String amount) {
    final double cost = double.parse(amount);
    final int calculatedAmount = (cost * 100).toInt();
    return calculatedAmount.toString();
  }
}

class CustomSnackBar extends SnackBar {
  final String message;

  CustomSnackBar({required this.message})
      : super(
          content: Text(
            message,
            textAlign: TextAlign.center,
            style: TextStyle(color: Colors.white, fontWeight: FontWeight.bold),
          ),
          backgroundColor: message == 'Success' ? Colors.green : Colors.red,
          behavior: SnackBarBehavior.floating,
          shape: RoundedRectangleBorder(
            borderRadius: BorderRadius.circular(24),
          ),
          margin: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
        );
}
