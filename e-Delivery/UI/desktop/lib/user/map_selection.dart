import 'package:desktop/user/floating_search_bar.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:flutter_map/flutter_map.dart';
import 'package:latlong2/latlong.dart';
import 'package:material_floating_search_bar_2/material_floating_search_bar_2.dart'; // Import the latlong package

class MapSelection extends StatefulWidget {
  @override
  _MapSelectionState createState() => _MapSelectionState();
}

class _MapSelectionState extends State<MapSelection> {
  List<Marker> markers = []; // Store markers
  LatLng _selectedLocation =
      LatLng(43.9159, 17.6791); // Default location in Bosnia and Herzegovina

  void _onDoubleTap(LatLng location) {
    setState(() {
      markers.add(
        Marker(
          width: 80.0,
          height: 80.0,
          point: location,
          child: Icon(Icons.location_pin, color: Colors.red, size: 50),
        ),
      );
    });
  }

  final mapController = MapController();

  @override
  Widget build(BuildContext context) {
    return Column(
      children: [
        GestureDetector(
          onDoubleTap: () {
            showDialog(
              context: context,
              builder: (context) => AlertDialog(
                title: Center(child: Text('Select Location')),
                content: Container(
                  height: 800,
                  width: 800,
                  child: FlutterMap(
                      mapController: mapController,
                      options: MapOptions(
                          initialRotation: 0.0,
                          keepAlive: true,
                          initialCenter: _selectedLocation,
                          initialZoom: 8.0,
                          onPositionChanged: null,
                          interactiveFlags: InteractiveFlag.drag |
                              InteractiveFlag.pinchZoom |
                              InteractiveFlag.doubleTapZoom,
                          interactionOptions: InteractionOptions(
                              cursorKeyboardRotationOptions:
                                  CursorKeyboardRotationOptions(
                            behaviour: CursorRotationBehaviour.setNorth,
                            isKeyTrigger: (key) =>
                                key == LogicalKeyboardKey.arrowRight,
                          ))),
                      children: [
                        TileLayer(
                          urlTemplate:
                              'https://tile.openstreetmap.org/{z}/{x}/{y}.png',
                          userAgentPackageName: 'com.example.app',
                        ),
                        MarkerLayer(markers: [
                          Marker(
                            width: 80.0,
                            height: 80.0,
                            point: _selectedLocation,
                            child: Icon(Icons.location_pin,
                                color: Colors.red, size: 50),
                          )
                        ]),
                        RichAttributionWidget(attributions: [
                          TextSourceAttribution(
                            "OpenStreetMap contributors",
                          )
                        ])
                      ]),
                ),
              ),
            );
          },
          child: Container(
            height: 200,
            width: 200,
            decoration: BoxDecoration(
              image: DecorationImage(
                image: NetworkImage(
                    "https://cdn-icons-png.flaticon.com/512/9356/9356230.png"),
                fit: BoxFit
                    .cover, // Use BoxFit.cover to ensure the image covers the entire container
              ),
              border: Border.all(
                color: Colors.black,
              ),
              color: Colors.white,
              borderRadius: BorderRadius.circular(10),
            ),
          ),
        ),
        SizedBox(height: 10),
        Text(
          'Click To View Your Location',
          style: TextStyle(fontWeight: FontWeight.bold, fontSize: 16),
        ),
      ],
    );
  }
}
