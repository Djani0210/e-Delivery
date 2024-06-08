import 'dart:async';
import 'dart:convert';
import 'package:e_delivery_mobile/customer/screens/order/components/polygon_util.dart';
import 'package:e_delivery_mobile/storage_service.dart';
import 'package:flutter/material.dart';
import 'package:geocoding/geocoding.dart';
import 'package:google_maps_flutter/google_maps_flutter.dart';
import 'package:location/location.dart' as loc;
import 'package:http/http.dart' as http;
import 'package:geoxml/geoxml.dart' as geo;
import 'package:flutter/services.dart' show rootBundle;

import 'package:archive/archive.dart';
import 'package:xml/xml.dart' as xml;

class MapScreen extends StatefulWidget {
  final Map<String, String>? initialAddressDetails;
  const MapScreen({Key? key, this.initialAddressDetails}) : super(key: key);
  @override
  _MapScreenState createState() => _MapScreenState();
}

class _MapScreenState extends State<MapScreen> {
  final Completer<GoogleMapController> _controller = Completer();
  bool isInTheDeliveryArea = true;
  LatLng initialLocation = LatLng(43.8563, 18.4131); // Default to Sarajevo
  String address = "";
  Map<String, String> addressDetails = {
    'locality': '',
    'administrativeArea': '',
    'postalCode': '',
    'country': '',
    'latitude': '',
    'longitude': '',
  };

  List<LatLng> bosniaPolygonPoints = [];
  /* @override
  void initState() {
    super.initState();

    _loadKmzFile();
    _setInitialLocation();
  } */
  @override
  void initState() {
    super.initState();

    _loadKmzFile();

    if (widget.initialAddressDetails != null &&
        widget.initialAddressDetails!['latitude'] != null &&
        widget.initialAddressDetails!['longitude'] != null) {
      print("$widget.initialAddressDetails");
      final latitude = double.parse(widget.initialAddressDetails!['latitude']!);
      print("Lat: $latitude");

      final longitude =
          double.parse(widget.initialAddressDetails!['longitude']!);
      print("Long: $longitude");
      setState(() {
        initialLocation = LatLng(latitude, longitude);
      });
      _moveCameraToInitialLocation();
    } else {
      _setInitialLocation();
    }
  }

  Future<void> _moveCameraToInitialLocation() async {
    final GoogleMapController controller = await _controller.future;
    controller.animateCamera(CameraUpdate.newCameraPosition(
      CameraPosition(
        target: initialLocation,
        zoom: 15.0,
      ),
    ));
    getAddressFromLatLon(initialLocation);
  }

  Future<void> _loadKmzFile() async {
    try {
      final bytes = await rootBundle.load('assets/gadm41_BIH_0.kmz');
      final kmzArchive = ZipDecoder().decodeBytes(bytes.buffer.asUint8List());

      final kmlFile = kmzArchive.files.firstWhere(
        (file) => file.name.toLowerCase().endsWith('.kml'),
        orElse: () => throw Exception('No KML file found in KMZ archive'),
      );

      final kmlContent = utf8.decode(kmlFile.content);
      final xmlDoc = xml.XmlDocument.parse(kmlContent);

      var polygons = xmlDoc.findAllElements('Polygon');
      if (polygons.isNotEmpty) {
        var outerBoundary =
            polygons.first.findElements('outerBoundaryIs').first;
        var linearRing = outerBoundary.findElements('LinearRing').first;
        var coordinates = linearRing.findElements('coordinates').first;

        var coordText = coordinates.text.trim();
        var coordPairs = coordText.split(' ');
        List<LatLng> polygonPoints = coordPairs.map((pair) {
          var coords = pair.split(',');
          return LatLng(double.parse(coords[1]), double.parse(coords[0]));
        }).toList();

        setState(() {
          bosniaPolygonPoints = polygonPoints;
        });
      }
    } catch (e) {
      print('Failed to load KMZ file: $e');
    }
  }

