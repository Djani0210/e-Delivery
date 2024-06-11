import 'dart:convert';
import 'package:e_delivery_mobile/customer/core/constants/app_defaults.dart';
import 'package:e_delivery_mobile/customer/core/constants/app_icons.dart';
import 'package:e_delivery_mobile/customer/screens/auth/api/auth_api.dart';
import 'package:e_delivery_mobile/customer/screens/auth/api/register_user_api.dart';
import 'package:e_delivery_mobile/customer/screens/auth/login_page.dart';
import 'package:e_delivery_mobile/deliveryPerson/screens/home/deliveryperson_entrypoint.dart';
import 'package:flutter/material.dart';
import 'package:flutter_svg/svg.dart';
import 'package:dropdown_search/dropdown_search.dart';
import 'package:intl/intl.dart';

class DeliveryPersonSignupForm extends StatefulWidget {
  const DeliveryPersonSignupForm({Key? key}) : super(key: key);

  @override
  _DeliveryPersonSignupFormState createState() =>
      _DeliveryPersonSignupFormState();
}

class _DeliveryPersonSignupFormState extends State<DeliveryPersonSignupForm> {
  final RegisterUserService _registerUserService = RegisterUserService();
  final _formKey = GlobalKey<FormState>();
  String _phoneNumber = '';
  String _userName = '';
  String _email = '';
  String _password = '';
  City? _selectedCity;
  List<City> _cities = [];
  TimeOfDay _workFromTime = TimeOfDay.now();
  TimeOfDay _workUntilTime = TimeOfDay.now();

  @override
  void initState() {
    super.initState();
    _fetchCities();
  }

  Future<void> _fetchCities() async {
    try {
      final response = await _registerUserService.getCities();
      final responseBody = json.decode(response.body);
      final List<dynamic> citiesData = responseBody['data'];
      setState(() {
        _cities =
            citiesData.map((cityData) => City.fromJson(cityData)).toList();
      });
    } catch (error) {
      // Handle error
      print('Failed to fetch cities: $error');
    }
  }

  String? _validateUsername(String? value) {
    if (value == null || value.isEmpty) {
      return 'Please enter a username';
    }
    if (value.length < 6) {
      return 'Username must be at least 6 characters long';
    }
    return null;
  }

  String? _validateEmail(String? value) {
    if (value == null || value.isEmpty) {
      return 'Please enter an email';
    }
    final emailRegex = RegExp(r'^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$');
    if (!emailRegex.hasMatch(value)) {
      return 'Please enter a valid email address';
    }
    return null;
  }

  String? _validatePhoneNumber(String? value) {
    if (value == null || value.isEmpty) {
      return 'Please enter a phone number';
    }
    final phoneRegex = RegExp(r'^\d{3}-\d{3}-\d{3,4}$');
    if (!phoneRegex.hasMatch(value)) {
      return 'Please enter a valid phone number in the format "061-444-444"';
    }
    return null;
  }

  String? _validatePassword(String? value) {
    if (value == null || value.isEmpty) {
      return 'Please enter a password';
    }
    if (value.length < 4) {
      return 'Password must be at least 4 characters long';
    }
    return null;
  }

  String? _validateCity(City? value) {
    if (value == null) {
      return 'Please select a city';
    }
    return null;
  }

  Future<void> _selectWorkFromTime(BuildContext context) async {
    final TimeOfDay? pickedTime = await showTimePicker(
        context: context,
        initialTime: _workFromTime,
        builder: (BuildContext context, Widget? child) {
          return MediaQuery(
            data: MediaQuery.of(context).copyWith(alwaysUse24HourFormat: true),
            child: child!,
          );
        },
        initialEntryMode: TimePickerEntryMode.input);
    if (pickedTime != null && pickedTime != _workFromTime) {
      setState(() {
        _workFromTime = pickedTime;
      });
    }
  }

