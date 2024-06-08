import 'package:e_delivery_mobile/customer/screens/profile/api/profile_api.dart';
import 'package:e_delivery_mobile/customer/screens/profile/dto/customer_get_dto.dart';

import 'package:flutter/material.dart';
import 'package:e_delivery_mobile/customer/screens/profile/components/profile_header.dart';
import 'package:e_delivery_mobile/customer/screens/profile/components/profile_menu_options.dart';
import '../../core/constants/app_colors.dart';

class ProfilePage extends StatefulWidget {
  const ProfilePage({Key? key}) : super(key: key);

  @override
  _ProfilePageState createState() => _ProfilePageState();
}

class _ProfilePageState extends State<ProfilePage> {
  CustomerGetDto? userData;

  @override
  void initState() {
    super.initState();
    _loadUserData();
  }

  Future<void> _loadUserData() async {
    try {
      userData = await ProfileService().fetchLoggedInUser();
      setState(() {});
    } catch (e) {
      print('Error loading user data: $e');
    }
  }

  void refreshUserData() {
    _loadUserData();
  }

  @override
  Widget build(BuildContext context) {
    if (userData == null) {
      return Center(child: CircularProgressIndicator());
    } else {
      return buildProfileContent(context, userData!);
    }
  }

  Widget buildProfileContent(BuildContext context, CustomerGetDto userData) {
    return Container(
      color: AppColors.cardColor,
      child: Column(
        children: [
          ProfileHeader(userDataViewModel: userData),
          ProfileMenuOptions(
              userDataViewModel: userData, refreshUserData: refreshUserData),
        ],
      ),
    );
  }
}
