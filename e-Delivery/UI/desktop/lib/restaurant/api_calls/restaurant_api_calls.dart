import 'dart:convert';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import 'package:http/http.dart' as http;

class ApiService {
  final _storage = FlutterSecureStorage();
  static const _baseUrl =
      'http://localhost:44395/api/Restaurant/get-RestaurantById';

  Future<dynamic> getRestaurantById(int id) async {
    final jwt = await _storage.read(key: 'jwt');
    final response = await http.get(Uri.parse('$_baseUrl?id=$id'),
        headers: {'Authorization': 'Bearer $jwt'});

    if (response.statusCode == 200) {
      return json.decode(response.body);
    } else {
      throw Exception('Failed to load restaurant');
    }
  }

  Future<dynamic> updateRestaurant(
      int id, Map<String, dynamic> updateData) async {
    final jwt = await _storage.read(key: 'jwt');
    final response = await http.put(
      Uri.parse(
          'http://localhost:44395/api/Restaurant/update-Restaurant?id=$id'),
      headers: {
        'Authorization': 'Bearer $jwt',
        'Content-Type': 'application/json',
      },
      body: json.encode(updateData),
    );

    if (response.statusCode == 200) {
      return json.decode(response.body);
    } else {
      throw Exception('Failed to update restaurant');
    }
  }
}
