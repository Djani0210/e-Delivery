import 'dart:convert';

import 'package:desktop/globals.dart';
import 'package:desktop/loginRegistration/reset_password.dart';
import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;
import '../components/hover_animation.dart'; // Assuming HoverAnimation is in a separate file

class ConfirmCodePage extends StatefulWidget {
  final String email;
  const ConfirmCodePage({super.key, required this.email});

  @override
  State<ConfirmCodePage> createState() => _ConfirmCodePageState();
}

class _ConfirmCodePageState extends State<ConfirmCodePage> {
  final _formKey = GlobalKey<FormState>();

  final codeController = TextEditingController();
  bool _showError = false;

  Future<void> checkCode(String email, String code) async {
    final response = await http.post(
      Uri.parse('${baseUrl}User/check-code'),
      headers: {'Content-Type': 'application/json'},
      body: jsonEncode({
        'Email': widget.email,
        'Code': code,
      }),
    );

    if (response.statusCode == 200) {
      // Navigate to ResetPasswordPage
      Navigator.push(
        context,
        MaterialPageRoute(builder: (context) => ResetPasswordPage()),
      );
    } else {
      // Show an error message in a SnackBar
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
            duration: Duration(milliseconds: 2000),
            content: Center(
                child: Text(
              'Failed to verify code',
              style: TextStyle(color: Colors.red),
            ))),
      );
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Enter code'),
        backgroundColor: Theme.of(context).appBarTheme.backgroundColor,
      ),
      body: Center(
        child: Form(
          key: _formKey,
          child: Padding(
            padding: const EdgeInsets.all(20.0),
            child: SingleChildScrollView(
              physics: const ScrollPhysics(),
              child: Column(
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
                  Text(
                    'Verify your code please',
                    style: Theme.of(context).textTheme.titleLarge,
                  ),
                  const SizedBox(height: 20),
                  HoverAnimation(
                    size: const Size(360, 54),
                    hoverColor: Colors.white,
                    bgColor: Colors.white,
                    offset: const Offset(4, 4),
                    border: Border.all(),
                    child: Padding(
                      padding: const EdgeInsets.symmetric(
                          horizontal: 8, vertical: 2),
                      child: TextFormField(
                        controller: codeController,
                        decoration: const InputDecoration(
                          hintText: 'Code',
                          border: InputBorder.none,
                        ),
                        validator: (value) {
                          if (value!.length != 6) {
                            setState(() {
                              _showError = true;
                            });
                            return '';
                          }
                          setState(() {
                            _showError = false;
                          });
                          return null;
                        },
                      ),
                    ),
                  ),
                  const SizedBox(height: 40),
                  SizedBox(
                    width: 360,
                    child: HoverAnimation(
                      size: const Size(360, 54),
                      hoverColor: Theme.of(context).hoverColor,
                      bgColor: Theme.of(context).colorScheme.background,
                      offset: const Offset(4, 4),
                      border: Border.all(),
                      child: ElevatedButton(
                        onPressed: () {
                          if (_formKey.currentState!.validate()) {
                            checkCode(widget.email, codeController.text);
                          }
                        },
                        style: ElevatedButton.styleFrom(),
                        child: const Text('Verify'),
                      ),
                    ),
                  ),
                  SizedBox(
                    height: 20.0, // Reserve space for error message
                    child: _showError
                        ? Text(
                            'Code must be 6 characters',
                            style: TextStyle(
                              color: Colors
                                  .red, // Optional: customize error message style
                            ),
                          )
                        : null, // If no error, don't show anything
                  ),
                ],
              ),
            ),
          ),
        ),
      ),
    );
  }
}
