import 'package:desktop/admin/api_calls/cities_api.dart';
import 'package:flutter/material.dart';
import 'dart:convert';

class CitiesPage extends StatefulWidget {
  @override
  _CitiesPageState createState() => _CitiesPageState();
}

class _CitiesPageState extends State<CitiesPage> {
  final TextEditingController _searchController = TextEditingController();
  final TextEditingController _titleController = TextEditingController();
  List<CityVM> _cities = [];
  int _currentPage = 0;
  int _totalPages = 0;
  final int _perPage = 10;
  final _formKey = GlobalKey<FormState>();

  @override
  void initState() {
    super.initState();
    _fetchCities();
  }

  Future<void> _fetchCities({String? title, int pageNumber = 1}) async {
    final response = await CityApiService().getCities(
        pageNumber: pageNumber, itemsPerPage: _perPage, title: title);
    if (response.statusCode == 200) {
      final Map<String, dynamic> responseData = json.decode(response.body);
      final List<dynamic> citiesJson = responseData['data']['cities'];
      final int totalPages = responseData['data']['totalPages'];
      setState(() {
        _cities = citiesJson.map((json) => CityVM.fromJson(json)).toList();
        _totalPages = totalPages;
        _currentPage = pageNumber - 1;
      });
    } else {}
  }

  void _filterCities(String query) {
    _fetchCities(title: query);
  }

  void _addCity() {
    final String title = _titleController.text.trim();
    if (title.isNotEmpty) {
      // Add the city using the CityApiService
      CityApiService().addCity(CityCreateVM(title: title)).then((response) {
        if (response.statusCode == 200) {
          _titleController.clear();
          _fetchCities();
        } else {
          // Handle error case
        }
      });
    }
  }

  void _editCity(int id, String title) {
    _titleController.text = title;
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: Text('Edit City'),
          content: Form(
            key: _formKey,
            child: TextFormField(
              controller: _titleController,
              decoration: InputDecoration(
                labelText: 'Name',
              ),
              maxLength: 20,
              validator: (value) {
                if (value!.isEmpty) {
                  return 'Please enter a title';
                } else if (!RegExp(r'^[a-zA-Z\s]+$').hasMatch(value)) {
                  return 'Only letters and spaces are allowed';
                }
                return null;
              },
            ),
          ),
          actions: [
            TextButton(
              child: Text('Cancel'),
              onPressed: () {
                Navigator.of(context).pop();
              },
            ),
            TextButton(
              child: Text('Update'),
              onPressed: () {
                if (_formKey.currentState!.validate()) {
                  CityApiService()
                      .updateCity(id, _titleController.text.toString())
                      .then((response) {
                    if (response.statusCode == 200 ||
                        response.statusCode == 201) {
                      _fetchCities();
                      Navigator.of(context).pop();
                    } else {
                      print(response.statusCode);
                      print(response.body);
                    }
                  });
                }
              },
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
                width: 400 + 16.0 + 150, // Adjust the width as needed
                child: Row(
                  children: [
                    SizedBox(
                      width: 400,
                      child: Padding(
                        padding: const EdgeInsets.symmetric(horizontal: 16.0),
                        child: TextFormField(
                          controller: _searchController,
                          onChanged: _filterCities,
                          decoration: InputDecoration(
                            labelText: 'Search by name',
                            border: OutlineInputBorder(),
                          ),
                        ),
                      ),
                    ),
                    SizedBox(width: 16.0),
                    ElevatedButton(
                      onPressed: () {
                        showDialog(
                          context: context,
                          builder: (BuildContext context) {
                            return AlertDialog(
                              title: Text('Add City'),
                              content: TextField(
                                controller: _titleController,
                                decoration: InputDecoration(
                                  labelText: 'Title',
                                ),
                              ),
                              actions: [
                                TextButton(
                                  child: Text('Cancel'),
                                  onPressed: () {
                                    Navigator.of(context).pop();
                                  },
                                ),
                                TextButton(
                                  child: Text('Add'),
                                  onPressed: () {
                                    _addCity();
                                    Navigator.of(context).pop();
                                  },
                                ),
                              ],
                            );
                          },
                        );
                      },
                      style: ElevatedButton.styleFrom(
                        primary: Colors.blue,
                        shape: RoundedRectangleBorder(
                          borderRadius: BorderRadius.circular(8.0),
                        ),
                        padding: EdgeInsets.symmetric(
                            horizontal: 24.0, vertical: 16.0),
                      ),
                      child: Text(
                        'Add city',
                        style: TextStyle(fontSize: 16.0),
                      ),
                    ),
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
                  child: DataTable(
                    columnSpacing: 16.0,
                    columns: [
                      DataColumn(
                        label: Text(
                          'ID',
                          style: TextStyle(fontWeight: FontWeight.bold),
                        ),
                      ),
                      DataColumn(
                        label: Text(
                          'Title',
                          style: TextStyle(fontWeight: FontWeight.bold),
                        ),
                      ),
                      DataColumn(
                        label: Text(
                          'Edit',
                          style: TextStyle(fontWeight: FontWeight.bold),
                        ),
                      ),
                    ],
                    rows: _cities.map((city) {
                      return DataRow(cells: [
                        DataCell(Text(city.id.toString())),
                        DataCell(Text(city.title)),
                        DataCell(
                          IconButton(
                            icon: Icon(
                              Icons.edit,
                              color: Colors.green,
                            ),
                            onPressed: () {
                              _editCity(city.id, city.title);
                            },
                          ),
                        ),
                      ]);
                    }).toList(),
                  ),
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
                ? () => _fetchCities(pageNumber: _currentPage)
                : null,
          ),
          Text('Page ${_currentPage + 1} of $_totalPages'),
          IconButton(
            icon: Icon(Icons.arrow_forward_ios),
            onPressed: _currentPage < _totalPages - 1
                ? () => _fetchCities(pageNumber: _currentPage + 2)
                : null,
          ),
        ],
      ),
    );
  }
}

class CityVM {
  final int id;
  final String title;

  CityVM({required this.id, required this.title});

  factory CityVM.fromJson(Map<String, dynamic> json) {
    return CityVM(
      id: json['id'],
      title: json['title'],
    );
  }
}
