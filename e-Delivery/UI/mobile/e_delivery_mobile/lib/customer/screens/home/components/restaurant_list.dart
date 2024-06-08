import 'package:e_delivery_mobile/customer/screens/home/dto/restaurant_get_dto.dart';
import 'package:flutter/material.dart';

class RestaurantList extends StatelessWidget {
  final List<RestaurantViewModel> restaurants;
  final Function(RestaurantViewModel) onRestaurantSelected;

  const RestaurantList({
    Key? key,
    required this.restaurants,
    required this.onRestaurantSelected,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Container(
      margin: const EdgeInsets.symmetric(horizontal: 16),
      decoration: BoxDecoration(
        color: Colors.white,
        borderRadius: BorderRadius.circular(8),
        boxShadow: [
          BoxShadow(
            color: Colors.black.withOpacity(0.1),
            blurRadius: 4,
            offset: const Offset(0, 2),
          ),
        ],
      ),
      child: Material(
        color: Colors.transparent,
        child: ListView.builder(
          shrinkWrap: true,
          itemCount: restaurants.length,
          itemBuilder: (context, index) {
            final restaurant = restaurants[index];
            return ListTile(
              title: Text(restaurant.name),
              subtitle: Text(restaurant.address),
              onTap: () => onRestaurantSelected(restaurant),
            );
          },
        ),
      ),
    );
  }
}
