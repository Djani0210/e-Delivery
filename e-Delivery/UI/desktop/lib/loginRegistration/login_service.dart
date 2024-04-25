import 'dart:convert';
import 'package:http/http.dart' as http;
import 'package:desktop/components/storage_service.dart'; // Import the StorageService file

class LoginService {
  static const String apiBaseUrl = 'https://localhost:44395/api/Auth';

  Future<LoginResult> loginUser(String username, String password) async {
    try {
      final response = await http.post(
        Uri.parse('$apiBaseUrl'),
        headers: {'Content-Type': 'application/json'},
        body: jsonEncode({
          'Username': username,
          'Password': password,
        }),
      );

      if (response.statusCode == 200) {
        final responseBody = jsonDecode(response.body);
        final token = responseBody['token'];
        final userId = responseBody['userId'];
        final userDataJson = jsonEncode(responseBody);

        // Store the JWT token and UserId securely
        try {
          await Future.wait([
            StorageService.storage.write(key: 'jwt', value: token),
          ]);
        } catch (e) {
          print('Error writing to secure storage: $e');
        }

        try {
          await Future.wait([
            StorageService.storage.write(key: 'currentUserId', value: userId),
          ]);
        } catch (e) {
          print(e);
        }

        try {
          await Future.wait([
            StorageService.storage.write(key: 'userData', value: userDataJson)
          ]);
        } catch (e) {
          print(e);
        }

        return LoginResult.success();
      } else if (response.statusCode == 403) {
        return LoginResult.failure('Forbidden');
      } else if (response.statusCode == 401) {
        return LoginResult.failure('Wrong username or password');
      } else {
        print('Response status code: ${response.statusCode}');
        print('Response body: ${response.body}');
        return LoginResult.failure('Failed to load login data');
      }
    } catch (e) {
      // Handle the error
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
