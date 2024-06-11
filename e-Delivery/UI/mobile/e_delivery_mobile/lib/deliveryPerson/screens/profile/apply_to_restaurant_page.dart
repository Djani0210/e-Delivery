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

  @override
  void initState() {
    super.initState();
    _fetchRestaurants();
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

  Future<void> _fetchCurrentRestaurantId() async {
    String? userDataJson = await _storage.read(key: 'userData');
    if (userDataJson != null) {
      final userData = jsonDecode(userDataJson);
      setState(() {
        _currentRestaurantId = userData['restaurantId'];
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
                    onPressed: _selectedRestaurant == null
                        ? null
                        : () => _applyToRestaurant(_selectedRestaurant!.id),
                    child: Text('Apply'),
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
                  Text("After successful confirmation, please login again."),
                ],
              ),
            ),
    );
  }
}
