import 'dart:convert';

import 'package:desktop/globals.dart';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import 'package:http/http.dart' as http;
import 'package:http_parser/http_parser.dart';

class FoodItemApiService {
  final _storage = const FlutterSecureStorage();
  final String _baseUrl = baseUrl;

  Future<String> _fetchJwtToken() async {
    String? jwt = await _storage.read(key: 'jwt');
    return jwt ?? '';
  }

  Future<String> GetMostFrequentFoodItem() async {
    String jwt = await _fetchJwtToken();
    final response = await http.get(
      Uri.parse('${_baseUrl}FoodItem/get-Most-Frequent'),
      headers: {'Authorization': 'Bearer $jwt'},
    );

    if (response.statusCode == 200) {
      final decodedBody = json.decode(response.body);
      return decodedBody['name'];
    } else if (response.statusCode == 404) {
      final decodedBody = json.decode(response.body);
      return decodedBody['message']; // Use the custom message from the backend
    } else {
      throw Exception("Failed to fetch most frequent food item");
    }
  }

  Future<bool> updateFoodItem({
    required int id,
    required String name,
    required String description,
    required double price,
    required bool isAvailable,
    required List<int> sideDishIds,
  }) async {
    final jwt = await _fetchJwtToken();
    final apiUrl = '${_baseUrl}FoodItem/update-FoodItem?id=$id';

    try {
      final response = await http.put(
        Uri.parse(apiUrl),
        headers: {
          'Authorization': 'Bearer $jwt',
          'Content-Type': 'application/json',
        },
        body: json.encode({
          'name': name,
          'description': description,
          'price': price,
          'isAvailable': isAvailable,
          'sideDishIds': sideDishIds,
        }),
      );

      if (response.statusCode == 200) {
        return true;
      } else {
        print(
            'Failed to update food item. Status code: ${response.statusCode}');
        return false;
      }
    } catch (e) {
      print('Error updating food item: $e');
      return false;
    }
  }

  Future<http.Response?> getFoodItems({
    int pageNumber = 1,
    int itemsPerPage = 4,
    bool? isAvailable,
    String? categoryName,
    String? itemName,
  }) async {
    String jwt = await _fetchJwtToken();
    var queryParams = {
      'items_per_page': '$itemsPerPage',
      'pageNumber': '$pageNumber',
      if (isAvailable != null) 'isAvailable': isAvailable.toString(),
      if (categoryName != null && categoryName.isNotEmpty)
        'categoryName': categoryName,
      if (itemName != null && itemName.isNotEmpty) 'itemName': itemName,
    };

    final url = Uri.parse('${_baseUrl}FoodItem/get-FoodItems')
        .replace(queryParameters: queryParams);
    try {
      final response = await http.get(
        url,
        headers: {'Authorization': 'Bearer $jwt'},
      );
      return response.statusCode == 200 ? response : null;
    } catch (e) {
      print("Error fetching food items: $e");
      return null;
    }
  }

  Future<http.Response?> getFoodItemById(int id) async {
    String jwt = await _fetchJwtToken();

    final url = Uri.parse('${_baseUrl}FoodItem/get-FoodItemById?id=$id');

    try {
      final response = await http.get(
        url,
        headers: {'Authorization': 'Bearer $jwt'},
      );
      return response.statusCode == 200 ? response : null;
    } catch (e) {
      print("Error fetching food items: $e");
      return null;
    }
  }

  Future<void> deleteFoodItem(int id) async {
    try {
      final String jwtToken = await _fetchJwtToken();
      final response = await http.delete(
        Uri.parse('${baseUrl}FoodItem/delete-FoodItem?id=$id'),
        headers: {
          'Authorization': 'Bearer $jwtToken',
          'Content-Type': 'application/json',
        },
      );

      if (response.statusCode == 200 || response.statusCode == 204) {
        print('Food item deleted successfully');
      } else {
        // Handle the error
        print(
            'Error deleting menu item: ${response.statusCode} - ${response.body}');
      }
    } catch (e) {
      // Handle the exception
      print('Error deleting menu item: $e');
    }
  }

