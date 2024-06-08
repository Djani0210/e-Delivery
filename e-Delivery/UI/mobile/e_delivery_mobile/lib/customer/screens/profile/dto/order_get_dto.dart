class OrderGetDto {
  final String id;
  final int paymentMethod;
  final double totalCost;
  final String? allergies;
  final int restaurantId;
  final String? restaurantName;
  final String createdDate;
  final int orderState;
  final LocationDto location;
  final List<OrderItemDto> orderItems;
  final String? userName;
  final String? address;
  final String? deliveryPersonId;
  final String? deliveryPersonAssigned;
  final String? createdByUserId;
  final double? deliveryCost;

  OrderGetDto({
    required this.id,
    required this.paymentMethod,
    required this.totalCost,
    required this.allergies,
    required this.restaurantId,
    required this.restaurantName,
    required this.createdDate,
    required this.orderState,
    required this.location,
    required this.orderItems,
    required this.userName,
    required this.address,
    required this.deliveryPersonId,
    required this.deliveryPersonAssigned,
    required this.createdByUserId,
    required this.deliveryCost,
  });

  factory OrderGetDto.fromJson(Map<String, dynamic> json) {
    return OrderGetDto(
      id: json['id'],
      paymentMethod: json['paymentMethod'],
      totalCost: json['totalCost'],
      allergies: json['allergies'],
      restaurantId: json['restaurantId'],
      restaurantName: json['restaurantName'],
      createdDate: json['createdDate'],
      orderState: json['orderState'],
      location: LocationDto.fromJson(json['location']),
      orderItems: (json['orderItems'] as List)
          .map((i) => OrderItemDto.fromJson(i))
          .toList(),
      userName: json['userName'],
      address: json['address'],
      deliveryPersonId: json['deliveryPersonId'],
      deliveryPersonAssigned: json['deliveryPersonAssigned'],
      createdByUserId: json['createdByUserId'],
      deliveryCost: json['deliveryCost'],
    );
  }
}

class LocationDto {
  final int id;
  final String longitude;
  final String latitude;
  final CityDto city;

  LocationDto({
    required this.id,
    required this.longitude,
    required this.latitude,
    required this.city,
  });

  factory LocationDto.fromJson(Map<String, dynamic> json) {
    return LocationDto(
      id: json['id'],
      longitude: json['longitude'],
      latitude: json['latitude'],
      city: CityDto.fromJson(json['city']),
    );
  }
}

class CityDto {
  final int id;
  final String title;

  CityDto({
    required this.id,
    required this.title,
  });

  factory CityDto.fromJson(Map<String, dynamic> json) {
    return CityDto(
      id: json['id'],
      title: json['title'],
    );
  }
}

class OrderItemDto {
  final FoodItemDto foodItem;
  final List<SideDishDto> sideDishes;
  final int quantity;
  final double cost;

  OrderItemDto({
    required this.foodItem,
    required this.sideDishes,
    required this.quantity,
    required this.cost,
  });

  factory OrderItemDto.fromJson(Map<String, dynamic> json) {
    return OrderItemDto(
      foodItem: FoodItemDto.fromJson(json['foodItem']),
      sideDishes: (json['sideDishes'] as List)
          .map((i) => SideDishDto.fromJson(i))
          .toList(),
      quantity: json['quantity'],
      cost: json['cost'],
    );
  }
}

class FoodItemDto {
  final int id;
  final String name;
  final String description;
  final double price;
  final bool isAvailable;
  final int logoId;

  final List<FoodItemPictureDto> foodItemPictures;
  final int restaurantId;
  final List<int> sideDishes;

  FoodItemDto({
    required this.id,
    required this.name,
    required this.description,
    required this.price,
    required this.isAvailable,
    required this.logoId,
    required this.foodItemPictures,
    required this.restaurantId,
    required this.sideDishes,
  });

  factory FoodItemDto.fromJson(Map<String, dynamic> json) {
    return FoodItemDto(
      id: json['id'],
      name: json['name'],
      description: json['description'],
      price: json['price'],
      isAvailable: json['isAvailable'],
      logoId: json['logoId'],
      foodItemPictures: (json['foodItemPictures'] as List)
          .map((i) => FoodItemPictureDto.fromJson(i))
          .toList(),
      restaurantId: json['restaurantId'],
      sideDishes: List<int>.from(json['sideDishes']),
    );
  }
}

class SideDishDto {
  final int id;
  final String name;
  final double price;
  final bool isAvailable;

  SideDishDto({
    required this.id,
    required this.name,
    required this.price,
    required this.isAvailable,
  });

  factory SideDishDto.fromJson(Map<String, dynamic> json) {
    return SideDishDto(
      id: json['id'],
      name: json['name'],
      price: json['price'],
      isAvailable: json['isAvailable'],
    );
  }
}

class FoodItemPictureDto {
  final int id;
  final String fileName;
  final int fileSize;
  final int foodItemId;

  FoodItemPictureDto({
    required this.id,
    required this.fileName,
    required this.fileSize,
    required this.foodItemId,
  });

  factory FoodItemPictureDto.fromJson(Map<String, dynamic> json) {
    return FoodItemPictureDto(
      id: json['id'],
      fileName: json['fileName'],
      fileSize: json['fileSize'],
      foodItemId: json['foodItemId'],
    );
  }
}
