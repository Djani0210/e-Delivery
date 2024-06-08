import 'package:e_delivery_mobile/customer/core/constants/app_colors.dart';
import 'package:e_delivery_mobile/deliveryPerson/screens/Home/dto/delivery_person_get_dto.dart';

import 'package:e_delivery_mobile/deliveryPerson/screens/profile/employee_profile_header.dart';
import 'package:e_delivery_mobile/deliveryPerson/screens/profile/employee_profile_menu_options.dart';

import 'package:flutter/material.dart';

import 'package:e_delivery_mobile/deliveryPerson/screens/profile/api/employee_profile_service.dart';

class EmployeeProfilePage extends StatefulWidget {
  const EmployeeProfilePage({Key? key}) : super(key: key);

  @override
  _EmployeeProfilePageState createState() => _EmployeeProfilePageState();
}

class _EmployeeProfilePageState extends State<EmployeeProfilePage> {
  DeliveryPersonGetDTO? userData;

  @override
  void initState() {
    super.initState();
    _loadUserData();
  }

  @override
  void dispose() {
    super.dispose();
  }

  Future<void> _loadUserData() async {
    try {
      userData = await EmployeeProfileService().fetchLoggedInUser();

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

  Widget buildProfileContent(
      BuildContext context, DeliveryPersonGetDTO userData) {
    return Container(
      color: AppColors.cardColor,
      child: Column(
        children: [
          EmployeeProfileHeader(userDataViewModel: userData),
          EmployeeProfileMenuOptions(
              userDataViewModel: userData, refreshUserData: refreshUserData),
        ],
      ),
    );
  }
}
