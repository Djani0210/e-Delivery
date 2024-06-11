import 'dart:convert';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import 'package:http/http.dart' as http;
import 'package:desktop/restaurant/viewmodels/food_item_get_VM.dart';

class SideDishApiService {
  final _storage = const FlutterSecureStorage();
  final String _baseUrl = 'http://localhost:44395/api/';

  Future<String> _fetchJwtToken() async {
    String? jwt = await _storage.read(key: 'jwt');
    return jwt ?? '';
  }

  Future<List<SideDishViewModel>> getSideDishes() async {
    String jwt = await _fetchJwtToken();
    final url = '${_baseUrl}SideDish/get-SideDishes';
    final response = await http
        .get(Uri.parse(url), headers: {'Authorization': 'Bearer $jwt'});

    if (response.statusCode == 200) {
      List<dynamic> jsonList = json.decode(response.body)['data'];
      return jsonList
          .map((jsonItem) => SideDishViewModel.fromJson(jsonItem))
          .toList();
    } else {
      throw Exception('Failed to load side dishes');
    }
  }

  Future<SideDishViewModel> getSideDishById(int id) async {
    String jwt = await _fetchJwtToken();
    final url = '${_baseUrl}SideDish/get-SideDish-By-Id?id=$id';
    final response = await http
        .get(Uri.parse(url), headers: {'Authorization': 'Bearer $jwt'});

    if (response.statusCode == 200) {
      Map<String, dynamic> jsonData = json.decode(response.body)['data'];
      return SideDishViewModel.fromJson(jsonData);
    } else {
      throw Exception('Failed to load side dish by ID');
    }
  }

  Future<void> deleteSideDish(int id) async {
    String jwt = await _fetchJwtToken();
    final url = '${_baseUrl}SideDish/delete-SideDish?id=$id';
    final response = await http.delete(
      Uri.parse(url),
      headers: {'Authorization': 'Bearer $jwt'},
    );

    if (response.statusCode == 200) {
      // Handle success
      print("Side dish deleted successfully");
    } else {
      // Handle error
      throw Exception(
          'Failed to delete side dish ${response.statusCode} ${response.body}');
    }
  }

  Future<void> updateSideDish(
      int id, String name, double price, bool isAvailable) async {
    String jwt = await _fetchJwtToken();
    final url = '${_baseUrl}SideDish/update-SideDish?id=$id';
    final response = await http.put(
      Uri.parse(url),
      headers: {
        'Content-Type': 'application/json',
        'Authorization': 'Bearer $jwt'
      },
      body: json.encode(
          {'id': id, 'name': name, 'price': price, 'isAvailable': isAvailable}),
    );

    if (response.statusCode == 200) {
      // Handle success
      print("Side dish updated successfully");
    } else {
      // Handle error
      throw Exception(
          'Failed to update side dish ${response.statusCode} ${response.body}');
    }
  }

  Future<void> createSideDish(
      String name, double price, bool isAvailable) async {
    String jwt = await _fetchJwtToken();
    final url = '${_baseUrl}SideDish/add-SideDish';
    final response = await http.post(
      Uri.parse(url),
      headers: {
        'Content-Type': 'application/json',
        'Authorization': 'Bearer $jwt'
      },
      body: json
          .encode({'name': name, 'price': price, 'isAvailable': isAvailable}),
    );

    if (response.statusCode == 200) {
      // Handle success
      print("Side dish created successfully");
    } else {
      // Handle error
      throw Exception(
          'Failed to create side dish ${response.statusCode} ${response.body}');
    }
  }
}
