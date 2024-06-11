import 'dart:async';

import 'package:desktop/globals.dart';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import 'package:http/http.dart' as http;

class RestaurantAdminService {
  final _storage = const FlutterSecureStorage();

  Future<String?> _fetchJwtToken() async {
    String? jwt = await _storage.read(key: 'jwt');
    return jwt;
  }

  Future<bool> deleteRestaurantAndRelatedEntities(int restaurantId) async {
    try {
      String? jwt = await _fetchJwtToken();
      if (jwt == null) {
        throw Exception('JWT token not found');
      }

      Map<String, String> headers = {
        'Content-Type': 'application/json',
        'Authorization': 'Bearer $jwt',
      };

      Uri uri =
          Uri.parse('${baseUrl}Restaurant/delete-Restaurant?id=$restaurantId');

      var response = await http.delete(uri, headers: headers);

      if (response.statusCode == 200) {
        return true;
      } else {
        throw Exception('Failed to delete restaurant');
      }
    } catch (e) {
      throw Exception('Error: $e');
    }
  }

  Future<http.Response> getRestaurants({
    int pageNumber = 1,
    String? name,
    int? cityId,
  }) async {
    try {
      String? jwt = await _fetchJwtToken();
      if (jwt == null) {
        throw Exception('JWT token not found');
      }

      var queryParams = {
        'items_per_page': '10',
        'pageNumber': pageNumber.toString(),
      };

      Map<String, String> headers = {
        'Content-Type': 'application/json',
        'Authorization': 'Bearer $jwt',
      };

      Uri uri = Uri.parse('${baseUrl}Restaurant/get-Restaurants-For-Admin')
          .replace(queryParameters: queryParams);

      if (name != null && name.isNotEmpty) {
        uri = uri.replace(queryParameters: {'name': name});
      }

      if (cityId != null) {
        uri = uri.replace(queryParameters: {'cityId': cityId.toString()});
      }

      var response = await http.get(uri, headers: headers);

      if (response.statusCode == 200) {
        return response;
      } else {
        throw Exception('Failed to fetch restaurants');
      }
    } catch (e) {
      throw Exception('Error: $e');
    }
  }

  Future<http.Response> getCities() async {
    String? jwtToken = await _fetchJwtToken();

    Map<String, String> headers = {
      'Content-Type': 'application/json',
      'Authorization': 'Bearer $jwtToken',
    };

    Uri uri = Uri.parse('${baseUrl}City/get-cities');

    final response = await http.get(uri, headers: headers);

    if (response.statusCode == 200) {
      return response;
    } else {
      throw Exception('Failed to fetch cities');
    }
  }
}
