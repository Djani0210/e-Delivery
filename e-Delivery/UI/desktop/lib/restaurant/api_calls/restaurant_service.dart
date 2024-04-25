import 'package:desktop/components/storage_service.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';

class RestaurantServiceResult {
  final bool success;
  final String message;

  RestaurantServiceResult({required this.success, required this.message});
}

class RestaurantService {
  static const String apiBaseUrl = 'https://localhost:44395/api/Restaurant';

  Future<Map<String, dynamic>?> CreateRestaurant(
    String name,
    String address,
    bool isOpen,
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
      // Handle the case where the JWT token is not found in storage
      print('JWT token not found in storage');
      return null;
    }
    // Create the restaurant without uploading the logo
    final response = await http.post(
      Uri.parse('$apiBaseUrl/add-Restaurant'),
      headers: {
        'Content-Type': 'application/json',
        'Authorization': 'Bearer $jwtToken',
        // Include authentication headers or tokens here
      },
      body: jsonEncode({
        'Name': name,
        'Address': address,
        'IsOpen': isOpen,
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
      // Log the request object, error code, and message
      print(
          'Request failed with status code ${response.statusCode}: ${response.body}');
      return null;
    }
  }
}
