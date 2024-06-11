import 'package:e_delivery_mobile/customer/screens/profile/api/profile_api.dart';
import 'package:e_delivery_mobile/customer/screens/profile/dto/order_get_dto.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:dropdown_search/dropdown_search.dart';
import 'package:e_delivery_mobile/customer/screens/profile/order_details_page.dart';

class OrdersPage extends StatefulWidget {
  @override
  _OrdersPageState createState() => _OrdersPageState();
}

class _OrdersPageState extends State<OrdersPage> {
  final ProfileService _profileService = ProfileService();
  List<OrderGetDto>? _orders;
  bool _isLoading = true;
  String _errorMessage = '';
  int _selectedOrderState = 0;
  String _selectedSortBy = '';
  DateTime? _startDate;
  DateTime? _endDate;
  int _currentPage = 1;
  int _totalPages = 1;

  @override
  void initState() {
    super.initState();
    _fetchOrders();
  }

  Future<void> _fetchOrders() async {
    try {
      final result = await _profileService.fetchOrders(
        startDate: _startDate,
        endDate: _endDate,
        orderState: _selectedOrderState == 0 ? null : _selectedOrderState,
        sortBy: _selectedSortBy.isNotEmpty ? _selectedSortBy : null,
        pageNumber: _currentPage,
        pageSize: 5,
      );
      if (!mounted) return;
      if (result['orders'].isNotEmpty) {
        setState(() {
          _orders = result['orders'];

          _totalPages = result['pagination']['totalPages'];
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
      appBar: AppBar(
        title: Text('Orders'),
        backgroundColor: Colors.orange,
      ),
      body: Padding(
        padding: const EdgeInsets.all(16.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            _buildFilterSection(),
            SizedBox(height: 16),
            _buildOrdersSection(),
            SizedBox(height: 16),
            _buildPaginationSection(),
          ],
        ),
      ),
    );
  }

  Widget _buildFilterSection() {
    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        Row(
          mainAxisAlignment: MainAxisAlignment.spaceBetween,
          children: [
            Text(
              'Filter Results',
              style: TextStyle(
                fontSize: 20,
                fontWeight: FontWeight.bold,
              ),
            ),
            ElevatedButton(
              onPressed: () {
                setState(() {
                  _startDate = null;
                  _endDate = null;
                  _currentPage = 1;
                  _fetchOrders();
                });
              },
              child: Text('Clear Filters'),
            ),
          ],
        ),
        SizedBox(height: 16),
        Row(
          children: [
            Expanded(
              child: DropdownSearch<int>(
                items: [0, 1, 2, 3, 4],
                itemAsString: (int? value) {
                  switch (value) {
                    case 0:
                      return 'All';
                    case 1:
                      return 'Created';
                    case 2:
                      return 'In Delivery';
                    case 3:
                      return 'Delivered';
                    case 4:
                      return 'Canceled';
                    default:
                      return '';
                  }
                },
                onChanged: (value) {
                  setState(() {
                    _selectedOrderState = value!;
                    _currentPage = 1;
                    _fetchOrders();
                  });
                },
                selectedItem: _selectedOrderState,
                dropdownDecoratorProps: DropDownDecoratorProps(
                  dropdownSearchDecoration: InputDecoration(
                    labelText: 'Order state',
                    contentPadding: EdgeInsets.symmetric(
                      vertical: 8,
                      horizontal: 16,
                    ),
                    border: OutlineInputBorder(),
                  ),
                ),
              ),
            ),
            SizedBox(width: 16),
            Expanded(
              child: DropdownSearch<String>(
                items: ['', 'totalPriceAsc', 'totalPriceDesc'],
                itemAsString: (String? value) {
                  switch (value) {
                    case '':
                      return 'None';
                    case 'totalPriceAsc':
                      return 'Price: Low to High';
                    case 'totalPriceDesc':
                      return 'Price: High to Low';
                    default:
                      return '';
                  }
                },
                onChanged: (value) {
                  setState(() {
                    _selectedSortBy = value!;
                    _currentPage = 1;
                    _fetchOrders();
                  });
                },
                selectedItem: _selectedSortBy,
                dropdownDecoratorProps: DropDownDecoratorProps(
                  dropdownSearchDecoration: InputDecoration(
                    labelText: 'Sort By',
                    contentPadding: EdgeInsets.symmetric(
                      vertical: 8,
                      horizontal: 16,
                    ),
                    border: OutlineInputBorder(),
                  ),
                ),
              ),
            ),
          ],
        ),
        SizedBox(height: 16),
        Row(
          children: [
            Expanded(
              child: GestureDetector(
                onTap: () async {
                  final DateTime? picked = await showDatePicker(
                    context: context,
                    initialDate: _startDate ?? DateTime.now(),
                    firstDate: DateTime(2000),
                    lastDate: DateTime(2100),
                  );
                  if (picked != null && picked != _startDate) {
                    setState(() {
                      _startDate = picked;
                      _currentPage = 1;
                      _fetchOrders();
                    });
                  }
                },
                child: Container(
                  padding: EdgeInsets.symmetric(
                    vertical: 8,
                    horizontal: 16,
                  ),
                  decoration: BoxDecoration(
                    border: Border.all(color: Colors.grey),
                    borderRadius: BorderRadius.circular(4),
                  ),
                  child: Row(
                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                    children: [
                      Text(
                        _startDate == null
                            ? 'Start Date'
                            : DateFormat('yyyy-MM-dd').format(_startDate!),
                        style: TextStyle(fontSize: 16),
                      ),
                      Icon(Icons.calendar_today),
                    ],
                  ),
                ),
              ),
            ),
            SizedBox(width: 16),
            Expanded(
              child: GestureDetector(
                onTap: () async {
                  final DateTime? picked = await showDatePicker(
                    context: context,
                    initialDate: _endDate ?? DateTime.now(),
                    firstDate: DateTime(2000),
                    lastDate: DateTime(2100),
                  );
                  if (picked != null && picked != _endDate) {
                    setState(() {
                      _endDate = picked;
                      _currentPage = 1;
                      _fetchOrders();
                    });
                  }
                },
                child: Container(
                  padding: EdgeInsets.symmetric(
                    vertical: 8,
                    horizontal: 16,
                  ),
                  decoration: BoxDecoration(
                    border: Border.all(color: Colors.grey),
                    borderRadius: BorderRadius.circular(4),
                  ),
                  child: Row(
                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                    children: [
                      Text(
                        _endDate == null
                            ? 'End Date'
                            : DateFormat('yyyy-MM-dd').format(_endDate!),
                        style: TextStyle(fontSize: 16),
                      ),
                      Icon(Icons.calendar_today),
                    ],
                  ),
                ),
              ),
            ),
          ],
        ),
      ],
    );
  }

