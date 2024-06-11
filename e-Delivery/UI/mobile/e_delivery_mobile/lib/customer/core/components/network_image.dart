import 'dart:async';
import 'package:e_delivery_mobile/customer/core/components/skeleton.dart';
import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;

import '../constants/app_defaults.dart';

class NetworkImageWithLoader extends StatelessWidget {
  final BoxFit fit;

  const NetworkImageWithLoader(
    this.src, {
    Key? key,
    this.fit = BoxFit.cover,
    this.radius = AppDefaults.radius,
    this.borderRadius,
  }) : super(key: key);

  final String src;
  final double radius;
  final BorderRadius? borderRadius;

  Future<http.Response> _fetchImage() async {
    return await http.get(Uri.parse(src));
  }

  @override
  Widget build(BuildContext context) {
    final isNetworkImage = src.startsWith('http') || src.startsWith('https');

    return ClipRRect(
      borderRadius: borderRadius ?? BorderRadius.all(Radius.circular(radius)),
      child: isNetworkImage
          ? FutureBuilder<http.Response>(
              future: _fetchImage(),
              builder: (context, snapshot) {
                if (snapshot.hasData) {
                  return Image.memory(
                    snapshot.data!.bodyBytes,
                    fit: fit,
                  );
                } else if (snapshot.hasError) {
                  return Icon(Icons.error);
                } else {
                  return Skeleton();
                }
              },
            )
          : Image.asset(
              "assets/images/no-image-found.jpg",
              fit: BoxFit.contain,
            ),
    );
  }
}
