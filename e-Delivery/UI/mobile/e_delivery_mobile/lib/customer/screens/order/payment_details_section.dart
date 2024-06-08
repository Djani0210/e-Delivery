import 'package:flutter/material.dart';

class PaymentDetailsSection extends StatefulWidget {
  final int paymentMethod;
  final ValueChanged<int> onPaymentMethodChanged;

  const PaymentDetailsSection({
    Key? key,
    required this.paymentMethod,
    required this.onPaymentMethodChanged,
  }) : super(key: key);

  @override
  _PaymentDetailsSectionState createState() => _PaymentDetailsSectionState();
}

class _PaymentDetailsSectionState extends State<PaymentDetailsSection> {
  late int _selectedPaymentMethod;

  @override
  void initState() {
    super.initState();
    _selectedPaymentMethod = widget.paymentMethod;
  }

  void _handlePaymentMethodChange(int? value) {
    if (value != null) {
      setState(() {
        _selectedPaymentMethod = value;
      });
      widget.onPaymentMethodChanged(value);
    }
  }

  @override
  Widget build(BuildContext context) {
    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        const Text(
          'Payment details',
          style: TextStyle(fontSize: 24, fontWeight: FontWeight.bold),
        ),
        const SizedBox(height: 16),
        const Text(
          'Pay with:',
          style: TextStyle(fontSize: 18, fontWeight: FontWeight.bold),
        ),
        const SizedBox(height: 8),
        Container(
          padding: const EdgeInsets.all(16),
          decoration: BoxDecoration(
            borderRadius: BorderRadius.circular(8),
          ),
          child: Column(
            children: [
              RadioListTile(
                contentPadding: EdgeInsets.zero,
                title: Row(
                  children: [
                    const Icon(Icons.credit_card),
                    const SizedBox(width: 8),
                    const Text('Credit Card'),
                  ],
                ),
                value: 1,
                groupValue: _selectedPaymentMethod,
                onChanged: _handlePaymentMethodChange,
                activeColor: Colors.orange,
              ),
              RadioListTile(
                contentPadding: EdgeInsets.zero,
                title: Row(
                  children: [
                    const Icon(Icons.money),
                    const SizedBox(width: 8),
                    const Text('Cash'),
                  ],
                ),
                value: 2,
                groupValue: _selectedPaymentMethod,
                onChanged: _handlePaymentMethodChange,
                activeColor: Colors.orange,
              ),
            ],
          ),
        ),
      ],
    );
  }
}
