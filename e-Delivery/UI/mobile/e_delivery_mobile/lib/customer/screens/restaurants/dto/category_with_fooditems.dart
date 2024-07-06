import 'package:e_delivery_mobile/customer/screens/restaurants/dto/category_get_dto.dart';

class CategoryWithFoodItemsViewModel {
  final String name;
  final List<FoodItemViewModel> foodItems;

  CategoryWithFoodItemsViewModel({
    required this.name,
    required this.foodItems,
  });

  factory CategoryWithFoodItemsViewModel.fromJson(Map<String, dynamic> json) {
    return CategoryWithFoodItemsViewModel(
      name: json['name'],
      foodItems: (json['foodItems'] as List<dynamic>)
          .map((item) => FoodItemViewModel.fromJson(item))
          .toList(),
    );
  }
}

class FoodItemPictureViewModel {
  final int id;
  final String fileName;
  final int fileSize;
  final int foodItemId;

  FoodItemPictureViewModel({
    required this.id,
    required this.fileName,
    required this.fileSize,
    required this.foodItemId,
  });

  factory FoodItemPictureViewModel.fromJson(Map<String, dynamic> json) {
    return FoodItemPictureViewModel(
      id: json['id'],
      fileName: json['fileName'],
      fileSize: json['fileSize'],
      foodItemId: json['foodItemId'],
    );
  }
}

class FoodItemViewModel {
  final int id;
  final String name;
  final String description;
  final double price;
  final bool isAvailable;
  final int logoId;
  final CategoryViewModel category;
  final int restaurantId;
  final List<SideDishViewModel> sideDishes;
  final List<FoodItemPictureViewModel> foodItemPictures;

  FoodItemViewModel({
    required this.id,
    required this.name,
    required this.description,
    required this.price,
    required this.isAvailable,
    required this.logoId,
    required this.category,
    required this.restaurantId,
    required this.sideDishes,
    required this.foodItemPictures,
  });

  factory FoodItemViewModel.fromJson(Map<String, dynamic> json) {
    var pictures = (json['foodItemPictures'] as List<dynamic>)
        .map((item) => FoodItemPictureViewModel.fromJson(item))
        .toList();

    pictures = pictures.map((picture) {
      var fixedUrl = picture.fileName.replaceAll('localhost', '10.0.2.2');
      return FoodItemPictureViewModel(
        id: picture.id,
        fileName: fixedUrl,
        fileSize: picture.fileSize,
        foodItemId: picture.foodItemId,
      );
    }).toList();
    return FoodItemViewModel(
      id: json['id'],
      name: json['name'],
      description: json['description'],
      price: json['price'],
      isAvailable: json['isAvailable'],
      logoId: json['logoId'],
      category: CategoryViewModel.fromJson(json['category']),
      restaurantId: json['restaurantId'],
      sideDishes: (json['sideDishes'] as List<dynamic>)
          .map((item) => SideDishViewModel.fromJson(item))
          .toList(),
      foodItemPictures: pictures,
    );
  }
}

class SideDishViewModel {
  final int id;
  final String name;
  final double price;
  final bool isAvailable;

  SideDishViewModel({
    required this.id,
    required this.name,
    required this.price,
    required this.isAvailable,
  });

  factory SideDishViewModel.fromJson(Map<String, dynamic> json) {
    return SideDishViewModel(
      id: json['id'],
      name: json['name'],
      price: json['price'],
      isAvailable: json['isAvailable'],
    );
  }
}
