class OrderViewModel {
  final String id;
  final int paymentMethod;
  final double totalCost;
  final String allergies;
  final int restaurantId;
  final DateTime createdDate;
  final LocationViewModel location;
  final List<OrderItemViewModel> orderItems;
  final int orderState;
  final String? userName;
  final String address;
  final String? deliveryPersonId;
  final String? deliveryPersonName;
  final double deliveryCost;

  OrderViewModel({
    required this.id,
    required this.paymentMethod,
    required this.totalCost,
    required this.allergies,
    required this.restaurantId,
    required this.createdDate,
    required this.location,
    required this.orderItems,
    required this.orderState,
    this.userName,
    required this.address,
    this.deliveryPersonId,
    this.deliveryPersonName,
    required this.deliveryCost,
  });

  factory OrderViewModel.fromJson(Map<String, dynamic> json) {
    if (json.containsKey('data')) {
      return OrderViewModel.fromJson(json['data']);
    }

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
      orderState: json['orderState'],
      userName: json['userName'],
      address: json['address'],
      deliveryPersonId: json['deliveryPersonId'],
      deliveryPersonName: json['deliveryPersonAssigned'],
      deliveryCost: json['deliveryCost'].toDouble(),
    );
  }

  String get orderStateText {
    switch (orderState) {
      case 1:
        return 'In progress';
      case 2:
        return 'In Delivery';
      case 3:
        return 'Delivered';
      case 4:
        return 'Cancelled';
      default:
        return 'Unknown';
    }
  }

  String get paymentMethodText {
    switch (paymentMethod) {
      case 1:
        return 'Credit card';
      case 2:
        return 'Cash';

      default:
        return 'Unknown';
    }
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
  final CategoryViewModel category;
  final int restaurantId;
  final List<SideDishViewModel> sideDishes;

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
  });

  factory FoodItemViewModel.fromJson(Map<String, dynamic> json) {
    return FoodItemViewModel(
      id: json['id'],
      name: json['name'],
      description: json['description'],
      price: json['price'].toDouble(),
      isAvailable: json['isAvailable'],
      logoId: json['logoId'],
      category: json['category'] != null
          ? CategoryViewModel.fromJson(json['category'])
          : CategoryViewModel(name: 'Unknown'),
      restaurantId: json['restaurantId'],
      sideDishes: (json['sideDishes'] as List? ?? [])
          .map((e) => SideDishViewModel.fromJson(e))
          .toList(),
    );
  }
}

class CategoryViewModel {
  final String name;

  CategoryViewModel({required this.name});

  factory CategoryViewModel.fromJson(Map<String, dynamic> json) {
    return CategoryViewModel(
      name: json['name'],
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
