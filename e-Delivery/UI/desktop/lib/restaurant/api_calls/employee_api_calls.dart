import 'dart:convert';

import 'package:desktop/globals.dart';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';

import 'package:http/http.dart' as http;

class EmployeeApiService {
  final _storage = const FlutterSecureStorage();
  final String _baseUrl = baseUrl;

  Future<String> _fetchJwtToken() async {
    String? jwt = await _storage.read(key: 'jwt');
    return jwt ?? '';
  }

  Future<http.Response?> getRestaurantEmployees({
    int pageNumber = 1,
    int itemsPerPage = 3,
    bool? isAvailable,
    String? username,
  }) async {
    String jwt = await _fetchJwtToken();
    var queryParams = {
      'items_per_page': '$itemsPerPage',
      'pageNumber': '$pageNumber',
      if (isAvailable != null) 'isAvailable': isAvailable.toString(),
      if (username != null && username.isNotEmpty) 'username': username,
    };

    final url = Uri.parse('${_baseUrl}Restaurant/get-Restaurant-Employees')
        .replace(queryParameters: queryParams);
    try {
      final response = await http.get(
        url,
        headers: {'Authorization': 'Bearer $jwt'},
      );
      return response.statusCode == 200 ? response : null;
    } catch (e) {
      print("Error fetching employees: $e");
      return null;
    }
  }

  Future<bool> removeEmployee(String id) async {
    final jwt = await _fetchJwtToken();

    final apiUrl = Uri.parse('${_baseUrl}Restaurant/remove-Employee')
        .replace(queryParameters: {'id': id});

    try {
      final response = await http.put(
        apiUrl,
        headers: {
          'Content-Type': 'application/json',
          'Authorization': 'Bearer $jwt',
        },
      );

      if (response.statusCode == 200) {
        print("Employee successfully removed");
        return true;
      } else {
        print(
            "Failed to remove employee with status code: ${response.statusCode}");
        return false;
      }
    } catch (e) {
      print("Error removing employee: $e");
      return false;
    }
  }

  Future<String> fetchImageUrl(String id) async {
    final jwt = await _fetchJwtToken();
    final apiUrl = '${_baseUrl}File/get-Profile-Pic-By-Id/$id';

    try {
      final response = await http.get(
        Uri.parse(apiUrl),
        headers: {
          'Authorization': 'Bearer $jwt',
        },
      );

      if (response.statusCode == 200) {
        final data = json.decode(response.body);
        if (data['data'] != null) {
          final String imagePath = data['data']['path'];

          final String baseFileUrl = _baseUrl.replaceAll('/api/', '');
          final String fullImageUrl = baseFileUrl + imagePath;

          return fullImageUrl;
        } else {
          throw Exception('No image data found');
        }
      } else {
        throw Exception(
            'Failed to load image URL with status code ${response.statusCode}');
      }
    } catch (e) {
      print("Error fetching image URL: $e");
      throw Exception('Error fetching image URL: $e');
    }
  }
}
