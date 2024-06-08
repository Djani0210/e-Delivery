import 'package:flutter/material.dart';

class NeedHelpButton extends StatelessWidget {
  const NeedHelpButton({
    Key? key,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return TextButton(
      onPressed: () {},
      child: Text(
        'Need Help?',
        style: Theme.of(context)
            .textTheme
            .labelLarge
            ?.copyWith(fontWeight: FontWeight.bold, color: Colors.black),
      ),
    );
  }
}
