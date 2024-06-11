import 'package:desktop/components/storage_service.dart';
import 'package:desktop/globals.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';

class RestaurantServiceResult {
  final bool success;
  final String message;

  RestaurantServiceResult({required this.success, required this.message});
}

class RestaurantService {
  static String apiBaseUrl = '${baseUrl}Restaurant';

  Future<Map<String, dynamic>?> CreateRestaurant(
    String name,
    String address,
    String openingTime,
    String closingTime,
    String contactNumber,
    double deliveryCharge,
    int deliveryTime,
    int cityId,
    String latitude,
    String longitude,
    int? logoId,
  ) async {
    String? jwtToken = await StorageService.storage.read(key: 'jwt');

    if (jwtToken == null) {
      print('JWT token not found in storage');
      return null;
    }

    final response = await http.post(
      Uri.parse('$apiBaseUrl/add-Restaurant'),
      headers: {
        'Content-Type': 'application/json',
        'Authorization': 'Bearer $jwtToken',
      },
      body: jsonEncode({
        'Name': name,
        'Address': address,
        'OpeningTime': openingTime,
        'ClosingTime': closingTime,
        'ContactNumber': contactNumber,
        'DeliveryCharge': deliveryCharge,
        'DeliveryTime': deliveryTime,
        'CityId': cityId,
        'Latitude': latitude,
        'Longitude': longitude,
      }),
    );

    if (response.statusCode == 200 || response.statusCode == 201) {
      final responseBody = jsonDecode(response.body);
      return responseBody;
    } else {
      print(
          'Request failed with status code ${response.statusCode}: ${response.body}');
      return null;
    }
  }
}
