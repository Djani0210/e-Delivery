import 'package:desktop/notifications_service.dart';
import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import 'package:signalr_netcore/signalr_client.dart';

class SignalRService {
  final String _baseUrl = 'https://localhost:44395/toastr';
  late HubConnection _connection;
  final _storage = const FlutterSecureStorage();
  bool connectionIsOpen = false;

  Future<void> connect(String userId) async {
    try {
      _connection = HubConnectionBuilder()
          .withUrl(_baseUrl,
              options: HttpConnectionOptions(
                  accessTokenFactory: () async => await _fetchJwtToken()))
          .build();

      _connection.onclose(({error}) {
        print("connection failed: $error");
      });

      _connection.on('ReceiveNotification', (message) {
        print('Received notification: $message');
        NotificationService.display('Order Update', message![0].toString());
      });

      await _connection.start();
      print('SignalR connection established.');
      connectionIsOpen = true;
    } catch (e) {
      print('SignalR connection error: $e');
    }
  }

  Future<void> disconnect() async {
    await _connection.stop();
  }

  Future<String> _fetchJwtToken() async {
    String? jwt = await _storage.read(key: 'jwt');
    return jwt ?? '';
  }
}
