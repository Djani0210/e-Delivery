import 'package:e_delivery_mobile/deliveryPerson/screens/Home/dto/delivery_person_get_dto.dart';
import 'package:e_delivery_mobile/deliveryPerson/screens/profile/api/employee_profile_service.dart';
import 'package:e_delivery_mobile/globals.dart';

import 'package:flutter/material.dart';
import 'package:dropdown_search/dropdown_search.dart';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';

class RestaurantViewModel {
  final int id;
  final String name;

  RestaurantViewModel({required this.id, required this.name});

  factory RestaurantViewModel.fromJson(Map<String, dynamic> json) {
    return RestaurantViewModel(
      id: json['id'],
      name: json['name'],
    );
  }
}

class ApplyToRestaurantPage extends StatefulWidget {
  @override
  _ApplyToRestaurantPageState createState() => _ApplyToRestaurantPageState();
}

class _ApplyToRestaurantPageState extends State<ApplyToRestaurantPage> {
  final _storage = const FlutterSecureStorage();
  List<RestaurantViewModel> _restaurants = [];
  RestaurantViewModel? _selectedRestaurant;
  bool _isLoading = true;
  int? _currentRestaurantId;
  DeliveryPersonGetDTO? userData;

  @override
  void initState() {
    super.initState();
    _fetchRestaurants();
    _loadUserData();
  }

  Future<void> _loadUserData() async {
    try {
      userData = await EmployeeProfileService().fetchLoggedInUser();

      setState(() {});
    } catch (e) {
      print('Error loading user data: $e');
    }
  }

  Future<void> _fetchRestaurants() async {
    try {
      String jwt = await _fetchJwtToken();
      final cityId = await _fetchCityId();
      final url = '${baseUrl}Restaurant/get-Restaurants?id=$cityId';
      final response = await http
          .get(Uri.parse(url), headers: {'Authorization': 'Bearer $jwt'});

      if (response.statusCode == 200) {
        final data = jsonDecode(response.body);
        if (data['isValid']) {
          final restaurantsData = data['data'] as List<dynamic>;
          setState(() {
            _restaurants = restaurantsData
                .map((json) => RestaurantViewModel.fromJson(json))
                .toList();
            _selectedRestaurant =
                _restaurants.isNotEmpty ? _restaurants[0] : null;
            _isLoading = false;
          });
          _fetchCurrentRestaurantId();
        } else {
          throw Exception('Failed to fetch restaurants: ${data['info']}');
        }
      } else {
        throw Exception('Failed to fetch restaurants');
      }
    } catch (e) {
      print('Error fetching restaurants: $e');
      setState(() {
        _isLoading = false;
      });
    }
  }

  Future<bool> removeEmployee(String id) async {
    final jwt = await _fetchJwtToken();

    final apiUrl = Uri.parse('${baseUrl}Restaurant/remove-Employee')
        .replace(queryParameters: {'id': id});

    try {
      final response = await http.put(
        apiUrl,
        headers: {
          'Content-Type': 'application/json',
          'Authorization': 'Bearer $jwt',
        },
      );

      if (response.statusCode == 200) {
        print("Employee successfully removed");
        return true;
      } else {
        print(
            "Failed to remove employee with status code: ${response.statusCode}");
        return false;
      }
    } catch (e) {
      print("Error removing employee: $e");
      return false;
    }
  }

  Future<void> _fetchCurrentRestaurantId() async {
    if (userData != null) {
      setState(() {
        _currentRestaurantId = userData!.restaurantId;
      });
    }
  }

  Future<String> _fetchJwtToken() async {
    String? jwt = await _storage.read(key: 'jwt');
    return jwt ?? '';
  }

  Future<int> _fetchCityId() async {
    String? userDataJson = await _storage.read(key: 'userData');
    if (userDataJson != null) {
      final userData = jsonDecode(userDataJson);
      return userData['cityId'];
    }
    throw Exception('City ID not found');
  }

