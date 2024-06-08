import 'dart:convert';
import 'package:e_delivery_mobile/customer/core/components/search_box.dart';
import 'package:e_delivery_mobile/customer/screens/home/api/home_api.dart';
import 'package:e_delivery_mobile/customer/screens/home/components/browse_restaurants_button.dart';
import 'package:e_delivery_mobile/customer/screens/home/components/home_greetings.dart';
import 'package:e_delivery_mobile/customer/screens/home/components/home_suggestions.dart';
import 'package:e_delivery_mobile/customer/screens/home/dto/recommended_restaurant_get_dto.dart';
import 'package:e_delivery_mobile/customer/screens/home/dto/restaurant_get_dto.dart';
import 'package:e_delivery_mobile/customer/screens/home/dto/user_data_dto.dart';

import 'package:e_delivery_mobile/storage_service.dart';
import 'package:flutter/material.dart';

class HomePage extends StatefulWidget {
  final VoidCallback onNavigateToRestaurants;

  const HomePage({Key? key, required this.onNavigateToRestaurants})
      : super(key: key);
  State<HomePage> createState() => _HomePageState();
}

class _HomePageState extends State<HomePage> {
  UserDataViewModel? _userDataViewModel;
  List<RestaurantViewModel> _restaurants = [];
  List<RestaurantViewModel> _filteredRestaurants = [];
  List<RecommendedRestaurantViewModel> _recommendedRestaurants = [];

  String _searchQuery = '';
  @override
  @override
  void initState() {
    super.initState();
    _loadUserData().then((_) {
      _fetchRecommendedRestaurants();
    });
  }

  Future<void> _fetchRecommendedRestaurants() async {
    try {
      final cityId = _userDataViewModel?.cityId;
      if (cityId != null) {
        final recommendedRestaurants =
            await RestaurantService().fetchRecommendedRestaurants();
        setState(() {
          _recommendedRestaurants = recommendedRestaurants;
        });
      }
    } catch (e) {
      print('Error fetching recommended restaurants: $e');
    }
  }

  Future<void> _loadUserData() async {
    try {
      final jwtToken = await StorageService.storage.read(key: 'jwt');

      if (jwtToken != null) {
        print("jwt exists");
      } else {
        print('No JWT token found in secure storage.');
      }
      final userId = await StorageService.storage.read(key: 'currentUserId');
      if (userId != null) {
        print('User ID from secure storage: $userId');
      } else {
        print('No user ID found in secure storage.');
      }

      final userDataJson = await StorageService.storage.read(key: 'userData');
      if (userDataJson != null) {
        final userData = jsonDecode(userDataJson);

        setState(() {
          _userDataViewModel = UserDataViewModel.fromJson(userData);
        });
        _fetchRestaurants();
      }
    } catch (e) {
      print('Error loading user data: $e');
    }
  }

  Future<void> _fetchRestaurants() async {
    try {
      final cityId = _userDataViewModel?.cityId;
      if (cityId != null) {
        final restaurants =
            await RestaurantService().fetchRestaurants(cityId, '');
        setState(() {
          _restaurants = restaurants;
          _filterRestaurants();
        });
      }
    } catch (e) {
      print('Error fetching restaurants: $e');
    }
  }

  void _filterRestaurants() {
    setState(() {
      _filteredRestaurants = _restaurants
          .where((restaurant) => restaurant.name
              .toLowerCase()
              .contains(_searchQuery.toLowerCase()))
          .toList();
    });
  }

  void _onSearchQueryChanged(String query) {
    setState(() {
      _searchQuery = query;
      _fetchRestaurants();
    });
  }

  void _onRestaurantSelected(RestaurantViewModel restaurant) {
    print('Selected restaurant: ${restaurant.name}');
  }

  @override
  Widget build(BuildContext context) {
    return SafeArea(
      child: SingleChildScrollView(
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            HomeGreetings(userDataViewModel: _userDataViewModel),
            SearchBox(
              onChanged: _onSearchQueryChanged,
              onRestaurantSelected: _onRestaurantSelected,
              restaurants: _filteredRestaurants,
            ),
            const SizedBox(height: 16),
            BrowseRestaurantsButton(
              onPressed: widget.onNavigateToRestaurants,
            ),
            const SizedBox(height: 16),
            HomeSuggestionSection(
                recommendedRestaurants: _recommendedRestaurants),
            const SizedBox(height: 16),
          ],
        ),
      ),
    );
  }
}
