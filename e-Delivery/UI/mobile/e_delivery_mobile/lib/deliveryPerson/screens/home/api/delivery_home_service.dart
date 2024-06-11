import 'dart:convert';

import 'package:e_delivery_mobile/customer/screens/profile/dto/order_get_dto.dart';
import 'package:e_delivery_mobile/deliveryPerson/screens/Home/dto/delivery_person_get_dto.dart';
import 'package:e_delivery_mobile/globals.dart';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';

import 'package:http/http.dart' as http;

class DeliveryHomeService {
  final _storage = const FlutterSecureStorage();
  final String _baseUrl = baseUrl;

  Future<String> _fetchJwtToken() async {
    String? jwt = await _storage.read(key: 'jwt');
    return jwt ?? '';
  }

  Future<DeliveryPersonGetDTO> fetchLoggedInUser() async {
    final jwt = await _fetchJwtToken();
    final apiUrl = '${_baseUrl}User/get-logged-delivery-person';

    try {
      final response = await http.get(
        Uri.parse(apiUrl),
        headers: {
          'Authorization': 'Bearer $jwt',
          'Content-Type': 'application/json',
        },
      );

      if (response.statusCode == 200) {
        final data = json.decode(response.body);

        if (data['isValid']) {
          var returnedData = DeliveryPersonGetDTO.fromJson(data['data']);

          return returnedData;
        } else {
          throw Exception(data['info']);
        }
      } else {
        throw Exception(
            'Failed to fetch logged in user ${response.statusCode}');
      }
    } catch (e) {
      throw Exception('Error loading user data: $e');
    }
  }

  Future<Map<String, dynamic>> fetchOrders({
    DateTime? startDate,
    DateTime? endDate,
    int? orderState,
    String? sortBy,
    int? pageNumber,
    int? pageSize,
  }) async {
    final jwt = await _fetchJwtToken();
    var apiUrl = '${_baseUrl}Order/get-Orders-For-DeliveryPerson?';

    if (startDate != null) {
      apiUrl += 'startDate=${startDate.toIso8601String()}&';
    }
    if (endDate != null) {
      apiUrl += 'endDate=${endDate.toIso8601String()}&';
    }
    if (orderState != null) {
      apiUrl += 'orderState=$orderState&';
    }
    if (sortBy != null) {
      apiUrl += 'sortBy=$sortBy&';
    }
    if (pageNumber != null) {
      apiUrl += 'pageNumber=$pageNumber&';
    }
    if (pageSize != null) {
      apiUrl += 'pageSize=$pageSize&';
    }

    try {
      final response = await http.get(
        Uri.parse(apiUrl),
        headers: {
          'Authorization': 'Bearer $jwt',
        },
      );

      if (response.statusCode == 200) {
        final data = json.decode(response.body);

        if (data['isValid']) {
          final ordersJson = data['data']['orders'] as List;
          final orders = ordersJson
              .map((orderJson) => OrderGetDto.fromJson(orderJson))
              .toList();

          final paginationData = {
            'totalCount': data['data']['totalCount'],
            'currentPage': data['data']['currentPage'],
            'totalPages': data['data']['totalPages'],
          };

          return {'orders': orders, 'pagination': paginationData};
        } else {
          throw Exception(data['info']);
        }
      } else {
        throw Exception(
            'Failed to load orders with status code ${response.statusCode}');
      }
    } catch (e) {
      print("Error fetching orders: $e");
      throw Exception('Error fetching orders: $e');
    }
  }
}
