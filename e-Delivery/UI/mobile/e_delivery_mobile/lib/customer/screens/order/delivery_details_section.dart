import 'package:e_delivery_mobile/customer/screens/order/map_screen.dart';
import 'package:flutter/material.dart';
import 'package:google_maps_flutter/google_maps_flutter.dart';

class DeliveryDetailsSection extends StatelessWidget {
  final String? address;
  final Map<String, String>? addressDetails;
  final String? cityId;
  final ValueChanged<String> onAddressSelected;
  final ValueChanged<Map<String, String>> onAddressDetailsUpdated;

  const DeliveryDetailsSection(
      {Key? key,
      this.address,
      this.addressDetails,
      this.cityId,
      required this.onAddressSelected,
      required this.onAddressDetailsUpdated})
      : super(key: key);

  void _showMap(BuildContext context) async {
    final result = await Navigator.push(
      context,
      MaterialPageRoute(
        builder: (context) => MapScreen(
          initialAddressDetails: addressDetails,
        ),
      ),
    );

    if (result != null && result is Map) {
      final selectedAddress = result['address'] as String;
      final newAddressDetails = result['details'] as Map<String, String>? ?? {};
      final newCityId = result['cityId'] as String?;

      print(
          "Address: $selectedAddress, Details: $newAddressDetails, City ID: $newCityId");

      if (selectedAddress != null) {
        onAddressSelected(selectedAddress);
      }
      onAddressDetailsUpdated(newAddressDetails);
    }
  }

  @override
  Widget build(BuildContext context) {
    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        const Text(
          'Delivery details',
          style: TextStyle(fontSize: 24, fontWeight: FontWeight.bold),
        ),
        const SizedBox(height: 16),
        GestureDetector(
          onTap: () => _showMap(context),
          child: Row(
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            children: [
              Row(
                children: [
                  Icon(Icons.location_on, color: Colors.orange),
                  const SizedBox(width: 8),
                  Text(
                    address ?? 'Select location',
                    style: TextStyle(fontSize: 16),
                  ),
                ],
              ),
              Icon(Icons.arrow_forward_ios, color: Colors.grey),
            ],
          ),
        ),
      ],
    );
  }
}
