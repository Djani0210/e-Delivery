import 'package:e_delivery_mobile/customer/core/constants/app_defaults.dart';
import 'package:e_delivery_mobile/customer/screens/chat/dto/chat_get_dto.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

class Message extends StatelessWidget {
  const Message({
    Key? key,
    required this.message,
    required this.isSender,
    required this.deliveryPersonImageUrl,
    required this.onDeleteMessage,
  }) : super(key: key);

  final ChatGetDto message;
  final bool isSender;
  final String deliveryPersonImageUrl;
  final Function(String) onDeleteMessage;

  @override
  Widget build(BuildContext context) {
    final DateTime messageDateTime = message.createdDate;
    final String formattedTime = DateFormat('HH:mm').format(messageDateTime);

    return InkWell(
      onLongPress: () {
        showDialog(
          context: context,
          builder: (context) => AlertDialog(
            title: const Text('Delete Message'),
            content:
                const Text('Are you sure you want to delete this message?'),
            actions: [
              TextButton(
                onPressed: () => Navigator.pop(context),
                child: const Text('Cancel'),
              ),
              TextButton(
                onPressed: () {
                  onDeleteMessage(message.id);
                  Navigator.pop(context);
                },
                child: const Text('Delete'),
              ),
            ],
          ),
        );
      },
      child: Padding(
        padding: const EdgeInsets.only(top: AppDefaults.padding),
        child: Padding(
          padding: const EdgeInsets.symmetric(horizontal: AppDefaults.padding),
          child: Row(
            mainAxisAlignment:
                isSender ? MainAxisAlignment.start : MainAxisAlignment.end,
            crossAxisAlignment: CrossAxisAlignment.end,
            children: [
              if (isSender) ...[
                CircleAvatar(
                  radius: 12,
                  backgroundImage: NetworkImage(deliveryPersonImageUrl),
                ),
                const SizedBox(width: AppDefaults.padding / 2),
              ],
              Flexible(
                child: Container(
                  padding: const EdgeInsets.symmetric(
                    horizontal: AppDefaults.padding * 0.75,
                    vertical: AppDefaults.padding / 2,
                  ),
                  decoration: BoxDecoration(
                    color: isSender ? Colors.grey[300] : Colors.blue[300],
                    borderRadius: BorderRadius.circular(20),
                  ),
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.end,
                    children: [
                      Text(
                        message.content,
                        style: TextStyle(
                          color: isSender ? Colors.black : Colors.white,
                        ),
                      ),
                      const SizedBox(height: 5),
                      Text(
                        formattedTime,
                        style: TextStyle(
                          fontSize: 12,
                          color: Colors.grey[600],
                        ),
                      ),
                    ],
                  ),
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }
}
