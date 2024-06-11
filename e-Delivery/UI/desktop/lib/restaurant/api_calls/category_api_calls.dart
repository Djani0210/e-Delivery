import 'dart:convert';

import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import 'package:http/http.dart' as http;

class CategoryApiService {
  final _storage = const FlutterSecureStorage();
  final String _baseUrl = 'http://localhost:44395/api/';

  Future<String> _fetchJwtToken() async {
    String? jwt = await _storage.read(key: 'jwt');
    return jwt ?? '';
  }

  Future<String> _fetchRestaurantId() async {
    String? userData = await _storage.read(key: 'userData');
    if (userData != null) {
      Map<String, dynamic> userDataMap = jsonDecode(userData);
      return userDataMap['restaurantId'].toString();
    }
    return '';
  }

  Future<List<String>> fetchCategoriesWithFoodItems() async {
    String restaurantId = await _fetchRestaurantId();
    String url =
        '${_baseUrl}Category/get-categories-with-foodItems?restaurantId=$restaurantId';

    String jwtToken = await _fetchJwtToken();
    Map<String, String> headers = {
      'Authorization': 'Bearer $jwtToken',
      'Content-Type': 'application/json',
    };

    try {
      http.Response response = await http.get(Uri.parse(url), headers: headers);

      if (response.statusCode == 200) {
        Map<String, dynamic> jsonData = jsonDecode(response.body);
        List<dynamic> categoriesData = jsonData['data'];

        List<String> categoryNames = categoriesData
            .map((category) => category['name'] as String)
            .toList();
        print(categoryNames);
        return categoryNames;
      } else {
        print('Request failed with status: ${response.statusCode}');
        return [];
      }
    } catch (error) {
      print('Error: $error');
      return [];
    }
  }

  Future<List<Map<String, dynamic>>> fetchCategories() async {
    String url = '${_baseUrl}Category/get-categories';

    String jwtToken = await _fetchJwtToken();
    Map<String, String> headers = {
      'Authorization': 'Bearer $jwtToken',
      'Content-Type': 'application/json',
    };

    try {
      http.Response response = await http.get(Uri.parse(url), headers: headers);

      if (response.statusCode == 200) {
        Map<String, dynamic> jsonData = jsonDecode(response.body);
        List<dynamic> categoriesData = jsonData['data'];

        List<Map<String, dynamic>> categories = categoriesData.map((category) {
          return {
            'id': category['id'],
            'name': category['name'],
          };
        }).toList();

        return categories;
      } else {
        print('Request failed with status: ${response.statusCode}');
        return [];
      }
    } catch (error) {
      print('Error: $error');
      return [];
    }
  }
}
