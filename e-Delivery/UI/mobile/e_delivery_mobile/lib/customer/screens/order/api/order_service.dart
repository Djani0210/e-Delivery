import 'package:e_delivery_mobile/globals.dart';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';

class OrderService {
  final String _baseUrl = baseUrl;
  final storage = FlutterSecureStorage();

  Future<String> fetchJwt() async {
    String? jwtToken = await storage.read(key: 'jwt');
    return jwtToken ?? '';
  }

  Future<List<String>> getSideDishNames(List<int> sideDishIds) async {
    String jwtToken = await fetchJwt();
    final response = await http.post(
      Uri.parse('${_baseUrl}SideDish/sideDishes/names'),
      headers: <String, String>{
        'Authorization': 'Bearer $jwtToken',
        'Content-Type': 'application/json',
      },
      body: jsonEncode(sideDishIds),
    );

    if (response.statusCode == 200) {
      List<String> sideDishNames = (jsonDecode(response.body) as List<dynamic>)
          .map((name) => name.toString())
          .toList();
      return sideDishNames;
    } else {
      throw Exception('Failed to load side dish names');
    }
  }

  Future<String> getFoodItemNameById(int foodItemId) async {
    String jwtToken = await fetchJwt();
    final response = await http.get(
      Uri.parse('${_baseUrl}FoodItem/get-by-name$foodItemId'),
      headers: <String, String>{
        'Authorization': 'Bearer $jwtToken',
      },
    );

    if (response.statusCode == 200) {
      return response.body;
    } else {
      throw Exception('Failed to load food item name');
    }
  }

  Future<void> createOrder(Map<String, dynamic> orderData) async {
    String jwtToken = await fetchJwt();
    final response = await http.post(
      Uri.parse('${_baseUrl}Order/create-Order'),
      headers: <String, String>{
        'Authorization': 'Bearer $jwtToken',
        'Content-Type': 'application/json',
      },
      body: jsonEncode(orderData),
    );

    if (response.statusCode != 200) {
      throw Exception('Failed to create order');
    }
  }
}
