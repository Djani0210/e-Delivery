import 'dart:io';

import 'package:desktop/restaurant/api_calls/image_api_calls.dart';
import 'package:desktop/restaurant/api_calls/restaurant_api_calls.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:image_picker/image_picker.dart';
import 'package:desktop/restaurant/viewmodels/restaurant_get_VM.dart'; // Ensure this path is correct

class RestaurantProfilePage extends StatefulWidget {
  final RestaurantViewModel? restaurantViewModel;

  RestaurantProfilePage({Key? key, this.restaurantViewModel}) : super(key: key);

  @override
  _RestaurantProfilePageState createState() => _RestaurantProfilePageState();
}

class _RestaurantProfilePageState extends State<RestaurantProfilePage> {
  final ImageApiService _imageApiService = ImageApiService();
  final ApiService _apiService = ApiService();
  final TextEditingController _nameController = TextEditingController();
  final TextEditingController _contactController = TextEditingController();
  final TextEditingController _addressController = TextEditingController();
  final TextEditingController _openingTimeController = TextEditingController();
  final TextEditingController _closingTimeController = TextEditingController();
  bool _isOpen = false;
  final TextEditingController _deliveryChargeController =
      TextEditingController();
  final TextEditingController _deliveryTimeController = TextEditingController();

  String? _imagePath;

  @override
  void initState() {
    super.initState();
    if (widget.restaurantViewModel != null) {
      _populateFields(widget.restaurantViewModel!);
    }
  }

  @override
  void dispose() {
    // Dispose of all your text editing controllers here
    _nameController.dispose();
    _contactController.dispose();
    _addressController.dispose();
    _openingTimeController.dispose();
    _closingTimeController.dispose();
    _deliveryChargeController.dispose();
    _deliveryTimeController.dispose();

    super.dispose(); // Call the dispose method of the superclass at the end
  }

  void _populateFields(RestaurantViewModel restaurantViewModel) {
    setState(() {
      _nameController.text = restaurantViewModel.name;
      _contactController.text = restaurantViewModel.contactNumber;
      _addressController.text = restaurantViewModel.address;
      _openingTimeController.text =
          _formatTime(restaurantViewModel.openingTime);
      _closingTimeController.text =
          _formatTime(restaurantViewModel.closingTime);
      _imagePath = restaurantViewModel.logo?.fullImageUrl;
    });
    _deliveryChargeController.text =
        restaurantViewModel.deliveryCharge.toString();
    _deliveryTimeController.text = restaurantViewModel.deliveryTime.toString();
    _isOpen = restaurantViewModel.isOpen;
  }

  Future<void> uploadImage() async {
    if (_imagePath != null && !_imagePath!.startsWith('http')) {
      bool uploadSuccess =
          await _imageApiService.updateRestaurantLogo(_imagePath!);
      if (uploadSuccess) {
        print("Image successfully uploaded.");
        // Here you would ideally fetch the updated RestaurantViewModel to get the new image URL
      } else {
        print("Failed to upload image.");
      }
    }
  }

  Widget _buildImageWidget() {
    // Check if the image path is null or empty, show a placeholder or stock image in that case
    if (_imagePath == null || _imagePath!.isEmpty) {
      return Container(
        width: 340, // Smaller width for the placeholder
        height: 300, // Smaller height for the placeholder
        decoration: BoxDecoration(
          color: Colors.grey[300],
          borderRadius: BorderRadius.circular(8),
        ),
        child: Center(
          child: Text(
            'No image found',
            style: TextStyle(
              color: Colors.grey[600],
              fontStyle: FontStyle.italic,
            ),
          ),
        ),
      );
    }
    // If the image path starts with "http" it's a network image, else it's a file image
    if (_imagePath!.startsWith('http')) {
      return Image.network(
        _imagePath!,
        width: 340,
        height: 300,
        fit: BoxFit.cover,
      );
    } else {
      // Using dart:io's File class to create a file from the local path
      return Image.file(
        File(_imagePath!),
        width: 340,
        height: 300,
        fit: BoxFit.cover,
      );
    }
  }

  String _formatTime(String? timeString) {
    // Check if timeString is not null and follows expected format
    if (timeString != null && timeString.contains(":")) {
      final parts = timeString.split(':');
      if (parts.length >= 2) {
        // Ensure there's at least hours and minutes
        return "${parts[0]}:${parts[1]}"; // Returns hh:mm format
      }
    }
    return "00:00"; // Return a default value if format is incorrect
  }

  Future<void> pickImage() async {
    final pickedFile =
        await ImagePicker().pickImage(source: ImageSource.gallery);
    if (pickedFile != null) {
      setState(() {
        _imagePath = pickedFile.path;
      });
    }
  }

  Widget _buildTextField(TextEditingController controller, String label,
      {int? maxLength, String? suffixText}) {
    return Container(
      width: 350, // Consistent width for all fields
      padding: EdgeInsets.only(bottom: 20), // Adds spacing between fields
      child: TextFormField(
        controller: controller,
        decoration: InputDecoration(
          labelText: label,
          suffixText: suffixText,
          border:
              OutlineInputBorder(), // Provides a border around the input fields
        ),
        maxLength: maxLength,
      ),
    );
  }

