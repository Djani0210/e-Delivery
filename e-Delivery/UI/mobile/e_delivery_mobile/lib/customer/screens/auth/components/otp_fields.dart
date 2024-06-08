import 'package:e_delivery_mobile/customer/core/constants/app_defaults.dart';
import 'package:e_delivery_mobile/customer/screens/auth/components/otp_textfield.dart';
import 'package:flutter/material.dart';

class OTPFields extends StatefulWidget {
  final Function(String) onCodeChanged;

  const OTPFields({Key? key, required this.onCodeChanged}) : super(key: key);

  @override
  _OTPFieldsState createState() => _OTPFieldsState();
}

class _OTPFieldsState extends State<OTPFields> {
  late List<TextEditingController> _controllers;

  @override
  void initState() {
    super.initState();
    _controllers = List.generate(6, (_) => TextEditingController());
  }

  @override
  void dispose() {
    _controllers.forEach((controller) => controller.dispose());
    super.dispose();
  }

  void _onCodeChanged() {
    final code = _controllers.map((controller) => controller.text).join();
    widget.onCodeChanged(code);
  }

  void _shiftToNextField(int index) {
    if (_controllers[index].text.isNotEmpty &&
        index < _controllers.length - 1) {
      FocusScope.of(context).nextFocus();
    }
  }

  final InputDecoration _decoration = InputDecoration(
    enabledBorder: UnderlineInputBorder(
      borderSide: BorderSide(color: Colors.grey.withOpacity(0.25)),
    ),
    focusedBorder: const UnderlineInputBorder(borderSide: BorderSide()),
    border: const UnderlineInputBorder(borderSide: BorderSide()),
  );

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.all(AppDefaults.padding),
      child: Row(
        mainAxisAlignment: MainAxisAlignment.spaceBetween,
        children: List.generate(
          6,
          (index) => OTPTextField(
            onChanged: () {
              _onCodeChanged();
              _shiftToNextField(index);
            },
            controller: _controllers[index],
            decoration: _decoration,
            autofocus: index == 0,
          ),
        ),
      ),
    );
  }
}
