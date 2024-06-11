import 'dart:ui';

import 'package:desktop/globals.dart';
import 'package:desktop/loginRegistration/log_in_page.dart';
import 'package:desktop/restaurant/api_calls/restaurant_api_calls.dart';

import 'package:desktop/restaurant/restaurant_dashboard.dart';
import 'package:desktop/restaurant/viewmodels/restaurant_get_VM.dart';
import 'package:desktop/restaurant/viewmodels/userDataVM.dart';
import 'package:flutter/material.dart';

import 'package:http/http.dart' as http;
import 'dart:convert';
import 'package:desktop/components/storage_service.dart';
import 'package:desktop/user/restaurant_form.dart';

class UserPage extends StatefulWidget {
  const UserPage({Key? key}) : super(key: key);

  @override
  _UserPageState createState() => _UserPageState();
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

class _UserPageState extends State<UserPage> {
  UserDataViewModel? _userDataViewModel;
  RestaurantViewModel? restaurantViewModel;
  List<City> _cities = [];
  String? _imagePath;
  @override
  void initState() {
    super.initState();
    _loadUserData();
    _fetchCities();
  }

  Future<void> _fetchCities() async {
    final response = await http.get(Uri.parse('${baseUrl}City/get-cities'));
    if (response.statusCode == 200) {
      final data = jsonDecode(response.body);
      setState(() {
        _cities = List<City>.from(data['data'].map((x) => City.fromJson(x)));
      });
    } else {}
  }

  Future<void> _loadUserData() async {
    try {
      final jwtToken = await StorageService.storage.read(key: 'jwt');

      if (jwtToken != null) {
      } else {}
      final userId = await StorageService.storage.read(key: 'currentUserId');
      if (userId != null) {
      } else {}

      final userDataJson = await StorageService.storage.read(key: 'userData');
      if (userDataJson != null) {
        final userData = jsonDecode(userDataJson);
        setState(() {
          _userDataViewModel = UserDataViewModel.fromJson(userData);
        });
        final restaurantId = _userDataViewModel?.restaurantId;
        if (restaurantId != null) {
          final ApiService apiService = ApiService();
          try {
            final restaurantData =
                await apiService.getRestaurantById(restaurantId);
            setState(() {
              restaurantViewModel =
                  RestaurantViewModel.fromJson(restaurantData['data']);
              _imagePath = restaurantViewModel?.logo?.fullImageUrl;
            });
          } catch (e) {
            print('Error fetching restaurant data: $e');
          }
        }
      }
    } catch (e) {
      print('Error loading user data: $e');
    }
  }

