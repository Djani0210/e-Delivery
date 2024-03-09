class OrderViewModel {
  final String id;
  final int paymentMethod;
  final double totalCost;
  final String allergies;
  final int restaurantId;
  final DateTime createdDate;
  final LocationViewModel location;
  final List<OrderItemViewModel> orderItems;

  OrderViewModel({
    required this.id,
    required this.paymentMethod,
    required this.totalCost,
    required this.allergies,
    required this.restaurantId,
    required this.createdDate,
    required this.location,
    required this.orderItems,
  });

  factory OrderViewModel.fromJson(Map<String, dynamic> json) {
    return OrderViewModel(
      id: json['id'],
      paymentMethod: json['paymentMethod'],
      totalCost: json['totalCost'].toDouble(),
      allergies: json['allergies'] ?? '',
      restaurantId: json['restaurantId'],
      createdDate: DateTime.parse(json['createdDate']),
      location: LocationViewModel.fromJson(json['location'] ?? {}),
      orderItems: (json['orderItems'] as List? ?? [])
          .map((i) => OrderItemViewModel.fromJson(i))
          .toList(),
    );
  }
}

class LocationViewModel {
  final int id;
  final String longitude;
  final String latitude;
  final CityViewModel city;

  LocationViewModel({
    required this.id,
    required this.longitude,
    required this.latitude,
    required this.city,
  });

  factory LocationViewModel.fromJson(Map<String, dynamic> json) {
    return LocationViewModel(
      id: json['id'],
      longitude: json['longitude'] ?? '',
      latitude: json['latitude'] ?? '',
      city: CityViewModel.fromJson(json['city'] ?? {}),
    );
  }
}

class CityViewModel {
  final int id;
  final String title;

  CityViewModel({required this.id, required this.title});

  factory CityViewModel.fromJson(Map<String, dynamic> json) {
    return CityViewModel(
      id: json['id'],
      title: json['title'] ?? '',
    );
  }
}

class OrderItemViewModel {
  final FoodItemViewModel foodItem;
  final List<SideDishViewModel> sideDishes;
  final int quantity;
  final double cost;

  OrderItemViewModel({
    required this.foodItem,
    required this.sideDishes,
    required this.quantity,
    required this.cost,
  });

  factory OrderItemViewModel.fromJson(Map<String, dynamic> json) {
    return OrderItemViewModel(
      foodItem: FoodItemViewModel.fromJson(json['foodItem'] ?? {}),
      sideDishes: (json['sideDishes'] as List? ?? [])
          .map((i) => SideDishViewModel.fromJson(i))
          .toList(),
      quantity: json['quantity'],
      cost: json['cost'].toDouble(),
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
  final int categoryId;
  final int restaurantId;
  final List<SideDishViewModel> sideDishes;

  FoodItemViewModel({
    required this.id,
    required this.name,
    required this.description,
    required this.price,
    required this.isAvailable,
    required this.logoId,
    required this.categoryId,
    required this.restaurantId,
    required this.sideDishes,
  });

  factory FoodItemViewModel.fromJson(Map<String, dynamic> json) {
    return FoodItemViewModel(
      id: json['id'],
      name: json['name'],
      description: json['description'],
      price: json['price'].toDouble(),
      isAvailable: json['isAvailable'],
      logoId: json['logoId'],
      categoryId: json['categoryId'],
      restaurantId: json['restaurantId'],
      sideDishes: (json['sideDishes'] as List? ?? [])
          .map((e) => SideDishViewModel.fromJson(e))
          .toList(),
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
      price: json['price'].toDouble(),
      isAvailable: json['isAvailable'],
    );
  }
}
