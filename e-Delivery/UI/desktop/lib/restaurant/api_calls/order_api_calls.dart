import 'dart:convert';
import 'package:desktop/globals.dart';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import 'package:http/http.dart' as http;
import 'package:intl/intl.dart';

class OrderApiService {
  final _storage = const FlutterSecureStorage();
  final String _baseUrl = baseUrl;

  Future<String> _fetchJwtToken() async {
    String? jwt = await _storage.read(key: 'jwt');
    return jwt ?? '';
  }

  Future<double?> getAverageRating() async {
    try {
      final jwt = await _fetchJwtToken();
      final response = await http.get(
        Uri.parse('${_baseUrl}Review/get-Review-Score-For-Restaurant'),
        headers: {'Authorization': 'Bearer $jwt'},
      );

      if (response.statusCode == 200) {
        return double.parse(response.body);
      } else {
        throw Exception(
            'Failed to load average rating: ${response.statusCode}');
      }
    } catch (e) {
      throw Exception('Failed to load average rating: $e');
    }
  }

  Future<http.Response?> getOrdersForRestaurant({
    int pageNumber = 1,
    int itemsPerPage = 4,
    DateTime? startDate,
    DateTime? endDate,
    int? orderState,
  }) async {
    String jwt = await _fetchJwtToken();

    String? startDateStr =
        startDate != null ? DateFormat('yyyy-MM-dd').format(startDate) : null;
    String? endDateStr =
        endDate != null ? DateFormat('yyyy-MM-dd').format(endDate) : null;

    var queryParams = {
      'items_per_page': '$itemsPerPage',
      'pageNumber': '$pageNumber',
      if (startDateStr != null) 'startDate': startDateStr,
      if (endDateStr != null) 'endDate': endDateStr,
      if (orderState != null) 'orderState': orderState.toString(),
    };

    final url = Uri.parse('${_baseUrl}Order/get-Orders-For-Restaurant')
        .replace(queryParameters: queryParams);
    try {
      final response = await http.get(
        url,
        headers: {'Authorization': 'Bearer $jwt'},
      );
      return response.statusCode == 200 ? response : null;
    } catch (e) {
      print("Error fetching orders: $e");
      return null;
    }
  }

  Future<http.Response?> getOrderById(String orderId) async {
    final jwt = await _fetchJwtToken();
    final url = Uri.parse('${_baseUrl}Order/get-Order-By-Id?id=$orderId');

    try {
      final response = await http.get(
        url,
        headers: {'Authorization': 'Bearer $jwt'},
      );
      return response.statusCode == 200 ? response : null;
    } catch (e) {
      print("Error fetching order by ID: $e");
      return null;
    }
  }

  Future<http.Response?> updateOrderState(String orderId,
      {int newState = 2}) async {
    final jwt = await _fetchJwtToken();
    final url = Uri.parse('${_baseUrl}Order/$orderId/state');

    try {
      final response = await http.patch(
        url,
        headers: {
          'Content-Type': 'application/json',
          'Authorization': 'Bearer $jwt',
        },
        body: jsonEncode({'newState': newState}),
      );
      return response.statusCode == 200 ? response : null;
    } catch (e) {
      print("Error updating order state: $e");
      return null;
    }
  }

  Future<String> fetchImageUrl(int foodItemId) async {
    final jwt = await _fetchJwtToken();
    final url = '${_baseUrl}FoodItemPictures/$foodItemId';

    try {
      final response = await http.get(
        Uri.parse(url),
        headers: {
          'Authorization': 'Bearer $jwt',
        },
      );

      if (response.statusCode == 200) {
        final data = json.decode(response.body);
        if (data['data'] != null && data['data'].isNotEmpty) {
          final String imageUrl = data['data'][0]['fileName'];

          return imageUrl;
        } else {
          return 'assets/images/no-image-found.jpg';
        }
      } else {
        throw Exception(
            'Failed to load image URL with status code ${response.statusCode}');
      }
    } catch (e) {
      throw Exception('Failed to load image URL');
    }
  }

  Future<int> getMonthlyOrderCount() async {
    final jwt = await _fetchJwtToken();
    final response = await http.get(
      Uri.parse('${_baseUrl}Order/monthly-count'),
      headers: {'Authorization': 'Bearer $jwt'},
    );
    if (response.statusCode == 200) {
      return int.parse(response.body);
    } else {
      throw Exception('Failed to load monthly order count');
    }
  }

  Future<bool> assignDeliveryPersonToOrder(
      String orderId, String userId) async {
    final jwt = await _fetchJwtToken();
    final apiUrl = '${_baseUrl}Order/assign-delivery-person';
    try {
      final response = await http.patch(
        Uri.parse(apiUrl),
        headers: {
          'Content-Type': 'application/json',
          'Authorization': 'Bearer $jwt',
        },
        body: json.encode({'orderId': orderId, 'userId': userId}),
      );
      if (response.statusCode == 200) {
        print('Delivery person assigned successfully');
        return true;
      } else {
        print(
            'Failed to assign delivery person. Status code: ${response.statusCode}');
        print('Response body: ${response.body}');
        return false;
      }
    } catch (e) {
      print("Error assigning delivery person: $e");
      return false;
    }
  }

  Future<http.Response?> generateOrderReport() async {
    try {
      String jwt = await _fetchJwtToken();

      final url = Uri.parse('${_baseUrl}OrderReport/order-report');
      final headers = {
        'Content-Type': 'application/json',
        'Authorization': 'Bearer $jwt',
      };

      final response = await http.post(url, headers: headers);

      if (response.statusCode == 200) {
        return response;
      } else {
        print('Failed to generate report. Status code: ${response.statusCode}');
        return null;
      }
    } catch (e) {
      print('Error generating report: $e');
      return null;
    }
  }

  Future<http.Response?> deleteOrder(String orderId) async {
    final jwt = await _fetchJwtToken();
    final url = Uri.parse('${_baseUrl}Order/delete-Order?id=$orderId');

    try {
      final response = await http.delete(
        url,
        headers: {'Authorization': 'Bearer $jwt'},
      );
      return response;
    } catch (e) {
      print("Error deleting order: $e");
      return null;
    }
  }
}
