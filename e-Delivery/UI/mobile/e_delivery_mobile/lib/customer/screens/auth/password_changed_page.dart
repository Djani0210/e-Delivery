import 'package:e_delivery_mobile/customer/core/constants/app_defaults.dart';
import 'package:e_delivery_mobile/customer/screens/auth/login_page.dart';
import 'package:flutter/material.dart';
import 'package:flutter_svg/svg.dart';
import 'package:e_delivery_mobile/customer/core/constants/ap_illustrations.dart';

class PasswordChangedPage extends StatelessWidget {
  const PasswordChangedPage({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SizedBox(
        width: double.infinity,
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            const Spacer(flex: 2),
            Text(
              'Password\nChanged!',
              style: Theme.of(context).textTheme.headlineSmall,
            ),
            const Spacer(flex: 1),
            SvgPicture.asset(AppIllustrations.illustration4),
            const Spacer(flex: 2),
            SizedBox(
              width: MediaQuery.of(context).size.width * 0.4,
              child: ElevatedButton(
                onPressed: () {
                  Navigator.push(
                      context,
                      MaterialPageRoute(
                          builder: (context) => const LoginPage()));
                },
                child: const Text('Return to Login'),
                style: ElevatedButton.styleFrom(
                  shape: const StadiumBorder(),
                  padding: const EdgeInsets.all(
                    AppDefaults.padding,
                  ),
                ),
              ),
            ),
            const Spacer(),
          ],
        ),
      ),
    );
  }
}
