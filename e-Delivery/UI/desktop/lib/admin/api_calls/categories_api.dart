import 'dart:async';
import 'dart:convert';
import 'dart:io';

import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import 'package:http/http.dart' as http;

class CategoryService {
  final _storage = const FlutterSecureStorage();
  final String _baseUrl = 'https://localhost:44395/api/';

  Future<String?> _fetchJwtToken() async {
    String? jwt = await _storage.read(key: 'jwt');
    return jwt;
  }

  Future<http.Response> addCategory(CategoryCreateVM categoryCreateVM) async {
    String? jwtToken = await _fetchJwtToken();
    Map<String, String> headers = {
      'Content-Type': 'application/json',
      'Authorization': 'Bearer $jwtToken',
    };

    final response = await http.post(
      Uri.parse('${_baseUrl}Category/add-category'),
      headers: headers,
      body: jsonEncode(categoryCreateVM.toJson()),
    );

    return response;
  }

  Future<http.Response> getCategories({
    String? name,
    int pageNumber = 1,
    int itemsPerPage = 10,
  }) async {
    String? jwtToken = await _fetchJwtToken();
    var queryParams = {
      'items_per_page': '$itemsPerPage',
      'pageNumber': '$pageNumber',
    };
    Map<String, String> headers = {
      'Content-Type': 'application/json',
      'Authorization': 'Bearer $jwtToken',
    };

    Uri uri = Uri.parse('${_baseUrl}Category/get-categories-for-admin')
        .replace(queryParameters: queryParams);
    if (name != null) {
      uri = uri.replace(queryParameters: {'name': name});
    }

    final response = await http.get(uri, headers: headers);

    return response;
  }

  Future<http.Response> getCategoryById(int id) async {
    String? jwtToken = await _fetchJwtToken();
    Map<String, String> headers = {
      'Content-Type': 'application/json',
      'Authorization': 'Bearer $jwtToken',
    };

    final response = await http.get(
      Uri.parse('${_baseUrl}Category/get-category-by-id?id=$id'),
      headers: headers,
    );

    return response;
  }

  Future<http.Response> updateCategory(int id, String name) async {
    String? jwtToken = await _fetchJwtToken();
    Map<String, String> headers = {
      'Content-Type': 'application/json',
      'Authorization': 'Bearer $jwtToken',
    };

    try {
      final response = await http.put(
        Uri.parse('${_baseUrl}Category/update-category?id=$id'),
        headers: headers,
        body: jsonEncode({'Name': name}), // Change this line
      );

      return response;
    } on SocketException {
      return http.Response('Network error', 503);
    } on TimeoutException {
      return http.Response('Request timed out', 504);
    } catch (e) {
      return http.Response('Unknown error: $e', 500);
    }
  }
}

class CategoryCreateVM {
  final String name;

  CategoryCreateVM({required this.name});

  Map<String, dynamic> toJson() => {
        'name': name,
      };
}
