import 'dart:io';
import 'package:e_delivery_mobile/customer/screens/profile/dto/customer_get_dto.dart';
import 'package:flutter/material.dart';
import 'package:image_picker/image_picker.dart';
import 'package:e_delivery_mobile/customer/core/constants/app_defaults.dart';
import 'package:e_delivery_mobile/customer/screens/home/dto/user_data_dto.dart';
import 'package:e_delivery_mobile/customer/screens/profile/api/profile_api.dart';

class ProfileHeader extends StatefulWidget {
  final CustomerGetDto userDataViewModel;

  ProfileHeader({Key? key, required this.userDataViewModel}) : super(key: key);

  @override
  _ProfileHeaderState createState() => _ProfileHeaderState();
}

class _ProfileHeaderState extends State<ProfileHeader> {
  @override
  Widget build(BuildContext context) {
    return Stack(
      children: [
        ClipRect(
          child: Align(
            alignment: Alignment.topCenter,
            heightFactor: 0.4,
            child: Image.asset('assets/images/orange_profile_photo1.jpg'),
          ),
        ),
        Column(
          children: [
            AppBar(
              title: const Text('Profile'),
              elevation: 0,
              backgroundColor: Colors.transparent,
              titleTextStyle: Theme.of(context).textTheme.titleLarge?.copyWith(
                    color: Colors.white,
                    fontWeight: FontWeight.bold,
                  ),
            ),
            UserData(
                userDataViewModel: widget.userDataViewModel,
                refreshParent: refreshParent),
          ],
        ),
      ],
    );
  }

  void refreshParent(UserDataViewModel userDataViewModel) {
    setState(() {});
  }
}

class UserData extends StatelessWidget {
  final CustomerGetDto userDataViewModel;
  final Function refreshParent;

  const UserData(
      {Key? key, required this.userDataViewModel, required this.refreshParent})
      : super(key: key);

  @override
  Widget build(BuildContext context) {
    final ProfileService _profileService = ProfileService();

    return FutureBuilder<String>(
      future: _profileService.fetchImageUrl(userDataViewModel.id),
      builder: (BuildContext context, AsyncSnapshot<String> snapshot) {
        Widget imageWidget;
        if (snapshot.connectionState == ConnectionState.waiting) {
          imageWidget = CircularProgressIndicator();
        } else if (snapshot.hasError || !snapshot.hasData) {
          imageWidget = Icon(Icons.error, color: Colors.red);
        } else {
          imageWidget = Stack(
            children: [
              ClipOval(
                child: Image.network(snapshot.data!,
                    width: 100, height: 100, fit: BoxFit.cover),
              ),
              Positioned(
                bottom: 0,
                right: 0,
                child: Container(
                  height: 30,
                  width: 30,
                  decoration: BoxDecoration(
                    shape: BoxShape.circle,
                    border: Border.all(
                      width: 3,
                      color: Theme.of(context).scaffoldBackgroundColor,
                    ),
                    color: Colors.orange,
                  ),
                  child: IconButton(
                    icon: Icon(Icons.edit, size: 15, color: Colors.white),
                    padding: EdgeInsets.zero,
                    constraints: BoxConstraints(),
                    onPressed: () => _changeProfilePicture(context),
                  ),
                ),
              ),
            ],
          );
        }

        return Padding(
          padding: const EdgeInsets.all(AppDefaults.padding),
          child: SingleChildScrollView(
            scrollDirection: Axis.horizontal,
            child: Row(
              children: [
                const SizedBox(width: AppDefaults.padding),
                imageWidget,
                const SizedBox(width: AppDefaults.padding),
                Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Text(
                      userDataViewModel.userName,
                      style: Theme.of(context).textTheme.titleLarge?.copyWith(
                          fontWeight: FontWeight.bold, color: Colors.white),
                    ),
                    const SizedBox(height: 8),
                    Text(
                      'Contact: ${userDataViewModel.phoneNumber}',
                      style: Theme.of(context)
                          .textTheme
                          .bodyLarge
                          ?.copyWith(color: Colors.white),
                    ),
                  ],
                )
              ],
            ),
          ),
        );
      },
    );
  }

  Future<void> _changeProfilePicture(BuildContext context) async {
    final picker = ImagePicker();
    final pickedFile = await picker.pickImage(source: ImageSource.gallery);

    if (pickedFile != null) {
      File imageFile = File(pickedFile.path);
      await _uploadProfileImage(imageFile, context);
    }
  }

  Future<void> _uploadProfileImage(File image, BuildContext context) async {
    final ProfileService _profileService = ProfileService();
    await _profileService.uploadProfileImage(image);
    refreshParent();
  }
}
