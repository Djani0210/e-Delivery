import 'dart:async';
import 'dart:convert';
import 'package:intl/intl.dart';
import 'package:desktop/restaurant/api_calls/order_api_calls.dart';
import 'dart:io';
import 'package:path_provider/path_provider.dart';
import 'package:open_file/open_file.dart';
import 'package:desktop/restaurant/viewmodels/orders_get_VM.dart';
import 'package:flutter/material.dart';

class OrdersPage extends StatefulWidget {
  final Function(String) onNavigateToDetails;

  const OrdersPage({super.key, required this.onNavigateToDetails});
  @override
  _OrdersPageState createState() => _OrdersPageState();
}

class _OrdersPageState extends State<OrdersPage> {
  final OrderApiService _orderApiService = OrderApiService();
  List<OrderViewModel> _orders = [];
  int _currentPage = 0;
  final int _perPage = 4;
  int _totalPages = 0;
  String _currentStatus = 'All';
  DateTime? _selectedFromDate;
  DateTime? _selectedToDate;
  int? _currentOrderState;
  int _totalOrdersCount = 0;
  Timer? _refreshTimer;
  @override
  void initState() {
    super.initState();
    _fetchOrders();
    _refreshTimer =
        Timer.periodic(Duration(seconds: 5), (Timer t) => _fetchOrders());
  }

  @override
  void dispose() {
    _refreshTimer?.cancel();
    super.dispose();
  }

  void _fetchOrders({
    int pageNumber = 1,
    DateTime? startDate,
    DateTime? endDate,
    int? orderState,
  }) async {
    final response = await _orderApiService.getOrdersForRestaurant(
        pageNumber: pageNumber,
        itemsPerPage: _perPage,
        startDate: startDate,
        endDate: endDate,
        orderState: orderState);
    if (response != null && response.statusCode == 200) {
      final Map<String, dynamic> responseBody = json.decode(response.body);

      final List<dynamic> ordersData = responseBody['data']['orders'];
      final int totalPages = responseBody['data']['totalPages'];
      final int totalCount = responseBody['data']['totalCount'];

      final List<OrderViewModel> fetchedOrders =
          ordersData.map((order) => OrderViewModel.fromJson(order)).toList();

      fetchedOrders.sort((a, b) => b.createdDate.compareTo(a.createdDate));

      setState(() {
        _orders = fetchedOrders;
        _totalPages = totalPages;
        _currentPage = pageNumber - 1;
        _totalOrdersCount = totalCount;
      });
    } else {
      print("Failed to fetch orders. Status code: ${response?.statusCode}");
    }
  }

