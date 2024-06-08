import 'dart:async';
import 'dart:convert';
import 'package:e_delivery_mobile/customer/core/constants/app_defaults.dart';
import 'package:e_delivery_mobile/customer/screens/auth/change_pass_page.dart';
import 'package:e_delivery_mobile/customer/screens/auth/components/otp_fields.dart';
import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;

class CodeVerificationPage extends StatefulWidget {
  final String email;

  const CodeVerificationPage({Key? key, required this.email}) : super(key: key);

  @override
  _CodeVerificationPageState createState() => _CodeVerificationPageState();
}

class _CodeVerificationPageState extends State<CodeVerificationPage> {
  String _code = '';
  bool _isButtonEnabled = false;
  int _resendCountdown = 32;
  late Timer _resendTimer;

  @override
  void initState() {
    super.initState();
    startResendTimer();
  }

  @override
  void dispose() {
    _resendTimer.cancel();
    super.dispose();
  }

  void startResendTimer() {
    _resendTimer = Timer.periodic(const Duration(seconds: 1), (timer) {
      if (_resendCountdown > 0) {
        setState(() {
          _resendCountdown--;
        });
      } else {
        _resendTimer.cancel();
      }
    });
  }

  Future<void> resendCode(String email) async {
    final response = await http.post(
      Uri.parse('https://10.0.2.2:44395/api/User/forgot-password'),
      headers: {'Content-Type': 'application/json'},
      body: jsonEncode({
        'Email': email,
      }),
    );

    if (response.statusCode == 200) {
      // Code resent successfully
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(
          duration: Duration(milliseconds: 2000),
          content: Center(
            child: Text('Code resent successfully'),
          ),
        ),
      );
      setState(() {
        _resendCountdown = 32;
      });
      startResendTimer();
    } else {
      // Show an error message in a SnackBar
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(
          duration: Duration(milliseconds: 2000),
          content: Center(
            child: Text(
              'Failed to resend code',
              style: TextStyle(color: Colors.red),
            ),
          ),
        ),
      );
    }
  }

  Future<void> checkCode(String email, String code) async {
    final response = await http.post(
      Uri.parse('https://10.0.2.2:44395/api/User/check-code'),
      headers: {'Content-Type': 'application/json'},
      body: jsonEncode({
        'Email': email,
        'Code': code,
      }),
    );

    if (response.statusCode == 200) {
      // Navigate to ChangePassPage
      Navigator.push(
        context,
        MaterialPageRoute(builder: (context) => const ChangePassPage()),
      );
    } else {
      // Show an error message in a SnackBar
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(
          duration: Duration(milliseconds: 2000),
          content: Center(
            child: Text(
              'Failed to verify code',
              style: TextStyle(color: Colors.red),
            ),
          ),
        ),
      );
    }
  }

  void _onCodeChanged(String code) {
    setState(() {
      _code = code;
      _isButtonEnabled = code.length == 6;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(
        child: Column(
          children: [
            const Spacer(),
            Align(
              alignment: Alignment.centerLeft,
              child: Padding(
                padding: const EdgeInsets.all(AppDefaults.padding),
                child: Text(
                  'Code\nVerification',
                  style: Theme.of(context).textTheme.headlineSmall,
                ),
              ),
            ),
            const Spacer(),
            OtpInput(
              onCodeChanged: _onCodeChanged,
              onVerificationPressed: () {
                checkCode(widget.email, _code);
              },
              isButtonEnabled: _isButtonEnabled,
              onResendPressed: _resendCountdown == 0
                  ? () {
                      resendCode(widget.email);
                    }
                  : null,
              resendCountdown: _resendCountdown,
            ),
            const Spacer(flex: 5),
          ],
        ),
      ),
    );
  }
}

class OtpInput extends StatelessWidget {
  final Function(String) onCodeChanged;
  final VoidCallback onVerificationPressed;
  final VoidCallback? onResendPressed;
  final bool isButtonEnabled;
  final int resendCountdown;

  const OtpInput({
    Key? key,
    required this.onCodeChanged,
    required this.onVerificationPressed,
    required this.isButtonEnabled,
    required this.onResendPressed,
    required this.resendCountdown,
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
          const SizedBox(height: AppDefaults.padding),
          SizedBox(
            width: double.infinity,
            child: ElevatedButton(
              onPressed: isButtonEnabled ? onVerificationPressed : null,
              child: const Text('Verification'),
            ),
          ),
          const SizedBox(height: AppDefaults.padding),
          Row(
            mainAxisAlignment: MainAxisAlignment.center,
            children: [
              const Text('Didn\'t receive the code?'),
              TextButton(
                onPressed: onResendPressed,
                child: Text(
                  'Re-send (${resendCountdown.toString()})',
                  style: Theme.of(context).textTheme.labelLarge?.copyWith(
                        fontWeight: FontWeight.bold,
                        color: Colors.black,
                      ),
                ),
              )
            ],
          )
        ],
      ),
    );
  }
}
