class SideDishViewModel {
  final int id;
  String name;
  double price;
  bool isAvailable;

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

class CategoryViewModel {
  final String name;

  CategoryViewModel({required this.name});

  factory CategoryViewModel.fromJson(Map<String, dynamic> json) {
    return CategoryViewModel(name: json['name']);
  }
}

class FoodItemViewModel {
  final int id;
  final String name;
  final String description;
  final double price;
  final bool isAvailable;
  final int? logoId;
  final CategoryViewModel category;
  final List<SideDishViewModel> sideDishes;

  FoodItemViewModel({
    required this.id,
    required this.name,
    required this.description,
    required this.price,
    required this.isAvailable,
    required this.category,
    required this.sideDishes,
    this.logoId,
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
          : CategoryViewModel(name: ''),
      sideDishes: List<SideDishViewModel>.from(
          json['sideDishes'].map((x) => SideDishViewModel.fromJson(x))),
    );
  }
}
