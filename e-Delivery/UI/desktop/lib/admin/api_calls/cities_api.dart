import 'dart:async';
import 'dart:convert';
import 'dart:io';

import 'package:desktop/globals.dart';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import 'package:http/http.dart' as http;

class CityApiService {
  final _storage = const FlutterSecureStorage();

  Future<String?> _fetchJwtToken() async {
    String? jwt = await _storage.read(key: 'jwt');
    return jwt;
  }

  Future<http.Response> addCity(CityCreateVM cityCreateVM) async {
    String? jwtToken = await _fetchJwtToken();
    Map<String, String> headers = {
      'Content-Type': 'application/json',
      'Authorization': 'Bearer $jwtToken',
    };

    final response = await http.post(
      Uri.parse('${baseUrl}City/add-city'),
      headers: headers,
      body: jsonEncode(cityCreateVM.toJson()),
    );

    return response;
  }

  Future<http.Response> getCities({
    String? title,
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

    Uri uri = Uri.parse('${baseUrl}City/get-cities-filtered')
        .replace(queryParameters: queryParams);
    if (title != null) {
      uri = uri.replace(queryParameters: {'title': title});
    }

    final response = await http.get(uri, headers: headers);

    return response;
  }

  Future<http.Response> getCityById(int id) async {
    String? jwtToken = await _fetchJwtToken();
    Map<String, String> headers = {
      'Content-Type': 'application/json',
      'Authorization': 'Bearer $jwtToken',
    };

    final response = await http.get(
      Uri.parse('${baseUrl}City/get-city/$id'),
      headers: headers,
    );

    return response;
  }

  Future<http.Response> updateCity(int id, String title) async {
    String? jwtToken = await _fetchJwtToken();
    Map<String, String> headers = {
      'Content-Type': 'application/json',
      'Authorization': 'Bearer $jwtToken',
    };

    try {
      final response = await http.put(
        Uri.parse('${baseUrl}City/update-city?id=$id'),
        headers: headers,
        body: jsonEncode({'Title': title}), // Change this line
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

class CityCreateVM {
  final String title;

  CityCreateVM({required this.title});

  Map<String, dynamic> toJson() => {
        'title': title,
      };
}
