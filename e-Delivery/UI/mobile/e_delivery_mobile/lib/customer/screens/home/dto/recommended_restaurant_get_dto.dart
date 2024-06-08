import 'package:e_delivery_mobile/customer/screens/home/dto/restaurant_get_dto.dart';

class RecommendedRestaurantViewModel {
  final int id;
  final String name;
  final String address;
  final bool isOpen;
  final String openingTime;
  final String closingTime;
  final String contactNumber;
  final double deliveryCharge;
  final int deliveryTime;

  final LogoViewModel? logo;

  RecommendedRestaurantViewModel({
    required this.id,
    required this.name,
    required this.address,
    required this.isOpen,
    required this.openingTime,
    required this.closingTime,
    required this.contactNumber,
    required this.deliveryCharge,
    required this.deliveryTime,
    this.logo,
  });

  factory RecommendedRestaurantViewModel.fromJson(Map<String, dynamic> json) {
    return RecommendedRestaurantViewModel(
      id: json['id'],
      name: json['name'],
      address: json['address'],
      isOpen: json['isOpen'],
      openingTime: json['openingTime'],
      closingTime: json['closingTime'],
      contactNumber: json['contactNumber'],
      deliveryCharge: json['deliveryCharge'],
      deliveryTime: json['deliveryTime'],
      logo: json['logo'] != null ? LogoViewModel.fromJson(json['logo']) : null,
    );
  }
}
