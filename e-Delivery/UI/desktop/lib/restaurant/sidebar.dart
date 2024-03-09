import 'package:desktop/restaurant/viewmodels/restaurant_get_VM.dart';
import 'package:flutter/material.dart';

class Sidebar extends StatelessWidget {
  final int selectedIndex;
  final Function(int) onTap;
  final RestaurantViewModel? restaurantData;
  Sidebar(
      {required this.onTap,
      required this.selectedIndex,
      required this.restaurantData});

  @override
  Widget build(BuildContext context) {
    return Drawer(
      child: ListView(
        children: [
          // Header (You can replace this with a UserAccountsDrawerHeader for a more material look)
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
          _createDrawerItem(icon: Icons.home, text: 'Početna', index: 0),
          _createDrawerItem(icon: Icons.receipt, text: 'Narudžbe', index: 1),
          _createDrawerItem(icon: Icons.menu_book, text: 'Meni', index: 2),
          _createDrawerItem(
              icon: Icons.person_2, text: "Dostavljači", index: 3),
          _createDrawerItem(
              icon: Icons.settings, text: "Uredi profil", index: 4)
          // ... more drawer items
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
