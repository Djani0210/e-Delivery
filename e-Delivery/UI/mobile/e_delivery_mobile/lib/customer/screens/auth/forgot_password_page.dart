import 'package:e_delivery_mobile/customer/core/constants/app_defaults.dart';
import 'package:e_delivery_mobile/customer/core/constants/app_icons.dart';
import 'package:e_delivery_mobile/customer/screens/auth/code_verification_page.dart';
import 'package:e_delivery_mobile/customer/screens/auth/login_page.dart';
import 'package:e_delivery_mobile/storage_service.dart';

import 'package:flutter/material.dart';
import 'package:flutter_svg/svg.dart';
import 'dart:convert';
import 'package:http/http.dart' as http;

class ForgotPassPage extends StatelessWidget {
  const ForgotPassPage({Key? key}) : super(key: key);

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
                  'Forgot\nPassword?',
                  style: Theme.of(context).textTheme.headlineSmall,
                ),
              ),
            ),
            const Spacer(flex: 1),
            const ForgotPasswordForm(),
            const Spacer(flex: 2),
          ],
        ),
      ),
    );
  }
}

class ForgotPasswordForm extends StatefulWidget {
  const ForgotPasswordForm({Key? key}) : super(key: key);

  @override
  _ForgotPasswordFormState createState() => _ForgotPasswordFormState();
}

class _ForgotPasswordFormState extends State<ForgotPasswordForm> {
  final _formKey = GlobalKey<FormState>();
  String _email = '';

  Future<void> sendForgotPasswordRequest(String email) async {
    final response = await http.post(
      Uri.parse('http://10.0.2.2:44395/api/User/forgot-password'),
      headers: {'Content-Type': 'application/json'},
      body: jsonEncode({
        'Email': email,
      }),
    );

    if (response.statusCode == 200) {
      Navigator.push(
        context,
        MaterialPageRoute(
          builder: (context) => CodeVerificationPage(
            email: _email,
          ),
        ),
      );
    } else {
      // Show an error message in a SnackBar
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          duration: Duration(milliseconds: 2000),
          content: Center(
            child: Text(
              'Failed to send forgot password request',
              style: TextStyle(color: Colors.red),
            ),
          ),
        ),
      );
    }
  }

  Future<void> fetchUserIdFromEmail(String email) async {
    final response = await http.get(
      Uri.parse(
          'http://10.0.2.2:44395/api/User/get-user-from-email?email=$email'),
      headers: {'Content-Type': 'application/json'},
    );

    if (response.statusCode == 200) {
      final responseBody = jsonDecode(response.body);
      final userId = responseBody['data']['id'];

      // Store the UserId securely using SharedPreferences
      await StorageService.storage
          .write(key: 'forgotPasswordUserId', value: userId);
    } else {
      // Show an error message in a SnackBar
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          duration: Duration(milliseconds: 2000),
          content: Center(
            child: Text(
              'Failed to retrieve user information',
              style: TextStyle(color: Colors.red),
            ),
          ),
        ),
      );
    }
  }

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.all(AppDefaults.padding),
      child: Form(
        key: _formKey,
        child: Column(
          children: [
            TextFormField(
              decoration: InputDecoration(
                labelText: 'Email',
                suffixIcon: SvgPicture.asset(AppIcons.email),
                suffixIconConstraints: const BoxConstraints(maxHeight: 24),
              ),
              keyboardType: TextInputType.emailAddress,
              validator: (value) {
                if (value == null || value.isEmpty) {
                  return 'Please enter your email';
                }
                if (!value.contains('@')) {
                  return 'Please enter a valid email';
                }
                if (value.split('@')[0].length < 3) {
                  return 'Email should have at least 3 letters before the @ sign';
                }
                if (!value.endsWith('@gmail.com')) {
                  return 'Email should end with @gmail.com';
                }
                return null;
              },
              onSaved: (value) {
                _email = value!;
              },
            ),
            const SizedBox(height: 16),
            Text(
              'Please provide your email to reset your password, please don\'t share any data with other people.',
              style: Theme.of(context).textTheme.bodySmall,
            ),
            const SizedBox(height: 16),
            SizedBox(
              width: double.infinity,
              child: ElevatedButton(
                onPressed: () {
                  if (_formKey.currentState!.validate()) {
                    _formKey.currentState!.save();
                    // Call fetchUserIdFromEmail to retrieve the user's ID
                    fetchUserIdFromEmail(_email).then((_) {
                      // After the user's ID is fetched and stored, proceed with sending the verification code
                      sendForgotPasswordRequest(_email);
                    }).catchError((error) {
                      // Handle any errors that occur during fetching the user's ID
                      ScaffoldMessenger.of(context).showSnackBar(
                        SnackBar(
                          content: Text(
                              'Failed to retrieve user information: $error'),
                        ),
                      );
                    });
                  }
                },
                child: const Text('Reset Password'),
              ),
            ),
            const SizedBox(height: 16),
            Row(
              mainAxisAlignment: MainAxisAlignment.center,
              children: [
                const Text('Remember now?'),
                TextButton(
                  onPressed: () {
                    Navigator.push(
                      context,
                      MaterialPageRoute(
                          builder: (context) => const LoginPage()),
                    );
                  },
                  child: Text(
                    'Login Here',
                    style: Theme.of(context).textTheme.labelLarge?.copyWith(
                          fontWeight: FontWeight.bold,
                          color: Colors.black,
                        ),
                  ),
                ),
              ],
            ),
          ],
        ),
      ),
    );
  }
}
