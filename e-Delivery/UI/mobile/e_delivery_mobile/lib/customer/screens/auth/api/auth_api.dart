import 'dart:convert';
import 'package:e_delivery_mobile/storage_service.dart';
import 'package:http/http.dart' as http;

class LoginService {
  static const String apiBaseUrl = 'http://10.0.2.2:44395/api/Auth';

  Future<LoginResult> loginUser(String username, String password) async {
    try {
      final response = await http.post(
        Uri.parse(apiBaseUrl),
        headers: {'Content-Type': 'application/json'},
        body: jsonEncode({
          'username': username,
          'password': password,
        }),
      );

      switch (response.statusCode) {
        case 200:
          final responseBody = jsonDecode(response.body);
          final token = responseBody['token'];
          final userId = responseBody['userId'];
          final userDataJson = jsonEncode(responseBody);

          try {
            await StorageService.storage.write(key: 'jwt', value: token);
          } catch (e) {
            print('Error writing JWT to secure storage: $e');
          }

          try {
            await StorageService.storage
                .write(key: 'currentUserId', value: userId);
          } catch (e) {
            print('Error writing UserId to secure storage: $e');
          }

          try {
            await StorageService.storage
                .write(key: 'userData', value: userDataJson);
          } catch (e) {
            print('Error writing user data to secure storage: $e');
          }

          return LoginResult.success();
        case 400:
          return LoginResult.failure('Bad Request');
        case 401:
          return LoginResult.failure('Wrong username or password');
        case 403:
          return LoginResult.failure('Forbidden');
        default:
          return LoginResult.failure('Failed to load login data');
      }
    } catch (e) {
      print('An error occurred during login: $e');
      return LoginResult.failure('An error occurred during login');
    }
  }
}

class LoginResult {
  final bool success;
  final String? message;

  LoginResult.success()
      : success = true,
        message = null;
  LoginResult.failure(String message)
      : success = false,
        message = message;
}
