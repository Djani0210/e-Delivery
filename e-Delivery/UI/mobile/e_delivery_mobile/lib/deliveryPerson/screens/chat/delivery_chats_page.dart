import "package:e_delivery_mobile/customer/core/constants/app_colors.dart";
import "package:e_delivery_mobile/customer/screens/chat/api/chat_api.dart";
import "package:e_delivery_mobile/customer/screens/chat/components/chat_card.dart";
import "package:e_delivery_mobile/customer/screens/chat/messages_page.dart";
import "package:e_delivery_mobile/customer/screens/profile/api/profile_api.dart";
import "package:e_delivery_mobile/customer/screens/profile/dto/customer_get_dto.dart";

import "package:flutter/material.dart";

class DeliveryChatsPage extends StatefulWidget {
  const DeliveryChatsPage({super.key});

  @override
  _DeliveryChatsPageState createState() => _DeliveryChatsPageState();
}

class _DeliveryChatsPageState extends State<DeliveryChatsPage> {
  late Future<List<CustomerGetDto>> _customersFuture;
  final ChatService _chatService = ChatService();
  final ProfileService _profileService = ProfileService();

  @override
  void initState() {
    super.initState();
    _customersFuture = _chatService.fetchCustomersForChat();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        automaticallyImplyLeading: false,
        title: const Text("Chats"),
        backgroundColor: AppColors.primary,
      ),
      body: Column(
        children: [
          const SizedBox(
            height: 30,
          ),
          Expanded(
            child: FutureBuilder<List<CustomerGetDto>>(
              future: _customersFuture,
              builder: (context, snapshot) {
                if (snapshot.connectionState == ConnectionState.waiting) {
                  return const Center(child: CircularProgressIndicator());
                } else if (snapshot.hasError) {
                  return Center(child: Text('Error: ${snapshot.error}'));
                } else if (snapshot.hasData && snapshot.data!.isNotEmpty) {
                  final deliveryPersons = snapshot.data!;
                  return ListView.builder(
                    itemCount: deliveryPersons.length,
                    itemBuilder: (context, index) {
                      final deliveryPerson = deliveryPersons[index];
                      return FutureBuilder<String>(
                        future:
                            _profileService.fetchImageUrl(deliveryPerson.id),
                        builder: (context, imageSnapshot) {
                          final imageUrl = imageSnapshot.data ?? '';
                          return ChatCard(
                            name: deliveryPerson.userName,
                            imageUrl: imageUrl,
                            press: () => Navigator.push(
                              context,
                              MaterialPageRoute(
                                builder: (context) => MessagesPage(
                                  deliveryPersonId: deliveryPerson.id,
                                  deliveryPersonName: deliveryPerson.userName,
                                  deliveryPersonImageUrl: imageUrl,
                                ),
                              ),
                            ),
                          );
                        },
                      );
                    },
                  );
                } else {
                  return const Center(child: Text('No chats found'));
                }
              },
            ),
          ),
        ],
      ),
    );
  }
}
