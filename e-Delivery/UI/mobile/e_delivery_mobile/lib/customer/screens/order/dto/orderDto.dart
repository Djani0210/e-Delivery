class OrderDto {
  final int paymentMethod;
  final double totalCost;
  final String allergies;
  final int restaurantId;
  final int cityId;
  final String latitude;
  final String longitude;
  final String address;
  final List<OrderItemDto> orderItems;

  OrderDto({
    required this.paymentMethod,
    required this.totalCost,
    required this.allergies,
    required this.restaurantId,
    required this.cityId,
    required this.latitude,
    required this.longitude,
    required this.address,
    required this.orderItems,
  });

  Map<String, dynamic> toJson() {
    return {
      'paymentMethod': paymentMethod,
      'totalCost': totalCost,
      'allergies': allergies,
      'restaurantId': restaurantId,
      'cityId': cityId,
      'latitude': latitude,
      'longitude': longitude,
      'address': address,
      'orderItems': orderItems.map((item) => item.toJson()).toList(),
    };
  }
}

class OrderItemDto {
  final int foodItemId;
  final List<int> sideDishIds;
  final int quantity;
  final double cost;

  OrderItemDto({
    required this.foodItemId,
    required this.sideDishIds,
    required this.quantity,
    required this.cost,
  });

  Map<String, dynamic> toJson() {
    return {
      'foodItemId': foodItemId,
      'sideDishIds': sideDishIds,
      'quantity': quantity,
      'cost': cost,
    };
  }
}
