import 'package:e_delivery_mobile/customer/core/constants/app_defaults.dart';
import 'package:e_delivery_mobile/customer/screens/chat/api/chat_api.dart';
import 'package:e_delivery_mobile/customer/screens/chat/components/chat_input_field.dart';
import 'package:e_delivery_mobile/customer/screens/chat/components/message.dart';
import 'package:e_delivery_mobile/customer/screens/chat/dto/chat_get_dto.dart';

import 'package:e_delivery_mobile/signalr_service.dart';
import 'package:flutter/material.dart';

class MessagesPage extends StatefulWidget {
  final String deliveryPersonId;
  final String deliveryPersonName;
  final String deliveryPersonImageUrl;

  const MessagesPage({
    super.key,
    required this.deliveryPersonId,
    required this.deliveryPersonName,
    required this.deliveryPersonImageUrl,
  });

  static final GlobalKey<_MessagesPageState> messagesPageKey =
      GlobalKey<_MessagesPageState>();

  static void onMessageReceived(ChatGetDto message) {
    final messagesPageState = messagesPageKey.currentState;
    if (messagesPageState != null &&
        messagesPageState.widget.deliveryPersonId == message.userFromId) {
      messagesPageState._onMessageReceived(message);
    }
  }

  @override
  _MessagesPageState createState() => _MessagesPageState();
}

class _MessagesPageState extends State<MessagesPage> {
  final ChatService _chatService = ChatService();
  final SignalRService _signalRService = SignalRService();
  final ScrollController _scrollController = ScrollController();
  List<ChatGetDto> _chatMessages = [];
  bool _isLoading = false;

  @override
  void initState() {
    super.initState();
    _loadInitialMessages();
    _connectToChat();
  }

  Future<void> _loadInitialMessages() async {
    final messages =
        await _chatService.fetchChatHistory(widget.deliveryPersonId);
    if (mounted) {
      setState(() {
        _chatMessages = messages;
        _isLoading = false;
      });
      WidgetsBinding.instance.addPostFrameCallback((_) {
        if (_scrollController.hasClients) {
          _scrollController.jumpTo(_scrollController.position.maxScrollExtent);
        }
      });
    }
  }

  void _onMessageReceived(ChatGetDto message) {
    if (mounted) {
      setState(() {
        _chatMessages.add(message);
      });
      WidgetsBinding.instance.addPostFrameCallback((_) {
        if (_scrollController.hasClients) {
          _scrollController.jumpTo(_scrollController.position.maxScrollExtent);
        }
      });
    }
  }

  void _deleteMessage(String messageId) async {
    await _chatService.deleteMessage(messageId);
    if (mounted) {
      setState(() {
        _chatMessages.removeWhere((message) => message.id == messageId);
      });
      WidgetsBinding.instance.addPostFrameCallback((_) {
        if (_scrollController.hasClients) {
          _scrollController.jumpTo(_scrollController.position.maxScrollExtent);
        }
      });
    }
  }

  Future<void> _connectToChat() async {
    _signalRService.onMessageReceived = (ChatGetDto message) {
      if (message.userFromId == widget.deliveryPersonId) {
        _onMessageReceived(message);
      }
    };
    await _signalRService.connectToChat(widget.deliveryPersonId);
  }

  void _sendMessage(String content) async {
    final sentMessage =
        await _chatService.sendMessage(widget.deliveryPersonId, content);
    if (sentMessage != null && mounted) {
      setState(() {
        _chatMessages.add(sentMessage);
      });
      WidgetsBinding.instance.addPostFrameCallback((_) {
        if (_scrollController.hasClients) {
          _scrollController.jumpTo(_scrollController.position.maxScrollExtent);
        }
      });
    }
  }

  @override
  void dispose() {
    _signalRService.disconnectFromChat();
    _scrollController.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        automaticallyImplyLeading: false,
        title: Row(
          children: [
            const BackButton(),
            CircleAvatar(
              backgroundImage: NetworkImage(widget.deliveryPersonImageUrl),
            ),
            const SizedBox(width: AppDefaults.padding * 0.75),
            Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Text(
                  widget.deliveryPersonName,
                  style: const TextStyle(fontSize: 16),
                ),
              ],
            )
          ],
        ),
      ),
      body: Column(
        children: [
          Expanded(
            child: _isLoading
                ? const Center(child: CircularProgressIndicator())
                : ListView.builder(
                    controller: _scrollController,
                    itemCount: _chatMessages.length,
                    itemBuilder: (context, index) {
                      final message = _chatMessages[index];
                      return Message(
                        message: message,
                        isSender: message.userFromId == widget.deliveryPersonId,
                        deliveryPersonImageUrl: widget.deliveryPersonImageUrl,
                        onDeleteMessage: _deleteMessage,
                      );
                    },
                  ),
          ),
          ChatInputField(onSendMessage: _sendMessage),
        ],
      ),
    );
  }
}
