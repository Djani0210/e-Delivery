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

class LogoViewModel {
  final int id;
  final String path;
  // other fields if needed

  LogoViewModel({required this.id, required this.path});
  String get fullImageUrl => 'http://localhost:44395$path';

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
  final String? createdByUserEmail;

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
    this.createdByUserEmail,
  });

  factory RestaurantViewModel.fromJson(Map<String, dynamic> json) {
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
      createdByUserEmail:
          json['createdByUser'] != null ? json['createdByUser']['email'] : null,
    );
  }
}
