import 'package:desktop/admin/api_calls/categories_api.dart';
import 'package:flutter/material.dart';
import 'dart:convert';

class CategoriesPage extends StatefulWidget {
  @override
  _CategoriesPageState createState() => _CategoriesPageState();
}

class _CategoriesPageState extends State<CategoriesPage> {
  final TextEditingController _searchController = TextEditingController();
  final TextEditingController _nameController = TextEditingController();
  List<CategoryVM> _categories = [];
  int _currentPage = 0;
  int _totalPages = 0;
  final int _perPage = 10;
  final _formKey = GlobalKey<FormState>();

  @override
  void initState() {
    super.initState();
    _fetchCategories();
  }

  Future<void> _fetchCategories({String? name, int pageNumber = 1}) async {
    final response = await CategoryService().getCategories(
        pageNumber: pageNumber, itemsPerPage: _perPage, name: name);
    if (response.statusCode == 200) {
      final Map<String, dynamic> responseData = json.decode(response.body);
      final List<dynamic> citiesJson = responseData['data']['categories'];
      final int totalPages = responseData['data']['totalPages'];
      setState(() {
        _categories =
            citiesJson.map((json) => CategoryVM.fromJson(json)).toList();
        _totalPages = totalPages;
        _currentPage = pageNumber - 1;
      });
    } else {}
  }

  void _filterCategories(String query) {
    _fetchCategories(name: query);
  }

  void _addCategory() {
    final String title = _nameController.text.trim();
    if (title.isNotEmpty) {
      CategoryService()
          .addCategory(CategoryCreateVM(name: title))
          .then((response) {
        if (response.statusCode == 200) {
          _nameController.clear();
          _fetchCategories();
        } else {}
      });
    }
  }

  void _editCategory(int id, String name) {
    _nameController.text = name;
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: Text('Edit category'),
          content: Form(
            key: _formKey,
            child: TextFormField(
              controller: _nameController,
              decoration: InputDecoration(
                labelText: 'Name',
              ),
              maxLength: 20,
              validator: (value) {
                if (value!.isEmpty) {
                  return 'Please enter the name';
                } else if (!RegExp(r'^[a-zA-Z\s]+$').hasMatch(value)) {
                  return 'Only letters and space allowed';
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
              child: Text('Edit'),
              onPressed: () {
                if (_formKey.currentState!.validate()) {
                  CategoryService()
                      .updateCategory(id, _nameController.text.toString())
                      .then((response) {
                    if (response.statusCode == 200 ||
                        response.statusCode == 201) {
                      _fetchCategories();
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
                width: 400 + 16.0 + 150,
                child: Row(
                  children: [
                    SizedBox(
                      width: 400,
                      child: Padding(
                        padding: const EdgeInsets.symmetric(horizontal: 16.0),
                        child: TextFormField(
                          controller: _searchController,
                          onChanged: _filterCategories,
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
                              title: Text('Add category'),
                              content: TextField(
                                controller: _nameController,
                                decoration: InputDecoration(
                                  labelText: 'Name',
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
                                    _addCategory();
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
                        'Add category',
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
                          'Name',
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
                    rows: _categories.map((category) {
                      return DataRow(cells: [
                        DataCell(Text(category.id.toString())),
                        DataCell(Text(category.name)),
                        DataCell(
                          IconButton(
                            icon: Icon(
                              Icons.edit,
                              color: Colors.green,
                            ),
                            onPressed: () {
                              _editCategory(category.id, category.name);
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
                ? () => _fetchCategories(pageNumber: _currentPage)
                : null,
          ),
          Text('Page ${_currentPage + 1} of $_totalPages'),
          IconButton(
            icon: Icon(Icons.arrow_forward_ios),
            onPressed: _currentPage < _totalPages - 1
                ? () => _fetchCategories(pageNumber: _currentPage + 2)
                : null,
          ),
        ],
      ),
    );
  }
}

class CategoryVM {
  final int id;
  final String name;

  CategoryVM({required this.id, required this.name});

  factory CategoryVM.fromJson(Map<String, dynamic> json) {
    return CategoryVM(
      id: json['id'],
      name: json['name'],
    );
  }
}