  Future<void> _setInitialLocation() async {
    try {
      final cityId = await _getCityIdFromUserData();
      final token = await StorageService.storage.read(key: 'jwt');
      if (token == null) throw Exception('JWT token is not available');

      final headers = {
        'Content-Type': 'application/json',
        'Authorization': 'Bearer $token',
      };

      final response = await http.get(
        Uri.parse('https://10.0.2.2:44395/api/City/get-city?id=$cityId'),
        headers: headers,
      );

      if (response.statusCode == 200) {
        final data = jsonDecode(response.body)['data'];
        final cityName = data['title'];

        final locations = await locationFromAddress(cityName);
        if (locations.isNotEmpty) {
          final location = locations.first;
          setState(() {
            initialLocation = LatLng(location.latitude, location.longitude);
          });
          _moveCameraToInitialLocation();
        }
      } else if (response.statusCode == 404) {
        print('Error 404: City not found');
      } else {
        throw Exception(
            'Failed to fetch city details with status code: ${response.statusCode}');
      }
    } catch (e) {
      print('Error setting initial location: $e');
    }
  }

  Future<String> _getCityIdFromUserData() async {
    final userData = await StorageService.storage.read(key: 'userData');
    if (userData != null) {
      final userDataJson = jsonDecode(userData);
      final cityId = userDataJson['cityId'].toString();
      return cityId;
    } else {
      throw Exception('User data is not available');
    }
  }

  void getAddressFromLatLon(LatLng latLng) {
    placemarkFromCoordinates(
      latLng.latitude,
      latLng.longitude,
      localeIdentifier: "en",
    ).then(
      (placemarks) {
        if (placemarks.isNotEmpty) {
          String street = placemarks[0].street ?? "";
          String locality = placemarks[0].locality ?? "";
          String administrativeArea = placemarks[0].administrativeArea ?? "";
          String postalCode = placemarks[0].postalCode ?? "";
          String country = placemarks[0].country ?? "";

          setState(() {
            isInTheDeliveryArea = PolygonUtil.containsLocation(
                latLng, bosniaPolygonPoints, false);
            address = street;
            addressDetails = {
              'locality': locality,
              'administrativeArea': administrativeArea,
              'postalCode': postalCode,
              'country': country,
              'latitude': latLng.latitude.toString(),
              'longitude': latLng.longitude.toString(),
            };
          });

          print("Address: $address");
          print("Latitude: ${latLng.latitude}");
          print("Longitude: ${latLng.longitude}");
          print("City: $locality");
        }
      },
    );
  }

