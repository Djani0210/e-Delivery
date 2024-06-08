import 'package:flutter/material.dart';
import 'package:e_delivery_mobile/customer/screens/home/dto/user_data_dto.dart';

class UserDataNotifier extends ValueNotifier<UserDataViewModel?> {
  UserDataNotifier() : super(null);

  void updateUserData(UserDataViewModel? userData) {
    value = userData;
    notifyListeners();
  }
}

final userDataNotifier = UserDataNotifier();
