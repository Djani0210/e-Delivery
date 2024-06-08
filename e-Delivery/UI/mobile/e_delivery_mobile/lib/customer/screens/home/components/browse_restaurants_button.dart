import 'package:flutter/material.dart';

class BrowseRestaurantsButton extends StatelessWidget {
  final VoidCallback onPressed;

  const BrowseRestaurantsButton({Key? key, required this.onPressed})
      : super(key: key);
  @override
  Widget build(BuildContext context) {
    return Center(
      child: ElevatedButton(
        onPressed: onPressed,
        style: ElevatedButton.styleFrom(
          shape: CircleBorder(),
          padding: EdgeInsets.all(24),
          primary: Colors.orange,
          onPrimary: Colors.white,
          elevation: 8,
        ),
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            Icon(
              Icons.restaurant,
              size: 48,
            ),
            SizedBox(height: 8),
            Text(
              'Browse\nRestaurants',
              style: TextStyle(fontSize: 18, fontWeight: FontWeight.bold),
              textAlign: TextAlign.center,
            ),
          ],
        ),
      ),
    );
  }
}
