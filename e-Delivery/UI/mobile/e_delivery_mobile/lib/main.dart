import 'dart:io';
import 'package:e_delivery_mobile/customer/core/themes/app_themes.dart';
import 'package:e_delivery_mobile/customer/screens/auth/login_page.dart';
import 'package:e_delivery_mobile/notification_service.dart';

import 'package:e_delivery_mobile/x509_override.dart';
import 'package:flutter/material.dart';

import 'package:flutter_stripe/flutter_stripe.dart';
import '.env';

void main() {
  late String stripePk;
  stripePk = const String.fromEnvironment("stripePublishableKey",
      defaultValue: stripePublishableKey);
  Stripe.publishableKey = stripePk;
  WidgetsFlutterBinding.ensureInitialized();
  HttpOverrides.global = X509Override();
  NotificationService.initialize();

  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'e-Delivery Mobile',
      theme: AppThemes.light,
      home: const LoginPage(),
    );
  }
}
