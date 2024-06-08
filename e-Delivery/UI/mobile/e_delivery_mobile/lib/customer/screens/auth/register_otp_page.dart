import 'package:e_delivery_mobile/customer/core/constants/ap_illustrations.dart';
import 'package:e_delivery_mobile/customer/core/constants/app_defaults.dart';
import 'package:e_delivery_mobile/customer/core/constants/app_icons.dart';
import 'package:flutter/material.dart';
import 'package:flutter_svg/svg.dart';

import 'components/need_help_button.dart';
import 'components/otp_fields.dart';

class RegisterOTPPage extends StatefulWidget {
  const RegisterOTPPage({Key? key}) : super(key: key);

  @override
  _RegisterOTPPageState createState() => _RegisterOTPPageState();
}

class _RegisterOTPPageState extends State<RegisterOTPPage> {
  // ignore: unused_field
  String _code = '';

  void _onCodeChanged(String code) {
    setState(() {
      _code = code;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      resizeToAvoidBottomInset: false,
      appBar: AppBar(
        leading: IconButton(
          icon: SvgPicture.asset(AppIcons.back),
          onPressed: () => Navigator.pop(context),
        ),
      ),
      body: Column(
        children: [
          const Spacer(),
          SvgPicture.asset(AppIllustrations.illustration5),
          OtpInput(onCodeChanged: _onCodeChanged),
          const Spacer(flex: 2),
          const NeedHelpButton(),
          const Spacer(),
        ],
      ),
    );
  }
}

class OtpInput extends StatelessWidget {
  final Function(String) onCodeChanged;

  const OtpInput({
    Key? key,
    required this.onCodeChanged,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.all(AppDefaults.padding),
      child: Column(
        children: [
          SizedBox(
            width: MediaQuery.of(context).size.width * 0.8,
            child: OTPFields(onCodeChanged: onCodeChanged),
          ),
          Text(
            'We have sent code verification to your\nmobile phone number **9383.',
            style: Theme.of(context).textTheme.bodySmall,
          ),
          const SizedBox(height: AppDefaults.padding),
          SizedBox(
            width: double.infinity,
            child: ElevatedButton(
              onPressed: () {},
              child: const Text('Verification'),
            ),
          ),
          const SizedBox(height: AppDefaults.padding),
          Row(
            mainAxisAlignment: MainAxisAlignment.center,
            children: [
              const Text('Didn\'t receive the code?'),
              TextButton(
                onPressed: () {},
                child: Text(
                  'Re-send (32)',
                  style: Theme.of(context).textTheme.labelLarge?.copyWith(
                      fontWeight: FontWeight.bold, color: Colors.black),
                ),
              )
            ],
          )
        ],
      ),
    );
  }
}
