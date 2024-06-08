import 'package:e_delivery_mobile/customer/core/constants/app_defaults.dart';
import 'package:e_delivery_mobile/customer/screens/auth/components/deliveryperson_signup_form.dart';
import 'package:flutter/material.dart';

class RegisterDeliveryPersonAccountPage extends StatelessWidget {
  const RegisterDeliveryPersonAccountPage({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      resizeToAvoidBottomInset: false,
      body: SafeArea(
        child: SingleChildScrollView(
          child: Column(
            children: [
              const SizedBox(height: 24),
              Align(
                alignment: Alignment.centerLeft,
                child: Padding(
                  padding: const EdgeInsets.all(AppDefaults.padding),
                  child: Text(
                    'Registruj\nNov racun dostavljaca',
                    style: Theme.of(context).textTheme.headlineSmall,
                  ),
                ),
              ),
              const SizedBox(height: 24),
              const DeliveryPersonSignupForm(),
              const SizedBox(height: 24),
            ],
          ),
        ),
      ),
    );
  }
}
