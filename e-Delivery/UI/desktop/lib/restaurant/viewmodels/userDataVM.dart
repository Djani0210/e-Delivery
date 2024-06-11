class UserDataViewModel {
  final String? userId;
  final String? userName;
  final int? restaurantId;
  final int? cityId;
  final String? firstName;
  final String? lastName;
  final String? token;
  final String? phoneNumber;
  final String? email;
  final int? tokenExpireDate;

  final List<String>? roles;

  UserDataViewModel({
    this.userId,
    this.userName,
    this.restaurantId,
    this.cityId,
    this.firstName,
    this.lastName,
    this.token,
    this.phoneNumber,
    this.email,
    this.tokenExpireDate,
    this.roles,
  });

  factory UserDataViewModel.fromJson(Map<String, dynamic> json) {
    return UserDataViewModel(
      userId: json['userId'],
      userName: json['username'],
      restaurantId: json['restaurantId'],
      cityId: json['cityId'],
      firstName: json['firstName'],
      lastName: json['lastName'],
      token: json['token'],
      phoneNumber: json['phoneNumber'],
      email: json['email'],
      tokenExpireDate: json['tokenExpireDate'],
      roles: List<String>.from(json['roles']),
    );
  }
}
