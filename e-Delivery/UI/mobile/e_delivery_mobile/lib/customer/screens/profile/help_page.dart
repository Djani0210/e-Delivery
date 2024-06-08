import 'package:e_delivery_mobile/customer/screens/profile/api/profile_api.dart';
import 'package:flutter/material.dart';

class HelpPage extends StatefulWidget {
  @override
  _HelpPageState createState() => _HelpPageState();
}

class _HelpPageState extends State<HelpPage> {
  final ProfileService _profileService = ProfileService();
  String? _adminEmail;
  String? _adminPhoneNumber;
  bool _isLoading = true;
  String? _errorMessage;

  @override
  void initState() {
    super.initState();
    _fetchAdmin();
  }

  Future<void> _fetchAdmin() async {
    try {
      final adminData = await _profileService.fetchAdmin();
      setState(() {
        _adminEmail = adminData['email']!;
        _adminPhoneNumber = adminData['phoneNumber']!;
        _isLoading = false;
      });
    } catch (e) {
      setState(() {
        _errorMessage = e.toString();
        _isLoading = false;
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Help'),
      ),
      body: _isLoading
          ? Center(child: CircularProgressIndicator())
          : _errorMessage != null
              ? Center(
                  child: Text(
                    'Error: $_errorMessage',
                    style: TextStyle(color: Colors.red, fontSize: 18),
                  ),
                )
              : SingleChildScrollView(
                  padding: EdgeInsets.all(16.0),
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      Text(
                        'Help & Support',
                        style: TextStyle(
                          fontSize: 28,
                          fontWeight: FontWeight.bold,
                          color: Colors.blueAccent,
                        ),
                      ),
                      SizedBox(height: 16),
                      Text(
                        'Welcome to our Help & Support page. We are a food delivery app dedicated to providing care and security for our customers. Our mission is to ensure that you have a seamless and enjoyable experience with our service.',
                        style: TextStyle(fontSize: 18),
                      ),
                      SizedBox(height: 16),
                      Text(
                        'What We Stand For',
                        style: TextStyle(
                          fontSize: 24,
                          fontWeight: FontWeight.bold,
                          color: Colors.blueAccent,
                        ),
                      ),
                      SizedBox(height: 8),
                      Text(
                        'We stand for quality, reliability, and customer satisfaction. Our team works tirelessly to bring you the best food delivery experience possible. We value your trust and strive to exceed your expectations with every order.',
                        style: TextStyle(fontSize: 18),
                      ),
                      SizedBox(height: 16),
                      Text(
                        'Contact Us',
                        style: TextStyle(
                          fontSize: 24,
                          fontWeight: FontWeight.bold,
                          color: Colors.blueAccent,
                        ),
                      ),
                      SizedBox(height: 8),
                      Text(
                        'In case of any issues, scams, or fraud, please do not hesitate to contact us. You can reach out to us at the following:',
                        style: TextStyle(fontSize: 18),
                      ),
                      SizedBox(height: 8),
                      Text(
                        'Email: $_adminEmail',
                        style: TextStyle(fontSize: 18, color: Colors.blue),
                      ),
                      SizedBox(height: 8),
                      Text(
                        'Phone: $_adminPhoneNumber',
                        style: TextStyle(fontSize: 18, color: Colors.blue),
                      ),
                      SizedBox(height: 16),
                      Text(
                        'Thank you for choosing our service. We are here to help you with any questions or concerns you may have.',
                        style: TextStyle(fontSize: 18),
                      ),
                    ],
                  ),
                ),
    );
  }
}