  void _getCurrentLocation() async {
    loc.Location location = loc.Location();
    bool _serviceEnabled;
    loc.PermissionStatus _permissionGranted;
    loc.LocationData _locationData;

    _serviceEnabled = await location.serviceEnabled();
    if (!_serviceEnabled) {
      _serviceEnabled = await location.requestService();
      if (!_serviceEnabled) {
        return;
      }
    }

    _permissionGranted = await location.hasPermission();
    if (_permissionGranted == loc.PermissionStatus.denied) {
      _permissionGranted = await location.requestPermission();
      if (_permissionGranted != loc.PermissionStatus.granted) {
        return;
      }
    }

    _locationData = await location.getLocation();
    LatLng currentLocation =
        LatLng(_locationData.latitude!, _locationData.longitude!);

    setState(() {
      initialLocation = currentLocation;
      getAddressFromLatLon(currentLocation);
    });

    final GoogleMapController controller = await _controller.future;
    controller.animateCamera(CameraUpdate.newLatLng(currentLocation));
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Select Location'),
        actions: [
          IconButton(
            icon: Icon(Icons.check),
            onPressed: () async {
              final cityId = await _getCityIdFromUserData();
              if (isInTheDeliveryArea) {
                Navigator.pop(context, {
                  'address': address,
                  'details': addressDetails,
                  'cityId': cityId.toString(),
                });
              }
            },
          ),
        ],
      ),
      body: Column(
        children: [
          Expanded(
            child: GoogleMap(
              mapType: MapType.terrain,
              mapToolbarEnabled: true,
              zoomControlsEnabled: true,
              initialCameraPosition: CameraPosition(
                target: initialLocation ?? LatLng(43.8563, 18.4131),
                zoom: 15.0,
              ),
              onMapCreated: (controller) {
                _controller.complete(controller);
              },
              onTap: (LatLng latLng) {
                setState(() {
                  initialLocation = latLng;
                  getAddressFromLatLon(latLng);
                });
              },
              markers: {
                Marker(
                  markerId: const MarkerId("marker"),
                  position: initialLocation,
                  draggable: true,
                  onDragEnd: (value) {
                    getAddressFromLatLon(value);
                  },
                ),
              },
              polygons: bosniaPolygonPoints.isNotEmpty
                  ? Set.from([
                      Polygon(
                        polygonId: const PolygonId("bosnia"),
                        fillColor: const Color(0xFF006491).withOpacity(0.1),
                        strokeColor: const Color(0xFF006491),
                        strokeWidth: 2,
                        points: bosniaPolygonPoints,
                      ),
                    ])
                  : Set<Polygon>(),
            ),
          ),
          SafeArea(
            top: false,
            child: Container(
              padding: const EdgeInsets.symmetric(horizontal: 16),
              decoration: const BoxDecoration(
                borderRadius: BorderRadius.only(
                  topLeft: Radius.circular(12),
                  topRight: Radius.circular(12),
                ),
              ),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Padding(
                    padding: const EdgeInsets.symmetric(vertical: 16),
                    child: Text(
                      "Your Location",
                      style: Theme.of(context).textTheme.titleLarge,
                    ),
                  ),
                  Container(
                    decoration: const BoxDecoration(
                      color: Color(0xFFF8F8F8),
                      borderRadius: BorderRadius.all(
                        Radius.circular(12),
                      ),
                    ),
                    child: ListTile(
                      minLeadingWidth: 32,
                      leading: CircleAvatar(
                        radius: 16,
                        backgroundColor: isInTheDeliveryArea
                            ? const Color(0xFF006491)
                            : const Color(0xFFEC3A3A),
                        child: const Icon(
                          Icons.near_me,
                          color: Colors.white,
                          size: 20,
                        ),
                      ),
                      title: Text(
                        isInTheDeliveryArea
                            ? address
                            : "This area is not accessible for delivery!",
                        style: Theme.of(context).textTheme.titleMedium,
                      ),
                      subtitle: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          Text(
                            "Locality: ${addressDetails['locality']}",
                            style: Theme.of(context).textTheme.bodySmall,
                          ),
                          Text(
                            "Administrative Area: ${addressDetails['administrativeArea']}",
                            style: Theme.of(context).textTheme.bodySmall,
                          ),
                          Text(
                            "Postal Code: ${addressDetails['postalCode']}",
                            style: Theme.of(context).textTheme.bodySmall,
                          ),
                          Text(
                            "Country: ${addressDetails['country']}",
                            style: Theme.of(context).textTheme.bodySmall,
                          ),
                        ],
                      ),
                    ),
                  ),
                  Padding(
                    padding: const EdgeInsets.only(top: 16, bottom: 16 / 2),
                    child: Row(
                      children: [
                        CircleAvatar(
                          backgroundColor: const Color(0xFF006491),
                          child: IconButton(
                            onPressed: _getCurrentLocation,
                            icon: const Icon(
                              Icons.my_location,
                              color: Colors.white,
                            ),
                          ),
                        ),
                        const SizedBox(width: 16),
                        Expanded(
                          child: ElevatedButton(
                            onPressed: isInTheDeliveryArea
                                ? () async {
                                    final cityId =
                                        await _getCityIdFromUserData();
                                    if (cityId != null) {
                                      Navigator.pop(context, {
                                        'address': address,
                                        'details': addressDetails,
                                        'cityId': cityId.toString(),
                                      });
                                    }
                                  }
                                : null,
                            child: const Text("Confirm Location"),
                          ),
                        ),
                      ],
                    ),
                  ),
                ],
              ),
            ),
          ),
        ],
      ),
    );
  }
}
