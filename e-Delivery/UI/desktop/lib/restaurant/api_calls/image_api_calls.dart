import 'dart:async';
import 'dart:io';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import 'package:http/http.dart' as http;
import 'package:http_parser/http_parser.dart';
import 'dart:convert';

class ImageApiService {
  final FlutterSecureStorage _storage = const FlutterSecureStorage();
  final String _baseUrl = 'https://localhost:44395/api/';

  Future<String> _fetchJwtToken() async {
    // Adjust 'jwt' as necessary based on how you've stored the token
    String? jwt = await _storage.read(key: 'jwt');
    return jwt ?? '';
  }

  Future<bool> updateRestaurantLogo(String imagePath) async {
    var uri = Uri.parse(_baseUrl + 'File/update-restaurant-logo');
    var request = http.MultipartRequest('PUT', uri);

    // Fetch JWT token
    String jwtToken = await _fetchJwtToken();
    request.headers.addAll({
      'Authorization': 'Bearer $jwtToken',
      'Content-Type': 'multipart/form-data',
    });

    // Add the isChangingLogo field
    request.fields['isChangingLogo'] = 'true';

    // Add the image file to the request
    request.files.add(await http.MultipartFile.fromPath(
      'ImageFile',
      imagePath,
      contentType:
          MediaType('image', 'jpeg'), // Adjust based on your image type
    ));

    try {
      var response = await request.send();

      if (response.statusCode == 200) {
        // Handle successful upload, perhaps by parsing the response
        var responseData = await response.stream.bytesToString();
        var decodedResponse = json.decode(responseData);

        // Assuming the backend responds with the new image URL in the Data field
        // You can then update the UI or internal state with this new image URL as needed
        print('Logo uploaded successfully: ${decodedResponse['Data']}');
        return true;
      } else {
        // Handle failure
        print('Failed to upload logo. Status code: ${response.statusCode}');
        return false;
      }
    } catch (e) {
      print('Exception caught during logo upload: $e');
      return false;
    }
  }
}
