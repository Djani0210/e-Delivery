import 'package:desktop/globals.dart';
import 'package:desktop/loginRegistration/log_in_page.dart';
import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;
import '../components/hover_animation.dart';
import 'package:desktop/components/storage_service.dart';

class ResetPasswordPage extends StatefulWidget {
  const ResetPasswordPage({Key? key}) : super(key: key);

  @override
  State<ResetPasswordPage> createState() => _ResetPasswordPageState();
}

class _ResetPasswordPageState extends State<ResetPasswordPage> {
  final _formKey = GlobalKey<FormState>();
  final TextEditingController _passwordController = TextEditingController();
  final TextEditingController _confirmPasswordController =
      TextEditingController();
  bool _showError = false;
  String? _errorMessage;

  @override
  void dispose() {
    _passwordController.dispose();
    _confirmPasswordController.dispose();
    super.dispose();
  }

  Future<void> resetPassword(String newPassword) async {
    final userId = await StorageService.storage.read(key: 'userId');

    if (userId != null) {
      final response = await http.post(
        Uri.parse('${baseUrl}User/change-password'),
        headers: {'Content-Type': 'application/json'},
        body: jsonEncode({
          'Id': userId,
          'Password': newPassword,
        }),
      );
      if (response.statusCode == 200) {
        await StorageService.storage.delete(key: 'forgotPasswordUserId');
        Navigator.push(
          context,
          MaterialPageRoute(builder: (context) => LogInPage()),
        );
      } else {
        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(content: Text('Failed to reset password')),
        );
      }
    } else {
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text('UserId not found')),
      );
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Reset password'),
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
                    'Enter your new password please',
                    style: Theme.of(context).textTheme.headline6,
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
                        controller: _passwordController,
                        decoration: const InputDecoration(
                          hintText: 'Password',
                          border: InputBorder.none,
                          icon: Icon(Icons.password),
                        ),
                        obscureText: true,
                        validator: (value) {
                          if (value!.isEmpty) {
                            _errorMessage = 'Please enter a password';
                            return _errorMessage;
                          }
                          if (value.length < 4) {
                            _errorMessage =
                                "Password must contain at least 4 characters";
                            return _errorMessage;
                          }
                          return null;
                        },
                      ),
                    ),
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
                        controller: _confirmPasswordController,
                        decoration: const InputDecoration(
                          hintText: 'Confirm Password',
                          border: InputBorder.none,
                          icon: Icon(Icons.password),
                        ),
                        obscureText: true,
                        validator: (value) {
                          if (value != _passwordController.text) {
                            setState(() {
                              _showError = true;
                              _errorMessage = 'Passwords do not match';
                            });
                            return '';
                          }
                          setState(() {
                            _showError = false;
                            _errorMessage = null;
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
                            resetPassword(_passwordController.text);
                          }
                        },
                        style: ElevatedButton.styleFrom(),
                        child: const Text('Confirm'),
                      ),
                    ),
                  ),
                  SizedBox(
                    height: 20.0,
                    child: _showError
                        ? Text(
                            _errorMessage ?? '',
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
