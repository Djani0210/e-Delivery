import 'package:e_delivery_mobile/deliveryPerson/screens/chat/delivery_chats_page.dart';
import 'package:e_delivery_mobile/deliveryPerson/screens/home/delivery_home_page.dart';
import 'package:e_delivery_mobile/deliveryPerson/screens/order/delivery_orders_page.dart';
import 'package:e_delivery_mobile/deliveryPerson/screens/profile/delivery_profile_page.dart';
import 'package:flutter/material.dart';
import 'package:flutter_svg/svg.dart';
import 'package:e_delivery_mobile/customer/core/constants/app_icons.dart';

class DeliveryPersonEntryPoint extends StatefulWidget {
  const DeliveryPersonEntryPoint({Key? key}) : super(key: key);

  @override
  State<DeliveryPersonEntryPoint> createState() => _CustomerEntryPointState();
}

class _CustomerEntryPointState extends State<DeliveryPersonEntryPoint> {
  int _currentPage = 0;
  late PageController _pageController;

  @override
  void initState() {
    super.initState();
    _pageController = PageController();
  }

  @override
  void dispose() {
    _pageController.dispose();
    super.dispose();
  }

  void _onPageChanged(int index) {
    setState(() {
      _currentPage = index;
    });
  }

  void _onMenuChanged(int index) {
    _pageController.jumpToPage(index);
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: PageView(
        controller: _pageController,
        onPageChanged: _onPageChanged,
        children: [
          const DeliveryHomePage(),
          DeliveryOrdersPage(),
          const DeliveryChatsPage(),
          const EmployeeProfilePage(),
        ],
        physics: NeverScrollableScrollPhysics(),
      ),
      bottomNavigationBar: BottomNavigationBar(
        type: BottomNavigationBarType.fixed,
        currentIndex: _currentPage,
        onTap: _onMenuChanged,
        items: [
          BottomNavigationBarItem(
            icon: Padding(
              padding: const EdgeInsets.all(8.0),
              child: SvgPicture.asset(
                  _currentPage == 0 ? AppIcons.homeBold : AppIcons.home),
            ),
            label: '',
          ),
          BottomNavigationBarItem(
            icon: Padding(
              padding: const EdgeInsets.all(8.0),
              child: SvgPicture.asset(_currentPage == 1
                  ? AppIcons.foodStyleBold
                  : AppIcons.foodStyle),
            ),
            label: '',
          ),
          BottomNavigationBarItem(
            icon: Padding(
              padding: const EdgeInsets.all(8.0),
              child: SvgPicture.asset(
                  _currentPage == 2 ? AppIcons.chat : AppIcons.chat),
            ),
            label: '',
          ),
          BottomNavigationBarItem(
            icon: Padding(
              padding: const EdgeInsets.all(8.0),
              child: SvgPicture.asset(
                  _currentPage == 3 ? AppIcons.profileBold : AppIcons.profile),
            ),
            label: '',
          ),
        ],
      ),
    );
  }
}
