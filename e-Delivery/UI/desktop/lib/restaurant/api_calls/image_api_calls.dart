import 'dart:async';
import 'dart:io';
import 'package:desktop/globals.dart';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import 'package:http/http.dart' as http;
import 'package:http_parser/http_parser.dart';
import 'dart:convert';

class ImageApiService {
  final FlutterSecureStorage _storage = const FlutterSecureStorage();
  final String _baseUrl = baseUrl;

  Future<String> _fetchJwtToken() async {
    String? jwt = await _storage.read(key: 'jwt');
    return jwt ?? '';
  }

  Future<bool> updateRestaurantLogo(String imagePath) async {
    var uri = Uri.parse(_baseUrl + 'File/update-restaurant-logo');
    var request = http.MultipartRequest('PUT', uri);

    String jwtToken = await _fetchJwtToken();
    request.headers.addAll({
      'Authorization': 'Bearer $jwtToken',
      'Content-Type': 'multipart/form-data',
    });

    request.fields['isChangingLogo'] = 'true';

    request.files.add(await http.MultipartFile.fromPath(
      'ImageFile',
      imagePath,
      contentType: MediaType('image', 'jpeg'),
    ));

    try {
      var response = await request.send();

      if (response.statusCode == 200) {
        var responseData = await response.stream.bytesToString();
        var decodedResponse = json.decode(responseData);

        print('Logo uploaded successfully: ${decodedResponse['Data']}');
        return true;
      } else {
        print(
            'Failed to upload logo. Status code: ${response.statusCode} , Body: ${await response.stream.bytesToString()}');
        return false;
      }
    } catch (e) {
      print('Exception caught during logo upload: $e');
      return false;
    }
  }

  Future<bool> postRestaurantLogo(String imagePath) async {
    var uri = Uri.parse(_baseUrl + 'File/upload-restaurant-logo');
    var request = http.MultipartRequest('POST', uri);

    String jwtToken = await _fetchJwtToken();
    request.headers.addAll({
      'Authorization': 'Bearer $jwtToken',
      'Content-Type': 'multipart/form-data',
    });

    request.files.add(await http.MultipartFile.fromPath(
      'ImageFile',
      imagePath,
      contentType: MediaType('image', 'jpeg'),
    ));

    request.fields['IsChangingLogo'] = 'false';

    try {
      var response = await request.send();

      if (response.statusCode == 200) {
        var responseData = await response.stream.bytesToString();
        var decodedResponse = json.decode(responseData);

        print('Logo uploaded successfully: ${decodedResponse['Data']}');
        return true;
      } else {
        print(
            'Failed to upload logo. Status code: ${response.statusCode}, Body: ${await response.stream.bytesToString()}');
        return false;
      }
    } catch (e) {
      print('Exception caught during logo upload: $e');
      return false;
    }
  }
}
