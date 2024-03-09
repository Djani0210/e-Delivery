import 'package:desktop/restaurant/home_screen.dart';

import 'package:flutter/material.dart';

class MyApp extends StatefulWidget {
  const MyApp({super.key});

  @override
  State<MyApp> createState() => _MyAppState();
}

class _MyAppState extends State<MyApp> {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Restaurant UI',
      themeMode: ThemeMode.system,
      darkTheme: ThemeData.dark(),
      theme: ThemeData(
        cardColor: Colors.white,
        scaffoldBackgroundColor: Colors.grey.shade100,
        useMaterial3: false,
      ),
      home: HomeScreenNew(),
    );
  }
}
