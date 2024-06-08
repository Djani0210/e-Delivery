import 'dart:convert';

import 'package:e_delivery_mobile/customer/screens/chat/dto/chat_get_dto.dart';
import 'package:e_delivery_mobile/customer/screens/profile/dto/customer_get_dto.dart';
import 'package:e_delivery_mobile/deliveryPerson/screens/home/dto/delivery_person_get_dto.dart';
import 'package:e_delivery_mobile/signalr_service.dart';

import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import 'package:http/http.dart' as http;

class ChatService {
  static const String baseUrl = 'https://10.0.2.2:44395/api';

  final _storage = const FlutterSecureStorage();
  final SignalRService _signalRService = SignalRService();
  Future<String> _fetchJwtToken() async {
    String? jwt = await _storage.read(key: 'jwt');
    return jwt ?? '';
  }

  Future<String> _fetchUserId() async {
    String? userId = await _storage.read(key: 'currentUserId');
    return userId ?? '';
  }

  Future<List<DeliveryPersonGetDTO>> fetchDeliveryPersons() async {
    final jwt = await _fetchJwtToken();
    final apiUrl = '$baseUrl/Chat/connected-delivery-persons';

    try {
      final response = await http.get(
        Uri.parse(apiUrl),
        headers: {
          'Authorization': 'Bearer $jwt',
        },
      );

      if (response.statusCode == 200) {
        final data = json.decode(response.body);
        if (data['data'] != null) {
          final List<dynamic> deliveryPersonsData = data['data'];
          return deliveryPersonsData
              .map((json) => DeliveryPersonGetDTO.fromJson(json))
              .toList();
        } else {
          throw Exception('No delivery persons data found');
        }
      } else {
        throw Exception(
            'Failed to fetch delivery persons with status code ${response.statusCode}');
      }
    } catch (e) {
      print("Error fetching delivery persons: $e");
      throw Exception('Error fetching delivery persons: $e');
    }
  }

  Future<List<CustomerGetDto>> fetchCustomersForChat() async {
    final jwt = await _fetchJwtToken();
    final apiUrl = '$baseUrl/Chat/connected-customers';

    try {
      final response = await http.get(
        Uri.parse(apiUrl),
        headers: {
          'Authorization': 'Bearer $jwt',
        },
      );

      if (response.statusCode == 200) {
        final data = json.decode(response.body);
        if (data['data'] != null) {
          final List<dynamic> deliveryPersonsData = data['data'];
          return deliveryPersonsData
              .map((json) => CustomerGetDto.fromJson(json))
              .toList();
        } else {
          throw Exception('No customer data found');
        }
      } else {
        throw Exception(
            'Failed to fetch customers with status code ${response.statusCode}');
      }
    } catch (e) {
      print("Error fetching customers: $e");
      throw Exception('Error fetching customers: $e');
    }
  }

  Future<List<ChatGetDto>> fetchChatHistory(String deliveryPersonId) async {
    final jwt = await _fetchJwtToken();
    final apiUrl = '$baseUrl/Chat/chat-history/$deliveryPersonId';

    try {
      final response = await http.get(
        Uri.parse(apiUrl),
        headers: {
          'Authorization': 'Bearer $jwt',
        },
      );

      if (response.statusCode == 200) {
        final data = json.decode(response.body);
        if (data['data'] != null) {
          final List<dynamic> chatData = data['data'];
          return chatData.map((json) => ChatGetDto.fromJson(json)).toList();
        } else {
          return [];
        }
      } else {
        throw Exception(
            'Failed to fetch chat history with status code ${response.statusCode}');
      }
    } catch (e) {
      print("Error fetching chat history: $e");
      throw Exception('Error fetching chat history: $e');
    }
  }

  Future<ChatGetDto?> sendMessage(
      String deliveryPersonId, String content) async {
    final jwt = await _fetchJwtToken();
    final apiUrl = '$baseUrl/Chat/send-message';

    try {
      final response = await http.post(
        Uri.parse(apiUrl),
        headers: {
          'Authorization': 'Bearer $jwt',
          'Content-Type': 'application/json',
        },
        body: json.encode({
          'userToId': deliveryPersonId,
          'content': content,
        }),
      );

      if (response.statusCode == 200) {
        final data = json.decode(response.body);
        if (data['data'] != null) {
          final chatData = data['data'];
          final sentMessage = ChatGetDto.fromJson(chatData);

          await _signalRService.sendMessage(deliveryPersonId, content);
          return sentMessage;
        }
      } else {
        throw Exception(
            'Failed to send message with status code ${response.statusCode}');
      }
    } catch (e) {
      print("Error sending message: $e");
      throw Exception('Error sending message: $e');
    }
    return null;
  }

  Future<void> deleteMessage(String messageId) async {
    final jwt = await _fetchJwtToken();
    final apiUrl = '$baseUrl/Chat/delete-message/$messageId';

    try {
      final response = await http.delete(
        Uri.parse(apiUrl),
        headers: {
          'Authorization': 'Bearer $jwt',
        },
      );

      if (response.statusCode != 200) {
        throw Exception(
            'Failed to delete message with status code ${response.statusCode}');
      }
    } catch (e) {
      print("Error deleting message: $e");
      throw Exception('Error deleting message: $e');
    }
  }
}
