import 'package:e_delivery_mobile/customer/screens/profile/api/notification_api.dart';
import 'package:e_delivery_mobile/customer/screens/profile/dto/notification_get_dto.dart';
import 'package:flutter/material.dart';

class NotificationPage extends StatefulWidget {
  @override
  _NotificationPageState createState() => _NotificationPageState();
}

class _NotificationPageState extends State<NotificationPage> {
  final NotificationApiService _notificationApiService =
      NotificationApiService();
  List<GetNotificationVM> _notifications = [];
  bool _isLoading = true;
  bool _isLoadingMore = false;
  int _loadedNotifications = 0;
  final int _loadBatchSize = 5;

  @override
  void initState() {
    super.initState();
    _loadNotifications();
  }

  Future<void> _loadNotifications({bool loadMore = false}) async {
    if (loadMore) {
      setState(() {
        _isLoadingMore = true;
      });
    } else {
      setState(() {
        _isLoading = true;
      });
    }

    try {
      final notifications = await _notificationApiService.getNotifications();
      setState(() {
        if (loadMore) {
          _notifications.addAll(
              notifications.skip(_loadedNotifications).take(_loadBatchSize));
        } else {
          _notifications = notifications.take(_loadBatchSize).toList();
        }
        _loadedNotifications += _loadBatchSize;
      });
    } catch (e) {
      print(e);
    } finally {
      setState(() {
        _isLoading = false;
        _isLoadingMore = false;
      });
    }
  }

  Future<void> _deleteNotification(int id) async {
    try {
      await _notificationApiService.deleteNotification(id);
      _loadedNotifications = 0;
      _loadNotifications();
    } catch (e) {
      print(e);
    }
  }

  Future<void> _deleteAllNotifications() async {
    final confirm = await showDialog<bool>(
      context: context,
      builder: (context) => AlertDialog(
        title: Text('Confirm'),
        content: Text('Are you sure you want to delete all notifications?'),
        actions: [
          TextButton(
            onPressed: () => Navigator.of(context).pop(false),
            child: Text('Cancel'),
          ),
          TextButton(
            onPressed: () => Navigator.of(context).pop(true),
            child: Text('Delete'),
          ),
        ],
      ),
    );

    if (confirm == true) {
      try {
        await _notificationApiService.deleteAllNotifications();
        _loadedNotifications = 0;
        _loadNotifications();
      } catch (e) {
        print(e);
      }
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Notifications'),
        backgroundColor: Colors.orange[50],
        leading: IconButton(
          icon: Icon(Icons.arrow_back),
          onPressed: () {
            Navigator.of(context).pop();
          },
        ),
        actions: [
          TextButton(
            onPressed: _deleteAllNotifications,
            child: Text(
              'Clear All',
              style: TextStyle(color: Colors.red),
            ),
          ),
        ],
      ),
      body: Container(
        color: Colors.grey[200],
        padding: EdgeInsets.all(16.0),
        child: _isLoading
            ? Center(child: CircularProgressIndicator())
            : _notifications.isEmpty
                ? Center(child: Text('No notifications found'))
                : Column(
                    children: [
                      Expanded(
                        child: ListView.builder(
                          itemCount: _notifications.length,
                          itemBuilder: (context, index) {
                            final notification = _notifications[index];
                            return Card(
                              color: Colors.orange[100],
                              margin: EdgeInsets.symmetric(vertical: 8.0),
                              child: ListTile(
                                leading:
                                    Icon(Icons.fastfood, color: Colors.orange),
                                title: Text(
                                  notification.restaurantName ??
                                      'Unknown Restaurant',
                                  style: TextStyle(fontWeight: FontWeight.bold),
                                ),
                                subtitle: Column(
                                  crossAxisAlignment: CrossAxisAlignment.start,
                                  children: [
                                    Text(notification.content),
                                    SizedBox(height: 4.0),
                                    Text(
                                      '${notification.createdDate.year}-${notification.createdDate.month.toString().padLeft(2, '0')}-${notification.createdDate.day.toString().padLeft(2, '0')} ${notification.createdDate.hour.toString().padLeft(2, '0')}:${notification.createdDate.minute.toString().padLeft(2, '0')}',
                                      style: TextStyle(color: Colors.grey),
                                    ),
                                  ],
                                ),
                                trailing: IconButton(
                                  icon: Icon(Icons.close, color: Colors.red),
                                  onPressed: () =>
                                      _deleteNotification(notification.id),
                                ),
                              ),
                            );
                          },
                        ),
                      ),
                      if (_isLoadingMore)
                        Center(child: CircularProgressIndicator()),
                      if (!_isLoadingMore &&
                          _notifications.length >= _loadedNotifications)
                        TextButton(
                          onPressed: () => _loadNotifications(loadMore: true),
                          child: Text('Load More'),
                        ),
                    ],
                  ),
      ),
    );
  }
}
