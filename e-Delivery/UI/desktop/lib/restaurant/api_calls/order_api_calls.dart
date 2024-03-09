import 'dart:convert';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import 'package:http/http.dart' as http;

class OrderApiService {
  final _storage = const FlutterSecureStorage();
  final String _baseUrl = 'https://localhost:44395/api/';

  Future<String> _fetchJwtToken() async {
    // Adjust 'jwt' as necessary based on how you've stored the token
    String? jwt = await _storage.read(key: 'jwt');
    return jwt ?? '';
  }

  Future<http.Response?> getOrdersForRestaurant() async {
    String jwt = await _fetchJwtToken();
    try {
      final response = await http.get(
        Uri.parse('${_baseUrl}Order/get-Orders-For-Restaurant'),
        headers: {'Authorization': 'Bearer $jwt'},
      );
      if (response.statusCode == 200) {
        return response;
      }
    } catch (e) {
      print("Error fetching orders: $e");
      return null;
    }
    return null;
  }

  Future<int> getMonthlyOrderCount() async {
    // Fetch JWT token
    final jwt = await _fetchJwtToken();
    final response = await http.get(
      Uri.parse('${_baseUrl}Order/monthly-count'),
      headers: {'Authorization': 'Bearer $jwt'},
    );
    if (response.statusCode == 200) {
      return int.parse(response.body);
    } else {
      throw Exception('Failed to load monthly order count');
    }
  }
}
