import 'dart:async';
import 'dart:convert';
import 'package:e_delivery_mobile/customer/screens/auth/dto/customer_create_dto.dart';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import 'package:http/http.dart' as http;

class RegisterUserService {
  Map<String, dynamic>? errorResponse;
  final _storage = const FlutterSecureStorage();
  final String _baseUrl = 'https://10.0.2.2:44395/api/';

  Future<String?> _fetchJwtToken() async {
    String? jwt = await _storage.read(key: 'jwt');
    return jwt;
  }

  Future<http.Response> getCities() async {
    String? jwtToken = await _fetchJwtToken();

    Map<String, String> headers = {
      'Content-Type': 'application/json',
      'Authorization': 'Bearer $jwtToken',
    };

    Uri uri = Uri.parse('${_baseUrl}City/get-cities');

    final response = await http.get(uri, headers: headers);

    if (response.statusCode == 200) {
      return response;
    } else {
      throw Exception('Failed to fetch cities');
    }
  }

  Future<bool> registerCustomer(String phoneNumber, String userName,
      String email, String password, int? cityId) async {
    try {
      CustomerCreateDTO userCreateDTO = CustomerCreateDTO(
        phoneNumber: phoneNumber,
        userName: userName,
        email: email,
        password: password,
        workFrom: "00:00",
        workUntil: "00:00",
        cityId: cityId,
        userRoles: ["67c0d30a-d873-4f9b-a143-08dc2a5ba67c"],
      );

      String userCreateJson = jsonEncode(userCreateDTO.toJson());
      print('Request body: $userCreateJson');

      final response = await http.post(
        Uri.parse('${_baseUrl}User'),
        headers: {'Content-Type': 'application/json'},
        body: userCreateJson,
      );

      if (response.statusCode == 200) {
        print('User registration successful');
        return true;
      } else {
        print('User registration failed');
        print('Status code: ${response.statusCode}');
        print('Response body: ${response.body}');

        final errorResponseBody = jsonDecode(response.body);
        errorResponse = errorResponseBody;

        if (response.statusCode == 400) {
          print('Bad request: ${errorResponse!['info']}');
        } else if (response.statusCode == 401) {
          print('Unauthorized: ${errorResponse!['info']}');
        } else if (response.statusCode == 409) {
          print('Conflict: ${errorResponse!['info']}');
        } else {
          print('Error: ${errorResponse!['info']}');
        }

        return false;
      }
    } catch (error) {
      print('Exception occurred during user registration: $error');
      return false;
    }
  }

  Future<bool> registerDeliveryPerson(
      String phoneNumber,
      String userName,
      String email,
      String password,
      int? cityId,
      String workFrom,
      String workUntil) async {
    try {
      CustomerCreateDTO userCreateDTO = CustomerCreateDTO(
        phoneNumber: phoneNumber,
        userName: userName,
        email: email,
        password: password,
        workFrom: workFrom,
        workUntil: workUntil,
        cityId: cityId,
        userRoles: ["7d7168d4-ef7e-4503-a144-08dc2a5ba67c"],
      );

      String userCreateJson = jsonEncode(userCreateDTO.toJson());
      print('Request body: $userCreateJson');

      final response = await http.post(
        Uri.parse('${_baseUrl}User'),
        headers: {'Content-Type': 'application/json'},
        body: userCreateJson,
      );

      if (response.statusCode == 200) {
        print('User registration successful');
        return true;
      } else {
        print('User registration failed');
        print('Status code: ${response.statusCode}');
        print('Response body: ${response.body}');

        final errorResponseBody = jsonDecode(response.body);
        errorResponse = errorResponseBody;

        if (response.statusCode == 400) {
          print('Bad request: ${errorResponse!['info']}');
        } else if (response.statusCode == 401) {
          print('Unauthorized: ${errorResponse!['info']}');
        } else if (response.statusCode == 409) {
          print('Conflict: ${errorResponse!['info']}');
        } else {
          print('Error: ${errorResponse!['info']}');
        }

        return false;
      }
    } catch (error) {
      print('Exception occurred during user registration: $error');
      return false;
    }
  }
}
