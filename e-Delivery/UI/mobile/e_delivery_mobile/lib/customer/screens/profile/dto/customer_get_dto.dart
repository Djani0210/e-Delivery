class CustomerGetDto {
  final String id;
  final String firstName;
  final String lastName;
  final String phoneNumber;
  final String userName;
  final String email;
  final int cityId;

  CustomerGetDto({
    required this.id,
    required this.firstName,
    required this.lastName,
    required this.phoneNumber,
    required this.userName,
    required this.email,
    required this.cityId,
  });

  factory CustomerGetDto.fromJson(Map<String, dynamic> json) {
    return CustomerGetDto(
      id: json['id'],
      firstName: json['firstName'],
      lastName: json['lastName'],
      phoneNumber: json['phoneNumber'],
      userName: json['userName'],
      email: json['email'],
      cityId: json['cityId'],
    );
  }
}
