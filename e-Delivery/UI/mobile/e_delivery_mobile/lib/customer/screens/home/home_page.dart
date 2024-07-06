import 'package:e_delivery_mobile/customer/core/components/search_box.dart';
import 'package:e_delivery_mobile/customer/screens/home/api/home_api.dart';
import 'package:e_delivery_mobile/customer/screens/home/components/browse_restaurants_button.dart';
import 'package:e_delivery_mobile/customer/screens/home/components/home_greetings.dart';
import 'package:e_delivery_mobile/customer/screens/home/components/home_suggestions.dart';
import 'package:e_delivery_mobile/customer/screens/home/dto/recommended_restaurant_get_dto.dart';
import 'package:e_delivery_mobile/customer/screens/home/dto/restaurant_get_dto.dart';
import 'package:e_delivery_mobile/customer/screens/profile/api/profile_api.dart';
import 'package:e_delivery_mobile/customer/screens/profile/dto/customer_get_dto.dart';
import 'package:e_delivery_mobile/customer/screens/restaurants/restaurant_details_page.dart';
import 'package:flutter/material.dart';

class HomePage extends StatefulWidget {
  final VoidCallback onNavigateToRestaurants;

  const HomePage({Key? key, required this.onNavigateToRestaurants})
      : super(key: key);
  State<HomePage> createState() => _HomePageState();
}

class _HomePageState extends State<HomePage> {
  CustomerGetDto? _userDataViewModel;

  List<RestaurantViewModel> _filteredRestaurants = [];
  List<RecommendedRestaurantViewModel> _recommendedRestaurants = [];
  List<RestaurantViewModel> _allRestaurants = [];

  @override
  void initState() {
    super.initState();
    _loadUserData().then((_) {
      _fetchRecommendedRestaurants();
      _fetchRestaurants();
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
      _userDataViewModel = await ProfileService().fetchLoggedInUser();
      setState(() {
        _fetchRestaurants();
      });
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
          _allRestaurants = restaurants;
          _filteredRestaurants = restaurants;
        });
      }
    } catch (e) {
      print('Error fetching restaurants: $e');
    }
  }

  void _filterRestaurants(String query) {
    setState(() {
      _filteredRestaurants = _allRestaurants
          .where((restaurant) =>
              restaurant.name.toLowerCase().contains(query.toLowerCase()))
          .toList();
    });
  }

  void _onSearchQueryChanged(String query) {
    _filterRestaurants(query);
  }

  void _onRestaurantSelected(RestaurantViewModel restaurant) {
    if (restaurant.isOpen) {
      Navigator.of(context).push(
        MaterialPageRoute(
          builder: (context) => RestaurantDetails(restaurantId: restaurant.id),
        ),
      );
    } else {
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          content: Text('Restaurant is currently closed, try later'),
          duration: Duration(seconds: 2),
        ),
      );
    }
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
