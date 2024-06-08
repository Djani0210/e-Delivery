import 'package:e_delivery_mobile/customer/core/components/network_image.dart';
import 'package:e_delivery_mobile/customer/core/constants/app_defaults.dart';
import 'package:e_delivery_mobile/customer/core/constants/app_icons.dart';
import 'package:flutter/material.dart';
import 'package:flutter_svg/svg.dart';

class ItemTilesVertical extends StatelessWidget {
  const ItemTilesVertical(
      {Key? key,
      required this.restaurantName,
      required this.imageUrl,
      required this.address,
      this.deliveryCharge,
      this.deliveryTime,
      this.rating,
      required this.isOpen})
      : super(key: key);

  final String restaurantName;
  final String imageUrl;
  final String address;
  final double? deliveryCharge;
  final int? deliveryTime;
  final double? rating;
  final bool isOpen;
  @override
  Widget build(BuildContext context) {
    return Material(
      child: InkWell(
        /*onTap: () {
          
        },*/
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
                  mainAxisAlignment: MainAxisAlignment.spaceBetween,
                  children: [
                    Text(
                      address,
                      style: Theme.of(context).textTheme.bodySmall,
                    ),
                    Text(
                      isOpen ? 'Open' : 'Closed',
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
                    Text(deliveryTime.toString() + ' min'),
                    const Spacer(),
                    SvgPicture.asset(AppIcons.stars),
                    Text(rating.toString()),
                    const Spacer(),
                    SvgPicture.asset(AppIcons.delivery),
                    Text(
                      deliveryCharge == null || deliveryCharge == 0.00
                          ? 'Free delivery'
                          : '\KM ${deliveryCharge?.toStringAsFixed(2)}',
                      style: Theme.of(context).textTheme.bodySmall,
                    ),
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
