import 'package:desktop/restaurant/api_calls/food_item_api_calls.dart';
import 'package:desktop/restaurant/api_calls/order_api_calls.dart';
import 'package:desktop/restaurant/viewmodels/orders_get_VM.dart';
import 'package:flutter/material.dart';
import 'dart:convert';

import 'package:http/http.dart';
// Replace these imports with the correct paths to your files

class DashboardPage extends StatefulWidget {
  @override
  _DashboardPageState createState() => _DashboardPageState();
}

class _DashboardPageState extends State<DashboardPage> {
  late Future<List<OrderViewModel>> _ordersFuture;
  late Future<int> _monthlyOrderCountFuture;
  late Future<String> _mostFrequentFoodItemFuture;
  @override
  void initState() {
    super.initState();
    final orderApiService = OrderApiService();
    final foodItemApiService = FoodItemApiService(); // Corrected variable name
    _ordersFuture = fetchOrders();
    _monthlyOrderCountFuture = orderApiService.getMonthlyOrderCount();
    _mostFrequentFoodItemFuture =
        foodItemApiService.GetMostFrequentFoodItem(); // This should be fine now
  }

  Future<List<OrderViewModel>> fetchOrders() async {
    var apiService = OrderApiService();
    var response = await apiService.getOrdersForRestaurant();
    if (response != null) {
      final List<dynamic> data = json.decode(response.body)['data'];
      return data.map((order) => OrderViewModel.fromJson(order)).toList();
    } else {
      throw Exception('Failed to load orders');
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SingleChildScrollView(
        child: Padding(
          padding: const EdgeInsets.symmetric(horizontal: 20.0),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: <Widget>[
              Padding(
                padding: const EdgeInsets.symmetric(vertical: 20.0),
                child: Text(
                  'Početna',
                  style: TextStyle(
                    color: Colors.orange,
                    fontWeight: FontWeight.bold,
                    fontSize: 24,
                  ),
                ),
              ),
              StatisticCard(
                label: "Broj narudžbi za ovaj mjesec:",
                value: FutureBuilder<int>(
                  future: _monthlyOrderCountFuture,
                  builder: (context, snapshot) {
                    if (snapshot.connectionState == ConnectionState.waiting) {
                      return Text("Loading...");
                    } else if (snapshot.hasError) {
                      return Text("Error");
                    } else {
                      return Text("${snapshot.data}");
                    }
                  },
                ),
              ),
              StatisticCard(
                label: "Najcesce narucen proizvod:",
                value: FutureBuilder<String>(
                  future: _mostFrequentFoodItemFuture,
                  builder: (context, snapshot) {
                    if (snapshot.connectionState == ConnectionState.waiting) {
                      return Text("Loading...");
                    } else if (snapshot.hasError) {
                      return Text("Error");
                    } else {
                      return Text(snapshot.data ?? "N/A");
                    }
                  },
                ),
              ),
              // Add your statistic cards and other static content here...
              SizedBox(height: 30),
              Text(
                'Najnovije narudžbe',
                style: TextStyle(
                  color: Colors.black,
                  fontSize: 20,
                  fontWeight: FontWeight.bold,
                ),
              ),
              FutureBuilder<List<OrderViewModel>>(
                future: _ordersFuture,
                builder: (context, snapshot) {
                  if (snapshot.connectionState == ConnectionState.waiting) {
                    return Center(child: CircularProgressIndicator());
                  } else if (snapshot.hasError) {
                    return Text('Error: ${snapshot.error}');
                  } else if (snapshot.hasData) {
                    final orders = snapshot.data!;
                    // Sort orders by createdDate descending
                    orders
                        .sort((a, b) => b.createdDate.compareTo(a.createdDate));
                    // Take the top 3 most recent orders
                    final recentOrders = orders.take(3).toList();

                    return Column(
                      children: recentOrders
                          .map((order) => OrderCard(
                                address: order.location.city.title,
                                price: '${order.totalCost} KM',
                                paymentMethod:
                                    _mapPaymentMethod(order.paymentMethod),
                              ))
                          .toList(),
                    );
                  } else {
                    return Text('No data');
                  }
                },
              ),
            ],
          ),
        ),
      ),
    );
  }

  String _mapPaymentMethod(int method) {
    // Adjust this method according to how you want to display payment methods
    switch (method) {
      case 1:
        return 'Online';
      default:
        return 'Gotovina';
    }
  }
}

class StatisticCard extends StatelessWidget {
  final String label;
  final Widget value;

  const StatisticCard({
    Key? key,
    required this.label,
    required this.value,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Card(
      margin: EdgeInsets.symmetric(vertical: 10),
      child: Padding(
        padding: EdgeInsets.all(20),
        child: Row(
          mainAxisAlignment: MainAxisAlignment.spaceBetween,
          children: <Widget>[
            Text(
              label,
              style: TextStyle(fontSize: 16),
            ),
            Align(
              alignment: Alignment.centerRight,
              child: value,
            ),
          ],
        ),
      ),
    );
  }
}

class OrderCard extends StatelessWidget {
  final String address;
  final String price;
  final String paymentMethod;

  const OrderCard({
    Key? key,
    required this.address,
    required this.price,
    required this.paymentMethod,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Card(
      margin: EdgeInsets.symmetric(vertical: 10),
      child: ListTile(
        title: Text(address),
        subtitle: Text('Cijena: $price | Plaćanje: $paymentMethod'),
        trailing: ElevatedButton(
          onPressed: () {
            // Add your action for the button press here
          },
          style: ElevatedButton.styleFrom(
            primary: Colors.orange,
          ),
          child: Text('Detalji'),
        ),
      ),
    );
  }
}
