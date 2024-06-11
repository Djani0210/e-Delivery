import 'dart:convert';
import 'dart:io';

import 'package:e_delivery_mobile/customer/screens/profile/dto/notification_get_dto.dart';
import 'package:e_delivery_mobile/globals.dart';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import 'package:http/http.dart' as http;

class NotificationApiService {
  final _storage = const FlutterSecureStorage();
  final String _baseUrl = baseUrl;

  Future<String> _fetchJwtToken() async {
    String? jwt = await _storage.read(key: 'jwt');
    return jwt ?? '';
  }

  Future<List<GetNotificationVM>> getNotifications() async {
    final token = await _fetchJwtToken();
    final response = await http.get(
      Uri.parse('${_baseUrl}Notification/get-notifications'),
      headers: {
        HttpHeaders.authorizationHeader: 'Bearer $token',
      },
    );

    if (response.statusCode == 200) {
      List<dynamic> body = jsonDecode(response.body)['data'];
      return body
          .map((dynamic item) => GetNotificationVM.fromJson(item))
          .toList();
    } else {
      throw Exception('Failed to load notifications');
    }
  }

  Future<void> deleteNotification(int id) async {
    final token = await _fetchJwtToken();
    final response = await http.patch(
      Uri.parse('${_baseUrl}Notification/delete-notification?id=$id'),
      headers: {
        HttpHeaders.authorizationHeader: 'Bearer $token',
      },
    );

    if (response.statusCode != 200) {
      throw Exception('Failed to delete notification');
    }
  }

  Future<void> deleteAllNotifications() async {
    final token = await _fetchJwtToken();
    final response = await http.delete(
      Uri.parse('${_baseUrl}Notification/delete-all-notifications'),
      headers: {
        HttpHeaders.authorizationHeader: 'Bearer $token',
      },
    );

    if (response.statusCode != 200) {
      throw Exception('Failed to delete all notifications');
    }
  }
}
