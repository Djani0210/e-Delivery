import 'dart:convert';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import 'package:http/http.dart' as http;

class ApiService {
  final _storage = FlutterSecureStorage();
  static const _baseUrl =
      'https://localhost:44395/api/Restaurant/get-RestauantById';

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
}
