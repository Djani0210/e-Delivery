import 'dart:convert';

import 'package:desktop/components/hover_animation.dart';
import 'package:desktop/globals.dart';
import 'package:desktop/user/user_page.dart';
import 'package:flutter/material.dart';

import 'package:http/http.dart' as http;

import 'package:desktop/loginRegistration/login_service.dart';

final String apiUrl = '${baseUrl}User';

class UserCreateDTO {
  String? firstName;
  String? lastName;
  String phoneNumber;
  String userName;
  String email;
  String password;

  bool? isAvailable;
  String workFrom;
  String workUntil;
  int? restaurantId;
  int? cityId;
  List<String> userRoles;

  UserCreateDTO({
    this.firstName = "",
    this.lastName = "",
    required this.phoneNumber,
    required this.userName,
    required this.email,
    required this.password,
    this.isAvailable = true,
    required this.workFrom,
    required this.workUntil,
    this.restaurantId,
    this.cityId,
    required this.userRoles,
  });
  Map<String, dynamic> toJson() => {
        'FirstName': firstName,
        'LastName': lastName,
        'PhoneNumber': phoneNumber,
        'UserName': userName,
        'Email': email,
        'Password': password,
        'IsAvailable': isAvailable,
        'WorkFrom': workFrom,
        'WorkUntil': workUntil,
        'RestaurantId': restaurantId ?? null,
        'CityId': cityId ?? null,
        'UserRoles': userRoles,
      };
}

class RegistrationForm extends StatefulWidget {
  const RegistrationForm({Key? key}) : super(key: key);

  @override
  _RegistrationFormState createState() => _RegistrationFormState();
}

class _RegistrationFormState extends State<RegistrationForm> {
  // ignore: unused_field
  String? _username;
  // ignore: unused_field
  String? _email;
  // ignore: unused_field
  String? _password;
  // ignore: unused_field
  String? _phoneNumber;
  String? _errorMessage;
  final _formKey = GlobalKey<FormState>();
  TextEditingController _usernameController = TextEditingController();
  TextEditingController _emailController = TextEditingController();
  TextEditingController _passwordController = TextEditingController();
  TextEditingController _phoneNumberController = TextEditingController();

  @override
  void initState() {
    super.initState();
    _usernameController = TextEditingController();
    _emailController = TextEditingController();
    _passwordController = TextEditingController();
    _phoneNumberController = TextEditingController();
  }

  @override
  void dispose() {
    _usernameController.dispose();
    _emailController.dispose();
    _passwordController.dispose();
    _phoneNumberController.dispose();
    super.dispose();
  }

  String? _validateUsername(String? value) {
    if (value == null || value.isEmpty) {
      return 'Please enter your username';
    } else if (value.length < 3) {
      return 'Username must be at least 3 characters long';
    }
    return null;
  }

  String? _validateEmail(String? value) {
    if (value == null || value.isEmpty) {
      return 'Please enter your email';
    } else if (!value.contains('@gmail.com')) {
      return 'Email must contain @gmail.com';
    }
    return null;
  }

  String? _validatePassword(String? value) {
    if (value == null || value.isEmpty) {
      return 'Please enter your password';
    } else if (value.length < 4) {
      return 'Password must be at least 4 characters long';
    }
    return null;
  }

  String? _validatePhoneNumber(String? value) {
    if (value == null || value.isEmpty) {
      return 'Please enter your phone number';
    }
    final RegExp pattern = RegExp(r'^\d{3}-\d{3}-\d{3}$');
    if (!pattern.hasMatch(value)) {
      return 'Phone number must be inR format "061-533-444"';
    }
    // Additional phone number validation can be done here if needed
    return null;
  }

