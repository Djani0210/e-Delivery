import 'dart:convert';

import 'package:desktop/restaurant/api_calls/employee_api_calls.dart';
import 'package:desktop/restaurant/api_calls/order_api_calls.dart';
import 'package:desktop/restaurant/viewmodels/employees_get_VM.dart';
import 'package:desktop/restaurant/viewmodels/orders_get_VM.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

class OrderDetailsPage extends StatefulWidget {
  final String id;

  OrderDetailsPage({Key? key, required this.id}) : super(key: key);
  @override
  _OrderDetailsPageState createState() => _OrderDetailsPageState();
}

class _OrderDetailsPageState extends State<OrderDetailsPage> {
  late Future<OrderViewModel> orderDetailsFuture;

  @override
  void initState() {
    super.initState();
    orderDetailsFuture = fetchOrderDetails();
  }

  Future<OrderViewModel> fetchOrderDetails() async {
    final OrderApiService apiService = OrderApiService();
    final response = await apiService.getOrderById(widget.id);
    if (response != null && response.statusCode == 200) {
      final json = jsonDecode(response.body);
      return OrderViewModel.fromJson(json);
    } else {
      throw Exception('Failed to load order details');
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(
          'Order details',
          style: TextStyle(color: Colors.black),
        ),
        backgroundColor:
            Colors.yellowAccent, // Updated to yellow color as requested
        leading: IconButton(
          icon: Icon(Icons.arrow_back, color: Colors.black),
          onPressed: () {
            Navigator.of(context).pop();
          },
        ),
      ),
      body: FutureBuilder<OrderViewModel>(
        future: orderDetailsFuture,
        builder: (context, snapshot) {
          if (snapshot.connectionState == ConnectionState.waiting) {
            return Center(child: CircularProgressIndicator());
          } else if (snapshot.hasError) {
            return Center(child: Text("Error: ${snapshot.error}"));
          } else if (snapshot.hasData) {
            return OrderDetailsContent(order: snapshot.data!);
          } else {
            return Center(child: Text("Unknown error occurred"));
          }
        },
      ),
    );
  }
}

class OrderDetailsContent extends StatelessWidget {
  final OrderViewModel order;

  OrderDetailsContent({required this.order});

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.all(20.0),
      child: Row(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Expanded(
            child: Column(
              children: [
                OrderInfoHeaderSection(order: order),
                SizedBox(height: 20),
                Text("Order contents:",
                    style:
                        TextStyle(fontWeight: FontWeight.bold, fontSize: 18.0)),
                SizedBox(height: 30),
                OrderItemsLabelSection(),
                OrderItemsSection(orderItems: order.orderItems),
              ],
            ),
          ),
          SizedBox(width: 20),
          OrderSummarySection(order: order),
        ],
      ),
    );
  }
}

class OrderInfoHeaderSection extends StatelessWidget {
  final OrderViewModel order;

  OrderInfoHeaderSection({required this.order});
  @override
  Widget build(BuildContext context) {
    return Card(
      shape: RoundedRectangleBorder(
        borderRadius: BorderRadius.circular(10.0),
      ),
      elevation: 4.0,
      child: Padding(
        padding: const EdgeInsets.symmetric(horizontal: 20.0, vertical: 10.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Text(
                'Order date: ${DateFormat('dd.MM.yyyy. HH:mm').format(order.createdDate)}',
                style: TextStyle(color: Colors.grey[700])),
          ],
        ),
      ),
    );
  }
}

class OrderItemsLabelSection extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Container(
      padding: const EdgeInsets.all(8.0),
      child: const Row(
        mainAxisAlignment: MainAxisAlignment.spaceEvenly,
        children: [
          Expanded(
              child: Text('Image',
                  style: TextStyle(fontWeight: FontWeight.bold),
                  textAlign: TextAlign.center)),
          Expanded(
              child: Text('Food item',
                  style: TextStyle(fontWeight: FontWeight.bold),
                  textAlign: TextAlign.center)),
          Expanded(
              child: Text('Category',
                  style: TextStyle(fontWeight: FontWeight.bold),
                  textAlign: TextAlign.center)),
          Expanded(
              child: Text('Price',
                  style: TextStyle(fontWeight: FontWeight.bold),
                  textAlign: TextAlign.center)),
          Expanded(
              child: Text('Quantity',
                  style: TextStyle(fontWeight: FontWeight.bold),
                  textAlign: TextAlign.center)),
          Expanded(
              child: Text('Side dishes',
                  style: TextStyle(fontWeight: FontWeight.bold),
                  textAlign: TextAlign.center)),
        ],
      ),
    );
  }
}

