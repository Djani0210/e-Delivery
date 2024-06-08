import 'package:e_delivery_mobile/customer/core/components/item_tile_horizontal.dart';

import 'package:e_delivery_mobile/customer/core/constants/app_defaults.dart';
import 'package:e_delivery_mobile/customer/screens/home/dto/recommended_restaurant_get_dto.dart';
import 'package:e_delivery_mobile/customer/screens/restaurants/api/restaurants_api.dart';
import 'package:flutter/material.dart';

class HomeSuggestionSection extends StatelessWidget {
  final List<RecommendedRestaurantViewModel> recommendedRestaurants;

  const HomeSuggestionSection({
    Key? key,
    required this.recommendedRestaurants,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Column(
      children: [
        Padding(
          padding: const EdgeInsets.all(AppDefaults.padding),
          child: Row(
            children: [
              Text(
                'Recommendations for you',
                style: Theme.of(context)
                    .textTheme
                    .bodyLarge
                    ?.copyWith(fontWeight: FontWeight.bold),
              ),
            ],
          ),
        ),
        SingleChildScrollView(
          scrollDirection: Axis.horizontal,
          child: Row(
            children: recommendedRestaurants.map((restaurant) {
              return ItemTileHorizontal(
                restaurantId: restaurant.id,
                restaurantName: restaurant.name,
                imageUrl: restaurant.logo?.fullImageUrl ??
                    'https://via.placeholder.com/150',
                address: restaurant.address,
                isOpen: restaurant.isOpen,
                deliveryTime: '${restaurant.deliveryTime}',
                deliveryCharge: restaurant.deliveryCharge,
                rating: RestaurantsService()
                    .getReviewScoreForRestaurantMobile(restaurant.id),
              );
            }).toList(),
          ),
        ),
      ],
    );
  }
}
