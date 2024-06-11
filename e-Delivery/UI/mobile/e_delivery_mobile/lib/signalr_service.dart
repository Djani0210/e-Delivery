import 'package:e_delivery_mobile/customer/screens/chat/dto/chat_get_dto.dart';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import 'package:signalr_netcore/signalr_client.dart';
import 'package:e_delivery_mobile/notification_service.dart';

class SignalRService {
  final String _baseUrl = 'http://10.0.2.2:44395';
  HubConnection? _notificationConnection;
  HubConnection? _chatConnection;

  final _storage = const FlutterSecureStorage();
  bool notificationConnectionIsOpen = false;
  bool chatConnectionIsOpen = false;

  Function(ChatGetDto)? onMessageReceived;

  Future<void> connectToChat(String userId) async {
    try {
      _chatConnection = HubConnectionBuilder()
          .withUrl('$_baseUrl/chathub',
              options: HttpConnectionOptions(
                  accessTokenFactory: () async => await _fetchJwtToken()))
          .build();

      _chatConnection?.onclose(({error}) {
        print("Chat connection failed: $error");
      });

      _chatConnection?.on('ReceiveMessage', (message) {
        if (message != null && message.isNotEmpty) {
          final Map<String, dynamic> messageMap =
              Map<String, dynamic>.from(message[0] as Map);
          final chatMessage = ChatGetDto.fromJson(messageMap);
          if (onMessageReceived != null) {
            onMessageReceived!(chatMessage);
          }
        }
      });

      await _chatConnection?.start();
      print('SignalR chat connection established.');
      chatConnectionIsOpen = true;
    } catch (e) {
      print('SignalR chat connection error: $e');
    }
  }

  Future<void> disconnectFromChat() async {
    if (_chatConnection != null) {
      await _chatConnection?.stop();
      _chatConnection = null;
      chatConnectionIsOpen = false;
    }
  }

  Future<void> sendMessage(String userToId, String content) async {
    if (chatConnectionIsOpen) {
      final chat = {
        'userFromId': await _fetchUserId(),
        'userToId': userToId,
        'content': content,
        'isDeleted': false,
        'createdDate': DateTime.now().toIso8601String(),
      };
      await _chatConnection?.invoke('SendMessage', args: [chat]);
    } else {
      print('Chat connection is not open.');
    }
  }

  Future<String> _fetchUserId() async {
    String? userId = await _storage.read(key: 'currentUserId');
    return userId ?? '';
  }

  Future<void> connectToNotifications(String userId) async {
    try {
      _notificationConnection = HubConnectionBuilder()
          .withUrl('$_baseUrl/toastr',
              options: HttpConnectionOptions(
                  accessTokenFactory: () async => await _fetchJwtToken()))
          .build();

      _notificationConnection?.onclose(({error}) {
        print("Notification connection failed: $error");
      });

      _notificationConnection?.on('ReceiveNotification', (message) {
        print('Received notification: $message');
        NotificationService.display('Order Update', message![0].toString());
      });

      await _notificationConnection?.start();
      print('SignalR notification connection established.');
      notificationConnectionIsOpen = true;
    } catch (e) {
      print('SignalR notification connection error: $e');
    }
  }

  Future<void> disconnectFromNotifications() async {
    if (_notificationConnection != null) {
      await _notificationConnection?.stop();
      _notificationConnection = null;
      notificationConnectionIsOpen = false;
    }
  }

  Future<String> _fetchJwtToken() async {
    String? jwt = await _storage.read(key: 'jwt');
    return jwt ?? '';
  }
}
