class ChatGetDto {
  final String id;
  final String userFromId;
  final String userToId;
  final String content;
  final bool isDeleted;
  final DateTime createdDate;

  ChatGetDto({
    required this.id,
    required this.userFromId,
    required this.userToId,
    required this.content,
    required this.isDeleted,
    required this.createdDate,
  });

  factory ChatGetDto.fromJson(Map<String, dynamic> json) {
    return ChatGetDto(
      id: json['id'],
      userFromId: json['userFromId'],
      userToId: json['userToId'],
      content: json['content'],
      isDeleted: json['isDeleted'],
      createdDate: DateTime.parse(json['createdDate']),
    );
  }

  Map<String, dynamic> toJson() {
    return {
      'id': id,
      'userFromId': userFromId,
      'userToId': userToId,
      'content': content,
      'isDeleted': isDeleted,
      'createdDate': createdDate.toIso8601String(),
    };
  }
}
