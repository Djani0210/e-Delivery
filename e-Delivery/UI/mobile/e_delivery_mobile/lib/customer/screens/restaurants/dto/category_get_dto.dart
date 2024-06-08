class CategoryViewModel {
  final int id;
  final String name;

  CategoryViewModel({required this.id, required this.name});

  factory CategoryViewModel.fromJson(Map<String, dynamic> json) {
    return CategoryViewModel(
      id: json['id'],
      name: json['name'],
    );
  }
}
