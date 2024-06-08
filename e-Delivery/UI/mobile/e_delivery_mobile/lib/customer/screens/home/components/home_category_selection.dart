import 'package:e_delivery_mobile/customer/core/constants/app_defaults.dart';
import 'package:e_delivery_mobile/customer/core/constants/app_icons.dart';
import 'package:flutter/material.dart';

import 'home_category_chip.dart';

class CategorySelection extends StatelessWidget {
  const CategorySelection({
    Key? key,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return const Padding(
      padding: EdgeInsets.symmetric(vertical: AppDefaults.padding),
      child: SingleChildScrollView(
        scrollDirection: Axis.horizontal,
        padding: EdgeInsets.only(left: AppDefaults.padding),
        child: Row(
          children: [
            HomeChip(
              name: 'Breakfast',
              icon: AppIcons.anyfood,
              isActive: true,
            ),
            HomeChip(
              name: 'Lunch',
              icon: AppIcons.burger,
              isActive: false,
            ),
            HomeChip(
              name: 'Dinner',
              icon: AppIcons.eggroll,
              isActive: false,
            ),
            HomeChip(
              name: 'Snack',
              icon: AppIcons.pizza,
              isActive: false,
            ),
            HomeChip(
              name: 'Desert',
              icon: AppIcons.pizza,
              isActive: false,
            ),
            HomeChip(
              name: 'Drinks',
              icon: AppIcons.pizza,
              isActive: false,
            ),
          ],
        ),
      ),
    );
  }
}
