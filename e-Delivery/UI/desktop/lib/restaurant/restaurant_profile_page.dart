import 'dart:io';

import 'package:desktop/restaurant/api_calls/image_api_calls.dart';
import 'package:desktop/restaurant/api_calls/restaurant_api_calls.dart';
import 'package:flutter/material.dart';

import 'package:image_picker/image_picker.dart';
import 'package:desktop/restaurant/viewmodels/restaurant_get_VM.dart';

class RestaurantProfilePage extends StatefulWidget {
  final RestaurantViewModel? restaurantViewModel;
  final VoidCallback onProfilePictureUpdated;

  RestaurantProfilePage(
      {Key? key,
      this.restaurantViewModel,
      required this.onProfilePictureUpdated})
      : super(key: key);

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
    _nameController.dispose();
    _contactController.dispose();
    _addressController.dispose();
    _openingTimeController.dispose();
    _closingTimeController.dispose();
    _deliveryChargeController.dispose();
    _deliveryTimeController.dispose();

    super.dispose();
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
        restaurantViewModel.deliveryCharge.toStringAsFixed(2);
    _deliveryTimeController.text = restaurantViewModel.deliveryTime.toString();
    _isOpen = restaurantViewModel.isOpen;
  }

  Future<void> uploadImage() async {
    if (_imagePath != null) {
      bool uploadSuccess = false;
      if (_imagePath!.startsWith('http')) {
        uploadSuccess =
            await _imageApiService.updateRestaurantLogo(_imagePath!);
      } else {
        uploadSuccess = await _imageApiService.postRestaurantLogo(_imagePath!);
      }

      if (uploadSuccess) {
        widget.onProfilePictureUpdated();
        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(
            content: Center(
              child: Text(
                'Image uploaded successfully',
                style: TextStyle(color: Colors.white),
              ),
            ),
            backgroundColor: Colors.green,
            duration: Duration(seconds: 3),
          ),
        );
      } else {
        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(
            content: Center(
              child: Text(
                'Failed to upload image',
                style: TextStyle(color: Colors.white),
              ),
            ),
            backgroundColor: Colors.red,
            duration: Duration(seconds: 3),
          ),
        );
      }
    }
  }

  Widget _buildImageWidget() {
    if (_imagePath == null || _imagePath!.isEmpty) {
      return Container(
        width: 340,
        height: 300,
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

    if (_imagePath!.startsWith('http')) {
      return Image.network(
        _imagePath!,
        width: 340,
        height: 300,
        fit: BoxFit.cover,
      );
    } else {
      return Image.file(
        File(_imagePath!),
        width: 340,
        height: 300,
        fit: BoxFit.cover,
      );
    }
  }

  String _formatTime(String? timeString) {
    if (timeString != null && timeString.contains(":")) {
      final parts = timeString.split(':');
      if (parts.length >= 2) {
        return "${parts[0]}:${parts[1]}";
      }
    }
    return "00:00";
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
      width: 350,
      padding: EdgeInsets.only(bottom: 20),
      child: TextFormField(
        controller: controller,
        decoration: InputDecoration(
          labelText: label,
          suffixText: suffixText,
          border: OutlineInputBorder(),
        ),
        maxLength: maxLength,
      ),
    );
  }

  Widget _buildSwitch(String label, bool value, Function(bool) onChanged) {
    return SizedBox(
      width: 350,
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
      return TimeOfDay.now();
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
                            'Important data about the restaurant',
                            style: TextStyle(
                                fontSize: 24, fontWeight: FontWeight.bold),
                          ),
                          SizedBox(height: 26),
                          _buildTextField(_nameController, 'Restaurant name',
                              maxLength: 30),
                          _buildSwitch('Restaurant open : ', _isOpen, (value) {
                            setState(() {
                              _isOpen = value;
                            });
                          }),
                          SizedBox(height: 20),
                          _buildNumericField(
                              _deliveryChargeController, 'Delivery cost',
                              suffixText: 'KM'),
                          _buildNumericField(
                              _deliveryTimeController, 'Delivery time',
                              suffixText: "min"),
                          _buildTextField(_contactController, 'Contact',
                              maxLength: 12),
                          _buildTextField(
                              _addressController, 'Restaurant Address',
                              maxLength: 20),
                        ],
                      ),
                    ),
                    SizedBox(width: 20),
                    Expanded(
                      child: Column(
                        children: [
                          Text(
                            'Edit picture and opening hours',
                            style: TextStyle(
                                fontSize: 24, fontWeight: FontWeight.bold),
                          ),
                          SizedBox(height: 26),
                          _buildTimePickerField(
                              _openingTimeController,
                              'Opening hours',
                              widget.restaurantViewModel?.openingTime),
                          SizedBox(height: 20),
                          _buildTimePickerField(
                              _closingTimeController,
                              'Closing hours',
                              widget.restaurantViewModel?.closingTime),
                          SizedBox(height: 20),
                          _buildImageWidget(),
                          SizedBox(height: 20),
                          Row(
                            mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                            children: [
                              TextButton(
                                onPressed: pickImage,
                                child: Text('Choose a picture'),
                              ),
                              ElevatedButton(
                                onPressed: uploadImage,
                                child: Text('Upload picture'),
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
                      child: Text('Save changes'),
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