  Future<void> _logout() async {
    final confirmation = await showDialog<bool>(
      context: context,
      builder: (context) => AlertDialog(
        title: const Text('Logout Confirmation'),
        content: const Text('Are you sure you want to log out?'),
        actions: [
          TextButton(
            onPressed: () => Navigator.of(context).pop(false),
            child: const Text('No'),
          ),
          TextButton(
            onPressed: () => Navigator.of(context).pop(true),
            child: const Text('Yes'),
          ),
        ],
      ),
    );

    if (confirmation == true) {
      try {
        final jwtToken = await StorageService.storage.read(key: 'jwt');

        final response = await http.post(
          Uri.parse('${baseUrl}Auth/logout'),
          headers: {
            'Content-Type': 'application/json',
            'Authorization': 'Bearer $jwtToken',
          },
        );

        if (response.statusCode == 200) {
          await Future.wait([
            StorageService.storage.delete(key: 'jwt'),
            StorageService.storage.delete(key: 'currentUserId'),
            StorageService.storage.delete(key: 'userData'),
          ]);

          Navigator.push(
            context,
            MaterialPageRoute(builder: (context) => LogInPage()),
          );
        } else {
          ScaffoldMessenger.of(context).showSnackBar(
            SnackBar(
              duration: Duration(milliseconds: 2000),
              content: Center(
                child: Text(
                  'Failed to log out: ${response.statusCode}',
                  style: TextStyle(color: Colors.red),
                ),
              ),
            ),
          );
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
          ),
        );
      }
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(
        child: Center(
          child: SingleChildScrollView(
            child: Padding(
              padding: const EdgeInsets.all(16.0),
              child: Column(
                mainAxisAlignment: MainAxisAlignment.center,
                crossAxisAlignment: CrossAxisAlignment.center,
                children: [
                  if (_userDataViewModel != null)
                    Text(
                      'Welcome, ${_userDataViewModel!.userName}',
                      style: TextStyle(
                          fontSize: 45,
                          fontWeight: FontWeight.bold,
                          fontFamily: 'Raleway'),
                      textAlign: TextAlign.center,
                    )
                  else
                    const CircularProgressIndicator(),
                  SizedBox(height: 20),
                  if (_userDataViewModel?.restaurantId == null)
                    Card(
                      elevation: 4,
                      shadowColor: Colors.black,
                      color: Colors.orange[100],
                      child: SizedBox(
                        width: 450,
                        height: 450,
                        child: Padding(
                          padding: const EdgeInsets.all(20.0),
                          child: Column(
                            children: [
                              CircleAvatar(
                                backgroundImage: _getBackgroundImage(),
                                radius: 100,
                              ),
                              const SizedBox(height: 10),
                              Text(
                                'Your Restaurant',
                                style: TextStyle(
                                  fontSize: 30,
                                  color: Colors.orange[900],
                                  fontWeight: FontWeight.w500,
                                ),
                                overflow: TextOverflow.ellipsis,
                              ),
                              const SizedBox(height: 10),
                              Text(
                                'You currently have no restaurant, register one!',
                                style: TextStyle(
                                  fontSize: 15,
                                  color: Colors.orange,
                                ),
                                overflow: TextOverflow.ellipsis,
                              ),
                              const SizedBox(height: 10),
                              SizedBox(
                                width: 400,
                                child: ElevatedButton(
                                  onPressed: () {
                                    showDialog(
                                      context: context,
                                      builder: (context) => AlertDialog(
                                        title: Center(
                                            child: Text(
                                          'Create Restaurant',
                                          style: TextStyle(
                                              fontWeight: FontWeight.bold),
                                        )),
                                        content: SingleChildScrollView(
                                          child:
                                              RestaurantForm(cities: _cities),
                                        ),
                                      ),
                                    );
                                  },
                                  style: ButtonStyle(
                                    backgroundColor: MaterialStateProperty.all(
                                        Colors.orange),
                                  ),
                                  child: Padding(
                                    padding: const EdgeInsets.all(4),
                                    child: Row(
                                      mainAxisAlignment:
                                          MainAxisAlignment.center,
                                      children: const [Text('Register')],
                                    ),
                                  ),
                                ),
                              ),
                            ],
                          ),
                        ),
                      ),
                    )
                  else
                    Card(
                      elevation: 4,
                      shadowColor: Colors.black,
                      color: Colors.orange[100],
                      child: SizedBox(
                        width: 450,
                        height: 450,
                        child: Padding(
                          padding: const EdgeInsets.all(20.0),
                          child: Column(
                            children: [
                              CircleAvatar(
                                backgroundImage: _getBackgroundImage(),
                                radius: 100,
                              ),
                              const SizedBox(height: 10),
                              Text(
                                'Your Restaurant',
                                style: TextStyle(
                                  fontSize: 30,
                                  color: Colors.orange[900],
                                  fontWeight: FontWeight.w500,
                                ),
                              ),
                              const SizedBox(height: 10),
                              Text(
                                'Manage your restaurant in the dashboard',
                                style: TextStyle(
                                  fontSize: 15,
                                  color: Colors.orange,
                                ),
                              ),
                              const SizedBox(height: 10),
                              SizedBox(
                                width: 400,
                                child: ElevatedButton(
                                  onPressed: () {
                                    Navigator.push(
                                      context,
                                      MaterialPageRoute(
                                          builder: (context) => const MyApp()),
                                    );
                                  },
                                  style: ButtonStyle(
                                    backgroundColor: MaterialStateProperty.all(
                                        Colors.orange),
                                  ),
                                  child: Padding(
                                    padding: const EdgeInsets.all(4),
                                    child: Row(
                                      mainAxisAlignment:
                                          MainAxisAlignment.center,
                                      children: const [Text('Go to Dashboard')],
                                    ),
                                  ),
                                ),
                              ),
                            ],
                          ),
                        ),
                      ),
                    ),
                  SizedBox(height: 24),
                  TextButton(
                    onPressed: _logout,
                    child: Text(
                      'Logout',
                      style: TextStyle(
                        fontSize: 20,
                        color: Colors.white,
                      ),
                    ),
                    style: TextButton.styleFrom(
                      backgroundColor: Colors.blue,
                      padding:
                          EdgeInsets.symmetric(horizontal: 30, vertical: 15),
                      shape: RoundedRectangleBorder(
                        borderRadius: BorderRadius.circular(30),
                      ),
                    ),
                  ),
                ],
              ),
            ),
          ),
        ),
      ),
    );
  }

  ImageProvider _getBackgroundImage() {
    if (_userDataViewModel?.restaurantId != null && _imagePath != null) {
      return NetworkImage(_imagePath!);
    } else {
      return const AssetImage('assets/images/no-image-found.jpg');
    }
  }
}
