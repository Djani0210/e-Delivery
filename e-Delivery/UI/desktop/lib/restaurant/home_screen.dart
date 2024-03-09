import "dart:convert";

import "package:desktop/components/storage_service.dart";
import 'package:desktop/restaurant/api_calls/restaurant_api_calls.dart';
import "package:desktop/restaurant/dashboard_page.dart";
import "package:desktop/restaurant/order_details_page.dart";
import "package:desktop/restaurant/orders_page.dart";
import "package:desktop/restaurant/placeholder_page.dart";
import "package:desktop/restaurant/sidebar.dart";
import "package:desktop/restaurant/viewmodels/restaurant_get_VM.dart";
import "package:flutter/material.dart";
import "package:flutter_secure_storage/flutter_secure_storage.dart";

class HomeScreenNew extends StatefulWidget {
  @override
  _HomeScreenState createState() => _HomeScreenState();
}

class _HomeScreenState extends State<HomeScreenNew> {
  int _selectedIndex = 0;
  late List<Widget> _pages;
  RestaurantViewModel? restaurantViewModel;
  final GlobalKey<NavigatorState> _navigatorKey = GlobalKey<NavigatorState>();

  @override
  void initState() {
    super.initState();
    _fetchRestaurantData();
    _pages = [
      DashboardPage(),
      // This OrdersPage is a placeholder; the actual navigation will be handled by Navigator.
      OrdersPage(
        onNavigateToDetails: () => _navigateToDetails(),
      ),
      PlaceholderPage(title: 'Meni'),
      PlaceholderPage(title: 'Dostavljači'),
      PlaceholderPage(title: 'Uredi profil'),
      // ... other pages
    ];
  }

  void _fetchRestaurantData() async {
    final ApiService apiService = ApiService();
    // Replace 'your_storage_key' with your actual key for fetching the restaurant ID
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
      });
    } catch (e) {
      print('Error fetching restaurant data: $e');
    }
  }

  void _onItemTap(int index) {
    setState(() {
      _selectedIndex = index;
    });
    // If the sidebar tap should not switch pages immediately but rather initiate some other logic,
    // insert that logic here.
  }

  void _navigateToDetails() {
    _navigatorKey.currentState?.push(
      MaterialPageRoute(
        builder: (context) => OrderDetailsPage(),
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
              restaurantData: restaurantViewModel),
          Expanded(
            child: Navigator(
              key: _navigatorKey, // Use the GlobalKey for navigation
              onGenerateRoute: (settings) {
                return MaterialPageRoute(
                  builder: (context) {
                    return IndexedStack(
                      index: _selectedIndex,
                      children: _pages,
                    );
                  },
                );
              },
            ),
          ),
        ],
      ),
    );
  }
}
