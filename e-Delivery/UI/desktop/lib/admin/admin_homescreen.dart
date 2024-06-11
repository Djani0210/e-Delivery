import 'dart:convert';

import 'package:desktop/admin/admin_sideBar.dart';
import 'package:desktop/admin/categories_page.dart';
import 'package:desktop/admin/cities_page.dart';
import 'package:desktop/admin/restaurants_page.dart';
import 'package:desktop/components/storage_service.dart';
import 'package:desktop/globals.dart';
import 'package:desktop/loginRegistration/log_in_page.dart';
import 'package:desktop/restaurant/viewmodels/userDataVM.dart';
import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;

class HomeScreenAdminPage extends StatefulWidget {
  const HomeScreenAdminPage({Key? key}) : super(key: key);
  @override
  _HomeScreenAdminState createState() => _HomeScreenAdminState();
}

class _HomeScreenAdminState extends State<HomeScreenAdminPage> {
  int _selectedIndex = 0;
  List<Widget>? _pages = [];
  UserDataViewModel? _userDataViewModel;
  final GlobalKey<NavigatorState> _navigatorKey = GlobalKey<NavigatorState>();

  void initState() {
    super.initState();
    _loadUserData();
  }

  void _onItemTap(int index) {
    setState(() {
      _selectedIndex = index;
    });
  }

  Future<void> _loadUserData() async {
    try {
      final jwtToken = await StorageService.storage.read(key: 'jwt');

      if (jwtToken != null) {
      } else {
        print('No JWT token found in secure storage.');
      }
      final userId = await StorageService.storage.read(key: 'currentUserId');
      if (userId != null) {
      } else {
        print('No user ID found in secure storage.');
      }

      final userDataJson = await StorageService.storage.read(key: 'userData');
      if (userDataJson != null) {
        final userData = jsonDecode(userDataJson);
        setState(() {
          _userDataViewModel = UserDataViewModel.fromJson(userData);
        });
        _pages = [
          CitiesPage(),
          CategoriesPage(),
          RestaurantsPage(),
        ];
      }
    } catch (e) {
      print('Error loading user data: $e');
    }
  }

  Future<void> _logout() async {
    final confirmation = await showDialog<bool>(
      context: context,
      builder: (context) => AlertDialog(
        title: const Text('Confirmation'),
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
      body: Row(
        children: [
          Sidebar(
              onTap: _onItemTap,
              selectedIndex: _selectedIndex,
              userData: _userDataViewModel,
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
