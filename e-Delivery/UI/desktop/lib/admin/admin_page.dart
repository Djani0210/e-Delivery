import "package:desktop/admin/admin_homescreen.dart";
import "package:flutter/material.dart";

class AdminPage extends StatefulWidget {
  const AdminPage({Key? key}) : super(key: key);
  @override
  _AdminPageState createState() => _AdminPageState();
}

class _AdminPageState extends State<AdminPage> {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Admin UI',
      themeMode: ThemeMode.system,
      darkTheme: ThemeData.dark(),
      theme: ThemeData(
        cardColor: Colors.white,
        scaffoldBackgroundColor: Colors.grey.shade100,
        useMaterial3: false,
      ),
      home: HomeScreenAdminPage(),
    );
  }
}