  Widget _buildSwitch(String label, bool value, Function(bool) onChanged) {
    return SizedBox(
      width: 350, // Set the width to 300
      child: SwitchListTile(
        title: Text(label),
        value: value,
        onChanged: onChanged,
      ),
    );
  }

  Widget _buildNumericField(TextEditingController controller, String label,
      {int? maxLength, String? suffixText}) {
    return _buildTextField(controller, label,
        maxLength: maxLength, suffixText: suffixText);
  }

  Future<void> _selectTime(BuildContext context,
      TextEditingController controller, TimeOfDay initialTime) async {
    final TimeOfDay? picked = await showTimePicker(
      context: context,
      initialTime: initialTime,
    );
    if (picked != null) {
      controller.text = picked.format(context);
    }
  }

  Widget _buildTimePickerField(TextEditingController controller, String label,
      String? initialTimeString) {
    // Convert the initial time string to a TimeOfDay
    final TimeOfDay initialTime = _timeFromString(initialTimeString);

    return Container(
      width: 350,
      child: GestureDetector(
        onTap: () => _selectTime(context, controller, initialTime),
        child: AbsorbPointer(
          child: TextFormField(
            controller: controller,
            decoration: InputDecoration(
              labelText: label,
              suffixIcon: Icon(Icons.access_time),
            ),
          ),
        ),
      ),
    );
  }

  TimeOfDay _timeFromString(String? timeString) {
    if (timeString == null) {
      return TimeOfDay.now(); // Return current time if the string is null
    }
    final List<String> parts = timeString.split(':');
    return TimeOfDay(hour: int.parse(parts[0]), minute: int.parse(parts[1]));
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Center(
        child: SingleChildScrollView(
          child: Container(
            width: 1200,
            padding: const EdgeInsets.all(16.0),
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Row(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Expanded(
                      child: Column(
                        children: [
                          Text(
                            'Osnovni podaci o restoranu',
                            style: TextStyle(
                                fontSize: 24, fontWeight: FontWeight.bold),
                          ),
                          SizedBox(height: 26),
                          _buildTextField(_nameController, 'Naziv restorana',
                              maxLength: 20),
                          _buildSwitch('Restoran otvoren : ', _isOpen, (value) {
                            setState(() {
                              _isOpen = value;
                            });
                          }),
                          SizedBox(height: 20),
                          _buildNumericField(
                              _deliveryChargeController, 'Trošak dostave',
                              suffixText: 'KM'),
                          _buildNumericField(
                              _deliveryTimeController, 'Vrijeme dostave',
                              suffixText: "min"),
                          _buildTextField(_contactController, 'Kontakt broj',
                              maxLength: 12),
                          _buildTextField(
                              _addressController, 'Adresa restorana',
                              maxLength: 20),
                        ],
                      ),
                    ),
                    SizedBox(width: 20),
                    Expanded(
                      child: Column(
                        children: [
                          Text(
                            'Uredi sliku i vrijeme',
                            style: TextStyle(
                                fontSize: 24, fontWeight: FontWeight.bold),
                          ),
                          SizedBox(height: 26),
                          _buildTimePickerField(
                              _openingTimeController,
                              'Vrijeme otvaranja',
                              widget.restaurantViewModel?.openingTime),
                          SizedBox(height: 20),
                          _buildTimePickerField(
                              _closingTimeController,
                              'Vrijeme zatvaranja',
                              widget.restaurantViewModel?.closingTime),
                          SizedBox(height: 20),
                          _buildImageWidget(),
                          SizedBox(height: 20),
                          Row(
                            mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                            children: [
                              TextButton(
                                onPressed: pickImage,
                                child: Text('Odaberi sliku'),
                              ),
                              ElevatedButton(
                                onPressed: uploadImage,
                                child: Text('Sačuvaj sliku'),
                              ),
                            ],
                          ),
                        ],
                      ),
                    ),
                  ],
                ),
                SizedBox(height: 30),
                Center(
                  child: SizedBox(
                    width: 200,
                    height: 50,
                    child: ElevatedButton(
                      onPressed: () async {
                        try {
// Collect data from controllers and call the API
                          final updateData = {
                            'Name': _nameController.text,
                            'Address': _addressController.text,
                            'IsOpen': _isOpen,
                            'OpeningTime': _openingTimeController.text,
                            'ClosingTime': _closingTimeController.text,
                            'ContactNumber': _contactController.text,
                            'DeliveryCharge':
                                double.parse(_deliveryChargeController.text),
                            'DeliveryTime':
                                int.parse(_deliveryTimeController.text),
// Include other fields here
                          };
                          final response = await _apiService.updateRestaurant(
                              widget.restaurantViewModel!.id, updateData);
                          ScaffoldMessenger.of(context).showSnackBar(
                            SnackBar(
                              content: Text('Promjene sačuvane',
                                  style: TextStyle(color: Colors.green)),
                              backgroundColor: Colors.white,
                              duration: Duration(seconds: 1),
                            ),
                          );
                        } catch (e) {
                          ScaffoldMessenger.of(context).showSnackBar(
                            SnackBar(
                              content: Text(
                                  'Greška pri aktualiziranju restorana',
                                  style: TextStyle(color: Colors.red)),
                              backgroundColor: Colors.white,
                              duration: Duration(seconds: 1),
                            ),
                          );
                        }
                      },
                      child: Text('Sačuvaj promjene'),
                    ),
                  ),
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }
}
