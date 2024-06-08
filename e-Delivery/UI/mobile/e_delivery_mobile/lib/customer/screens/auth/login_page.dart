import 'dart:convert';

import 'package:e_delivery_mobile/customer/core/constants/app_defaults.dart';
import 'package:e_delivery_mobile/customer/core/constants/app_icons.dart';
import 'package:e_delivery_mobile/customer/screens/auth/api/auth_api.dart';
import 'package:e_delivery_mobile/customer/screens/auth/choose_roles_page.dart';
import 'package:e_delivery_mobile/customer/screens/auth/forgot_password_page.dart';
import 'package:e_delivery_mobile/customer/screens/home/customer_entry_point.dart';
import 'package:e_delivery_mobile/deliveryPerson/screens/home/deliveryperson_entrypoint.dart';
import 'package:e_delivery_mobile/signalr_service.dart';

import 'package:e_delivery_mobile/storage_service.dart';
import 'package:flutter/material.dart';
import 'package:flutter_svg/svg.dart';

class LoginPage extends StatefulWidget {
  const LoginPage({Key? key}) : super(key: key);
  @override
  _LoginPageState createState() => _LoginPageState();
}

class _LoginPageState extends State<LoginPage> {
  final TextEditingController _usernameController = TextEditingController();
  final TextEditingController _passwordController = TextEditingController();
  final GlobalKey<FormState> _formKey = GlobalKey<FormState>();

  @override
  void dispose() {
    _usernameController.dispose();
    _passwordController.dispose();
    super.dispose();
  }

  Future<void> _loginUser(String username, String password) async {
    LoginService loginService = LoginService();

    LoginResult result = await loginService.loginUser(username, password);
    if (!mounted) return;

    if (result.success) {
      String? userDataJson = await StorageService.storage.read(key: 'userData');
      String? userId = await StorageService.storage.read(key: 'currentUserId');
      if (!mounted) return;

      if (userDataJson != null) {
        Map<String, dynamic> userData = jsonDecode(userDataJson);
        List<dynamic> roles = userData['roles'];

        final signalRService = SignalRService();
        await signalRService.connectToNotifications(userId!);
        await signalRService.connectToChat(userId);

        if (!mounted) return;

        if (roles.contains('MobileClient')) {
          Navigator.of(context).pushAndRemoveUntil(
            MaterialPageRoute(builder: (context) => CustomerEntryPoint()),
            (Route<dynamic> route) => false,
          );
        } else if (roles.contains('MobileDeliveryPerson')) {
          Navigator.of(context).pushAndRemoveUntil(
            MaterialPageRoute(builder: (context) => DeliveryPersonEntryPoint()),
            (Route<dynamic> route) => false,
          );
        } else {
          ScaffoldMessenger.of(context).showSnackBar(
            SnackBar(
              duration: Duration(milliseconds: 2000),
              content: Center(
                child: Text(
                  'Unable to log in',
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

  void _validateAndSignIn() {
    if (_formKey.currentState!.validate()) {
      _loginUser(_usernameController.text, _passwordController.text);
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      resizeToAvoidBottomInset: false,
      body: SafeArea(
        child: Form(
          key: _formKey,
          child: Column(
            children: [
              const Spacer(),
              Align(
                alignment: Alignment.centerLeft,
                child: Padding(
                  padding: const EdgeInsets.all(AppDefaults.padding),
                  child: Text(
                    'Login to\nfind the best food',
                    style: Theme.of(context).textTheme.headlineSmall,
                  ),
                ),
              ),
              const Spacer(),
              LoginForm(
                usernameController: _usernameController,
                passwordController: _passwordController,
              ),
              Padding(
                padding: const EdgeInsets.all(8.0),
                child: Align(
                  alignment: Alignment.centerRight,
                  child: TextButton(
                    onPressed: () {
                      Navigator.push(
                          context,
                          MaterialPageRoute(
                              builder: (context) => const ForgotPassPage()));
                    },
                    child: Text(
                      'Forget Password?',
                      style: Theme.of(context)
                          .textTheme
                          .labelLarge
                          ?.copyWith(color: Colors.black),
                    ),
                  ),
                ),
              ),
              SignInButtons(
                onSignIn: _validateAndSignIn,
              ),
              const SizedBox(height: 8),
              const DontHaveAccountRow(),
              const Spacer(),
            ],
          ),
        ),
      ),
    );
  }
}

class LoginForm extends StatelessWidget {
  const LoginForm({
    Key? key,
    required this.usernameController,
    required this.passwordController,
  }) : super(key: key);

  final TextEditingController usernameController;
  final TextEditingController passwordController;

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.all(AppDefaults.padding),
      child: Column(
        children: [
          TextFormField(
            controller: usernameController,
            decoration: InputDecoration(
              labelText: 'Username',
              suffixIcon: SvgPicture.asset(AppIcons.profileBold),
              suffixIconConstraints: const BoxConstraints(maxHeight: 24),
            ),
            validator: (value) {
              if (value == null || value.isEmpty) {
                return 'Please enter your username';
              }
              return null;
            },
          ),
          const SizedBox(height: 16),
          TextFormField(
            controller: passwordController,
            decoration: InputDecoration(
              labelText: 'Password',
              suffixIcon: SvgPicture.asset(AppIcons.password),
              suffixIconConstraints: const BoxConstraints(maxHeight: 24),
            ),
            obscureText: true,
            validator: (value) {
              if (value == null || value.isEmpty) {
                return 'Please enter your password';
              }
              if (value.length < 6) {
                return 'Password must be at least 6 characters long';
              }
              return null;
            },
          ),
        ],
      ),
    );
  }
}

class SignInButtons extends StatelessWidget {
  const SignInButtons({
    Key? key,
    required this.onSignIn,
  }) : super(key: key);

  final void Function() onSignIn;

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.symmetric(horizontal: AppDefaults.padding),
      child: Column(
        children: [
          SizedBox(
            width: double.infinity,
            child: ElevatedButton(
              onPressed: onSignIn,
              child: const Text('Sign In'),
            ),
          ),
          const SizedBox(height: AppDefaults.margin),
        ],
      ),
    );
  }
}

class DontHaveAccountRow extends StatelessWidget {
  const DontHaveAccountRow({
    Key? key,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Row(
      mainAxisAlignment: MainAxisAlignment.center,
      children: [
        const Text('Don\'t have an account?'),
        TextButton(
          onPressed: () {
            Navigator.push(
                context,
                MaterialPageRoute(
                    builder: (context) => const ChooseRoleScreen()));
          },
          child: Text(
            'Register',
            style: Theme.of(context)
                .textTheme
                .labelLarge
                ?.copyWith(fontWeight: FontWeight.bold, color: Colors.black),
          ),
        )
      ],
    );
  }
}
