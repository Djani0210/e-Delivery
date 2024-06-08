import 'package:flutter/material.dart';
import 'package:google_maps_flutter/google_maps_flutter.dart';
import 'package:e_delivery_mobile/customer/screens/profile/api/profile_api.dart';
import 'package:e_delivery_mobile/customer/screens/profile/dto/order_get_dto.dart';
import 'package:intl/intl.dart';

class OrderDetailsPage extends StatefulWidget {
  final String orderId;

  const OrderDetailsPage({Key? key, required this.orderId}) : super(key: key);

  @override
  _OrderDetailsPageState createState() => _OrderDetailsPageState();
}

class _OrderDetailsPageState extends State<OrderDetailsPage> {
  final int _itemsPerPage = 3;
  int _currentMaxItems = 3;
  bool isLoading = true;
  bool _showMap = false;
  String errorMessage = '';
  OrderGetDto? order;

  @override
  void initState() {
    super.initState();
    _fetchOrderDetails();
  }

  Future<void> _fetchOrderDetails() async {
    try {
      final ProfileService profileService = ProfileService();
      var fetchedOrder = await profileService.fetchOrderById(widget.orderId);
      if (!mounted) return;
      setState(() {
        order = fetchedOrder;
        isLoading = false;
      });
    } catch (e) {
      if (!mounted) return;
      setState(() {
        errorMessage = e.toString();
        isLoading = false;
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Order Details'),
        backgroundColor: Colors.orange,
      ),
      body: isLoading
          ? Center(child: CircularProgressIndicator())
          : errorMessage.isNotEmpty
              ? Center(child: Text(errorMessage))
              : order == null
                  ? Center(child: Text("Order not found"))
                  : _buildOrderContent(),
    );
  }

  Widget _buildAdditionalInfoSection() {
    return Container(
      margin: EdgeInsets.symmetric(vertical: 16),
      padding: EdgeInsets.all(16),
      decoration: BoxDecoration(
        color: Colors.white,
        borderRadius: BorderRadius.circular(10),
        boxShadow: [
          BoxShadow(
            color: Colors.grey.withOpacity(0.3),
            spreadRadius: 2,
            blurRadius: 5,
            offset: Offset(0, 3),
          ),
        ],
      ),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Text(
            'Additional Information',
            style: TextStyle(
              fontSize: 20,
              fontWeight: FontWeight.bold,
              color: Colors.orange,
            ),
          ),
          SizedBox(height: 16),
          _buildInfoRow('Order State', _getOrderStateName(order!.orderState)),
          _buildInfoRow(
            'Created on',
            DateFormat('dd MMM yyyy')
                .format(DateTime.parse(order!.createdDate)),
          ),
          _buildInfoRow(
              'Payment Method', _getPaymentMethodName(order!.paymentMethod)),
        ],
      ),
    );
  }

  Widget _buildAllergiesSection() {
    if (order!.allergies == null || order!.allergies!.isEmpty) {
      return SizedBox.shrink();
    }

    return Container(
      margin: EdgeInsets.symmetric(vertical: 16),
      padding: EdgeInsets.all(16),
      decoration: BoxDecoration(
        color: Colors.white,
        borderRadius: BorderRadius.circular(10),
        boxShadow: [
          BoxShadow(
            color: Colors.grey.withOpacity(0.3),
            spreadRadius: 2,
            blurRadius: 5,
            offset: Offset(0, 3),
          ),
        ],
      ),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Text(
            'Allergies',
            style: TextStyle(
              fontSize: 20,
              fontWeight: FontWeight.bold,
              color: Colors.orange,
            ),
          ),
          SizedBox(height: 16),
          Text(
            order!.allergies!,
            style: TextStyle(fontSize: 16),
          ),
        ],
      ),
    );
  }

  Widget _buildRestaurantAndDeliveryInfo() {
    return Container(
      margin: EdgeInsets.symmetric(vertical: 16),
      padding: EdgeInsets.all(16),
      decoration: BoxDecoration(
        color: Colors.white,
        borderRadius: BorderRadius.circular(10),
        boxShadow: [
          BoxShadow(
            color: Colors.grey.withOpacity(0.3),
            spreadRadius: 2,
            blurRadius: 5,
            offset: Offset(0, 3),
          ),
        ],
      ),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Text(
            'Restaurant & Delivery Info',
            style: TextStyle(
              fontSize: 20,
              fontWeight: FontWeight.bold,
              color: Colors.orange,
            ),
          ),
          SizedBox(height: 16),
          _buildInfoRow('Restaurant', order!.restaurantName!),
          _buildInfoRow('Customer', order!.userName ?? 'Not provided'),
          _buildInfoRow('Delivery Person',
              order!.deliveryPersonAssigned ?? 'Not assigned'),
        ],
      ),
    );
  }

  Widget _buildSummarySection() {
    return Container(
      margin: EdgeInsets.symmetric(vertical: 16),
      padding: EdgeInsets.all(16),
      decoration: BoxDecoration(
        color: Colors.white,
        borderRadius: BorderRadius.circular(10),
        boxShadow: [
          BoxShadow(
            color: Colors.grey.withOpacity(0.3),
            spreadRadius: 2,
            blurRadius: 5,
            offset: Offset(0, 3),
          ),
        ],
      ),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Text(
            'Summary',
            style: TextStyle(
              fontSize: 20,
              fontWeight: FontWeight.bold,
              color: Colors.orange,
            ),
          ),
          SizedBox(height: 16),
          _buildSummaryRow(
              'Products', 'KM ${(order!.totalCost) - (order!.deliveryCost!)}0',
              isBold: true),
          _buildSummaryRow(
              'Delivery Cost', 'KM ${order!.deliveryCost!.toStringAsFixed(2)}'),
          Divider(thickness: 1),
          _buildSummaryRow('Total', 'KM ${order!.totalCost.toStringAsFixed(2)}',
              isBold: true),
        ],
      ),
    );
  }

  Widget _buildInfoRow(String label, String value) {
    return Padding(
      padding: const EdgeInsets.symmetric(vertical: 8),
      child: Row(
        mainAxisAlignment: MainAxisAlignment.spaceBetween,
        children: [
          Text(
            label,
            style: TextStyle(fontSize: 16, fontWeight: FontWeight.bold),
          ),
          Expanded(
            child: Text(
              value,
              style: TextStyle(fontSize: 16),
              textAlign: TextAlign.right,
            ),
          ),
        ],
      ),
    );
  }

  Widget _buildSummaryRow(String label, String value, {bool isBold = false}) {
    return Padding(
      padding: const EdgeInsets.symmetric(vertical: 8),
      child: Row(
        mainAxisAlignment: MainAxisAlignment.spaceBetween,
        children: [
          Text(
            label,
            style: TextStyle(
              fontSize: 16,
              fontWeight: isBold ? FontWeight.bold : FontWeight.normal,
            ),
          ),
          Text(
            value,
            style: TextStyle(
              fontSize: 16,
              fontWeight: isBold ? FontWeight.bold : FontWeight.normal,
            ),
          ),
        ],
      ),
    );
  }

  String _getOrderStateName(int orderState) {
    switch (orderState) {
      case 1:
        return 'Created';
      case 2:
        return 'In Delivery';
      case 3:
        return 'Delivered';
      case 4:
        return 'Canceled';
      default:
        return 'Unknown';
    }
  }

  String _getPaymentMethodName(int methodCode) {
    switch (methodCode) {
      case 1:
        return "Credit Card";
      case 2:
        return "Cash";
      default:
        return "Unknown";
    }
  }

  Widget _buildOrderContent() {
    return SingleChildScrollView(
      padding: EdgeInsets.all(16.0),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Text(
            'Order Items',
            style: TextStyle(fontSize: 24, fontWeight: FontWeight.bold),
          ),
          SizedBox(height: 16),
          ...List.generate(
            _currentMaxItems < order!.orderItems.length
                ? _currentMaxItems
                : order!.orderItems.length,
            (i) => Column(
              children: [
                _buildOrderItem(order!.orderItems[i]),
                SizedBox(height: 16), // Add space between items
              ],
            ),
          ),
          if (_currentMaxItems < order!.orderItems.length)
            Center(
              child: ElevatedButton(
                onPressed: () {
                  setState(() {
                    _currentMaxItems = (_currentMaxItems + _itemsPerPage >
                            order!.orderItems.length)
                        ? order!.orderItems.length
                        : _currentMaxItems + _itemsPerPage;
                  });
                },
                child: Text('Show More'),
              ),
            ),
          Divider(thickness: 2),
          _buildDeliveryDetailsSection(),
          Divider(thickness: 2),
          _buildRestaurantAndDeliveryInfo(),
          Divider(thickness: 2),
          _buildAllergiesSection(),
          Divider(thickness: 2),
          _buildAdditionalInfoSection(),
          Divider(thickness: 2),
          _buildSummarySection(),
        ],
      ),
    );
  }

  Widget _buildOrderItem(OrderItemDto orderItem) {
    String imageUrl = orderItem.foodItem.foodItemPictures.first.fileName;
    imageUrl = imageUrl.replaceFirst('localhost', '10.0.2.2');

    return Container(
      padding: EdgeInsets.all(16),
      decoration: BoxDecoration(
        color: Colors.white,
        borderRadius: BorderRadius.circular(10),
        boxShadow: [
          BoxShadow(
            color: Colors.grey.withOpacity(0.3),
            spreadRadius: 2,
            blurRadius: 5,
            offset: Offset(0, 3),
          ),
        ],
      ),
      child: Row(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          ClipRRect(
            borderRadius: BorderRadius.circular(10),
            child: Image.network(
              imageUrl,
              height: 110,
              width: 80,
              fit: BoxFit.cover,
            ),
          ),
          SizedBox(width: 16),
          Expanded(
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Text(
                  orderItem.foodItem.name,
                  style: TextStyle(fontSize: 18, fontWeight: FontWeight.bold),
                ),
                SizedBox(height: 8),
                Text(
                  'Quantity: ${orderItem.quantity}',
                  style: TextStyle(fontSize: 16),
                ),
                SizedBox(height: 8),
                Text(
                  'Cost: KM ${orderItem.cost.toStringAsFixed(2)}',
                  style: TextStyle(fontSize: 16),
                ),
              ],
            ),
          ),
          if (orderItem.sideDishes.isNotEmpty) SizedBox(width: 16),
          if (orderItem.sideDishes.isNotEmpty)
            Expanded(
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Text(
                    'Side Dishes:',
                    style: TextStyle(fontSize: 16, fontWeight: FontWeight.bold),
                  ),
                  SizedBox(height: 4),
                  ...orderItem.sideDishes
                      .map((e) => Text(e.name, style: TextStyle(fontSize: 16))),
                ],
              ),
            ),
        ],
      ),
    );
  }

  Widget _buildDeliveryDetailsSection() {
    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        Padding(
          padding: const EdgeInsets.symmetric(vertical: 16.0),
          child: Text('Delivery Details',
              style: TextStyle(fontSize: 24, fontWeight: FontWeight.bold)),
        ),
        Row(
          mainAxisAlignment: MainAxisAlignment.spaceBetween,
          children: [
            Text('Address:',
                style: TextStyle(fontSize: 18, fontWeight: FontWeight.bold)),
            Expanded(
              child: Text(
                order!.address ?? 'No address provided',
                style: TextStyle(fontSize: 18),
                textAlign: TextAlign.right,
              ),
            ),
          ],
        ),
        SizedBox(height: 16),
        InkWell(
          onTap: () {
            setState(() {
              _showMap = !_showMap;
            });
          },
          child: Row(
            mainAxisAlignment: MainAxisAlignment.start,
            children: [
              Text('Location',
                  style: TextStyle(fontSize: 18, fontWeight: FontWeight.bold)),
              Icon(_showMap ? Icons.arrow_drop_up : Icons.arrow_drop_down,
                  size: 24),
            ],
          ),
        ),
        if (_showMap)
          Container(
            margin: EdgeInsets.only(top: 8),
            height: 200,
            decoration: BoxDecoration(
              border: Border.all(color: Colors.grey),
              borderRadius: BorderRadius.circular(10),
            ),
            child: GoogleMap(
              mapType: MapType.terrain,
              initialCameraPosition: CameraPosition(
                target: LatLng(
                  double.parse(order!.location.latitude),
                  double.parse(order!.location.longitude),
                ),
                zoom: 15,
              ),
              markers: {
                Marker(
                  markerId: MarkerId('loc'),
                  position: LatLng(
                    double.parse(order!.location.latitude),
                    double.parse(order!.location.longitude),
                  ),
                  infoWindow: InfoWindow(title: 'Delivery Location'),
                ),
              },
            ),
          ),
      ],
    );
  }
}
