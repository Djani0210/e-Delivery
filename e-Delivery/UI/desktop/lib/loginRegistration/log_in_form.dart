// ignore_for_file: unused_import

import 'dart:async';

import 'package:desktop/admin/admin_page.dart';
import 'package:desktop/components/storage_service.dart';
import 'package:desktop/loginRegistration/forgot_password_page.dart';
import 'package:desktop/loginRegistration/registration_page.dart';
import 'package:desktop/signalr_service.dart';
import 'package:desktop/user/user_page.dart';
import 'package:flutter/material.dart';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import '../components/hover_animation.dart';
import 'dart:convert';
import 'package:http/http.dart' as http;
import 'package:desktop/loginRegistration/login_service.dart';

final storage = FlutterSecureStorage();

class LogInForm extends StatefulWidget {
  const LogInForm({Key? key}) : super(key: key);

  @override
  _LogInFormState createState() => _LogInFormState();
}

class _LogInFormState extends State<LogInForm> {
  // ignore: unused_field
  String? _username;
  // ignore: unused_field
  String? _password;
  String? _errorMessage;
  Future<String?> getJwtToken() async {
    return await storage.read(key: 'jwt');
  }

  final _formKey = GlobalKey<FormState>();
  TextEditingController _usernameController = TextEditingController();
  TextEditingController _passwordController = TextEditingController();

  @override
  void dispose() {
    _usernameController.dispose();
    _passwordController.dispose();
    super.dispose();
  }

  String? _validateUsername(String? value) {
    if (value == null || value.isEmpty) {
      return 'Please enter your username';
    }
    return null;
  }

  String? _validatePassword(String? value) {
    if (value == null || value.isEmpty) {
      return 'Please enter your password';
    }
    return null;
  }

  Future<void> _loginUser(String username, String password) async {
    LoginService loginService = LoginService();

    LoginResult result = await loginService.loginUser(username, password);
    if (result.success) {
      String? userDataJson = await StorageService.storage.read(key: 'userData');
      String? userId = await StorageService.storage.read(key: 'currentUserId');
      if (!mounted) return;
      if (userDataJson != null) {
        Map<String, dynamic> userData = jsonDecode(userDataJson);
        List<dynamic> roles = userData['roles'];

        final signalRService = SignalRService();
        await signalRService.connect(userId!);

        if (!mounted) return;

        if (roles.contains('Desktop')) {
          Navigator.push(
            context,
            MaterialPageRoute(builder: (context) => const UserPage()),
          );
        } else if (roles.contains('Admin')) {
          Navigator.push(
            context,
            MaterialPageRoute(builder: (context) => const AdminPage()),
          );
        } else {
          ScaffoldMessenger.of(context).showSnackBar(
            SnackBar(
              duration: Duration(milliseconds: 2000),
              content: Center(
                child: Text(
                  'Login impossible',
                  style: TextStyle(color: Colors.red),
                ),
              ),
            ),
          );
        }
      } else {
        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(
            duration: Duration(milliseconds: 2000),
            content: Center(
              child: Text(
                'User data not found',
                style: TextStyle(color: Colors.red),
              ),
            ),
          ),
        );
      }
    } else {
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          duration: Duration(milliseconds: 2000),
          content: Center(
            child: Text(
              result.message ?? 'Login failed',
              style: TextStyle(color: Colors.red),
            ),
          ),
        ),
      );
    }
  }

  @override
  Widget build(BuildContext context) {
    return Form(
      key: _formKey,
      child: SizedBox(
        width: 360,
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.end,
          children: [
            HoverAnimation(
              size: const Size(360, 54),
              hoverColor: Colors.white,
              bgColor: Colors.white,
              offset: const Offset(6, 6),
              border: Border.all(),
              child: Padding(
                padding: const EdgeInsets.symmetric(horizontal: 8, vertical: 2),
                child: TextFormField(
                  controller: _usernameController,
                  validator: _validateUsername,
                  onSaved: (value) {
                    _username = value;
                  },
                  decoration: const InputDecoration(hintText: "Username"),
                ),
              ),
            ),
            Padding(
              padding: const EdgeInsets.symmetric(vertical: 16),
            ),
            HoverAnimation(
              size: const Size(360, 54),
              hoverColor: Colors.white,
              bgColor: Colors.white,
              offset: const Offset(6, 6),
              border: Border.all(),
              child: Padding(
                padding: const EdgeInsets.symmetric(horizontal: 8, vertical: 2),
                child: TextFormField(
                  controller: _passwordController,
                  validator: _validatePassword,
                  onSaved: (value) {
                    _password = value;
                  },
                  obscureText: true,
                  decoration: const InputDecoration(hintText: "Password"),
                ),
              ),
            ),
            if (_errorMessage != null)
              Center(
                child: Text(
                  _errorMessage!,
                  style: TextStyle(color: Colors.red),
                ),
              ),
            const SizedBox(height: 24),
            SizedBox(
              child: HoverAnimation(
                size: const Size(88, 48),
                offset: const Offset(6, 6),
                curve: Curves.fastOutSlowIn,
                child: ElevatedButton(
                  onPressed: () async {
                    if (_formKey.currentState!.validate()) {
                      _formKey.currentState!.save();
                      setState(() {
                        _errorMessage = null;
                      });
                      await _loginUser(
                          _usernameController.text, _passwordController.text);
                    }
                  },
                  style: ElevatedButton.styleFrom(),
                  child: const Text("Log in"),
                ),
              ),
            ),
            const SizedBox(height: 24),
            TextButton(
              onPressed: () {
                Navigator.push(
                  context,
                  MaterialPageRoute(
                      builder: (context) => const ForgotPasswordPage()),
                );
              },
              child: const Text('Forgot Password?'),
            ),
            TextButton(
              onPressed: () {
                Navigator.push(
                  context,
                  MaterialPageRoute(
                      builder: (context) => const RegistrationPage()),
                );
              },
              child: const Text('Don\'t have an account? Register now!'),
            ),
          ],
        ),
      ),
    );
  }
}
