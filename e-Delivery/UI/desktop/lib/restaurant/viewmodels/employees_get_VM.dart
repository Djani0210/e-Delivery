class EmployeeViewModel {
  final String id;
  final String firstName;
  final String lastName;
  final String phoneNumber;
  final String userName;
  final String email;
  final int gender;
  final String? role;
  final String? company;
  final bool isAvailable;
  final String workFrom;
  final String workUntil;

  EmployeeViewModel({
    required this.id,
    required this.firstName,
    required this.lastName,
    required this.phoneNumber,
    required this.userName,
    required this.email,
    required this.gender,
    this.role,
    this.company,
    required this.isAvailable,
    required this.workFrom,
    required this.workUntil,
  });

  factory EmployeeViewModel.fromJson(Map<String, dynamic> json) {
    return EmployeeViewModel(
      id: json['id'],
      firstName: json['firstName'],
      lastName: json['lastName'],
      phoneNumber: json['phoneNumber'],
      userName: json['userName'],
      email: json['email'],
      gender: json['gender'],
      role: json['role'],
      company: json['company'],
      isAvailable: json['isAvailable'],
      workFrom: json['workFrom'],
      workUntil: json['workUntil'],
    );
  }
}