  Future<void> _deleteOrder(String orderId) async {
    final response = await _orderApiService.deleteOrder(orderId);
    if (response != null && response.statusCode == 200) {
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text('Order deleted successfully')),
      );
      _fetchOrders(
        pageNumber: _currentPage + 1,
        startDate: _selectedFromDate,
        endDate: _selectedToDate,
        orderState: _currentOrderState,
      );
    } else {
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text('Failed to delete order')),
      );
    }
  }

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.all(16.0),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: <Widget>[
          SizedBox(width: 10),
          Text(
            'Orders',
            style: TextStyle(
              fontSize: 24,
              fontWeight: FontWeight.bold,
            ),
          ),
          SizedBox(height: 16),
          _buildDatePickers(context),
          SizedBox(height: 10),
          SizedBox(height: 20),
          _buildStatusFilters(context),
          SizedBox(height: 40),
          Expanded(child: _buildOrdersTable()),
          _buildPagination(),
          SizedBox(height: 10),
          _buildPrintReportButton(context),
        ],
      ),
    );
  }

  Widget _buildDatePickers(BuildContext context) {
    return Row(
      children: <Widget>[
        SizedBox(width: 5),
        Text('Currently found $_totalOrdersCount orders:'),
        SizedBox(width: 16),
        Text('From:'),
        SizedBox(width: 16),
        ElevatedButton(
          onPressed: () => _selectDate(context, true),
          child: Text(
            _selectedFromDate == null
                ? 'Choose a date'
                : DateFormat('yyyy-MM-dd').format(_selectedFromDate!),
          ),
        ),
        SizedBox(width: 16),
        Text('To:'),
        SizedBox(width: 16),
        ElevatedButton(
          onPressed: () => _selectDate(context, false),
          child: Text(
            _selectedToDate == null
                ? 'Choose a date'
                : DateFormat('yyyy-MM-dd').format(_selectedToDate!),
          ),
        ),
        SizedBox(width: 25),
        IconButton(
          icon: Icon(Icons.search),
          onPressed: () {
            _fetchOrders(
                startDate: _selectedFromDate, endDate: _selectedToDate);
          },
        ),
        SizedBox(width: 25),
        IconButton(
          icon: Icon(Icons.clear),
          onPressed: () {
            _clearFilters();
          },
        ),
      ],
    );
  }

  void _clearFilters() {
    setState(() {
      _selectedFromDate = null;
      _selectedToDate = null;
      _currentStatus = 'All';
      _currentOrderState = null;
      _currentPage = 1;
    });
    _fetchOrders();
  }

  void _selectDate(BuildContext context, bool isFrom) async {
    final DateTime? picked = await showDatePicker(
      context: context,
      initialDate: isFrom
          ? _selectedFromDate ?? DateTime.now()
          : _selectedToDate ?? DateTime.now(),
      firstDate: DateTime(2000),
      lastDate: DateTime(2101),
    );
    if (picked != null &&
        (isFrom ? picked != _selectedFromDate : picked != _selectedToDate)) {
      setState(() {
        if (isFrom) {
          _selectedFromDate = picked;
        } else {
          _selectedToDate = picked;
        }
      });
    }
  }

  Widget _buildPagination() {
    return Row(
      mainAxisAlignment: MainAxisAlignment.center,
      children: <Widget>[
        IconButton(
          icon: Icon(Icons.arrow_back_ios),
          onPressed: _currentPage > 0
              ? () => _fetchOrders(
                  pageNumber: _currentPage,
                  startDate: _selectedFromDate,
                  endDate: _selectedToDate,
                  orderState: _currentOrderState)
              : null,
        ),
        Text('Page ${_currentPage + 1} of $_totalPages'),
        IconButton(
          icon: Icon(Icons.arrow_forward_ios),
          onPressed: _currentPage < _totalPages - 1
              ? () => _fetchOrders(
                  pageNumber: _currentPage + 2,
                  startDate: _selectedFromDate,
                  endDate: _selectedToDate,
                  orderState: _currentOrderState)
              : null,
        ),
      ],
    );
  }

  void _searchOrders() {
    print(
        'From: ${_selectedFromDate == null ? "Not selected" : MaterialLocalizations.of(context).formatShortDate(_selectedFromDate!)}');
    print(
        'To: ${_selectedToDate == null ? "Not selected" : MaterialLocalizations.of(context).formatShortDate(_selectedToDate!)}');
  }

  Widget _buildStatusFilters(BuildContext context) {
    List<String> statuses = ['All', 'Preparing', 'Deployed', 'Delivered'];

    return Row(
      mainAxisAlignment: MainAxisAlignment.spaceEvenly,
      children: statuses.asMap().entries.map((entry) {
        int index = entry.key;
        String status = entry.value;

        return ChoiceChip(
          label: Text(status),
          selected: _currentStatus == status,
          onSelected: (bool selected) {
            setState(() {
              _currentStatus = status;

              _currentOrderState = status == 'All' ? null : index;

              _fetchOrders(
                startDate: _selectedFromDate,
                endDate: _selectedToDate,
                orderState: _currentOrderState,
              );
            });
          },
          selectedColor: Colors.orange,
          backgroundColor: Colors.grey,
        );
      }).toList(),
    );
  }

  String formatDateTime(String dateTimeStr) {
    final DateTime dateTime = DateTime.parse(dateTimeStr);
    final DateFormat formatter = DateFormat('yyyy-MM-dd HH:mm');
    return formatter.format(dateTime);
  }

  Widget _buildOrdersTable() {
    return SingleChildScrollView(
      scrollDirection: Axis.horizontal,
      child: ConstrainedBox(
        constraints: BoxConstraints(minWidth: 1500),
        child: DataTable(
          columnSpacing: 38,
          columns: const <DataColumn>[
            DataColumn(label: Text('Address')),
            DataColumn(label: Text('Date')),
            DataColumn(label: Text('Cost')),
            DataColumn(label: Text('Status')),
            DataColumn(label: Text('Action')),
            DataColumn(label: Text('Delete')),
          ],
          rows: _orders.map((order) {
            return DataRow(cells: [
              DataCell(Text(order.address)),
              DataCell(Text(formatDateTime(order.createdDate.toString()))),
              DataCell(Text(order.totalCost.toStringAsFixed(2) + ' KM')),
              DataCell(Text(order.orderStateText)),
              DataCell(TextButton(
                  onPressed: () => widget.onNavigateToDetails(order.id),
                  child: Text('Details'))),
              DataCell(IconButton(
                icon: Icon(Icons.delete),
                onPressed: () => _showDeleteConfirmationDialog(order.id),
              )),
            ]);
          }).toList(),
        ),
      ),
    );
  }

  void _showDeleteConfirmationDialog(String orderId) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: Text("Confirm Delete"),
          content: Text("Are you sure you want to delete this order?"),
          actions: <Widget>[
            TextButton(
              child: Text("Cancel"),
              onPressed: () => Navigator.of(context).pop(),
            ),
            TextButton(
              child: Text("Delete"),
              onPressed: () {
                Navigator.of(context).pop();
                _deleteOrder(orderId);
              },
            ),
          ],
        );
      },
    );
  }

  Widget _buildPrintReportButton(BuildContext context) {
    return Align(
      alignment: Alignment.centerRight,
      child: ElevatedButton(
        style: ElevatedButton.styleFrom(
          primary: Colors.green,
          textStyle: TextStyle(fontWeight: FontWeight.bold),
          padding: EdgeInsets.symmetric(horizontal: 35, vertical: 18),
        ),
        onPressed: () => _showConfirmationDialog(context),
        child: Text('Print report'),
      ),
    );
  }

  void _showConfirmationDialog(BuildContext context) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: Text('Generate Report'),
          content: Text('Do you want to generate a report?'),
          actions: <Widget>[
            TextButton(
              child: Text('No'),
              onPressed: () {
                Navigator.of(context).pop();
              },
            ),
            TextButton(
              child: Text('Yes'),
              onPressed: () {
                Navigator.of(context).pop();
                _generateReport(context);
              },
            ),
          ],
        );
      },
    );
  }

  void _generateReport(BuildContext context) async {
    showDialog(
      context: context,
      barrierDismissible: false,
      builder: (BuildContext context) {
        return Center(child: CircularProgressIndicator());
      },
    );

    final response = await _orderApiService.generateOrderReport();

    Navigator.of(context).pop();

    if (response != null && response.statusCode == 200) {
      final bytes = response.bodyBytes;
      final tempDir = await getTemporaryDirectory();
      final file = File('${tempDir.path}/order_report.pdf');
      await file.writeAsBytes(bytes);

      OpenFile.open(file.path);

      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text('Report generated successfully')),
      );
    } else {
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text('Failed to generate report')),
      );
    }
  }
}
