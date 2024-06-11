import 'dart:convert';

import 'package:flutter_secure_storage/flutter_secure_storage.dart';

import 'package:http/http.dart' as http;

class DeliveryOrderService {
  final _storage = const FlutterSecureStorage();
  final String _baseUrl = 'http://10.0.2.2:44395/api/';

  Future<String> _fetchJwtToken() async {
    String? jwt = await _storage.read(key: 'jwt');
    return jwt ?? '';
  }

  Future<void> updateOrderState(String orderId, int orderState) async {
    final jwt = await _fetchJwtToken();
    final apiUrl = '${_baseUrl}Order/$orderId/state';
    final response = await http.patch(
      Uri.parse(apiUrl),
      headers: {
        'Authorization': 'Bearer $jwt',
        'Content-Type': 'application/json',
      },
      body: jsonEncode({'newState': orderState}),
    );

    if (response.statusCode != 200) {
      throw Exception('Failed to update order state: ${response.body}');
    }
  }
}
