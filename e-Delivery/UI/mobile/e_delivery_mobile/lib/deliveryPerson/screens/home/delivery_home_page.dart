import 'package:e_delivery_mobile/deliveryPerson/screens/home/api/delivery_home_service.dart';
import 'package:e_delivery_mobile/deliveryPerson/screens/order/delivery_order_details_page.dart';
import 'package:flutter/material.dart';
import 'package:e_delivery_mobile/deliveryPerson/screens/Home/dto/delivery_person_get_dto.dart';
import 'package:e_delivery_mobile/customer/screens/profile/dto/order_get_dto.dart';
import 'package:intl/intl.dart';

class DeliveryHomePage extends StatefulWidget {
  const DeliveryHomePage({Key? key}) : super(key: key);

  @override
  _DeliveryHomePageState createState() => _DeliveryHomePageState();
}

class _DeliveryHomePageState extends State<DeliveryHomePage> {
  final DeliveryHomeService _deliveryHomeService = DeliveryHomeService();
  late Future<DeliveryPersonGetDTO> _futureUser;
  List<OrderGetDto>? _orders;
  bool _isLoading = true;
  String _errorMessage = '';

  @override
  void initState() {
    super.initState();
    _futureUser = _deliveryHomeService.fetchLoggedInUser();
    _fetchOrders();
  }

  Future<void> _fetchOrders() async {
    try {
      final result = await _deliveryHomeService.fetchOrders();
      if (!mounted) return;
      if (result['orders'] != null) {
        setState(() {
          _orders = result['orders'];

          _isLoading = false;
        });
      } else {
        setState(() {
          _errorMessage = 'No orders found.';
          _isLoading = false;
        });
      }
    } catch (e) {
      if (!mounted) return;
      setState(() {
        _errorMessage = 'Error fetching orders: $e';
        _isLoading = false;
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: _isLoading
          ? Center(child: CircularProgressIndicator())
          : SingleChildScrollView(
              child: Padding(
                padding: const EdgeInsets.all(16.0),
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    SizedBox(height: 40),
                    FutureBuilder<DeliveryPersonGetDTO>(
                      future: _futureUser,
                      builder: (context, snapshot) {
                        if (snapshot.connectionState ==
                            ConnectionState.waiting) {
                          return CircularProgressIndicator();
                        } else if (snapshot.hasError) {
                          return Text("Error: ${snapshot.error}");
                        } else if (snapshot.hasData) {
                          return Column(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            children: [
                              Text(
                                "Welcome ${snapshot.data!.userName}, complete your orders",
                                style: TextStyle(
                                  fontSize: 20,
                                  fontWeight: FontWeight.bold,
                                ),
                              ),
                              SizedBox(height: 30),
                              Row(
                                mainAxisAlignment:
                                    MainAxisAlignment.spaceBetween,
                                children: [
                                  Text(
                                      "Status: ${snapshot.data!.isAvailable! ? 'Available' : 'Not available'}"),
                                  Text(
                                      "Number of current orders: ${_orders?.where((order) => order.orderState == 2).length ?? 0}"),
                                ],
                              ),
                              Divider(thickness: 2),
                            ],
                          );
                        } else {
                          return Text("No data available");
                        }
                      },
                    ),
                    SizedBox(height: 20),
                    Text(
                      "Your most recent orders",
                      style: TextStyle(
                        fontSize: 18,
                        fontWeight: FontWeight.bold,
                      ),
                    ),
                    Divider(thickness: 2),
                    SizedBox(height: 10),
                    Row(
                      mainAxisAlignment: MainAxisAlignment.spaceAround,
                      children: [
                        Text('Address',
                            style: TextStyle(fontWeight: FontWeight.bold)),
                        Text('Date',
                            style: TextStyle(fontWeight: FontWeight.bold)),
                        Text('Cost',
                            style: TextStyle(fontWeight: FontWeight.bold)),
                        Text('Details',
                            style: TextStyle(fontWeight: FontWeight.bold)),
                      ],
                    ),
                    SizedBox(height: 10),
                    if (_orders != null && _orders!.isNotEmpty)
                      ..._orders!.take(3).map((order) {
                        return Card(
                          elevation: 4,
                          margin: EdgeInsets.symmetric(vertical: 8),
                          child: Padding(
                            padding: const EdgeInsets.all(16.0),
                            child: Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              children: [
                                Text(order.address ?? "No address",
                                    style: TextStyle(fontSize: 14)),
                                Text(
                                  DateFormat('dd.MM  HH:mm').format(
                                      DateTime.parse(order.createdDate)),
                                  style: TextStyle(fontSize: 14),
                                ),
                                Text(
                                  "${order.totalCost.toStringAsFixed(2)} KM",
                                  style: TextStyle(fontSize: 14),
                                ),
                                IconButton(
                                  icon: Icon(Icons.arrow_forward,
                                      color: Colors.orange),
                                  onPressed: () {
                                    Navigator.push(
                                      context,
                                      MaterialPageRoute(
                                        builder: (context) =>
                                            DeliveryOrderDetailsPage(
                                                orderId: order.id),
                                      ),
                                    );
                                  },
                                ),
                              ],
                            ),
                          ),
                        );
                      }).toList()
                    else
                      const Center(child: Text("No orders found")),
                  ],
                ),
              ),
            ),
    );
  }
}
