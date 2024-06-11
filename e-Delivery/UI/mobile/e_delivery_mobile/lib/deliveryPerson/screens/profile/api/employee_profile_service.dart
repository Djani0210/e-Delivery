import 'dart:convert';
import 'dart:io';

import 'package:e_delivery_mobile/deliveryPerson/screens/Home/dto/delivery_person_get_dto.dart';
import 'package:e_delivery_mobile/deliveryPerson/screens/profile/dto/employee_update_dto.dart';
import 'package:e_delivery_mobile/globals.dart';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';

import 'package:http/http.dart' as http;

class EmployeeProfileService {
  final _storage = const FlutterSecureStorage();
  final String _baseUrl = baseUrl;

  Future<String> _fetchJwtToken() async {
    String? jwt = await _storage.read(key: 'jwt');
    return jwt ?? '';
  }

  Future<http.Response> updateDeliveryPersonAvailability(
      DeliveryPersonUpdateDTO dto) async {
    final jwt = await _fetchJwtToken();
    final apiUrl = '${_baseUrl}User/update-delivery-person-availability';

    try {
      final response = await http.put(
        Uri.parse(apiUrl),
        headers: {
          'Authorization': 'Bearer $jwt',
          'Content-Type': 'application/json',
        },
        body: json.encode(dto.toJson()),
      );

      if (response.statusCode == 200) {
        print("Successfully updated delivery person availability");
      } else {
        print(response.body);
        print(
            "Failed to update delivery person availability with status code ${response.statusCode}");
      }
      return response;
    } catch (e) {
      throw Exception('Error updating delivery person availability: $e');
    }
  }

  Future<void> uploadProfileImage(File image) async {
    final jwt = await _fetchJwtToken();
    final apiUrl = '${_baseUrl}File/upload-profile-image';
    var request = http.MultipartRequest('POST', Uri.parse(apiUrl))
      ..headers['Authorization'] = 'Bearer $jwt'
      ..fields['isChangingLogo'] = 'true' // Set isChangingLogo to true
      ..files.add(await http.MultipartFile.fromPath('ImageFile', image.path));

    var response = await request.send();
    if (response.statusCode != 200) {
      throw Exception('Failed to upload image');
    }
  }

  Future<String> fetchImageUrl(String id) async {
    final jwt = await _fetchJwtToken();
    final apiUrl = '${_baseUrl}File/get-Profile-Pic-By-Id/$id';

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
          final String imagePath = data['data']['path'];

          final String baseFileUrl = _baseUrl.replaceAll('/api/', '');
          final String fullImageUrl = baseFileUrl + imagePath;

          return fullImageUrl;
        } else {
          throw Exception('No image data found');
        }
      } else {
        throw Exception(
            'Failed to load image URL with status code ${response.statusCode}');
      }
    } catch (e) {
      print("Error fetching image URL: $e");
      throw Exception('Error fetching image URL: $e');
    }
  }

  Future<Map<String, dynamic>> fetchAdmin() async {
    final jwt = await _fetchJwtToken();
    final apiUrl = '${_baseUrl}User/get-admin';

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
          return data['data'];
        } else {
          throw Exception(data['info']);
        }
      } else {
        throw Exception(
            'Failed to load admin with status code ${response.statusCode}');
      }
    } catch (e) {
      print("Error fetching admin: $e");
      throw Exception('Error fetching admin: $e');
    }
  }

  Future<http.Response> updateUserProfile({
    required String userId,
    required String firstName,
    required String lastName,
    required String phoneNumber,
    required String email,
    required String userName,
    required int cityId,
  }) async {
    final jwt = await _fetchJwtToken();
    final apiUrl = '${_baseUrl}User/update-profile/$userId';

    try {
      final response = await http.put(
        Uri.parse(apiUrl),
        headers: {
          'Authorization': 'Bearer $jwt',
          'Content-Type': 'application/json',
        },
        body: json.encode({
          'firstName': firstName,
          'lastName': lastName,
          'phoneNumber': phoneNumber,
          'email': email,
          'userName': userName,
          'cityId': cityId,
        }),
      );
      if (response.statusCode == 200) {
        print("Successfully updated user");
      }
      print("Raw response body: ${response.body}");
      return response;
    } catch (e) {
      throw Exception(e.toString());
    }
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
          print(returnedData);
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
}
