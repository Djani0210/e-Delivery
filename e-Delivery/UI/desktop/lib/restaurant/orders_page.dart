import 'dart:convert';
import 'package:desktop/restaurant/order_report_form.dart';

import 'package:intl/intl.dart';

import 'package:desktop/restaurant/api_calls/order_api_calls.dart';

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
  String _currentStatus = 'Sve';
  DateTime? _selectedFromDate;
  DateTime? _selectedToDate;
  int? _currentOrderState;
  int _totalOrdersCount = 0;
  @override
  void initState() {
    super.initState();
    _fetchOrders();
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
      // Access the nested "orders" within "data"
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

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.all(16.0),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: <Widget>[
          SizedBox(width: 10),
          Text(
            'Narudzbe',
            style: TextStyle(
              fontSize: 24, // Make the font size larger
              fontWeight: FontWeight.bold, // Make the text bold
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
        Text('Trenutno pronađeno $_totalOrdersCount narudžbi:'),
        SizedBox(width: 16),
        Text('Od:'),
        SizedBox(width: 16),
        ElevatedButton(
          onPressed: () => _selectDate(context, true),
          child: Text(
            _selectedFromDate == null
                ? 'Odaberite datum'
                : DateFormat('yyyy-MM-dd').format(_selectedFromDate!),
          ),
        ),
        SizedBox(width: 16),
        Text('Do:'),
        SizedBox(width: 16),
        ElevatedButton(
          onPressed: () => _selectDate(context, false),
          child: Text(
            _selectedToDate == null
                ? 'Odaberite datum'
                : DateFormat('yyyy-MM-dd').format(_selectedToDate!),
          ),
        ),
        SizedBox(width: 25),
        IconButton(
          icon: Icon(Icons.search),
          onPressed: () {
            // Here, we call _fetchOrders with the currently selected dates
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
      _currentStatus = 'Sve';
      _currentOrderState = null;
      _currentPage = 1; // Reset to the first page
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
    List<String> statuses = ['Sve', 'U pripremi', 'Na dostavi', 'Dostavljeno'];
    // No need to maintain a separate list for status codes if converting directly in the method
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
              // Convert status to orderState integer, handling "Sve" as null

              _currentOrderState = status == 'Sve' ? null : index;
              // Now pass the integer or null to _fetchOrders
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
        constraints: BoxConstraints(minWidth: 1500), // Minimum table width
        child: DataTable(
          columnSpacing: 38, // Adjust the spacing as needed
          columns: const <DataColumn>[
            DataColumn(label: Text('Id')),
            DataColumn(label: Text('Ime')),
            DataColumn(label: Text('Datum')),
            DataColumn(label: Text('Cijena')),
            DataColumn(label: Text('Status')),
            DataColumn(label: Text('Akcija')),
          ],
          rows: _orders.map((order) {
            return DataRow(cells: [
              DataCell(Text(order.id)),
              DataCell(Text(order.location.city.title)),
              DataCell(Text(formatDateTime(order.createdDate.toString()))),
              DataCell(Text(order.totalCost.toString())),
              DataCell(Text(order.orderStateText)),
              DataCell(TextButton(
                  onPressed: () => widget.onNavigateToDetails(order.id),
                  child: Text('Detalji'))),
            ]);
          }).toList(),
        ),
      ),
    );
  }

  void _showOrderReportDialog() {
    showDialog(
      context: context,
      builder: (context) {
        return Dialog(
          child: OrderReportForm(
            onGenerateReport: (fromDate, toDate, minPrice, maxPrice) {
              // Handle the generated report here
              print(
                  'Report generated from $fromDate to $toDate with min price $minPrice and max price $maxPrice');
            },
          ),
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
        onPressed: _showOrderReportDialog,
        child: Text('Printaj izvještaj'),
      ),
    );
  }
}
