class GetNotificationVM {
  final int id;
  final String content;
  final bool isDeleted;
  final DateTime createdDate;
  final String? restaurantName;

  GetNotificationVM({
    required this.id,
    required this.content,
    required this.isDeleted,
    required this.createdDate,
    this.restaurantName,
  });

  factory GetNotificationVM.fromJson(Map<String, dynamic> json) {
    return GetNotificationVM(
      id: json['id'],
      content: json['content'],
      isDeleted: json['isDeleted'],
      createdDate: DateTime.parse(json['createdDate']),
      restaurantName: json['restaurantName'],
    );
  }

  Map<String, dynamic> toJson() {
    return {
      'id': id,
      'content': content,
      'isDeleted': isDeleted,
      'createdDate': createdDate.toIso8601String(),
      'restaurantName': restaurantName,
    };
  }
}
