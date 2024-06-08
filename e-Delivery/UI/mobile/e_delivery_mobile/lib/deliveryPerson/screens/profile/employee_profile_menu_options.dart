import 'package:e_delivery_mobile/customer/screens/auth/login_page.dart';

import 'package:e_delivery_mobile/customer/screens/profile/help_page.dart';
import 'package:e_delivery_mobile/customer/screens/profile/notification_page.dart';

import 'package:e_delivery_mobile/deliveryPerson/screens/Home/dto/delivery_person_get_dto.dart';
import 'package:e_delivery_mobile/deliveryPerson/screens/profile/apply_to_restaurant_page.dart';
import 'package:e_delivery_mobile/deliveryPerson/screens/profile/availability_and_options.dart';
import 'package:e_delivery_mobile/deliveryPerson/screens/profile/update_employee_profile_page.dart';
import 'package:e_delivery_mobile/signalr_service.dart';

import 'package:e_delivery_mobile/storage_service.dart';
import 'package:flutter/material.dart';
import 'package:e_delivery_mobile/customer/core/constants/app_defaults.dart';
import 'package:e_delivery_mobile/customer/screens/profile/components/profile_list_tile.dart';
import 'package:http/http.dart' as http;

class EmployeeProfileMenuOptions extends StatefulWidget {
  final DeliveryPersonGetDTO userDataViewModel;
  final Function refreshUserData;

  EmployeeProfileMenuOptions(
      {Key? key,
      required this.userDataViewModel,
      required this.refreshUserData})
      : super(key: key);

  @override
  _ProfileMenuOptionsState createState() => _ProfileMenuOptionsState();
}

class _ProfileMenuOptionsState extends State<EmployeeProfileMenuOptions> {
  Future<void> _logout() async {
    final confirmation = await showDialog<bool>(
      context: context,
      builder: (context) => AlertDialog(
        title: const Text('Logout confirmation'),
        content: const Text('Are you sure you want to log out?'),
        actions: [
          TextButton(
            onPressed: () => Navigator.of(context).pop(false),
            child: const Text('No'),
          ),
          TextButton(
            onPressed: () => Navigator.of(context).pop(true),
            child: const Text('Yes'),
          ),
        ],
      ),
    );

    if (confirmation == true) {
      try {
        final jwtToken = await StorageService.storage.read(key: 'jwt');

        final response = await http.post(
          Uri.parse('https://10.0.2.2:44395/api/Auth/logout'),
          headers: {
            'Content-Type': 'application/json',
            'Authorization': 'Bearer $jwtToken',
          },
        );

        if (response.statusCode == 200) {
          await Future.wait([
            StorageService.storage.delete(key: 'jwt'),
            StorageService.storage.delete(key: 'currentUserId'),
            StorageService.storage.delete(key: 'userData'),
          ]);
          final signalRService = SignalRService();

          await signalRService.disconnectFromChat();
          await signalRService.disconnectFromNotifications();

          Navigator.push(
            context,
            MaterialPageRoute(builder: (context) => const LoginPage()),
          );
        } else {
          ScaffoldMessenger.of(context).showSnackBar(
            SnackBar(
              duration: Duration(milliseconds: 2000),
              content: Center(
                child: Text(
                  'Failed to log out: ${response.statusCode}',
                  style: TextStyle(color: Colors.red),
                ),
              ),
            ),
          );
        }
      } catch (e) {
        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(
            duration: Duration(milliseconds: 2000),
            content: Center(
              child: Text(
                'An error occurred: $e',
                style: TextStyle(color: Colors.red),
              ),
            ),
          ),
        );
      }
    }
  }

  @override
  Widget build(BuildContext context) {
    return Container(
      margin: const EdgeInsets.all(AppDefaults.padding),
      padding: const EdgeInsets.all(AppDefaults.padding),
      decoration: BoxDecoration(
        color: Colors.white,
        boxShadow: AppDefaults.boxShadow,
        borderRadius: BorderRadius.circular(15),
      ),
      child: Column(
        children: [
          const Divider(thickness: 0.1),
          ProfileListTile(
            title: 'Notifications',
            icon: Icons.notifications,
            onTap: () {
              Navigator.push(
                context,
                MaterialPageRoute(builder: (context) => NotificationPage()),
              );
            },
          ),
          const Divider(thickness: 0.1),
          ProfileListTile(
            title: 'Personal info',
            icon: Icons.person,
            onTap: () {
              Navigator.push(
                context,
                MaterialPageRoute(
                    builder: (context) => EmployeeUpdateProfilePage(
                        onProfileUpdated: widget.refreshUserData)),
              );
            },
          ),
          const Divider(thickness: 0.1),
          ProfileListTile(
            title: 'Availability and options',
            icon: Icons.event_available,
            onTap: () {
              Navigator.push(
                context,
                MaterialPageRoute(
                  builder: (context) => UpdateEmployeeAvailabilityPage(
                    userData: widget.userDataViewModel,
                    onUpdated: widget.refreshUserData,
                  ),
                ),
              ).then((_) => widget.refreshUserData());
            },
          ),
          const Divider(thickness: 0.1),
          ProfileListTile(
            title: 'Help',
            icon: Icons.help,
            onTap: () {
              Navigator.push(
                context,
                MaterialPageRoute(builder: (context) => HelpPage()),
              );
            },
          ),
          const Divider(thickness: 0.1),
          ProfileListTile(
            title: 'My Restaurant',
            icon: Icons.restaurant,
            onTap: () {
              Navigator.push(
                context,
                MaterialPageRoute(
                    builder: (context) => ApplyToRestaurantPage()),
              );
            },
          ),
          const Divider(thickness: 0.1),
          ProfileListTile(
            title: 'Logout',
            icon: Icons.logout,
            onTap: _logout,
          ),
        ],
      ),
    );
  }
}
