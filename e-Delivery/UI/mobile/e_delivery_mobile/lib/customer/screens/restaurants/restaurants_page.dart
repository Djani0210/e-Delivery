import 'package:e_delivery_mobile/customer/screens/home/dto/restaurant_get_dto.dart';
import 'package:e_delivery_mobile/customer/screens/profile/api/profile_api.dart';
import 'package:e_delivery_mobile/customer/screens/restaurants/api/restaurants_api.dart';
import 'package:e_delivery_mobile/customer/screens/restaurants/components/category_tile.dart';
import 'package:e_delivery_mobile/customer/screens/restaurants/dto/category_get_dto.dart';

import 'package:flutter/material.dart';
import 'package:e_delivery_mobile/customer/core/components/search_box.dart';
import 'package:e_delivery_mobile/customer/core/components/item_tiles_vertical.dart';

import 'package:e_delivery_mobile/customer/screens/restaurants/restaurant_details_page.dart';
import 'package:e_delivery_mobile/customer/screens/profile/dto/customer_get_dto.dart';

class RestaurantsPage extends StatefulWidget {
  const RestaurantsPage({Key? key}) : super(key: key);

  @override
  _RestaurantsPageState createState() => _RestaurantsPageState();
}

class _RestaurantsPageState extends State<RestaurantsPage> {
  List<CategoryViewModel> categories = [];
  List<RestaurantViewModel> _allrestaurants = [];
  List<RestaurantViewModel> _filteredRestaurants = [];

  CategoryViewModel? _selectedCategory;
  CustomerGetDto? userData;

  @override
  void initState() {
    super.initState();
    _loadCategories();
    _loadUserData().then((_) {
      _fetchRestaurants();
    });
  }

  @override
  void dispose() {
    super.dispose();
  }

  void _refreshRestaurants() {
    _loadUserData();
  }

  Future<void> _loadUserData() async {
    try {
      userData = await ProfileService().fetchLoggedInUser();
      setState(() {
        _fetchRestaurants();
      });
    } catch (e) {
      print('Error loading user data: $e');
    }
  }

  Future<void> _loadCategories() async {
    categories = await RestaurantsService().fetchCategories();

    categories.insert(0, CategoryViewModel(id: -1, name: 'All'));

    _selectedCategory = categories[0];
  }

  Future<void> _fetchRestaurants() async {
    try {
      final cityId = userData?.cityId;
      final categoryId =
          _selectedCategory?.id == -1 ? null : _selectedCategory?.id;
      if (cityId != null) {
        final restaurants = categoryId == null
            ? await RestaurantsService().fetchRestaurants(cityId, '', null)
            : await RestaurantsService()
                .fetchRestaurants(cityId, '', categoryId);
        for (var restaurant in restaurants) {
          double? score = await RestaurantsService()
              .getReviewScoreForRestaurantMobile(restaurant.id);
          restaurant.reviewScore = score;
        }

        setState(() {
          _allrestaurants = restaurants;
          _filteredRestaurants = restaurants;
        });
      }
    } catch (e) {
      print('Error fetching restaurants: $e');
    }
  }

  void _filterRestaurants(String query) {
    setState(() {
      _filteredRestaurants = _allrestaurants
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
    return Scaffold(
      appBar: AppBar(
        title: Text('Restaurants'),
        automaticallyImplyLeading: false,
      ),
      body: SingleChildScrollView(
        child: Column(
          children: [
            SearchBox(
              onRestaurantSelected: _onRestaurantSelected,
              restaurants: _filteredRestaurants,
              onChanged: _onSearchQueryChanged,
            ),
            SizedBox(height: 16),
            SizedBox(
              height: 50,
              child: ListView.builder(
                scrollDirection: Axis.horizontal,
                itemCount: categories.length,
                itemBuilder: (context, index) {
                  final category = categories[index];
                  return CategoryTile(
                      category: category,
                      isSelected: _selectedCategory == category,
                      onTap: () {
                        setState(() {
                          _selectedCategory = category;
                          _fetchRestaurants();
                        });
                      });
                },
              ),
            ),
            SizedBox(height: 16),
            ListView.separated(
              shrinkWrap: true,
              physics: NeverScrollableScrollPhysics(),
              itemCount: _allrestaurants.length,
              itemBuilder: (context, index) {
                final restaurant = _allrestaurants[index];
                return InkWell(
                  onTap: () {
                    if (restaurant.isOpen) {
                      Navigator.of(context).push(
                        MaterialPageRoute(
                          builder: (context) =>
                              RestaurantDetails(restaurantId: restaurant.id),
                        ),
                      );
                    } else {
                      ScaffoldMessenger.of(context).showSnackBar(
                        SnackBar(
                          content:
                              Text('Restaurant is currently closed, try later'),
                          duration: Duration(seconds: 2),
                        ),
                      );
                    }
                  },
                  child: ItemTilesVertical(
                    restaurantName: restaurant.name,
                    imageUrl: _getRestaurantImageUrl(restaurant),
                    address: restaurant.address,
                    deliveryCharge: restaurant.deliveryCharge,
                    deliveryTime: restaurant.deliveryTime,
                    rating: restaurant.reviewScore,
                    isOpen: restaurant.isOpen,
                  ),
                );
              },
              separatorBuilder: (context, index) {
                return Divider(
                  color: Colors.grey.shade300,
                  thickness: 1,
                );
              },
            ),
          ],
        ),
      ),
    );
  }

  String _getRestaurantImageUrl(RestaurantViewModel restaurant) {
    if (restaurant.logo != null && restaurant.logo!.path.isNotEmpty) {
      return restaurant.logo!.fullImageUrl;
    } else {
      return 'assets/images/no-image-found.jpg';
    }
  }
}