  Future<void> registerUser(String phoneNumber, String userName, String email,
      String password) async {
    UserCreateDTO userCreateDTO = UserCreateDTO(
      phoneNumber: phoneNumber,
      userName: userName,
      email: email,
      password: password,
      workFrom: "01:00",
      workUntil: "23:00",
      userRoles: ["f57f872c-eaa4-441e-a142-08dc2a5ba67c"],
    );

    String userCreateJson = jsonEncode(userCreateDTO.toJson());
    print('Request body: $userCreateJson');

    final response = await http.post(
      Uri.parse('$apiUrl'),
      headers: {'Content-Type': 'application/json'},
      body: userCreateJson,
    );

    if (response.statusCode == 200) {
      LoginService loginService = LoginService();
      LoginResult result = await loginService.loginUser(userName, password);
      if (result.success) {
        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(content: Text('Registration successful!')),
        );
        Navigator.push(
          context,
          MaterialPageRoute(builder: (context) => const UserPage()),
        );
      } else {
        setState(() {
          _errorMessage =
              result.message ?? 'Failed to log in after registration.';
        });
      }
    } else {
      final responseBody = jsonDecode(response.body);
      if (responseBody['info'] != null) {
        setState(() {
          _errorMessage = responseBody['info'];
        });
      } else {
        setState(() {
          _errorMessage = 'An error occurred while registering.';
        });
      }
    }
  }

  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      child: Padding(
        padding: const EdgeInsets.symmetric(horizontal: 20.0),
        child: Form(
          key: _formKey,
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.end,
            children: [
              HoverAnimation(
                size: const Size(360, 54),
                hoverColor: Colors.white,
                bgColor: Colors.white,
                offset: const Offset(4, 4),
                border: Border.all(),
                child: Padding(
                  padding:
                      const EdgeInsets.symmetric(horizontal: 8, vertical: 2),
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
              const SizedBox(height: 16),
              HoverAnimation(
                size: const Size(360, 54),
                hoverColor: Colors.white,
                bgColor: Colors.white,
                offset: const Offset(4, 4),
                border: Border.all(),
                child: Padding(
                  padding:
                      const EdgeInsets.symmetric(horizontal: 8, vertical: 2),
                  child: TextFormField(
                    controller: _emailController,
                    validator: _validateEmail,
                    onSaved: (value) {
                      _email = value;
                    },
                    decoration: const InputDecoration(
                        hintText: "Email", border: OutlineInputBorder()),
                  ),
                ),
              ),
              const SizedBox(height: 16),
              HoverAnimation(
                size: const Size(360, 54),
                hoverColor: Colors.white,
                bgColor: Colors.white,
                offset: const Offset(4, 4),
                border: Border.all(),
                child: Padding(
                  padding:
                      const EdgeInsets.symmetric(horizontal: 8, vertical: 2),
                  child: TextFormField(
                    controller: _phoneNumberController,
                    validator: _validatePhoneNumber,
                    keyboardType: TextInputType.phone,
                    onSaved: (value) {
                      _phoneNumber = value;
                    },
                    decoration: const InputDecoration(hintText: "Phone Number"),
                  ),
                ),
              ),
              const SizedBox(height: 16),
              HoverAnimation(
                size: const Size(360, 54),
                hoverColor: Colors.white,
                bgColor: Colors.white,
                offset: const Offset(4, 4),
                border: Border.all(),
                child: Padding(
                  padding:
                      const EdgeInsets.symmetric(horizontal: 8, vertical: 2),
                  child: TextFormField(
                    controller: _passwordController,
                    validator: _validatePassword,
                    obscureText: true,
                    onSaved: (value) {
                      _password = value;
                    },
                    decoration: const InputDecoration(hintText: "Password"),
                  ),
                ),
              ),
              const SizedBox(height: 15),
              if (_errorMessage != null)
                Text(
                  _errorMessage!,
                  style: TextStyle(color: Colors.red),
                ),
              const SizedBox(height: 15),
              SizedBox(
                child: HoverAnimation(
                  size: const Size(100, 48),
                  offset: const Offset(6, 6),
                  curve: Curves.fastOutSlowIn,
                  child: ElevatedButton(
                    onPressed: () async {
                      if (_formKey.currentState!.validate()) {
                        _formKey.currentState!.save();

                        await registerUser(
                          _phoneNumberController.text,
                          _usernameController.text,
                          _emailController.text,
                          _passwordController.text,
                        );
                      }
                    },
                    style: ElevatedButton.styleFrom(),
                    child: const Text("Sign Up"),
                  ),
                ),
              ),
              const SizedBox(height: 24),
            ],
          ),
        ),
      ),
    );
  }
}