class OrderItemsSection extends StatelessWidget {
  final List<OrderItemViewModel> orderItems;

  OrderItemsSection({required this.orderItems});

  @override
  Widget build(BuildContext context) {
    return Card(
      elevation: 4.0,
      child: Container(
        padding: EdgeInsets.all(20.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            SizedBox(height: 10),
            ListView.separated(
              shrinkWrap: true,
              physics: NeverScrollableScrollPhysics(),
              itemCount: orderItems.length,
              separatorBuilder: (context, index) => Divider(),
              itemBuilder: (context, index) =>
                  OrderItemWidget(orderItem: orderItems[index]),
            ),
          ],
        ),
      ),
    );
  }
}

class OrderItemWidget extends StatelessWidget {
  final OrderItemViewModel orderItem;

  OrderItemWidget({required this.orderItem});

  @override
  Widget build(BuildContext context) {
    final int foodItemId = orderItem.foodItem.id;

    final OrderApiService apiService = OrderApiService();
    return Container(
      padding: EdgeInsets.symmetric(vertical: 8.0),
      child: Row(
        mainAxisAlignment: MainAxisAlignment.spaceEvenly,
        children: <Widget>[
          Expanded(
            child: FutureBuilder<String>(
              future: apiService.fetchImageUrl(foodItemId),
              builder: (context, snapshot) {
                if (snapshot.connectionState == ConnectionState.waiting) {
                  return CircularProgressIndicator();
                } else if (snapshot.hasError) {
                  print('Error fetching image: ${snapshot.error}');
                  return Column(
                    children: [
                      Icon(Icons.error),
                      Text('Error: ${snapshot.error}'),
                    ],
                  );
                } else {
                  return Image.network(
                    snapshot.data!,
                    width: 80,
                    height: 80,
                    fit: BoxFit.contain,
                  );
                }
              },
            ),
          ),
          Expanded(
              child:
                  Text(orderItem.foodItem.name, textAlign: TextAlign.center)),
          Expanded(
              child: Text(orderItem.foodItem.category.name,
                  textAlign: TextAlign.center)),
          Expanded(
              child: Text('${orderItem.cost.toStringAsFixed(2)} KM',
                  textAlign: TextAlign.center)),
          Expanded(
              child:
                  Text(' ${orderItem.quantity}', textAlign: TextAlign.center)),
          Expanded(
            child: ElevatedButton(
              onPressed: () =>
                  _showSideDishesDialog(context, orderItem.sideDishes),
              child: Text('Side Dishes'),
            ),
          ),
        ],
      ),
    );
  }
}

void _showSideDishesDialog(
    BuildContext context, List<SideDishViewModel> sideDishes) {
  showDialog(
    context: context,
    builder: (BuildContext context) {
      return AlertDialog(
        title: Text("Side dishes"),
        content: SingleChildScrollView(
          // Added for better scrolling behavior
          child: Container(
            // Reducing the width and ensuring the dialog is not too wide
            width: 300, // Example: 50% of screen width
            child: Table(
              // Adding border to create gridlines
              border: TableBorder.all(color: Colors.grey),
              columnWidths: const {
                0: FlexColumnWidth(
                    3), // Adjust the width ratio between name and price
                1: FlexColumnWidth(1),
              },
              children: sideDishes.map((sideDish) {
                return TableRow(
                  children: [
                    Padding(
                      padding: const EdgeInsets.all(8.0),
                      child: Text(sideDish.name),
                    ),
                    Padding(
                      padding: const EdgeInsets.all(8.0),
                      child: Text('${sideDish.price} KM'),
                    ),
                  ],
                );
              }).toList(),
            ),
          ),
        ),
        actions: <Widget>[
          TextButton(
            child: Text("Close"),
            onPressed: () => Navigator.of(context).pop(),
          ),
        ],
      );
    },
  );
}

