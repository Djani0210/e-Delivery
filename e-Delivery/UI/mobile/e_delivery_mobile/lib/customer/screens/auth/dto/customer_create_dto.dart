class CustomerCreateDTO {
  String? firstName;
  String? lastName;
  String phoneNumber;
  String userName;
  String email;
  String password;
  String workFrom;
  String workUntil;
  int? cityId;
  List<String> userRoles;

  CustomerCreateDTO({
    this.firstName = "",
    this.lastName = "",
    required this.phoneNumber,
    required this.userName,
    required this.email,
    required this.password,
    required this.workFrom,
    required this.workUntil,
    this.cityId,
    required this.userRoles,
  });

  Map<String, dynamic> toJson() => {
        'FirstName': firstName,
        'LastName': lastName,
        'PhoneNumber': phoneNumber,
        'UserName': userName,
        'Email': email,
        'Password': password,
        'WorkFrom': workFrom,
        'WorkUntil': workUntil,
        'CityId': cityId ?? null,
        'UserRoles': userRoles,
      };
}
