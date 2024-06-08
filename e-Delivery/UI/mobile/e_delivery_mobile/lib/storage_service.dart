import 'package:flutter_secure_storage/flutter_secure_storage.dart';

class StorageService {
  static final FlutterSecureStorage _storage = FlutterSecureStorage();

  static FlutterSecureStorage get storage => _storage;
}
