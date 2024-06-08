import 'dart:convert';

import 'package:dropdown_search/dropdown_search.dart';

import 'package:e_delivery_mobile/customer/screens/profile/api/profile_api.dart';
import 'package:e_delivery_mobile/customer/screens/profile/dto/customer_get_dto.dart';

import 'package:flutter/material.dart';

class UpdateProfilePage extends StatefulWidget {
  final Function onProfileUpdated;
  const UpdateProfilePage({Key? key, required this.onProfileUpdated})
      : super(key: key);
  @override
  _UpdateProfilePageState createState() => _UpdateProfilePageState();
}

class _UpdateProfilePageState extends State<UpdateProfilePage> {
  final ProfileService _profileService = ProfileService();
  final _formKey = GlobalKey<FormState>();
  final TextEditingController _firstNameController = TextEditingController();
  final TextEditingController _lastNameController = TextEditingController();
  final TextEditingController _emailController = TextEditingController();
  final TextEditingController _phoneNumberController = TextEditingController();
  final TextEditingController _userNameController = TextEditingController();

  int? cityId;
  CustomerGetDto? _userDataViewModel;

  City? _selectedCity;
  List<City> _cities = [];

  Future<void> _loadUserData() async {
    try {
      _userDataViewModel = await _profileService.fetchLoggedInUser();
      setState(() {
        _firstNameController.text = _userDataViewModel?.firstName ?? '';
        _lastNameController.text = _userDataViewModel?.lastName ?? '';
        _emailController.text = _userDataViewModel?.email ?? '';
        _phoneNumberController.text = _userDataViewModel?.phoneNumber ?? '';
        _userNameController.text = _userDataViewModel?.userName ?? '';
        cityId = _userDataViewModel?.cityId;
        _selectedCity = _cities.firstWhere((city) => city.id == cityId);
      });
    } catch (e) {
      print('Error loading user data: $e');
    }
  }

  @override
  void initState() {
    super.initState();
    _loadUserData();
    _fetchCities();
  }

  @override
  void dispose() {
    _firstNameController.dispose();
    _lastNameController.dispose();
    _emailController.dispose();
    _phoneNumberController.dispose();
    _userNameController.dispose();
    super.dispose();
  }

  Future<void> _updateProfile() async {
    if (_formKey.currentState!.validate()) {
      _formKey.currentState!.save();
      try {
        final userId = '${_userDataViewModel?.id.toString()}';
        final firstName = _firstNameController.text;
        final lastName = _lastNameController.text;
        final phoneNumber = _phoneNumberController.text;
        final email = _emailController.text;
        final userName = _userNameController.text;
        final cityId = this.cityId ?? 0;

        final response = await _profileService.updateUserProfile(
          userId: userId,
          firstName: firstName,
          lastName: lastName,
          phoneNumber: phoneNumber,
          email: email,
          userName: userName,
          cityId: cityId,
        );

        final responseBody = json.decode(response.body);
        print(responseBody);

        await _loadUserData();
        widget.onProfileUpdated();

        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(content: Center(child: Text("Good job"))),
        );

        Future.delayed(Duration(seconds: 1), () {
          Navigator.of(context).pop();
        });
      } catch (e) {
        print('Error updating profile: $e');

        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(content: Center(child: Text("Error updating profile"))),
        );
      }
    }
  }

  Future<void> _fetchCities() async {
    try {
      final response = await _profileService.getCities();
      final responseBody = json.decode(response.body);
      final List<dynamic> citiesData = responseBody['data'];
      setState(() {
        _cities =
            citiesData.map((cityData) => City.fromJson(cityData)).toList();
        _selectedCity = _cities.firstWhere((city) => city.id == cityId,
            orElse: () => _cities.first);
      });
    } catch (error) {
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

  String? _validateCity(City? value) {
    if (value == null) {
      return 'Please select a city';
    }
    return null;
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Update Profile'),
      ),
      body: Padding(
        padding: EdgeInsets.all(16.0),
        child: Form(
          key: _formKey,
          child: ListView(
            children: [
              Text(
                'First and Last Name can be left empty.',
                style: TextStyle(color: Colors.grey, fontSize: 14),
              ),
              SizedBox(height: 10),
              TextFormField(
                controller: _firstNameController,
                decoration: InputDecoration(
                  labelText: 'First Name',
                  border: OutlineInputBorder(),
                ),
                maxLength: 15,
                onSaved: (value) => _firstNameController.text = value ?? '',
              ),
              SizedBox(height: 10),
              TextFormField(
                controller: _lastNameController,
                decoration: InputDecoration(
                  labelText: 'Last Name',
                  border: OutlineInputBorder(),
                ),
                maxLength: 20,
                onSaved: (value) => _lastNameController.text = value ?? '',
              ),
              SizedBox(height: 10),
              TextFormField(
                controller: _emailController,
                decoration: InputDecoration(
                  labelText: 'Email',
                  border: OutlineInputBorder(),
                ),
                onSaved: (value) => _emailController.text = value ?? '',
                validator: _validateEmail,
                maxLength: 30,
              ),
              SizedBox(height: 10),
              TextFormField(
                controller: _phoneNumberController,
                decoration: InputDecoration(
                  labelText: 'Phone Number',
                  border: OutlineInputBorder(),
                ),
                onSaved: (value) => _phoneNumberController.text = value ?? '',
                validator: _validatePhoneNumber,
                maxLength: 15,
              ),
              SizedBox(height: 10),
              TextFormField(
                controller: _userNameController,
                decoration: InputDecoration(
                  labelText: 'Username',
                  border: OutlineInputBorder(),
                ),
                onSaved: (value) => _userNameController.text = value ?? '',
                maxLength: 15,
                validator: _validateUsername,
              ),
              SizedBox(height: 10),
              DropdownSearch<City>(
                selectedItem: _selectedCity,
                onChanged: (City? newValue) {
                  setState(() {
                    _selectedCity = newValue;
                    cityId = newValue?.id;
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
              SizedBox(height: 20),
              ElevatedButton(
                onPressed: _updateProfile,
                child: Text('Update Profile'),
                style: ElevatedButton.styleFrom(
                  padding: EdgeInsets.symmetric(vertical: 16.0),
                  textStyle: TextStyle(fontSize: 18),
                ),
              ),
            ],
          ),
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
