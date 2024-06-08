import 'package:e_delivery_mobile/customer/core/constants/app_defaults.dart';
import 'package:e_delivery_mobile/customer/core/constants/app_icons.dart';
import 'package:e_delivery_mobile/customer/screens/restaurants/restaurant_details_page.dart';
import 'package:flutter/material.dart';
import 'package:flutter_svg/svg.dart';

import 'network_image.dart';

class ItemTileHorizontal extends StatelessWidget {
  final int restaurantId;
  final String restaurantName;
  final String imageUrl;
  final String address;
  final bool isOpen;
  final String deliveryTime;
  final double deliveryCharge;
  final Future<double?> rating;

  const ItemTileHorizontal({
    Key? key,
    required this.restaurantId,
    required this.restaurantName,
    required this.imageUrl,
    required this.address,
    required this.isOpen,
    required this.deliveryTime,
    required this.deliveryCharge,
    required this.rating,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Material(
      child: InkWell(
        onTap: () {
          // Navigate to the RestaurantDetailsPage with the restaurant ID
          Navigator.push(
            context,
            MaterialPageRoute(
              builder: (context) =>
                  RestaurantDetails(restaurantId: restaurantId),
            ),
          );
        },
        borderRadius: AppDefaults.borderRadius,
        child: Padding(
          padding: const EdgeInsets.symmetric(horizontal: 16),
          child: SizedBox(
            width: MediaQuery.of(context).size.width * 0.6,
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                AspectRatio(
                  aspectRatio: 16 / 10,
                  child: NetworkImageWithLoader(imageUrl),
                ),
                const SizedBox(height: 16),
                Text(
                  restaurantName,
                  style: Theme.of(context).textTheme.titleLarge,
                ),
                const SizedBox(height: 8),
                Row(
                  children: [
                    Expanded(
                      child: Text(
                        address,
                        style: Theme.of(context).textTheme.bodySmall,
                      ),
                    ),
                    Text(
                      isOpen ? "Open" : "Closed",
                      style: TextStyle(
                        color: isOpen ? Colors.green : Colors.red,
                        fontWeight: FontWeight.bold,
                      ),
                    ),
                  ],
                ),
                const SizedBox(height: 16),
                Row(
                  children: [
                    SvgPicture.asset(AppIcons.time),
                    Text('$deliveryTime min'),
                    const Spacer(),
                    SvgPicture.asset(AppIcons.stars),
                    FutureBuilder<double?>(
                      future: rating,
                      builder: (context, snapshot) {
                        if (snapshot.hasData) {
                          return Text('${snapshot.data}');
                        } else if (snapshot.hasError) {
                          return Text('N/A');
                        }
                        return CircularProgressIndicator();
                      },
                    ),
                    const Spacer(),
                    SvgPicture.asset(AppIcons.delivery),
                    Text('${deliveryCharge.toStringAsFixed(2)} Delivery')
                  ],
                )
              ],
            ),
          ),
        ),
      ),
    );
  }
}
