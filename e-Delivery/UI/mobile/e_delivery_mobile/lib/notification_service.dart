import 'package:flutter_local_notifications/flutter_local_notifications.dart';

class NotificationService {
  static final FlutterLocalNotificationsPlugin _notificationsPlugin =
      FlutterLocalNotificationsPlugin();

  static void initialize() {
    final InitializationSettings initializationSettings =
        InitializationSettings(
      android: AndroidInitializationSettings('@mipmap/ic_launcher'),
    );
    _notificationsPlugin.initialize(initializationSettings);
  }

  static void display(String title, String body) async {
    try {
      final id = DateTime.now().millisecondsSinceEpoch ~/ 4000;
      final NotificationDetails notificationDetails = NotificationDetails(
        android: AndroidNotificationDetails('channel_id', 'channel_name',
            importance: Importance.max,
            priority: Priority.high,
            timeoutAfter: 10000),
      );
      await _notificationsPlugin.show(id, title, body, notificationDetails);
    } catch (e) {
      print(e);
    }
  }
}
