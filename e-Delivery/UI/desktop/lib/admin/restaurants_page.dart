import 'dart:convert';

import 'package:desktop/admin/api_calls/cities_api.dart';
import 'package:desktop/admin/api_calls/restaurant_admin_api.dart';
import 'package:desktop/admin/cities_page.dart';
import 'package:desktop/restaurant/viewmodels/restaurant_get_VM.dart';
import 'package:dropdown_search/dropdown_search.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';

class RestaurantsPage extends StatefulWidget {
  @override
  _RestaurantsPageState createState() => _RestaurantsPageState();
}

class _RestaurantsPageState extends State<RestaurantsPage> {
  final RestaurantAdminService _restaurantAdminService =
      RestaurantAdminService();

  List<RestaurantViewModel> _restaurants = [];
  int _currentPage = 0;
  int _totalPages = 0;
  String _searchQuery = '';
  int? _selectedCityId;
  List<City> _cities = [];
  City? _selectedCity;
  @override
  void initState() {
    super.initState();
    _fetchRestaurants();
    _fetchCities();
  }

  Future<void> _fetchRestaurants(
      {int pageNumber = 1, String? name, int? cityId}) async {
    try {
      final response = await _restaurantAdminService.getRestaurants(
        pageNumber: pageNumber,
        name: name,
        cityId: cityId,
      );

      if (response.statusCode == 200) {
        final Map<String, dynamic> responseData = json.decode(response.body);
        final List<dynamic> restaurantsJson =
            responseData['data']['restaurants'];
        final int totalPages = responseData['data']['totalPages'];
        setState(() {
          _restaurants = restaurantsJson
              .map((json) => RestaurantViewModel.fromJson(json))
              .toList();
          _totalPages = totalPages;
          _currentPage = pageNumber - 1;
        });
      }
    } catch (e) {}
  }

  Future<void> _fetchCities() async {
    try {
      final response = await _restaurantAdminService.getCities();
      if (response.statusCode == 200) {
        final Map<String, dynamic> responseData = json.decode(response.body);
        final List<dynamic> citiesJson = responseData['data'];
        setState(() {
          _cities = citiesJson.map((json) => City.fromJson(json)).toList();
        });
      } else {
        print(response.statusCode);
      }
    } catch (e) {
      print("Error fetching cities: $e");
    }
  }

  Widget _buildSearchBar() {
    return SizedBox(
      width: 400,
      child: Padding(
        padding: const EdgeInsets.symmetric(horizontal: 16.0),
        child: TextField(
          onChanged: (value) {
            setState(() {
              _searchQuery = value;
            });
            _filterRestaurants(value);
          },
          decoration: InputDecoration(
            labelText: 'Search restaurants...',
            border: OutlineInputBorder(),
          ),
        ),
      ),
    );
  }

  Widget _buildCityDropdown() {
    return Container(
      width: 200,
      child: DropdownSearch<City>(
        selectedItem: _selectedCity,
        onChanged: (City? newValue) {
          setState(() {
            _selectedCity = newValue;
            _selectedCityId = newValue?.id;
            _fetchRestaurants(cityId: _selectedCityId);
          });
        },
        items: _cities,
        itemAsString: (City city) => city.title,
        filterFn: (City city, String filter) =>
            city.title.toLowerCase().startsWith(filter.toLowerCase()),
        dropdownDecoratorProps: DropDownDecoratorProps(
          dropdownSearchDecoration: InputDecoration(
            labelText: 'Choose city...',
            hintText: 'Search cities...',
            border: OutlineInputBorder(),
          ),
        ),
        popupProps: PopupProps.menu(
          showSearchBox: true,
          loadingBuilder: (context, w) => CircularProgressIndicator(),
          searchDelay: Duration(milliseconds: 300),
          searchFieldProps: TextFieldProps(
            decoration: InputDecoration(
              hintText: 'Search cities...',
              border: OutlineInputBorder(),
            ),
          ),
          itemBuilder: (context, City city, isSelected) => ListTile(
            title: Text(city.title),
            selected: isSelected,
          ),
          constraints: BoxConstraints(maxHeight: 300, maxWidth: 200),
        ),
        clearButtonProps: ClearButtonProps(
          isVisible: true,
          onPressed: () {
            setState(() {
              _selectedCity = null;
              _selectedCityId = null;
              _fetchRestaurants();
            });
          },
        ),
      ),
    );
  }

