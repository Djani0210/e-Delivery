class LocationViewModel {
  final int id;
  final String longitude;
  final String latitude;
  final CityViewModel city;

  LocationViewModel(
      {required this.id,
      required this.longitude,
      required this.latitude,
      required this.city});

  factory LocationViewModel.fromJson(Map<String, dynamic> json) {
    return LocationViewModel(
      id: json['id'],
      longitude: json['longitude'],
      latitude: json['latitude'],
      city: CityViewModel.fromJson(json['city']),
    );
  }
}

class CityViewModel {
  final int id;
  final String title;

  CityViewModel({required this.id, required this.title});

  factory CityViewModel.fromJson(Map<String, dynamic> json) {
    return CityViewModel(
      id: json['id'],
      title: json['title'],
    );
  }
}

class ReviewViewModel {
  final int id;
  final double grade;
  final String description;
  final String userName;
  final String createdDate;

  ReviewViewModel({
    required this.id,
    required this.grade,
    required this.description,
    required this.userName,
    required this.createdDate,
  });

  factory ReviewViewModel.fromJson(Map<String, dynamic> json) {
    return ReviewViewModel(
      id: json['id'],
      grade: json['grade'],
      description: json['description'],
      userName: json['userName'],
      createdDate: formatDate(json['createdDate']),
    );
  }
  static String formatDate(String dateString) {
    DateTime parsedDate = DateTime.parse(dateString);
    return "${parsedDate.day.toString().padLeft(2, '0')} ${parsedDate.month.toString().padLeft(2, '0')} ${parsedDate.year}";
  }
}

class LogoViewModel {
  final int id;
  final String path;

  LogoViewModel({required this.id, required this.path});
  String get fullImageUrl => 'https://10.0.2.2:44395$path';

  factory LogoViewModel.fromJson(Map<String, dynamic> json) {
    return LogoViewModel(
      id: json['id'],
      path: json['path'],
    );
  }
}

class RestaurantViewModel {
  final int id;
  final String name;
  final String address;
  final bool isOpen;
  final String openingTime;
  final String closingTime;
  final String contactNumber;
  final double deliveryCharge;
  final int deliveryTime;
  final LocationViewModel location;
  final LogoViewModel? logo;
  final List<ReviewViewModel> reviews;
  final String? createdByUserEmail;
  double? reviewScore;

  RestaurantViewModel({
    required this.id,
    required this.name,
    required this.address,
    required this.isOpen,
    required this.openingTime,
    required this.closingTime,
    required this.contactNumber,
    required this.deliveryCharge,
    required this.deliveryTime,
    required this.location,
    this.logo,
    required this.reviews,
    this.createdByUserEmail,
    this.reviewScore,
  });

  factory RestaurantViewModel.fromJson(Map<String, dynamic> json) {
    var reviewsList = json['reviews'] as List;
    List<ReviewViewModel> reviews =
        reviewsList.map((i) => ReviewViewModel.fromJson(i)).toList();
    return RestaurantViewModel(
      id: json['id'],
      name: json['name'],
      address: json['address'],
      isOpen: json['isOpen'],
      openingTime: json['openingTime'],
      closingTime: json['closingTime'],
      contactNumber: json['contactNumber'],
      deliveryCharge: json['deliveryCharge'],
      deliveryTime: json['deliveryTime'],
      location: LocationViewModel.fromJson(json['location']),
      logo: json['logo'] != null ? LogoViewModel.fromJson(json['logo']) : null,
      reviews: reviews,
      createdByUserEmail:
          json['createdByUser'] != null ? json['createdByUser']['email'] : null,
    );
  }
}
