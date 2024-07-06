import 'dart:async';
import 'dart:convert';

import 'package:desktop/components/hover_animation.dart';
import 'package:desktop/components/storage_service.dart';
import 'package:desktop/restaurant/restaurant_dashboard.dart';

import 'package:dropdown_search/dropdown_search.dart';
import 'package:flutter/material.dart';

import 'package:desktop/restaurant/api_calls/restaurant_service.dart';
import 'package:desktop/user/user_page.dart';

class RestaurantForm extends StatefulWidget {
  final List<City> cities;

  RestaurantForm({required this.cities});

  @override
  _RestaurantFormState createState() => _RestaurantFormState();
}

class _RestaurantFormState extends State<RestaurantForm> {
  final _formKey = GlobalKey<FormState>();
  final _restaurantService = RestaurantService();

  String _name = '';
  String _address = '';

  String _openingTime = '';
  String _closingTime = '';
  String _contactNumber = '';
  double _deliveryCharge = 0.0;
  int _deliveryTime = 0;
  int _cityId = 0;
  String _latitude = '';
  String _longitude = '';
  City? _selectedCity;
  bool _isLoading = false;
  String _message = '';

  Future<void> _submitForm() async {
    if (_formKey.currentState!.validate()) {
      _formKey.currentState!.save();

      setState(() {
        _isLoading = true;
        _message = '';
      });

      try {
        final Map<String, dynamic>? response =
            await _restaurantService.CreateRestaurant(
          _name,
          _address,
          _openingTime,
          _closingTime,
          _contactNumber,
          _deliveryCharge,
          _deliveryTime,
          _cityId,
          _latitude,
          _longitude,
          null,
        );

        if (response != null &&
            (response['status'] == 201 || response['status'] == 200)) {
          ScaffoldMessenger.of(context).showSnackBar(
            SnackBar(
              content: Text(
                'Successfully registered restaurant',
                style: TextStyle(color: Colors.green),
              ),
              duration: Duration(milliseconds: 2000),
              behavior: SnackBarBehavior.floating,
              shape: RoundedRectangleBorder(
                  borderRadius: BorderRadius.circular(24)),
              margin: EdgeInsets.fromLTRB(16.0, 0, 16.0, 16.0),
            ),
          );
          final String? userDataJson =
              await StorageService.storage.read(key: 'userData');
          if (userDataJson != null) {
            final Map<String, dynamic> userData = jsonDecode(userDataJson);
            userData['restaurantId'] = response['data']['id'];
            await StorageService.storage
                .write(key: 'userData', value: jsonEncode(userData));
          }

          Future.delayed(Duration(seconds: 2), () {
            Navigator.pushReplacement(
              context,
              MaterialPageRoute(builder: (context) => MyApp()),
            );
          });
        } else {
          ScaffoldMessenger.of(context).showSnackBar(
            SnackBar(
              duration: Duration(milliseconds: 2000),
              content: Center(
                child: Text(
                  'Failed to register restaurant',
                  style: TextStyle(color: Colors.red),
                ),
              ),
              behavior: SnackBarBehavior.floating,
              shape: RoundedRectangleBorder(
                  borderRadius: BorderRadius.circular(24)),
              margin: EdgeInsets.fromLTRB(16.0, 0, 16.0, 16.0),
            ),
          );
          print(
              " Error Location is Lattitude ${_latitude}, Longitude ${_longitude} city ${_cityId}");
        }
      } catch (e) {
        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(
            duration: Duration(milliseconds: 2000),
            content: Center(
              child: Text(
                'An error occurred: $e',
                style: TextStyle(color: Colors.red),
              ),
            ),
            behavior: SnackBarBehavior.floating,
            shape:
                RoundedRectangleBorder(borderRadius: BorderRadius.circular(24)),
            margin: EdgeInsets.fromLTRB(16.0, 0, 16.0, 16.0),
          ),
        );
      } finally {
        setState(() {
          _isLoading = false;
        });
      }
    }
  }

  @override
  Widget build(BuildContext context) {
    final Color goldColor = Color.fromRGBO(255, 215, 0, 1);
    return Container(
      height: 660,
      width: 400,
      decoration: BoxDecoration(
        color: goldColor,
        borderRadius: BorderRadius.circular(10),
      ),
      child: SingleChildScrollView(
        padding: EdgeInsets.all(16.0),
        child: Form(
          key: _formKey,
          child: Column(
            children: [
              SizedBox(height: 16.0),
              HoverAnimation(
                size: const Size(360, 54),
                hoverColor: Colors.white,
                bgColor: Colors.white,
                offset: const Offset(1, 1),
                border: Border.all(),
                child: Padding(
                  padding:
                      const EdgeInsets.symmetric(horizontal: 8, vertical: 2),
                  child: TextFormField(
                    decoration: InputDecoration(
                      hintText: 'Restaurant Name',
                      contentPadding: EdgeInsets.all(12.0),
                    ),
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Please enter the restaurant name';
                      }
                      return null;
                    },
                    onSaved: (value) => _name = value!,
                  ),
                ),
              ),
              SizedBox(height: 16.0),
              HoverAnimation(
                size: const Size(360, 54),
                hoverColor: Colors.white,
                bgColor: Colors.white,
                offset: const Offset(1, 1),
                border: Border.all(),
                child: Padding(
                  padding:
                      const EdgeInsets.symmetric(horizontal: 8, vertical: 2),
                  child: TextFormField(
                    decoration: InputDecoration(
                      hintText: 'Opening Time (HH:mm)',
                      contentPadding: EdgeInsets.all(12.0),
                    ),
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Please enter the opening time';
                      }

                      final RegExp timePattern =
                          RegExp(r'^([01]\d|2[0-3]):([0-5]\d)$');
                      if (!timePattern.hasMatch(value)) {
                        return 'Please enter a valid opening time (HH:mm)';
                      }
                      return null;
                    },
                    onSaved: (value) => _openingTime = value!,
                  ),
                ),
              ),
              SizedBox(height: 16.0),
              HoverAnimation(
                size: const Size(360, 54),
                hoverColor: Colors.white,
                bgColor: Colors.white,
                offset: const Offset(1, 1),
                border: Border.all(),
                child: Padding(
                  padding:
                      const EdgeInsets.symmetric(horizontal: 8, vertical: 2),
                  child: TextFormField(
                    decoration: InputDecoration(
                      hintText: 'Closing Time (HH:mm)',
                      contentPadding: EdgeInsets.all(12.0),
                    ),
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Please enter the closing time';
                      }

                      final RegExp timePattern =
                          RegExp(r'^([01]\d|2[0-3]):([0-5]\d)$');
                      if (!timePattern.hasMatch(value)) {
                        return 'Please enter a valid closing time (HH:mm)';
                      }

                      if (_openingTime.isNotEmpty &&
                          value.compareTo(_openingTime) <= 0) {
                        return 'Closing time must be later than opening time';
                      }
                      return null;
                    },
                    onSaved: (value) => _closingTime = value!,
                  ),
                ),
              ),
              SizedBox(height: 16.0),
              HoverAnimation(
                size: const Size(360, 54),
                hoverColor: Colors.white,
                bgColor: Colors.white,
                offset: const Offset(1, 1),
                border: Border.all(),
                child: Padding(
                  padding:
                      const EdgeInsets.symmetric(horizontal: 8, vertical: 2),
                  child: TextFormField(
                    decoration: InputDecoration(
                      hintText: 'Contact Number example 061-402-222',
                      contentPadding: EdgeInsets.all(12.0),
                    ),
                    keyboardType: TextInputType.phone,
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Please enter the contact number';
                      }

                      final RegExp pattern = RegExp(r'^\d{3}-\d{3}-\d{3,4}$');
                      if (!pattern.hasMatch(value)) {
                        return 'Please enter a valid phone number';
                      }
                      return null;
                    },
                    onSaved: (value) => _contactNumber = value!,
                  ),
                ),
              ),
              SizedBox(height: 16.0),
              HoverAnimation(
                size: const Size(360, 54),
                hoverColor: Colors.white,
                bgColor: Colors.white,
                offset: const Offset(1, 1),
                border: Border.all(),
                child: Padding(
                  padding:
                      const EdgeInsets.symmetric(horizontal: 8, vertical: 2),
                  child: TextFormField(
                    decoration: InputDecoration(
                      hintText: 'Delivery Charge (KM)',
                      contentPadding: EdgeInsets.all(12.0),
                      suffixText: 'KM',
                    ),
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Please enter the delivery charge';
                      }

                      final double? charge = double.tryParse(value);
                      if (charge == null || charge < 0) {
                        return 'Please enter a valid non-negative delivery charge';
                      }
                      return null;
                    },
                    onSaved: (value) => _deliveryCharge = double.parse(value!),
                  ),
                ),
              ),
              SizedBox(height: 16.0),
              HoverAnimation(
                size: const Size(360, 54),
                hoverColor: Colors.white,
                bgColor: Colors.white,
                offset: const Offset(1, 1),
                border: Border.all(),
                child: Padding(
                  padding:
                      const EdgeInsets.symmetric(horizontal: 8, vertical: 2),
                  child: TextFormField(
                    decoration: InputDecoration(
                        hintText: 'Delivery Time (minutes)',
                        contentPadding: EdgeInsets.all(12.0),
                        suffixText: 'min'),
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Please enter the delivery time';
                      }

                      final int? time = int.tryParse(value);
                      if (time == null || time < 0) {
                        return 'Please enter a valid non-negative delivery time';
                      }
                      return null;
                    },
                    onSaved: (value) => _deliveryTime = int.parse(value!),
                  ),
                ),
              ),
              SizedBox(height: 16.0),
              HoverAnimation(
                size: const Size(360, 54),
                hoverColor: Colors.white,
                bgColor: Colors.white,
                offset: const Offset(1, 1),
                border: Border.all(),
                child: Padding(
                  padding:
                      const EdgeInsets.symmetric(horizontal: 8, vertical: 2),
                  child: DropdownSearch<City>(
                    validator: (value) {
                      if (value == null) {
                        return 'Please enter the city';
                      }

                      return null;
                    },
                    selectedItem: _selectedCity,
                    onChanged: (City? newValue) {
                      setState(() {
                        _selectedCity = newValue;
                        _cityId = newValue?.id ?? 0;
                      });
                    },
                    items: widget.cities,
                    itemAsString: (City city) => city.title,
                    dropdownDecoratorProps: DropDownDecoratorProps(
                      dropdownSearchDecoration: InputDecoration(
                        hintText: 'Search cities...',
                        contentPadding: EdgeInsets.all(12.0),
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
                      constraints:
                          BoxConstraints(maxHeight: 300, maxWidth: 300),
                    ),
                  ),
                ),
              ),
              SizedBox(height: 16.0),
              HoverAnimation(
                size: const Size(360, 54),
                hoverColor: Colors.white,
                bgColor: Colors.white,
                offset: const Offset(1, 1),
                border: Border.all(),
                child: Padding(
                  padding:
                      const EdgeInsets.symmetric(horizontal: 8, vertical: 2),
                  child: TextFormField(
                    decoration: InputDecoration(
                      hintText: 'Address',
                      contentPadding: EdgeInsets.all(12.0),
                    ),
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Please insert your address';
                      }
                      return null;
                    },
                    onSaved: (value) => _address = value!,
                  ),
                ),
              ),
              SizedBox(height: 16.0),
              HoverAnimation(
                size: const Size(360, 54),
                hoverColor: Colors.white,
                bgColor: Colors.white,
                offset: const Offset(1, 1),
                border: Border.all(),
                child: Padding(
                  padding:
                      const EdgeInsets.symmetric(horizontal: 8, vertical: 2),
                  child: TextFormField(
                    decoration: InputDecoration(
                      hintText: 'Latitude',
                      contentPadding: EdgeInsets.all(12.0),
                    ),
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Check your restaurant\'s latitude on maps';
                      }
                      final RegExp latitudeRegex = RegExp(r'^\d{2}\.\d{5}$');
                      if (!latitudeRegex.hasMatch(value)) {
                        return 'Enter latitude in format: 2 digits, decimal point, 5 digits';
                      }
                      return null;
                    },
                    onSaved: (value) => _latitude = value!,
                  ),
                ),
              ),
              SizedBox(height: 16.0),
              HoverAnimation(
                size: const Size(360, 54),
                hoverColor: Colors.white,
                bgColor: Colors.white,
                offset: const Offset(1, 1),
                border: Border.all(),
                child: Padding(
                  padding:
                      const EdgeInsets.symmetric(horizontal: 8, vertical: 2),
                  child: TextFormField(
                    decoration: InputDecoration(
                      hintText: 'Longitude',
                      contentPadding: EdgeInsets.all(12.0),
                    ),
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Check your restaurant\'s longitude on maps';
                      }
                      final RegExp longitudeRegex = RegExp(r'^\d{2}\.\d{5}$');
                      if (!longitudeRegex.hasMatch(value)) {
                        return 'Enter longitude in format: 2 digits, decimal point, 5 digits';
                      }
                      return null;
                    },
                    onSaved: (value) => _longitude = value!,
                  ),
                ),
              ),
              SizedBox(
                height: 16,
              ),
              ElevatedButton(
                onPressed: _isLoading ? null : _submitForm,
                child: _isLoading
                    ? CircularProgressIndicator()
                    : Text('Create Restaurant'),
              ),
              SizedBox(height: 16.0),
            ],
          ),
        ),
      ),
    );
  }
}
