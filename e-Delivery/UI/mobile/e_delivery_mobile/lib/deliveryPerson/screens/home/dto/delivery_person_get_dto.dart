class DeliveryPersonGetDTO {
  final String? id;
  final String? firstName;
  final String? lastName;
  final String? phoneNumber;
  final String? userName;
  final String? email;
  final int? cityId;
  final int? restaurantId;
  final bool? isAvailable;
  final String? workFrom;
  final String? workUntil;

  DeliveryPersonGetDTO({
    this.id,
    this.firstName,
    this.lastName,
    this.phoneNumber,
    this.userName,
    this.email,
    this.cityId,
    this.restaurantId,
    this.isAvailable,
    this.workFrom,
    this.workUntil,
  });

  factory DeliveryPersonGetDTO.fromJson(Map<String, dynamic> json) {
    return DeliveryPersonGetDTO(
      id: json['id'],
      firstName: json['firstName'],
      lastName: json['lastName'],
      phoneNumber: json['phoneNumber'],
      userName: json['userName'],
      email: json['email'],
      cityId: json['cityId'],
      restaurantId: json['restaurantId'],
      isAvailable: json['isAvailable'],
      workFrom: json['workFrom'],
      workUntil: json['workUntil'],
    );
  }
}
