import 'package:flutter/material.dart';
import 'package:flutter_svg/svg.dart';
import 'package:e_delivery_mobile/customer/core/constants/app_icons.dart';
import 'package:e_delivery_mobile/customer/screens/chat/chats_page.dart';
import 'package:e_delivery_mobile/customer/screens/home/home_page.dart';
import 'package:e_delivery_mobile/customer/screens/profile/profile_page.dart';
import 'package:e_delivery_mobile/customer/screens/restaurants/restaurants_page.dart';

class CustomerEntryPoint extends StatefulWidget {
  const CustomerEntryPoint({Key? key}) : super(key: key);

  @override
  State<CustomerEntryPoint> createState() => _CustomerEntryPointState();
}

class _CustomerEntryPointState extends State<CustomerEntryPoint> {
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
          HomePage(onNavigateToRestaurants: () => _onMenuChanged(1)),
          const RestaurantsPage(),
          const ChatsPage(),
          const ProfilePage(),
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
/* import 'package:animations/animations.dart';
import 'package:e_delivery_mobile/customer/core/constants/app_icons.dart';
import 'package:e_delivery_mobile/customer/screens/chat/chats_page.dart';

import 'package:e_delivery_mobile/customer/screens/home/home_page.dart';
import 'package:e_delivery_mobile/customer/screens/profile/profile_page.dart';
import 'package:e_delivery_mobile/customer/screens/restaurants/restaurants_page.dart';
import 'package:flutter/material.dart';
import 'package:flutter_svg/svg.dart';

class CustomerEntryPoint extends StatefulWidget {
  const CustomerEntryPoint({
    Key? key,
  }) : super(key: key);

  @override
  State<CustomerEntryPoint> createState() => _CustomerEntryPointState();
}

class _CustomerEntryPointState extends State<CustomerEntryPoint> {
  int _currentPage = 0;

  late final List<Widget> _screens;

  void _onMenuChanged(int index) {
    setState(() {
      _currentPage = index;
    });
  }

  void _navigateToRestaurantsPage() {
    setState(() {
      _currentPage = 1;
    });
  }

  @override
  void initState() {
    super.initState();
    _screens = [
      HomePage(onNavigateToRestaurants: _navigateToRestaurantsPage),
      const RestaurantsPage(),
      const ChatsPage(),
      const ProfilePage(),
    ];
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      resizeToAvoidBottomInset: false,
      body: Navigator(
        onGenerateRoute: (settings) {
          return MaterialPageRoute(
            builder: (context) => PageTransitionSwitcher(
              transitionBuilder:
                  ((child, primaryAnimation, secondaryAnimation) =>
                      SharedAxisTransition(
                        animation: primaryAnimation,
                        secondaryAnimation: secondaryAnimation,
                        transitionType: SharedAxisTransitionType.horizontal,
                        child: child,
                      )),
              child: _screens[_currentPage],
            ),
          );
        },
      ),
      bottomNavigationBar: BottomNavigationBar(
        type: BottomNavigationBarType.fixed,
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
 */