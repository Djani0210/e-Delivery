import 'dart:convert';
import 'package:desktop/components/storage_service.dart';
import 'package:desktop/globals.dart';

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

  void handleProfilePictureUpdated() {
    _fetchRestaurantData();
  }

  Future<void> _logout() async {
    final confirmation = await showDialog<bool>(
      context: context,
      builder: (context) => AlertDialog(
        title: const Text('Logout confirmation'),
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

  void _fetchRestaurantData() async {
    final ApiService apiService = ApiService();
    final String? userDataJson =
        await FlutterSecureStorage().read(key: 'userData');

    if (userDataJson == null) {
      print('User data not found in storage.');
      return;
    }

    final Map<String, dynamic> userData = jsonDecode(userDataJson);
    final int? restaurantId = userData['restaurantId'];
    if (restaurantId == null) {
      print('Restaurant ID not found in user data.');
      return;
    }

    try {
      final restaurantData = await apiService.getRestaurantById(restaurantId);
      setState(() {
        restaurantViewModel =
            RestaurantViewModel.fromJson(restaurantData['data']);

        _pages = [
          DashboardPage(),
          OrdersPage(onNavigateToDetails: _navigateToDetails),
          MenuPage(),
          EmployeesPage(),
          RestaurantProfilePage(
            restaurantViewModel: restaurantViewModel,
            onProfilePictureUpdated: handleProfilePictureUpdated,
          ),
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
                return MaterialPageRoute(
                  builder: (context) => IndexedStack(
                    index: _selectedIndex,
                    children: _pages!,
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
