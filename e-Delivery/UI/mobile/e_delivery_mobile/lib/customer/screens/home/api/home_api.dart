import 'dart:convert';
import 'package:e_delivery_mobile/customer/screens/home/dto/recommended_restaurant_get_dto.dart';
import 'package:e_delivery_mobile/customer/screens/home/dto/restaurant_get_dto.dart';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import 'package:http/http.dart' as http;

class RestaurantService {
  static const String baseUrl = 'http://10.0.2.2:44395/api';

  final _storage = const FlutterSecureStorage();

  Future<String> _fetchJwtToken() async {
    String? jwt = await _storage.read(key: 'jwt');
    return jwt ?? '';
  }

  Future<List<RestaurantViewModel>> fetchRestaurants(
      int cityId, String? name) async {
    String jwt = await _fetchJwtToken();
    final url = '$baseUrl/Restaurant/get-Restaurants?id=$cityId&name=$name';
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
      throw Exception('Failed to fetch restaurants');
    }
  }

  Future<List<RecommendedRestaurantViewModel>>
      fetchRecommendedRestaurants() async {
    String jwt = await _fetchJwtToken();
    const url = '$baseUrl/Restaurant/get-recommended-restaurants';
    final response = await http
        .get(Uri.parse(url), headers: {'Authorization': 'Bearer $jwt'});

    if (response.statusCode == 200) {
      print("yes");
      final data = jsonDecode(response.body);
      if (data['isValid']) {
        final restaurantsData = data['data'] as List<dynamic>;
        return restaurantsData
            .map((json) => RecommendedRestaurantViewModel.fromJson(json))
            .toList();
      } else {
        throw Exception('Failed to fetch restaurants: ${data['info']}');
      }
    } else {
      throw Exception('Failed to fetch restaurants');
    }
  }
}