  Widget _buildRestaurantTable() {
    return DataTable(
      columns: [
        DataColumn(label: Text('Name')),
        DataColumn(label: Text('Address')),
        DataColumn(label: Text('Contact')),
        DataColumn(label: Text('Open?')),
        DataColumn(label: Text('Owners email')),
        DataColumn(label: Text('Action')),
      ],
      rows: _restaurants.map((restaurant) {
        return DataRow(cells: [
          DataCell(Text(restaurant.name)),
          DataCell(Text(restaurant.address)),
          DataCell(Text(restaurant.contactNumber.toString())),
          DataCell(Text(restaurant.isOpen ? 'Open' : 'Closed')),
          DataCell(Text(restaurant.createdByUserEmail ?? 'N/A')),
          DataCell(TextButton(
            onPressed: () async {
              bool confirmed = await showConfirmationDialog(
                context,
                'Delete confirmation',
                'Are you sure you want to delete restaurant "${restaurant.name}"?',
              );
              if (confirmed) {
                try {
                  bool deleted = await RestaurantAdminService()
                      .deleteRestaurantAndRelatedEntities(restaurant.id);
                  if (deleted) {
                    setState(() {
                      _restaurants.remove(restaurant);
                    });
                  }
                } catch (e) {
                  print('Error deleting restaurant: $e');
                }
              }
            },
            child: Text('Delete'),
          )),
        ]);
      }).toList(),
    );
  }

  Future<bool> showConfirmationDialog(
      BuildContext context, String title, String content) async {
    return await showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: Text(title),
          content: Text(content),
          actions: [
            TextButton(
              onPressed: () {
                Navigator.of(context).pop(false);
              },
              child: Text('Cancel'),
            ),
            TextButton(
              onPressed: () {
                Navigator.of(context).pop(true);
              },
              child: Text('Confirm'),
            ),
          ],
        );
      },
    );
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Padding(
        padding: const EdgeInsets.all(32.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.stretch,
          children: [
            Container(
              decoration: BoxDecoration(
                borderRadius: BorderRadius.circular(8.0),
              ),
              child: SizedBox(
                width: 400 + 16.0 + 200,
                child: Row(
                  children: [
                    _buildSearchBar(),
                    SizedBox(width: 16.0),
                    _buildCityDropdown(),
                  ],
                ),
              ),
            ),
            SizedBox(height: 16.0),
            Expanded(
              child: Container(
                decoration: BoxDecoration(
                  color: Colors.white,
                  borderRadius: BorderRadius.circular(8.0),
                  boxShadow: [
                    BoxShadow(
                      color: Colors.black.withOpacity(0.1),
                      blurRadius: 4.0,
                      offset: Offset(0, 2),
                    ),
                  ],
                ),
                child: SingleChildScrollView(
                  scrollDirection: Axis.vertical,
                  child: _buildRestaurantTable(),
                ),
              ),
            ),
            SizedBox(height: 16.0),
            _buildPagination(),
          ],
        ),
      ),
    );
  }

  Widget _buildPagination() {
    return Padding(
      padding: EdgeInsets.only(bottom: 32),
      child: Row(
        mainAxisAlignment: MainAxisAlignment.center,
        children: <Widget>[
          IconButton(
            icon: Icon(Icons.arrow_back_ios),
            onPressed: _currentPage > 0
                ? () => _fetchRestaurants(pageNumber: _currentPage)
                : null,
          ),
          Text('Page ${_currentPage + 1} of $_totalPages'),
          IconButton(
            icon: Icon(Icons.arrow_forward_ios),
            onPressed: _currentPage < _totalPages - 1
                ? () => _fetchRestaurants(pageNumber: _currentPage + 2)
                : null,
          ),
        ],
      ),
    );
  }

  void _filterRestaurants(String query) {
    _fetchRestaurants(name: query);
  }
}

class City {
  final int id;
  final String title;

  City({required this.id, required this.title});

  factory City.fromJson(Map<String, dynamic> json) {
    return City(
      id: json['id'],
      title: json['title'],
    );
  }
}
