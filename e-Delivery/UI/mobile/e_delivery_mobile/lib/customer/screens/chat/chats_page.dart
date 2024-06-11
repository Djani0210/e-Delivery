import 'package:e_delivery_mobile/customer/core/constants/app_colors.dart';
import 'package:e_delivery_mobile/customer/screens/chat/api/chat_api.dart';
import 'package:e_delivery_mobile/customer/screens/chat/components/chat_card.dart';
import 'package:e_delivery_mobile/customer/screens/chat/messages_page.dart';
import 'package:e_delivery_mobile/customer/screens/profile/api/profile_api.dart';
import 'package:e_delivery_mobile/deliveryPerson/screens/home/dto/delivery_person_get_dto.dart';
import 'package:flutter/material.dart';

class ChatsPage extends StatefulWidget {
  const ChatsPage({super.key});

  @override
  _ChatsPageState createState() => _ChatsPageState();
}

class _ChatsPageState extends State<ChatsPage> {
  late Future<List<DeliveryPersonGetDTO>> _deliveryPersonsFuture;
  final ChatService _chatService = ChatService();
  final ProfileService _profileService = ProfileService();

  @override
  void initState() {
    super.initState();
    _deliveryPersonsFuture = _chatService.fetchDeliveryPersons();
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
            child: FutureBuilder<List<DeliveryPersonGetDTO>>(
              future: _deliveryPersonsFuture,
              builder: (context, snapshot) {
                if (snapshot.connectionState == ConnectionState.waiting) {
                  return const Center(child: CircularProgressIndicator());
                } else if (snapshot.hasError) {
                  return Center(child: Text('Error: ${snapshot.error}'));
                } else if (snapshot.hasData) {
                  final deliveryPersons = snapshot.data!;
                  return ListView.builder(
                    itemCount: deliveryPersons.length,
                    itemBuilder: (context, index) {
                      final deliveryPerson = deliveryPersons[index];
                      return FutureBuilder<String>(
                        future:
                            _profileService.fetchImageUrl(deliveryPerson.id!),
                        builder: (context, imageSnapshot) {
                          if (imageSnapshot.connectionState ==
                              ConnectionState.waiting) {
                            return const Center(
                                child: CircularProgressIndicator());
                          } else if (imageSnapshot.hasError) {
                            return Center(
                                child: Text('Error: ${imageSnapshot.error}'));
                          } else {
                            final imageUrl = imageSnapshot.data ?? '';
                            return ChatCard(
                              name: deliveryPerson.userName!,
                              imageUrl: imageUrl,
                              press: () => Navigator.push(
                                context,
                                MaterialPageRoute(
                                  builder: (context) => MessagesPage(
                                    deliveryPersonId: deliveryPerson.id!,
                                    deliveryPersonName:
                                        deliveryPerson.userName!,
                                    deliveryPersonImageUrl: imageUrl,
                                  ),
                                ),
                              ),
                            );
                          }
                        },
                      );
                    },
                  );
                } else {
                  return const Center(child: Text('No delivery persons found'));
                }
              },
            ),
          ),
        ],
      ),
    );
  }
}