class OrderSummarySection extends StatefulWidget {
  final OrderViewModel order;

  OrderSummarySection({required this.order});

  @override
  _OrderSummarySectionState createState() => _OrderSummarySectionState();
}

class _OrderSummarySectionState extends State<OrderSummarySection> {
  late OrderViewModel order;

  @override
  void initState() {
    super.initState();
    order = widget.order;
  }

  void showAssignDeliveryPersonDialog(
      BuildContext context, String orderId) async {
    final response =
        await EmployeeApiService().getRestaurantEmployees(isAvailable: true);
    if (response != null && response.statusCode == 200) {
      final data = json.decode(response.body);
      final employees = (data['data']['employees'] as List)
          .map((e) => EmployeeViewModel.fromJson(e))
          .toList();

      showDialog(
        context: context,
        builder: (context) {
          return AlertDialog(
            title: Text("Choose delivery person"),
            shape:
                RoundedRectangleBorder(borderRadius: BorderRadius.circular(20)),
            content: Container(
              width: 250,
              height: 300,
              child: employees.isNotEmpty
                  ? ListView.builder(
                      itemCount: employees.length,
                      itemBuilder: (context, index) {
                        final employee = employees[index];
                        return ListTile(
                          title: Text(
                              '${employee.firstName} ${employee.lastName}'),
                          trailing: ElevatedButton(
                            onPressed: () async {
                              await assignDeliveryPerson(order.id, employee.id);
                              Navigator.of(context).pop();
                            },
                            child: Text('Add'),
                          ),
                        );
                      },
                    )
                  : Center(child: Text("Delivery persons not found.")),
            ),
            actions: <Widget>[
              TextButton(
                child: Text("Cancel"),
                onPressed: () => Navigator.of(context).pop(),
              ),
            ],
          );
        },
      );
    } else {
      print("Error fetching employees");
    }
  }

  Future<void> fetchOrderDetails() async {
    final OrderApiService apiService = OrderApiService();
    final response = await apiService.getOrderById(order.id);
    if (response != null && response.statusCode == 200) {
      final json = jsonDecode(response.body);
      setState(() {
        order = OrderViewModel.fromJson(json);
      });
    } else {
      throw Exception('Failed to load order details');
    }
  }

