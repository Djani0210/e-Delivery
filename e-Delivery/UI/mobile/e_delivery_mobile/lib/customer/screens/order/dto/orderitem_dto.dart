class OrderItem {
  int foodItemId;
  List<int> sideDishIds;
  int quantity;
  double cost;

  OrderItem({
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
