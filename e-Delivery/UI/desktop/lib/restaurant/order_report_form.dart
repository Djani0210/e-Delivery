import 'dart:io';
import 'dart:typed_data';

import 'package:desktop/restaurant/api_calls/order_api_calls.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:intl/intl.dart';
import 'package:flutter_pdfview/flutter_pdfview.dart';
import 'package:open_file/open_file.dart';
import 'package:path_provider/path_provider.dart';

class OrderReportForm extends StatefulWidget {
  final Function(DateTime?, DateTime?, double?, double?) onGenerateReport;

  const OrderReportForm({Key? key, required this.onGenerateReport})
      : super(key: key);

  @override
  _OrderReportFormState createState() => _OrderReportFormState();
}

class _OrderReportFormState extends State<OrderReportForm> {
  DateTime? _selectedFromDate;
  DateTime? _selectedToDate;
  double _minPrice = 0.0;
  double _maxPrice = 0.0;
  bool _isLoading = false;
  Uint8List? _pdfData;

  final _formKey = GlobalKey<FormState>();

  final _minPriceController = TextEditingController();
  final _maxPriceController = TextEditingController();

  @override
  void dispose() {
    _minPriceController.dispose();
    _maxPriceController.dispose();
    super.dispose();
  }

  Future<void> _selectDate(BuildContext context, bool isFromDate) async {
    final DateTime? pickedDate = await showDatePicker(
      context: context,
      initialDate:
          isFromDate ? DateTime.now() : _selectedFromDate ?? DateTime.now(),
      firstDate:
          isFromDate ? DateTime(2000) : _selectedFromDate ?? DateTime(2000),
      lastDate: DateTime(2100),
    );
    if (pickedDate != null) {
      setState(() {
        if (isFromDate) {
          _selectedFromDate = pickedDate;
        } else {
          _selectedToDate = pickedDate;
        }
      });
    }
  }

  Future<void> _generateReport() async {
    if (_formKey.currentState!.validate()) {
      setState(() {
        _isLoading = true;
      });

      final response = await OrderApiService().generateOrderReport(
        fromDate: _selectedFromDate,
        toDate: _selectedToDate,
        minPrice: _minPrice,
        maxPrice: _maxPrice,
      );

      if (response != null && response.statusCode == 200) {
        final directory = await getDownloadsDirectory();
        final filePath = '${directory?.path}/report.pdf';
        final file = File(filePath);
        await file.writeAsBytes(response.bodyBytes);

        setState(() {
          _isLoading = false;
        });

        await OpenFile.open(filePath);
        widget.onGenerateReport(
            _selectedFromDate, _selectedToDate, _minPrice, _maxPrice);
        Navigator.of(context).pop();
      } else {
        setState(() {
          _isLoading = false;
        });
        print(
            "Greška pri generisanju izvestaja: Status kod ${response?.statusCode}");
      }
    }
  }

  String? _validatePrice(String? value) {
    if (value == null || value.isEmpty) {
      return null;
    }
    final price = double.tryParse(value);
    if (price == null) {
      return 'Molimo unesite validnu vrijednost';
    }
    if (price < 0) {
      return 'Vrijednost mora biti pozitivna';
    }
    return null;
  }

  void _incrementPrice(TextEditingController controller) {
    final currentValue = double.tryParse(controller.text) ?? 0.0;
    final newValue = currentValue + 1.0;
    controller.text = newValue.toStringAsFixed(2);
  }

  void _decrementPrice(TextEditingController controller) {
    final currentValue = double.tryParse(controller.text) ?? 0.0;
    final newValue = currentValue - 1.0;
    controller.text = newValue >= 0 ? newValue.toStringAsFixed(2) : '0.00';
  }