  Future<void> updateOrderState(String orderId, {int newState = 2}) async {
    final OrderApiService apiService = OrderApiService();
    final response =
        await apiService.updateOrderState(orderId, newState: newState);

    if (response != null && response.statusCode == 200) {
      // Update successful, fetch updated order details
      await fetchOrderDetails();
    } else {
      // Update failed, show an error message
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          content: Text('Error updating order state'),
          backgroundColor: Colors.red,
        ),
      );
    }
  }

  Future<void> assignDeliveryPerson(String orderId, String employeeId) async {
    try {
      final success = await OrderApiService()
          .assignDeliveryPersonToOrder(orderId, employeeId);
      if (success) {
        print('Delivery person assigned successfully');
        await fetchOrderDetails();
      } else {
        print('Failed to assign delivery person');
        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(content: Text('Greška')),
        );
      }
    } catch (e) {
      print('Error assigning delivery person: $e');
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text('Greška')),
      );
    }
  }

  @override
  Widget build(BuildContext context) {
    return Container(
      width: 500,
      height: 600, // Set the width as requested
      padding:
          EdgeInsets.only(top: 20.0), // Aligns vertically with OrderItemSection
      child: Card(
        shape: RoundedRectangleBorder(
          borderRadius:
              BorderRadius.circular(10.0), // Rounded edges for the card
        ),
        color: Colors.grey[200], // Light grey background color for the card
        child: Padding(
          padding: EdgeInsets.all(16.0), // Padding inside the card
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  const Text('Payment:',
                      style:
                          TextStyle(fontWeight: FontWeight.bold, fontSize: 16)),
                  Text('${order.paymentMethodText}',
                      style: TextStyle(fontSize: 16)),
                ],
              ),
              SizedBox(height: 16.0), // Spacing between the rows
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  const Text('Status:',
                      style:
                          TextStyle(fontWeight: FontWeight.bold, fontSize: 16)),
                  Text('${order.orderStateText}',
                      style: TextStyle(fontSize: 16)),
                ],
              ),
              SizedBox(height: 16.0),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Text('Customer name:',
                      style:
                          TextStyle(fontWeight: FontWeight.bold, fontSize: 16)),
                  Text('${order.userName}', style: TextStyle(fontSize: 16)),
                ],
              ),
              SizedBox(height: 16.0),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Text('Customer address:',
                      style:
                          TextStyle(fontWeight: FontWeight.bold, fontSize: 16)),
                  Text('${order.address}', style: TextStyle(fontSize: 16)),
                ],
              ),
              SizedBox(height: 16.0),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Text('Allergies:',
                      style:
                          TextStyle(fontWeight: FontWeight.bold, fontSize: 16)),
                  Text('${order.allergies}', style: TextStyle(fontSize: 16)),
                ],
              ),
              SizedBox(height: 16.0),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Text('Delivery person:',
                      style:
                          TextStyle(fontWeight: FontWeight.bold, fontSize: 16)),
                  order.deliveryPersonId == null
                      ? ElevatedButton.icon(
                          onPressed: () =>
                              showAssignDeliveryPersonDialog(context, order.id),

                          icon: Icon(Icons.person_2_outlined), // Employee icon
                          label: Text('Add delivery person'),
                          style: ElevatedButton.styleFrom(
                            primary: Colors.blue, // Button background color

                            shape: RoundedRectangleBorder(
                              borderRadius: BorderRadius.circular(20),
                            ),
                          ),
                        )
                      : Text('${order.deliveryPersonName}',
                          style: TextStyle(fontSize: 16)),
                ],
              ),
              SizedBox(height: 16.0),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Text(
                    'Action',
                    style: TextStyle(
                      fontSize: 16,
                      fontWeight: FontWeight.bold,
                    ),
                  ),
                  if (order.orderState == 1)
                    ElevatedButton.icon(
                      onPressed: () {
                        showDialog(
                          context: context,
                          builder: (BuildContext context) {
                            return AlertDialog(
                              title: Text('Confirm action'),
                              content: Text(
                                  'Are you sure you want to mark this order as deployed?'),
                              actions: [
                                TextButton(
                                  onPressed: () async {
                                    await updateOrderState(order.id,
                                        newState: 2);
                                    Navigator.of(context).pop();
                                  },
                                  child: Text('Yes'),
                                ),
                                TextButton(
                                  onPressed: () {
                                    Navigator.of(context).pop();
                                  },
                                  child: Text('Cancel'),
                                ),
                              ],
                            );
                          },
                        );
                      },
                      icon: Icon(Icons.delivery_dining),
                      label: Text('Mark as deployed'),
                      style: ElevatedButton.styleFrom(
                        primary: Colors.green,
                        shape: RoundedRectangleBorder(
                          borderRadius: BorderRadius.circular(20),
                        ),
                      ),
                    )
                  else
                    Text(
                      'Already deployed',
                      style: TextStyle(
                        color: Colors.grey,
                        fontStyle: FontStyle.italic,
                      ),
                    ),
                ],
              ),
              SizedBox(height: 16.0),
              Divider(color: Colors.grey[400]),
              Padding(
                padding: const EdgeInsets.only(bottom: 16.0, top: 16.0),
                child: Text('Payment details',
                    style:
                        TextStyle(fontWeight: FontWeight.bold, fontSize: 18)),
              ),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Text('Order cost:',
                      style:
                          TextStyle(fontWeight: FontWeight.bold, fontSize: 16)),
                  Text('${order.totalCost - order.deliveryCost} KM',
                      style: TextStyle(fontSize: 16)),
                ],
              ),
              SizedBox(height: 16.0),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Text('Delivery cost:',
                      style:
                          TextStyle(fontWeight: FontWeight.bold, fontSize: 16)),
                  Text('${order.deliveryCost} KM',
                      style: TextStyle(fontSize: 16)),
                ],
              ),
              SizedBox(height: 16.0),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Text('Total cost:',
                      style:
                          TextStyle(fontWeight: FontWeight.bold, fontSize: 16)),
                  Text('${order.totalCost} KM', style: TextStyle(fontSize: 16)),
                ],
              ),
              SizedBox(height: 16.0),
            ],
          ),
        ),
      ),
    );
  }
}