  Future<bool> createFoodItem({
    required String name,
    required String description,
    required double price,
    required bool isAvailable,
    required int categoryId,
    required List<int> sideDishIds,
  }) async {
    final jwt = await _fetchJwtToken();
    final apiUrl = '${_baseUrl}FoodItem/add-FoodItem';

    try {
      final response = await http.post(
        Uri.parse(apiUrl),
        headers: {
          'Authorization': 'Bearer $jwt',
          'Content-Type': 'application/json',
        },
        body: json.encode({
          'name': name,
          'description': description,
          'price': price,
          'isAvailable': isAvailable,
          'categoryId': categoryId,
          'sideDishIds': sideDishIds,
        }),
      );

      if (response.statusCode == 200) {
        return true;
      } else {
        print(
            'Failed to create food item. Status code: ${response.statusCode}');
        return false;
      }
    } catch (e) {
      print('Error creating food item: $e');
      return false;
    }
  }

  Future<String> fetchImageUrl(int id) async {
    final jwt = await _fetchJwtToken();
    final apiUrl = '${_baseUrl}FoodItemPictures/$id';

    try {
      final response = await http.get(
        Uri.parse(apiUrl),
        headers: {
          'Authorization': 'Bearer $jwt',
        },
      );

      if (response.statusCode == 200) {
        final data = json.decode(response.body);
        if (data != null && data['data'] != null && data['data'].isNotEmpty) {
          final String imagePath = data['data'][0]['fileName'];

          return imagePath;
        } else {
          throw Exception('No image data found');
        }
      } else {
        return '';
      }
    } catch (e) {
      print("Error fetching image URL: $e");
      throw Exception('Error fetching image URL: $e');
    }
  }

  Future<int> fetchImageId(int id) async {
    final jwt = await _fetchJwtToken();
    final apiUrl = '${_baseUrl}FoodItemPictures/$id';

    try {
      final response = await http.get(
        Uri.parse(apiUrl),
        headers: {
          'Authorization': 'Bearer $jwt',
        },
      );

      if (response.statusCode == 200) {
        final data = json.decode(response.body);
        if (data != null && data['data'] != null && data['data'].isNotEmpty) {
          final int imageId = data['data'][0]['id'];

          return imageId;
        } else {
          throw Exception('No image data found');
        }
      } else {
        return 0;
      }
    } catch (e) {
      print("Error fetching image id: $e");
      throw Exception('Error fetching image id: $e');
    }
  }

  // postImageUrl function
  Future<bool> postImageUrl(int id, String imagePath) async {
    final jwt = await _fetchJwtToken();
    var uri = Uri.parse('${_baseUrl}FoodItemPictures/$id');
    var request = http.MultipartRequest('POST', uri);

    String jwtToken = await _fetchJwtToken();
    request.headers.addAll({
      'Authorization': 'Bearer $jwtToken',
      'Content-Type': 'multipart/form-data',
    });

    request.files.add(await http.MultipartFile.fromPath(
      'FoodItem_image',
      imagePath,
      contentType: MediaType('image', 'jpeg'),
    ));

    try {
      var response = await request.send();

      if (response.statusCode == 200 || response.statusCode == 201) {
        var responseData = await response.stream.bytesToString();
        var decodedResponse = json.decode(responseData);

        print(
            'Logo uploaded successfully: ${decodedResponse['data']['fileName']}');
        return true;
      } else {
        print('Failed to upload logo. Status code: ${response.statusCode}');
        return false;
      }
    } catch (e) {
      print('Exception caught during logo upload: $e');
      return false;
    }
  }

  Future<bool> deleteImageUrl(int id) async {
    final jwt = await _fetchJwtToken();
    final apiUrl = '${_baseUrl}FoodItemPictures/$id';

    try {
      final response = await http.delete(
        Uri.parse(apiUrl),
        headers: {
          'Authorization': 'Bearer $jwt',
        },
      );

      if (response.statusCode == 200 ||
          response.statusCode == 204 ||
          response.statusCode == 201) {
        return true;
      } else {
        print(
            "Error deleting image URL: ${response.statusCode} - ${response.body}");
        return false;
      }
    } catch (e) {
      print("Error deleting image URL: $e");
      return false;
    }
  }
}
