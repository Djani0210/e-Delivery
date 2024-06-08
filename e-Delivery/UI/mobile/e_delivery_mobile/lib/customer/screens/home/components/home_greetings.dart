import 'package:e_delivery_mobile/customer/core/constants/app_defaults.dart';
import 'package:e_delivery_mobile/customer/screens/home/dto/user_data_dto.dart';
import 'package:flutter/material.dart';

class HomeGreetings extends StatelessWidget {
  final UserDataViewModel? userDataViewModel;

  const HomeGreetings({
    Key? key,
    this.userDataViewModel,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    final username = userDataViewModel?.userName ?? 'Guest';

    return Padding(
      padding: EdgeInsets.all(AppDefaults.padding),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Text(
            'Welcome $username,',
            style: Theme.of(context)
                .textTheme
                .bodyLarge
                ?.copyWith(color: Colors.grey),
          ),
          const SizedBox(height: 8),
          Text(
            'Choose a meal!',
            style: Theme.of(context)
                .textTheme
                .headlineSmall
                ?.copyWith(fontWeight: FontWeight.bold),
          ),
        ],
      ),
    );
  }
}
