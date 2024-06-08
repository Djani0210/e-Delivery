import 'package:e_delivery_mobile/customer/core/constants/app_defaults.dart';
import 'package:e_delivery_mobile/customer/screens/auth/components/customer_signup_form.dart';
import 'package:flutter/material.dart';

class RegisterCustomerAccountPage extends StatelessWidget {
  const RegisterCustomerAccountPage({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      resizeToAvoidBottomInset: false,
      body: SafeArea(
        child: Column(
          children: [
            const Spacer(),
            Align(
              alignment: Alignment.centerLeft,
              child: Padding(
                padding: const EdgeInsets.all(AppDefaults.padding),
                child: Text(
                  'Register\nNew customer account',
                  style: Theme.of(context).textTheme.headlineSmall,
                ),
              ),
            ),
            const Spacer(),
            const CustomerSignupForm(),
            const Spacer(),
          ],
        ),
      ),
    );
  }
}
