import 'dart:math';

import 'package:desktop/components/hover_animation.dart';
import 'package:desktop/restaurant/restaurant_dashboard.dart';
import 'package:desktop/user/map_selection.dart';
import 'package:flutter/material.dart';

import 'package:desktop/restaurant/restaurant_service.dart';
import 'package:desktop/user/user_page.dart';
import 'package:geocoding/geocoding.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';
import 'package:desktop/components/storage_service.dart';
import 'package:geolocator/geolocator.dart';
import 'package:desktop/user/geolocation.dart';

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
  bool _isOpen = false;
  String _openingTime = '';
  String _closingTime = '';
  String _contactNumber = '';
  double _deliveryCharge = 0.0;
  int _deliveryTime = 0;
  int _cityId = 0;
  String _latitude = '';
  String _longitude = '';

  Future<void> _fetchLocationAndAddress() async {
    Position position = await DeterminePosition();
    String address =
        await GetAddressFromLatLng(position.latitude, position.longitude);
    setState(() {
      _latitude = position.latitude.toString();
      _longitude = position.longitude.toString();
      _address = address;
    });
  }

  @override
  Widget build(BuildContext context) {
    final Color goldColor = Color.fromRGBO(255, 215, 0, 1);
    return Container(
      height: 660,
      width: 400, // Set a fixed width for the form
      decoration: BoxDecoration(
        color: goldColor, // Set the background color to orange
        borderRadius: BorderRadius.circular(10), // Add rounded corners
      ),

      child: SingleChildScrollView(
        padding: EdgeInsets.all(16.0),
        child: Form(
          key: _formKey,
          child: Column(
            children: [
              //MapSelection(),
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
                      contentPadding: EdgeInsets.all(12.0), // Add padding
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
                      contentPadding: EdgeInsets.all(12.0), // Add padding
                    ),
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Please enter the opening time';
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
                      contentPadding: EdgeInsets.all(12.0), // Add padding
                    ),
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Please enter the closing time';
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
                      hintText:
                          'Contact Number example 061-402-222', // Placeholder text
                      // Add border
                      contentPadding: EdgeInsets.all(12.0), // Add padding
                    ),
                    keyboardType: TextInputType
                        .phone, // Set keyboard type for phone numbers
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Please enter the contact number';
                      }
                      // Add a regex pattern to validate the phone number format
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
                      contentPadding: EdgeInsets.all(12.0), // Add padding
                    ),
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Please enter the delivery charge';
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
                      contentPadding: EdgeInsets.all(12.0), // Add padding
                    ),
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Please enter the delivery time';
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
                  child: DropdownButtonFormField<int>(
                    decoration: InputDecoration(
                      hintText: 'City',
                      contentPadding: EdgeInsets.all(12.0), // Add padding
                    ),
                    items: widget.cities.map((City city) {
                      return DropdownMenuItem<int>(
                        value: city.id,
                        child: Text(
                          city.title,
                          style: const TextStyle(color: Colors.purple),
                        ),
                      );
                    }).toList(),
                    onChanged: (int? newValue) {
                      setState(() {
                        _cityId = newValue!;
                      });
                    },
                    onSaved: (int? value) => _cityId = value!,
                  ),
                ),
              ),

              SizedBox(height: 16.0),
              CheckboxListTile(
                title: Text(
                  'Is Open',
                  style: TextStyle(fontWeight: FontWeight.bold),
                ),
                value: _isOpen,
                onChanged: (bool? value) {
                  setState(() {
                    _isOpen = value!;
                  });
                },
                activeColor: Colors.black,
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
                      contentPadding: EdgeInsets.all(12.0), // Add padding
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
                      hintText: 'Lattitude',
                      contentPadding: EdgeInsets.all(12.0), // Add padding
                    ),
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Check your restaurants lattitude on maps';
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
                      contentPadding: EdgeInsets.all(12.0), // Add padding
                    ),
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Check your restaurants longitude on maps';
                      }
                      return null;
                    },
                    onSaved: (value) => _longitude = value!,
                  ),
                ),
              ),
              /* ElevatedButton(
                onPressed: _fetchLocationAndAddress,
                child: Text('Get Current Location'),
                style: ElevatedButton.styleFrom(
                  primary: Colors.blue,
                  onPrimary: Colors.white,
                ),
              ), */
              SizedBox(
                height: 16,
              ),
              FloatingActionButton(
                isExtended: true,
                onPressed: () async {
                  if (_formKey.currentState!.validate()) {
                    _formKey.currentState!.save();
                    // Call the service to create the restaurant
                    final Map<String, dynamic>? response =
                        await _restaurantService.CreateRestaurant(
                      _name,
                      _address,
                      _isOpen,
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
                    if (response != null && response['status'] == 201 ||
                        response?['status'] == 200) {
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
                      Future.delayed(Duration(seconds: 2), () {
                        Navigator.pushReplacement(
                          context,
                          MaterialPageRoute(builder: (context) => MyApp()),
                        );
                      });
                    } else {
                      // Show an error message
                      ScaffoldMessenger.of(context).showSnackBar(
                        SnackBar(
                          duration: Duration(milliseconds: 2000),
                          content: Center(
                              child: Text(
                            'Failed to register restaurant',
                            style: TextStyle(color: Colors.red),
                          )),
                          behavior: SnackBarBehavior.floating,
                          shape: RoundedRectangleBorder(
                              borderRadius: BorderRadius.circular(24)),
                          margin: EdgeInsets.fromLTRB(16.0, 0, 16.0, 16.0),
                        ),
                      );
                    }
                  }
                },
                child: Icon(
                  Icons.check,
                  color: Colors.green,
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }
}
