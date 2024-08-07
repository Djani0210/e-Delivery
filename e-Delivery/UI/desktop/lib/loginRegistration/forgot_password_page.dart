import 'package:desktop/globals.dart';
import 'package:flutter/material.dart';
import '../components/hover_animation.dart';
import 'confirm_code_page.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';
import 'package:desktop/components/storage_service.dart';

class ForgotPasswordPage extends StatefulWidget {
  const ForgotPasswordPage({Key? key}) : super(key: key);

  @override
  State<ForgotPasswordPage> createState() => _ForgotPasswordPageState();
}

class _ForgotPasswordPageState extends State<ForgotPasswordPage> {
  final _formKey = GlobalKey<FormState>();
  final emailController = TextEditingController();
  bool _showError = false;

  Future<void> sendForgotPasswordRequest(String email) async {
    final response = await http.post(
      Uri.parse('${baseUrl}User/forgot-password'),
      headers: {'Content-Type': 'application/json'},
      body: jsonEncode({
        'Email': email,
      }),
    );
    if (response.statusCode == 200) {
      Navigator.push(
        context,
        MaterialPageRoute(
            builder: (context) => ConfirmCodePage(
                  email: emailController.text,
                )),
      );
    } else {
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
            duration: Duration(milliseconds: 2000),
            content: Center(
                child: Text(
              'Failed to send forgot password request',
              style: TextStyle(color: Colors.red),
            ))),
      );
    }
  }

  Future<void> fetchUserIdFromEmail(String email) async {
    final response = await http.get(
      Uri.parse('${baseUrl}User/get-user-from-email?email=$email'),
      headers: {'Content-Type': 'application/json'},
    );

    if (response.statusCode == 200) {
      final responseBody = jsonDecode(response.body);
      final userId = responseBody['data']['id'];

      await StorageService.storage
          .write(key: 'forgotPasswordUserId', value: userId);
    } else {
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
            duration: Duration(milliseconds: 2000),
            content: Center(
                child: Text(
              'Failed to retrieve user information',
              style: TextStyle(color: Colors.red),
            ))),
      );
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Forgot Password'),
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
                    'Enter your registered email address.',
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
                        controller: emailController,
                        maxLength: 30,
                        decoration: const InputDecoration(
                          hintText: 'Email',
                          border: InputBorder.none,
                        ),
                        validator: (value) {
                          if (!value!.contains('@gmail.com')) {
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
                            fetchUserIdFromEmail(emailController.text)
                                .then((_) {
                              sendForgotPasswordRequest(emailController.text);
                            }).catchError((error) {
                              ScaffoldMessenger.of(context).showSnackBar(
                                SnackBar(
                                    content: Text(
                                        'Failed to retrieve user information: $error')),
                              );
                            });
                          }
                        },
                        style: ElevatedButton.styleFrom(),
                        child: const Text('Proceed'),
                      ),
                    ),
                  ),
                  SizedBox(
                    height: 20.0,
                    child: _showError
                        ? Text(
                            'Please enter a valid email address.',
                            style: TextStyle(
                              color: Colors.red,
                            ),
                          )
                        : null,
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
