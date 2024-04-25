import 'dart:convert';
import 'package:desktop/components/storage_service.dart';

import 'package:desktop/loginRegistration/log_in_page.dart';
import 'package:desktop/restaurant/api_calls/restaurant_api_calls.dart';
import 'package:desktop/restaurant/dashboard_page.dart';
import 'package:desktop/restaurant/employees_page.dart';
import 'package:desktop/restaurant/menu_page.dart';
import 'package:desktop/restaurant/order_details_page.dart';
import 'package:desktop/restaurant/orders_page.dart';

import 'package:desktop/restaurant/restaurant_profile_page.dart';
import 'package:desktop/restaurant/sidebar.dart';
import 'package:desktop/restaurant/viewmodels/restaurant_get_VM.dart';
import 'package:flutter/material.dart';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import 'package:http/http.dart' as http;

class HomeScreenNew extends StatefulWidget {
  @override
  _HomeScreenState createState() => _HomeScreenState();
}

class _HomeScreenState extends State<HomeScreenNew> {
  int _selectedIndex = 0;
  List<Widget>? _pages = [];
  RestaurantViewModel? restaurantViewModel;
  final GlobalKey<NavigatorState> _navigatorKey = GlobalKey<NavigatorState>();

  @override
  void initState() {
    super.initState();
    _fetchRestaurantData();
  }

  Future<void> _logout() async {
    // Show a confirmation dialog
    final confirmation = await showDialog<bool>(
      context: context,
      builder: (context) => AlertDialog(
        title: const Text('Potvrda objave'),
        content: const Text('Da li ste sigurni da se zelite odjaviti?'),
        actions: [
          TextButton(
            onPressed: () => Navigator.of(context).pop(false),
            child: const Text('Ne'),
          ),
          TextButton(
            onPressed: () => Navigator.of(context).pop(true),
            child: const Text('Da'),
          ),
        ],
      ),
    );

    if (confirmation == true) {
      try {
        // Retrieve the JWT token from secure storage
        final jwtToken = await StorageService.storage.read(key: 'jwt');

        // Call the logout endpoint with the JWT token in the Authorization header
        final response = await http.post(
          Uri.parse('https://localhost:44395/api/Auth/logout'),
          headers: {
            'Content-Type': 'application/json',
            'Authorization': 'Bearer $jwtToken',
          },
        );

        if (response.statusCode == 200) {
          // Delete the user data from secure storage
          await Future.wait([
            StorageService.storage.delete(key: 'jwt'),
            StorageService.storage.delete(key: 'currentUserId'),
            StorageService.storage.delete(key: 'userData'),
          ]);

          // Navigate to the login page
          Navigator.push(
            context,
            MaterialPageRoute(builder: (context) => LogInPage()),
          );
        } else {
          // Handle logout failure
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
        // Handle any exceptions that occur during the request
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

  void _fetchRestaurantData() async {
    final ApiService apiService = ApiService();
    final String? userDataJson =
        await FlutterSecureStorage().read(key: 'userData');

    if (userDataJson == null) {
      print('User data not found in storage.');
      return;
    }

    final Map<String, dynamic> userData = jsonDecode(userDataJson);
    final int restaurantId = userData['restaurantId'];
    if (restaurantId == null) {
      print('Restaurant ID not found in user data.');
      return;
    }

    try {
      final restaurantData = await apiService.getRestaurantById(restaurantId);
      setState(() {
        restaurantViewModel =
            RestaurantViewModel.fromJson(restaurantData['data']);
        // Initialize _pages here, after restaurantViewModel is fetched
        _pages = [
          DashboardPage(),
          OrdersPage(onNavigateToDetails: _navigateToDetails),
          MenuPage(),
          EmployeesPage(),
          RestaurantProfilePage(
              restaurantViewModel:
                  restaurantViewModel), // Adjusted to pass viewModel
        ];
      });
    } catch (e) {
      print('Error fetching restaurant data: $e');
      print(restaurantViewModel);
    }
  }

  void _onItemTap(int index) {
    setState(() {
      _selectedIndex = index;
    });
  }

  void _navigateToDetails(String id) {
    _navigatorKey.currentState?.push(
      MaterialPageRoute(
        builder: (context) => OrderDetailsPage(id: id),
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    // Using a Builder to ensure the Navigator is under MaterialApp
    return Scaffold(
      body: Row(
        children: [
          Sidebar(
              onTap: _onItemTap,
              selectedIndex: _selectedIndex,
              restaurantData: restaurantViewModel,
              onLogout: _logout),
          Expanded(
            child: Navigator(
              key: _navigatorKey,
              onGenerateRoute: (settings) {
                // Safe to use _pages now as it's initialized to an empty list
                return MaterialPageRoute(
                  builder: (context) => IndexedStack(
                    index: _selectedIndex,
                    children:
                        _pages!, // Use the non-null assertion operator as _pages is now guaranteed to be initialized
                  ),
                );
              },
            ),
          ),
        ],
      ),
    );
  }
}
