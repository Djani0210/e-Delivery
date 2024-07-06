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
