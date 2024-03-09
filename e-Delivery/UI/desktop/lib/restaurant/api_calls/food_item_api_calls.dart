import 'dart:convert';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import 'package:http/http.dart' as http;

class FoodItemApiService {
  final _storage = const FlutterSecureStorage();
  final String _baseUrl = 'https://localhost:44395/api/';

  Future<String> _fetchJwtToken() async {
    // Adjust 'jwt' as necessary based on how you've stored the token
    String? jwt = await _storage.read(key: 'jwt');
    return jwt ?? '';
  }

  Future<String> GetMostFrequentFoodItem() async {
    String jwt = await _fetchJwtToken();
    final response = await http.get(
      Uri.parse('${_baseUrl}FoodItem/get-Most-Frequent'),
      headers: {'Authorization': 'Bearer $jwt'},
    );
    if (response.statusCode == 200) {
      final decodedBody = json.decode(response.body);
      return decodedBody['name']; // This returns a String now
    } else {
      throw Exception("Failed to fetch most frequent food item");
    }
  }
}