  Widget _buildOrdersSection() {
    return Expanded(
      child: _isLoading
          ? Center(child: CircularProgressIndicator())
          : _orders?.isNotEmpty ?? false
              ? ListView.builder(
                  itemCount: _orders!.length,
                  itemBuilder: (context, index) {
                    final order = _orders![index];
                    return Container(
                      child: Card(
                        color: Colors.orange[100],
                        elevation: 2,
                        margin: EdgeInsets.symmetric(vertical: 8),
                        child: ListTile(
                          title: Text(
                            'Address: ${order.address}',
                            style: TextStyle(
                                fontWeight: FontWeight.bold, fontSize: 16),
                          ),
                          subtitle: Column(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            children: [
                              SizedBox(height: 4),
                              Text(
                                'Created: ${DateFormat('dd. MM. yyyy. HH:mm').format(DateTime.parse(order.createdDate))}',
                              ),
                              SizedBox(height: 4),
                              Text(
                                'Total Cost: \KM ${order.totalCost.toStringAsFixed(2)}',
                                style: TextStyle(fontSize: 14),
                              ),
                              SizedBox(height: 4),
                              Text(
                                'Order State: ${_getOrderStateName(order.orderState)}',
                                style: TextStyle(fontSize: 14),
                              ),
                            ],
                          ),
                          trailing: Icon(
                            Icons.arrow_forward_ios,
                            color: Colors.orange,
                          ),
                          onTap: () {
                            Navigator.push(
                              context,
                              MaterialPageRoute(
                                builder: (context) =>
                                    OrderDetailsPage(orderId: order.id),
                              ),
                            );
                          },
                        ),
                      ),
                    );
                  },
                )
              : _errorMessage.isNotEmpty
                  ? Center(
                      child: Text(_errorMessage,
                          style: TextStyle(color: Colors.red, fontSize: 16)))
                  : Center(
                      child: Text('No orders found.',
                          style: TextStyle(fontSize: 16))),
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

  Widget _buildPaginationSection() {
    return Container(
      decoration: BoxDecoration(
        color: Colors.orange[200],
        borderRadius: BorderRadius.circular(8),
      ),
      padding: EdgeInsets.symmetric(horizontal: 16, vertical: 8),
      child: Row(
        mainAxisAlignment: MainAxisAlignment.center,
        children: [
          IconButton(
            icon: Icon(Icons.arrow_back_ios),
            onPressed: _currentPage > 1
                ? () {
                    setState(() {
                      _currentPage--;
                      _fetchOrders();
                    });
                  }
                : null,
          ),
          SizedBox(width: 8),
          Text(
            'Page $_currentPage of $_totalPages',
            style: TextStyle(fontSize: 16),
          ),
          SizedBox(width: 8),
          IconButton(
            icon: Icon(Icons.arrow_forward_ios),
            onPressed: _currentPage < _totalPages
                ? () {
                    setState(() {
                      _currentPage++;
                      _fetchOrders();
                    });
                  }
                : null,
          ),
        ],
      ),
    );
  }
}
