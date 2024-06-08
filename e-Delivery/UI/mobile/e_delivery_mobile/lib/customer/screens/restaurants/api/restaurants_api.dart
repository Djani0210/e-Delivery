import 'dart:convert';
import 'package:e_delivery_mobile/customer/screens/home/dto/restaurant_get_dto.dart';
import 'package:e_delivery_mobile/customer/screens/restaurants/dto/category_get_dto.dart';
import 'package:e_delivery_mobile/customer/screens/restaurants/dto/category_with_fooditems.dart';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import 'package:http/http.dart' as http;

class RestaurantsService {
  static const String baseUrl = 'https://10.0.2.2:44395/api';

  final _storage = const FlutterSecureStorage();

  Future<String> _fetchJwtToken() async {
    String? jwt = await _storage.read(key: 'jwt');
    return jwt ?? '';
  }

  Future<List<RestaurantViewModel>> fetchRestaurants(
      int cityId, String? name, int? categoryId) async {
    String jwt = await _fetchJwtToken();
    final url = '$baseUrl/Restaurant/get-Restaurants?id=$cityId&name=$name' +
        (categoryId != null ? '&categoryId=$categoryId' : '');
    final response = await http
        .get(Uri.parse(url), headers: {'Authorization': 'Bearer $jwt'});

    if (response.statusCode == 200) {
      final data = jsonDecode(response.body);
      if (data['isValid']) {
        final restaurantsData = data['data'] as List<dynamic>;
        return restaurantsData
            .map((json) => RestaurantViewModel.fromJson(json))
            .toList();
      } else {
        throw Exception('Failed to fetch restaurants: ${data['info']}');
      }
    } else {
      print(response.statusCode);
      print(response.body);
      throw Exception('Failed to fetch restaurants');
    }
  }

  Future<String> addOrUpdateReview(
      double grade, String description, int restaurantId) async {
    String jwt = await _fetchJwtToken();
    final url = '$baseUrl/Review/add-Review';
    final response = await http.post(
      Uri.parse(url),
      headers: {
        'Authorization': 'Bearer $jwt',
        'Content-Type': 'application/json',
      },
      body: jsonEncode({
        'grade': grade,
        'description': description,
        'restaurantId': restaurantId,
      }),
    );

    final data = jsonDecode(response.body);
    if (response.statusCode == 200) {
      if (data['isValid']) {
        return data['info'];
      } else {
        return (data['info']);
      }
    } else {
      return (data['info']);
    }
  }

  Future<RestaurantViewModel> fetchRestaurantById(int restaurantId) async {
    String jwt = await _fetchJwtToken();
    final url = '$baseUrl/Restaurant/get-RestaurantById?id=$restaurantId';
    final response = await http
        .get(Uri.parse(url), headers: {'Authorization': 'Bearer $jwt'});

    if (response.statusCode == 200) {
      final data = jsonDecode(response.body);
      if (data['isValid']) {
        final restaurantData = data['data'] as Map<String, dynamic>;
        return RestaurantViewModel.fromJson(restaurantData);
      } else {
        throw Exception('Failed to fetch restaurant: ${data['info']}');
      }
    } else {
      throw Exception('Failed to fetch restaurant');
    }
  }

  Future<List<CategoryViewModel>> fetchCategories() async {
    String jwt = await _fetchJwtToken();
    final url = '$baseUrl/Category/get-categories';
    final response = await http
        .get(Uri.parse(url), headers: {'Authorization': 'Bearer $jwt'});

    if (response.statusCode == 200) {
      final data = jsonDecode(response.body);
      if (data['isValid']) {
        final categoriesData = data['data'] as List<dynamic>;
        return categoriesData
            .map((json) => CategoryViewModel.fromJson(json))
            .toList();
      } else {
        throw Exception('Failed to fetch categories: ${data['info']}');
      }
    } else {
      print(response.statusCode);
      print(response.body);
      throw Exception('Failed to fetch categories' + response.body);
    }
  }

  Future<List<CategoryWithFoodItemsViewModel>> fetchCategoriesWithFoodItems(
      int restaurantId) async {
    String jwt = await _fetchJwtToken();
    final url =
        '$baseUrl/Category/get-categories-with-foodItems?restaurantId=$restaurantId';
    final response = await http
        .get(Uri.parse(url), headers: {'Authorization': 'Bearer $jwt'});

    if (response.statusCode == 200) {
      final data = jsonDecode(response.body);
      if (data['isValid']) {
        final categoriesData = data['data'] as List<dynamic>;
        return categoriesData
            .map((json) => CategoryWithFoodItemsViewModel.fromJson(json))
            .toList();
      } else {
        throw Exception(
            'Failed to fetch categories with food items: ${data['info']}');
      }
    } else {
      print(response.statusCode);
      print(response.body);
      throw Exception(
          'Failed to fetch categories with food items: ${response.body}');
    }
  }

  Future<double?> getReviewScoreForRestaurantMobile(int id) async {
    String jwt = await _fetchJwtToken();
    final url = '$baseUrl/Review/get-Review-Score-For-Restaurant-Mobile?id=$id';
    final response = await http
        .get(Uri.parse(url), headers: {'Authorization': 'Bearer $jwt'});

    if (response.statusCode == 200) {
      final data = response.body;
      {
        double? score = data.toString() == 'null' ? null : double.parse(data);
        if (score != null) {
          return score;
        } else {
          throw Exception('No reviews found for the restaurant.');
        }
      }
    } else if (response.statusCode == 404) {
      return 0.0;
    }
  }

  Future<String> deleteReview(int reviewId) async {
    String jwt = await _fetchJwtToken();
    final url = '$baseUrl/Review/delete-Review?id=$reviewId';
    final response = await http.delete(
      Uri.parse(url),
      headers: {
        'Authorization': 'Bearer $jwt',
        'Content-Type': 'application/json',
      },
    );

    final data = jsonDecode(response.body);
    if (response.statusCode == 200) {
      if (data['isValid']) {
        return data['info'];
      } else {
        return data['info'];
      }
    } else {
      throw Exception(data['info']);
    }
  }
}