  @override
  Widget build(BuildContext context) {
    return SizedBox(
      width: 400,
      child: SingleChildScrollView(
        padding: const EdgeInsets.all(16.0),
        child: Form(
          key: _formKey,
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              Text(
                'Generiši izvještaj za narudžbe',
                style: TextStyle(
                  fontSize: 20,
                  fontWeight: FontWeight.bold,
                ),
              ),
              SizedBox(height: 16),
              Row(
                children: [
                  Text('Od:'),
                  SizedBox(width: 16),
                  ElevatedButton(
                    style: ElevatedButton.styleFrom(
                      primary: Colors.blue,
                      textStyle: TextStyle(fontWeight: FontWeight.bold),
                      padding:
                          EdgeInsets.symmetric(horizontal: 16, vertical: 12),
                    ),
                    onPressed: () => _selectDate(context, true),
                    child: Text(
                      _selectedFromDate == null
                          ? 'Odaberi datum'
                          : DateFormat('yyyy-MM-dd').format(_selectedFromDate!),
                    ),
                  ),
                  SizedBox(width: 16),
                  Text('Do:'),
                  SizedBox(width: 16),
                  ElevatedButton(
                    style: ElevatedButton.styleFrom(
                      primary: Colors.blue,
                      textStyle: TextStyle(fontWeight: FontWeight.bold),
                      padding:
                          EdgeInsets.symmetric(horizontal: 16, vertical: 12),
                    ),
                    onPressed: () => _selectDate(context, false),
                    child: Text(
                      _selectedToDate == null
                          ? 'Odaberi Datum'
                          : DateFormat('yyyy-MM-dd').format(_selectedToDate!),
                    ),
                  ),
                ],
              ),
              SizedBox(height: 16),
              Row(
                children: [
                  Expanded(
                    child: TextFormField(
                      controller: _minPriceController,
                      decoration: InputDecoration(
                        labelText: 'Min cijena',
                      ),
                      keyboardType: TextInputType.number,
                      inputFormatters: [
                        FilteringTextInputFormatter.allow(
                            RegExp(r'^\d{0,4}\.?\d{0,2}')),
                      ],
                      validator: _validatePrice,
                      onChanged: (value) {
                        setState(() {
                          _minPrice = double.tryParse(value) ?? 0.0;
                        });
                      },
                    ),
                  ),
                  SizedBox(width: 8),
                  Column(
                    children: [
                      IconButton(
                        iconSize: 16,
                        icon: Icon(Icons.arrow_drop_up),
                        onPressed: () => _incrementPrice(_minPriceController),
                      ),
                      IconButton(
                        iconSize: 16,
                        icon: Icon(Icons.arrow_drop_down),
                        onPressed: () => _decrementPrice(_minPriceController),
                      ),
                    ],
                  ),
                ],
              ),
              SizedBox(height: 16),
              Row(
                children: [
                  Expanded(
                    child: TextFormField(
                      controller: _maxPriceController,
                      decoration: InputDecoration(
                        labelText: 'Max cijena',
                      ),
                      keyboardType: TextInputType.number,
                      inputFormatters: [
                        FilteringTextInputFormatter.allow(
                            RegExp(r'^\d{0,4}\.?\d{0,2}')),
                      ],
                      validator: (value) {
                        final error = _validatePrice(value);
                        if (error != null) {
                          return error;
                        }
                        if (_maxPrice < _minPrice) {
                          return 'Max cijena ne može biti manja od min cijene';
                        }
                        return null;
                      },
                      onChanged: (value) {
                        setState(() {
                          _maxPrice = double.tryParse(value) ?? 0.0;
                        });
                      },
                    ),
                  ),
                  SizedBox(width: 8),
                  Column(
                    children: [
                      IconButton(
                        iconSize: 16,
                        icon: Icon(Icons.arrow_drop_up),
                        onPressed: () => _incrementPrice(_maxPriceController),
                      ),
                      IconButton(
                        iconSize: 16,
                        icon: Icon(Icons.arrow_drop_down),
                        onPressed: () => _decrementPrice(_maxPriceController),
                      ),
                    ],
                  ),
                ],
              ),
              SizedBox(height: 16),
              Center(
                child: ElevatedButton(
                  style: ElevatedButton.styleFrom(
                    primary: Colors.green,
                    textStyle: TextStyle(fontWeight: FontWeight.bold),
                    padding: EdgeInsets.symmetric(horizontal: 35, vertical: 18),
                  ),
                  onPressed: _isLoading ? null : _generateReport,
                  child: _isLoading
                      ? CircularProgressIndicator()
                      : Text('Generiši izvještaj'),
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }
}
