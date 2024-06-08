import 'dart:convert';

import 'package:http/http.dart' as http;

class ApiClient {
  static Future<dynamic> post(String url,
      {required Map<String, dynamic> body}) async {
    try {
      print('Request body: $body');
      final response = await http.post(
        Uri.parse(url),
        headers: {'Content-Type': 'application/json'},
        body: jsonEncode(body),
      );

      if (response.statusCode == 200) {
        return jsonDecode(response.body);
      } else {
        throw Exception('Request failed with status: ${response.statusCode}');
      }
    } catch (e) {
      print('An error occurred during API call: $e');

      throw e;
    }
  }
}
