import 'package:desktop/restaurant/order_details_page.dart';
import 'package:flutter/material.dart';

class OrdersPage extends StatefulWidget {
  final VoidCallback onNavigateToDetails;

  const OrdersPage({super.key, required this.onNavigateToDetails});
  @override
  _OrdersPageState createState() => _OrdersPageState();
}

class _OrdersPageState extends State<OrdersPage> {
  // Dummy orders data
  final List<Map<String, dynamic>> _orders = [
    {
      'id': '#1999',
      'name': 'Majstor',
      'address': 'Musala 22',
      'date': '10.18.2023',
      'price': '23KM',
      'status': 'Na dostavi',
    },
    {
      'id': '#1999',
      'name': 'Džonko',
      'address': 'Potoci BB',
      'date': '10.18.2023',
      'price': '12KM',
      'status': 'Dostavljeno',
    },
    // Add more hardcoded orders here...
  ];

  // Current filter status
  String _currentStatus = 'Sve';
  DateTime? _selectedFromDate;
  DateTime? _selectedToDate;

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
          _buildSearchField(context),
          SizedBox(height: 20),
          _buildStatusFilters(context),
          SizedBox(height: 40),
          Expanded(child: _buildOrdersTable(context)),
          _buildPagination(context),
          SizedBox(height: 10),
          _buildPrintReportButton(context),
        ],
      ),
    );
  }

  Widget _buildDatePickers(BuildContext context) {
    return Row(
      children: <Widget>[
        SizedBox(
          width: 5,
        ),
        Text('Trenutno pronadjene 2 narudzbe:'),
        SizedBox(
          width: 16,
        ),
        Text('Od:'),
        SizedBox(
          width: 16,
        ),
        ElevatedButton(
          onPressed: () => _selectDate(context, true),
          child: Text(
            _selectedFromDate == null
                ? 'Select Date'
                : MaterialLocalizations.of(context)
                    .formatShortDate(_selectedFromDate!),
          ),
        ),
        SizedBox(
          width: 16,
        ),
        Text('Do:'),
        SizedBox(
          width: 16,
        ),
        ElevatedButton(
          onPressed: () => _selectDate(context, false),
          child: Text(
            _selectedToDate == null
                ? 'Select Date'
                : MaterialLocalizations.of(context)
                    .formatShortDate(_selectedToDate!),
          ),
        ),
        SizedBox(
          width: 25,
        ),
        IconButton(
          icon: Icon(Icons.search),
          onPressed: _searchOrders,
        ),
      ],
    );
  }

  Widget _buildSearchField(BuildContext context) {
    return TextField(
      maxLength: 20,
      decoration: InputDecoration(
        labelText: 'Search',
        suffixIcon: Icon(Icons.search),
      ),
    );
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

  void _searchOrders() {
    print(
        'From: ${_selectedFromDate == null ? "Not selected" : MaterialLocalizations.of(context).formatShortDate(_selectedFromDate!)}');
    print(
        'To: ${_selectedToDate == null ? "Not selected" : MaterialLocalizations.of(context).formatShortDate(_selectedToDate!)}');
  }

  Widget _buildStatusFilters(BuildContext context) {
    List<String> statuses = ['Sve', 'U pripremi', 'Na dostavi', 'Dostavljeno'];
    return Row(
      mainAxisAlignment: MainAxisAlignment.spaceEvenly,
      children: statuses.map((status) {
        return ChoiceChip(
          label: Text(status),
          selected: _currentStatus == status,
          onSelected: (bool selected) {
            setState(() {
              _currentStatus = status;
            });
          },
          selectedColor: Colors.orange,
          backgroundColor: Colors.grey,
        );
      }).toList(),
    );
  }

  /*  Widget _buildOrdersTable(BuildContext context) {
    // Replace with your actual table widget
    return SingleChildScrollView(
      scrollDirection: Axis.vertical,
      child: DataTable(
        columns: const <DataColumn>[
          DataColumn(label: Text('Id')),
          DataColumn(label: Text('Ime')),
          DataColumn(label: Text('Adresa')),
          DataColumn(label: Text('Datum')),
          DataColumn(label: Text('Cijena')),
          DataColumn(label: Text('Status')),
          DataColumn(label: Text('Akcija')),
        ],
        rows: _orders.map((order) {
          return DataRow(cells: [
            DataCell(Text(order['id'])),
            DataCell(Text(order['name'])),
            DataCell(Text(order['address'])),
            DataCell(Text(order['date'])),
            DataCell(Text(order['price'])),
            DataCell(Text(order['status'])),
            DataCell(TextButton(onPressed: () {}, child: Text('Detalji'))),
          ]);
        }).toList(),
      ),
    );
  } */

  Widget _buildOrdersTable(BuildContext context) {
    return SingleChildScrollView(
      scrollDirection: Axis.horizontal,
      child: ConstrainedBox(
        constraints: BoxConstraints(minWidth: 1500), // Minimum table width
        child: DataTable(
          columnSpacing: 38, // Adjust the spacing as needed
          columns: const <DataColumn>[
            DataColumn(label: Text('Id')),
            DataColumn(label: Text('Ime')),
            DataColumn(label: Text('Adresa')),
            DataColumn(label: Text('Datum')),
            DataColumn(label: Text('Cijena')),
            DataColumn(label: Text('Status')),
            DataColumn(label: Text('Akcija')),
          ],
          rows: _orders.map((order) {
            return DataRow(cells: [
              DataCell(Text(order['id'])),
              DataCell(Text(order['name'])),
              DataCell(Text(order['address'])),
              DataCell(Text(order['date'])),
              DataCell(Text(order['price'])),
              DataCell(Text(order['status'])),
              DataCell(TextButton(
                  onPressed: widget.onNavigateToDetails,
                  child: Text('Detalji'))),
            ]);
          }).toList(),
        ),
      ),
    );
  }
}

Widget _buildPagination(BuildContext context) {
  return Row(
    mainAxisAlignment: MainAxisAlignment.center,
    children: [
      IconButton(icon: Icon(Icons.arrow_back_ios), onPressed: () {}),
      SizedBox(width: 12),
      Text('1'),
      SizedBox(width: 12),
      IconButton(icon: Icon(Icons.arrow_forward_ios), onPressed: () {}),
    ],
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
      onPressed: () {
        // Implement your print logic here
      },
      child: Text('Printaj izvještaj'),
    ),
  );
}
