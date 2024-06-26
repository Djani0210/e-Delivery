import 'package:e_delivery_mobile/customer/core/constants/app_colors.dart';
import 'package:e_delivery_mobile/customer/core/constants/app_defaults.dart';
import 'package:e_delivery_mobile/customer/screens/chat/components/chat_messages.dart';
import 'package:flutter/material.dart';

class AudioMessage extends StatelessWidget {
  final ChatMessage? message;

  const AudioMessage({Key? key, this.message}) : super(key: key);
  @override
  Widget build(BuildContext context) {
    return Container(
      width: MediaQuery.of(context).size.width * 0.55,
      padding: const EdgeInsets.symmetric(
        horizontal: AppDefaults.padding * 0.75,
        vertical: AppDefaults.padding / 2.5,
      ),
      decoration: BoxDecoration(
        borderRadius: BorderRadius.circular(30),
        color: AppColors.primary.withOpacity(message!.isSender ? 1 : 0.1),
      ),
      child: Row(
        children: [
          Icon(
            Icons.play_arrow,
            color: message!.isSender ? Colors.white : AppColors.primary,
          ),
          Expanded(
            child: Padding(
              padding: const EdgeInsets.symmetric(
                  horizontal: AppDefaults.padding / 2),
              child: Stack(
                clipBehavior: Clip.none,
                alignment: Alignment.center,
                children: [
                  Container(
                    width: double.infinity,
                    height: 2,
                    color: message!.isSender
                        ? Colors.white
                        : AppColors.primary.withOpacity(0.4),
                  ),
                  Positioned(
                    left: 0,
                    child: Container(
                      height: 8,
                      width: 8,
                      decoration: BoxDecoration(
                        color: message!.isSender
                            ? Colors.white
                            : AppColors.primary,
                        shape: BoxShape.circle,
                      ),
                    ),
                  )
                ],
              ),
            ),
          ),
          Text(
            "0.37",
            style: TextStyle(
                fontSize: 12, color: message!.isSender ? Colors.white : null),
          ),
        ],
      ),
    );
  }
}