  Future<void> _selectWorkUntilTime(BuildContext context) async {
    final TimeOfDay? pickedTime = await showTimePicker(
      context: context,
      initialTime: _workUntilTime,
      builder: (BuildContext context, Widget? child) {
        return MediaQuery(
          data: MediaQuery.of(context).copyWith(alwaysUse24HourFormat: true),
          child: child!,
        );
      },
      initialEntryMode: TimePickerEntryMode.input,
    );
    if (pickedTime != null && pickedTime != _workUntilTime) {
      setState(() {
        _workUntilTime = pickedTime;
      });
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
                labelText: 'Username',
                suffixIcon: SvgPicture.asset(AppIcons.data),
                suffixIconConstraints: const BoxConstraints(maxHeight: 24),
              ),
              onChanged: (value) {
                _userName = value;
              },
              validator: _validateUsername,
            ),
            const SizedBox(height: 16),
            TextFormField(
              decoration: InputDecoration(
                labelText: 'Email',
                suffixIcon: SvgPicture.asset(AppIcons.email),
                suffixIconConstraints: const BoxConstraints(maxHeight: 24),
              ),
              keyboardType: TextInputType.emailAddress,
              onChanged: (value) {
                _email = value;
              },
              validator: _validateEmail,
            ),
            const SizedBox(height: 16),
            TextFormField(
              decoration: InputDecoration(
                labelText: 'Phone',
                suffixIcon: SvgPicture.asset(AppIcons.phone),
                suffixIconConstraints: const BoxConstraints(maxHeight: 24),
                hintText: 'Enter Phone number',
              ),
              keyboardType: TextInputType.phone,
              onChanged: (value) {
                _phoneNumber = value;
              },
              validator: _validatePhoneNumber,
            ),
            const SizedBox(height: 16),
            TextFormField(
              obscureText: true,
              decoration: InputDecoration(
                labelText: 'Password',
                suffixIcon: SvgPicture.asset(AppIcons.password),
                suffixIconConstraints: const BoxConstraints(maxHeight: 24),
                hintText: 'Enter Password',
              ),
              keyboardType: TextInputType.visiblePassword,
              onChanged: (value) {
                _password = value;
              },
              validator: _validatePassword,
            ),
            const SizedBox(height: 16),
            DropdownSearch<City>(
              selectedItem: _selectedCity,
              onChanged: (City? newValue) {
                setState(() {
                  _selectedCity = newValue;
                });
              },
              items: _cities,
              itemAsString: (City city) => city.title,
              dropdownDecoratorProps: DropDownDecoratorProps(
                dropdownSearchDecoration: InputDecoration(
                  labelText: 'Select City',
                  hintText: 'Search cities...',
                  border: OutlineInputBorder(),
                ),
              ),
              popupProps: PopupProps.menu(
                showSearchBox: true,
                searchFieldProps: TextFieldProps(
                  decoration: InputDecoration(
                    hintText: 'Search cities...',
                    border: OutlineInputBorder(),
                  ),
                ),
                itemBuilder: (context, City city, isSelected) => ListTile(
                  title: Text(city.title),
                  selected: isSelected,
                ),
                constraints: BoxConstraints(maxHeight: 300),
              ),
              validator: _validateCity,
            ),
            const SizedBox(height: 16),
            Row(
              children: [
                Expanded(
                  child: InkWell(
                    onTap: () => _selectWorkFromTime(context),
                    child: InputDecorator(
                      decoration: InputDecoration(
                        labelText: 'Work From',
                        border: OutlineInputBorder(),
                      ),
                      child: Row(
                        mainAxisAlignment: MainAxisAlignment.spaceBetween,
                        children: [
                          Text(
                            DateFormat('hh:mm a').format(
                              DateTime(
                                DateTime.now().year,
                                DateTime.now().month,
                                DateTime.now().day,
                                _workFromTime.hour,
                                _workFromTime.minute,
                              ),
                            ),
                          ),
                          Icon(Icons.arrow_drop_down),
                        ],
                      ),
                    ),
                  ),
                ),
                const SizedBox(width: 16),
                Expanded(
                  child: InkWell(
                    onTap: () => _selectWorkUntilTime(context),
                    child: InputDecorator(
                      decoration: InputDecoration(
                        labelText: 'Work Until',
                        border: OutlineInputBorder(),
                      ),
                      child: Row(
                        mainAxisAlignment: MainAxisAlignment.spaceBetween,
                        children: [
                          Text(
                            DateFormat('hh:mm a').format(
                              DateTime(
                                DateTime.now().year,
                                DateTime.now().month,
                                DateTime.now().day,
                                _workUntilTime.hour,
                                _workUntilTime.minute,
                              ),
                            ),
                          ),
                          Icon(Icons.arrow_drop_down),
                        ],
                      ),
                    ),
                  ),
                ),
              ],
            ),
            const SizedBox(height: 32),
            SizedBox(
              width: double.infinity,
              child: ElevatedButton(
                onPressed: () async {
                  if (_formKey.currentState!.validate()) {
                    String workFrom = DateFormat('HH:mm').format(
                      DateTime(
                        DateTime.now().year,
                        DateTime.now().month,
                        DateTime.now().day,
                        _workFromTime.hour,
                        _workFromTime.minute,
                      ),
                    );
                    String workUntil = DateFormat('HH:mm').format(
                      DateTime(
                        DateTime.now().year,
                        DateTime.now().month,
                        DateTime.now().day,
                        _workUntilTime.hour,
                        _workUntilTime.minute,
                      ),
                    );
                    bool success =
                        await _registerUserService.registerDeliveryPerson(
                      _phoneNumber,
                      _userName,
                      _email,
                      _password,
                      _selectedCity?.id,
                      workFrom,
                      workUntil,
                    );
                    if (success) {
                      ScaffoldMessenger.of(context).showSnackBar(
                        SnackBar(content: Text('Registration successful')),
                      );
                      LoginService loginService = LoginService();
                      LoginResult result =
                          await loginService.loginUser(_userName, _password);

                      if (result.success) {
                        Navigator.push(
                          context,
                          MaterialPageRoute(
                              builder: (context) => DeliveryPersonEntryPoint()),
                        );
                      }
                    } else {
                      final errorResponse = _registerUserService.errorResponse;
                      if (errorResponse != null) {
                        final errorInfo = errorResponse['info'];
                        ScaffoldMessenger.of(context).showSnackBar(
                          SnackBar(content: Text(errorInfo)),
                        );
                      } else {
                        ScaffoldMessenger.of(context).showSnackBar(
                          SnackBar(content: Text('Registration failed')),
                        );
                      }
                    }
                  }
                },
                child: const Text('Register'),
              ),
            ),
            const SizedBox(height: 16),
            Row(
              mainAxisAlignment: MainAxisAlignment.center,
              children: [
                const Text('Already have an account?'),
                TextButton(
                  onPressed: () {
                    Navigator.push(
                      context,
                      MaterialPageRoute(builder: (context) => LoginPage()),
                    );
                  },
                  child: Text(
                    'Login',
                    style: Theme.of(context).textTheme.labelLarge?.copyWith(
                          fontWeight: FontWeight.bold,
                          color: Colors.black,
                        ),
                  ),
                )
              ],
            ),
          ],
        ),
      ),
    );
  }
}

class City {
  final int id;
  final String title;

  City({required this.id, required this.title});

  factory City.fromJson(Map<String, dynamic> json) {
    return City(
      id: json['id'],
      title: json['title'],
    );
  }
}
