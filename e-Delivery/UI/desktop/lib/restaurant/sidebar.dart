import 'package:desktop/restaurant/viewmodels/restaurant_get_VM.dart';
import 'package:flutter/material.dart';

class Sidebar extends StatelessWidget {
  final int selectedIndex;
  final Function(int) onTap;
  final RestaurantViewModel? restaurantData;
  final Future<void> Function() onLogout;
  Sidebar(
      {required this.onTap,
      required this.selectedIndex,
      required this.restaurantData,
      required this.onLogout});

  @override
  Widget build(BuildContext context) {
    return Drawer(
      child: ListView(
        children: [
          DrawerHeader(
            decoration: BoxDecoration(
              color: Colors.orange,
            ),
            child: Column(
              mainAxisAlignment: MainAxisAlignment.center,
              children: <Widget>[
                CircleAvatar(
                  backgroundColor: Colors.white,
                  radius: 30.0,
                  child: FlutterLogo(size: 30),
                ),
                SizedBox(height: 15),
                Text(restaurantData?.name ?? 'Loading...',
                    style: TextStyle(color: Colors.white)),
              ],
            ),
          ),
          _createDrawerItem(icon: Icons.home, text: 'Home', index: 0),
          _createDrawerItem(icon: Icons.receipt, text: 'Orders', index: 1),
          _createDrawerItem(icon: Icons.menu_book, text: 'Menu', index: 2),
          _createDrawerItem(
              icon: Icons.person_2, text: "Delivery persons", index: 3),
          _createDrawerItem(
              icon: Icons.settings, text: "Edit profile", index: 4),
          Divider(),
          // Logout option
          ListTile(
            leading: Icon(Icons.logout),
            title: Text('Logout'),
            onTap: () => onLogout(),
          ),
        ],
      ),
    );
  }

  Widget _createDrawerItem(
      {required IconData icon, required String text, required int index}) {
    return ListTile(
      leading: Icon(icon),
      title: Text(text),
      selected: index == selectedIndex,
      onTap: () => onTap(index),
    );
  }
}
