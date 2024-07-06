import "package:flutter/material.dart";

class AllergiesSection extends StatelessWidget {
  final String? allergies;
  final ValueChanged<String> onSave;

  const AllergiesSection({
    Key? key,
    this.allergies,
    required this.onSave,
  }) : super(key: key);

  void _showAllergiesForm(BuildContext context) {
    TextEditingController _allergiesController =
        TextEditingController(text: allergies);
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: const Text('Enter Allergies'),
          content: TextField(
            controller: _allergiesController,
            maxLength: 70,
            maxLines: 3,
            decoration: const InputDecoration(
              hintText: 'Enter any allergies here...',
              border: OutlineInputBorder(),
            ),
          ),
          actions: [
            TextButton(
              child: const Text('Close'),
              onPressed: () {
                Navigator.of(context).pop();
              },
            ),
            TextButton(
              child: const Text('Save'),
              onPressed: () {
                onSave(_allergiesController.text);
                Navigator.of(context).pop();
              },
            ),
          ],
        );
      },
    );
  }

  @override
  Widget build(BuildContext context) {
    return GestureDetector(
      onTap: () => _showAllergiesForm(context),
      child: const Row(
        mainAxisAlignment: MainAxisAlignment.spaceBetween,
        children: [
          Row(
            children: [
              Icon(Icons.dangerous, color: Colors.orange),
              SizedBox(width: 8),
              Text(
                'Any allergies?',
                style: TextStyle(fontSize: 16),
              ),
            ],
          ),
          Icon(Icons.arrow_forward_ios, color: Colors.grey),
        ],
      ),
    );
  }
}