  Future<void> _applyToRestaurant(int restaurantId) async {
    try {
      String jwt = await _fetchJwtToken();
      final url = '${baseUrl}User/apply/$restaurantId';
      final response = await http
          .post(Uri.parse(url), headers: {'Authorization': 'Bearer $jwt'});

      if (response.statusCode == 200) {
        final data = jsonDecode(response.body);
        if (data['isValid']) {
          ScaffoldMessenger.of(context).showSnackBar(
              SnackBar(content: Text('Application sent successfully.')));
        } else {
          throw Exception('Failed to apply: ${data['info']}');
        }
      } else {
        throw Exception('Failed to apply');
      }
    } catch (e) {
      print('Error applying to restaurant: $e');
      ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(content: Text('Error applying to restaurant: $e')));
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Apply to Restaurant'),
      ),
      body: _isLoading
          ? Center(child: CircularProgressIndicator())
          : Padding(
              padding: const EdgeInsets.all(16.0),
              child: Column(
                children: [
                  DropdownSearch<RestaurantViewModel>(
                    items: _restaurants,
                    itemAsString: (RestaurantViewModel r) => r.name,
                    selectedItem: _selectedRestaurant,
                    onChanged: (RestaurantViewModel? restaurant) {
                      setState(() {
                        _selectedRestaurant = restaurant;
                      });
                    },
                    dropdownDecoratorProps: const DropDownDecoratorProps(
                        dropdownSearchDecoration: InputDecoration(
                      labelText: 'Select Restaurant',
                      contentPadding:
                          EdgeInsets.symmetric(horizontal: 12, vertical: 4),
                      border: OutlineInputBorder(),
                    )),
                    popupProps: const PopupProps.menu(
                      showSearchBox: true,
                      searchFieldProps: TextFieldProps(
                        decoration: InputDecoration(
                          hintText: 'Search restaurants...',
                          border: OutlineInputBorder(),
                        ),
                      ),
                    ),
                  ),
                  SizedBox(height: 20),
                  ElevatedButton(
                    onPressed: (_selectedRestaurant == null ||
                            _selectedRestaurant!.id == _currentRestaurantId)
                        ? null
                        : () => _applyToRestaurant(_selectedRestaurant!.id),
                    child: Text('Apply'),
                  ),
                  SizedBox(height: 20),
                  ElevatedButton(
                    onPressed: _currentRestaurantId == null
                        ? null
                        : () => _removeFromRestaurant(),
                    child: Text('Remove from Current Restaurant'),
                  ),
                  SizedBox(height: 20),
                  Center(
                    child: Text(
                      _currentRestaurantId == null
                          ? "You're currently not a part of any restaurant"
                          : "Your current restaurant is ${_restaurants.firstWhere((r) => r.id == _currentRestaurantId!).name}",
                      style: TextStyle(color: Colors.black),
                      textAlign: TextAlign.center,
                    ),
                  ),
                  SizedBox(height: 30),
                  Text("After successful confirmation, please login again."),
                ],
              ),
            ),
    );
  }

  Future<void> _reloadPage() async {
    await _fetchRestaurants();
    await _fetchCurrentRestaurantId();

    setState(() {});
  }

  Future<void> _removeFromRestaurant() async {
    if (userData != null) {
      bool confirmed = await showDialog(
        context: context,
        builder: (BuildContext context) {
          return AlertDialog(
            title: Text('Confirmation'),
            content: Text(
                'Are you sure you want to remove yourself from the restaurant?'),
            actions: [
              TextButton(
                onPressed: () {
                  Navigator.of(context).pop(false);
                },
                child: Text('Cancel'),
              ),
              TextButton(
                onPressed: () {
                  Navigator.of(context).pop(true);
                },
                child: Text('Confirm'),
              ),
            ],
          );
        },
      );

      if (confirmed) {
        bool success = await removeEmployee(userData!.id.toString());
        if (success) {
          setState(() {
            _currentRestaurantId = null;
          });
          print(userData!.id.toString());
          ScaffoldMessenger.of(context).showSnackBar(
            SnackBar(
                content: Text('Successfully removed from the restaurant.')),
          );

          await _loadUserData();
          await _reloadPage();
        } else {
          ScaffoldMessenger.of(context).showSnackBar(
            SnackBar(content: Text('Failed to remove from the restaurant.')),
          );
        }
      }
    }
  }
}
