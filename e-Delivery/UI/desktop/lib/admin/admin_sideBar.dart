import 'package:desktop/restaurant/viewmodels/userDataVM.dart';
import 'package:flutter/material.dart';

class Sidebar extends StatelessWidget {
  final int selectedIndex;
  final Function(int) onTap;
  final UserDataViewModel? userData;
  final Future<void> Function() onLogout;
  Sidebar(
      {required this.onTap,
      required this.selectedIndex,
      required this.userData,
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
                Text(userData?.firstName ?? 'Loading...',
                    style: TextStyle(color: Colors.white)),
              ],
            ),
          ),
          _createDrawerItem(icon: Icons.place, text: 'Citites', index: 0),
          _createDrawerItem(icon: Icons.category, text: 'Categories', index: 1),
          _createDrawerItem(
              icon: Icons.restaurant_outlined, text: 'Restaurants', index: 2),
          Divider(),
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
