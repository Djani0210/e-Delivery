import 'dart:convert';
import 'package:e_delivery_mobile/customer/core/constants/app_defaults.dart';
import 'package:e_delivery_mobile/customer/core/constants/app_icons.dart';
import 'package:e_delivery_mobile/customer/screens/auth/password_changed_page.dart';
import 'package:flutter/material.dart';
import 'package:flutter_svg/svg.dart';
import 'package:http/http.dart' as http;
import 'package:flutter_secure_storage/flutter_secure_storage.dart';

class ChangePassPage extends StatefulWidget {
  const ChangePassPage({Key? key}) : super(key: key);

  @override
  _ChangePassPageState createState() => _ChangePassPageState();
}

class _ChangePassPageState extends State<ChangePassPage> {
  final _formKey = GlobalKey<FormState>();
  final TextEditingController _passwordController = TextEditingController();
  final TextEditingController _confirmPasswordController =
      TextEditingController();
  bool _showError = false;
  String? _errorMessage;
  final _storage = FlutterSecureStorage();

  @override
  void dispose() {
    _passwordController.dispose();
    _confirmPasswordController.dispose();
    super.dispose();
  }

  Future<void> resetPassword(String newPassword) async {
    final userId = await _storage.read(key: 'forgotPasswordUserId');

    if (userId != null) {
      final response = await http.post(
        Uri.parse('http://10.0.2.2:44395/api/User/change-password'),
        headers: {'Content-Type': 'application/json'},
        body: jsonEncode({
          'Id': userId,
          'Password': newPassword,
        }),
      );
      if (response.statusCode == 200) {
        await _storage.delete(key: 'forgotPasswordUserId');
        Navigator.push(
          context,
          MaterialPageRoute(builder: (context) => const PasswordChangedPage()),
        );
      } else {
        ScaffoldMessenger.of(context).showSnackBar(
          const SnackBar(content: Text('Failed to reset password')),
        );
      }
    } else {
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(content: Text('UserId not found')),
      );
    }
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
                  'Change\nNew Password',
                  style: Theme.of(context).textTheme.headlineSmall,
                ),
              ),
            ),
            const Spacer(),
            ChangePasswordFields(
              formKey: _formKey,
              passwordController: _passwordController,
              confirmPasswordController: _confirmPasswordController,
              showError: _showError,
              errorMessage: _errorMessage,
              onSubmit: () {
                if (_formKey.currentState!.validate()) {
                  resetPassword(_passwordController.text);
                }
              },
            ),
            const Spacer(flex: 3),
          ],
        ),
      ),
    );
  }
}

class ChangePasswordFields extends StatefulWidget {
  final GlobalKey<FormState> formKey;
  final TextEditingController passwordController;
  final TextEditingController confirmPasswordController;
  final bool showError;
  final String? errorMessage;
  final VoidCallback onSubmit;

  const ChangePasswordFields({
    Key? key,
    required this.formKey,
    required this.passwordController,
    required this.confirmPasswordController,
    required this.showError,
    required this.errorMessage,
    required this.onSubmit,
  }) : super(key: key);

  @override
  _ChangePasswordFieldsState createState() => _ChangePasswordFieldsState();
}

class _ChangePasswordFieldsState extends State<ChangePasswordFields> {
  bool _obscurePassword = true;
  bool _obscureConfirmPassword = true;

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.all(AppDefaults.padding),
      child: Form(
        key: widget.formKey,
        child: Column(
          children: [
            TextFormField(
              controller: widget.passwordController,
              obscureText: _obscurePassword,
              decoration: InputDecoration(
                labelText: 'NEW PASSWORD',
                suffixIcon: IconButton(
                  icon: SvgPicture.asset(
                    _obscurePassword ? AppIcons.unhide : AppIcons.hide,
                  ),
                  onPressed: () {
                    setState(() {
                      _obscurePassword = !_obscurePassword;
                    });
                  },
                ),
                suffixIconConstraints: const BoxConstraints(maxHeight: 24),
              ),
              validator: (value) {
                if (value!.isEmpty) {
                  return 'Please enter a password';
                }
                if (value.length < 6) {
                  return 'Password must contain at least 6 characters';
                }
                return null;
              },
            ),
            const SizedBox(height: 16),
            TextFormField(
              controller: widget.confirmPasswordController,
              obscureText: _obscureConfirmPassword,
              decoration: InputDecoration(
                labelText: 'CONFIRM PASSWORD',
                suffixIcon: IconButton(
                  icon: SvgPicture.asset(
                    _obscureConfirmPassword ? AppIcons.unhide : AppIcons.hide,
                  ),
                  onPressed: () {
                    setState(() {
                      _obscureConfirmPassword = !_obscureConfirmPassword;
                    });
                  },
                ),
                suffixIconConstraints: const BoxConstraints(maxHeight: 24),
              ),
              validator: (value) {
                if (value != widget.passwordController.text) {
                  return 'Passwords do not match';
                }
                return null;
              },
            ),
            const SizedBox(height: 16),
            Text(
              'Please provide your email to reset your password, please don\'t share any data with other people.',
              style: Theme.of(context).textTheme.bodySmall,
            ),
            const SizedBox(height: 32),
            SizedBox(
              width: double.infinity,
              child: ElevatedButton(
                onPressed: widget.onSubmit,
                child: const Text('Change Password'),
              ),
            ),
            if (widget.showError)
              Padding(
                padding: const EdgeInsets.only(top: 16),
                child: Text(
                  widget.errorMessage ?? '',
                  style: const TextStyle(color: Colors.red),
                ),
              ),
          ],
        ),
      ),
    );
  }
}
