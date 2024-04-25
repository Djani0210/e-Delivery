import 'dart:convert';
import 'dart:io';
import 'package:desktop/restaurant/api_calls/category_api_calls.dart';
import 'package:desktop/restaurant/api_calls/food_item_api_calls.dart';
import 'package:desktop/restaurant/api_calls/sidedish_api_calls.dart';
import 'package:desktop/restaurant/viewmodels/food_item_get_VM.dart';
import 'package:flutter/material.dart';
import 'package:image_picker/image_picker.dart';

class MenuPage extends StatefulWidget {
  @override
  _MenuPageState createState() => _MenuPageState();
}

class _MenuPageState extends State<MenuPage> {
  final FoodItemApiService _menuApiService = FoodItemApiService();
  final CategoryApiService _categoryApiService = CategoryApiService();
  List<FoodItemViewModel> _menuItems = [];
  int _currentPage = 0;
  int _totalPages = 0;
  final int _perPage = 3;
  String _searchTerm = '';
  bool? _isAvailable;
  String _selectedAvailability = 'Svi';
  String _selectedCategory = 'Sve';
  final TextEditingController _priceController = TextEditingController();
  List<String> _categories = [];
  List<Map<String, dynamic>> _allCategories = [];
  int _selectedCategoryId = 0;
  List<int> _selectedSideDishIds = [];
  List<SideDishViewModel> _sideDishes = [];
  late _SideDishesTableState _sideDishesTableState;
  String? _imagePath;
  FoodItemViewModel? _selectedFoodItem;
  @override
  void initState() {
    super.initState();
    _fetchMenuItems();
    _fetchCategories();
    _fetchAllCategories();
    _fetchSideDishes();
  }

  void _setSideDishesTableState(_SideDishesTableState tableState) {
    _sideDishesTableState = tableState;
  }

  Future<void> _fetchSideDishes() async {
    List<SideDishViewModel> sideDishes =
        await SideDishApiService().getSideDishes();
    setState(() {
      _sideDishes = sideDishes;
    });
  }

  Future<void> _fetchAllCategories() async {
    List<Map<String, dynamic>> categories =
        await _categoryApiService.fetchCategories();
    setState(() {
      _allCategories = categories;
      if (categories.isNotEmpty) {
        _selectedCategoryId = categories.first['id'];
      }
    });
  }

  Future<void> _fetchCategories() async {
    final List<String> fetchedCategories =
        await _categoryApiService.fetchCategoriesWithFoodItems();
    setState(() {
      _categories = ['Sve', ...fetchedCategories];
    });
  }

  Future<void> pickImage() async {
    final pickedFile =
        await ImagePicker().pickImage(source: ImageSource.gallery);
    if (pickedFile != null) {
      setState(() {
        _imagePath = pickedFile.path;
      });
    }
  }

  Future<bool> uploadImage(int id) async {
    if (_imagePath != null && !_imagePath!.startsWith('http')) {
      bool uploadSuccess = await _menuApiService.postImageUrl(id, _imagePath!);
      if (uploadSuccess) {
        print("Image successfully uploaded.");
        return true;
      } else {
        print("Failed to upload image.");
        return false;
      }
    }
    return false;
  }

  Future<void> _fetchMenuItems({
    int pageNumber = 1,
    bool? isAvailable,
    String? name,
    String? categoryName,
  }) async {
    final response = await _menuApiService.getFoodItems(
      pageNumber: pageNumber,
      itemsPerPage: _perPage,
      isAvailable: isAvailable,
      itemName: name,
      categoryName: categoryName == 'Sve' ? null : categoryName,
    );
    if (response != null && response.statusCode == 200) {
      final Map<String, dynamic> responseBody = json.decode(response.body);
      final List<dynamic> menuItemsData = responseBody['data']['menuItems'];
      final int totalPages = responseBody['data']['totalPages'];

      final List<FoodItemViewModel> fetchedMenuItems = menuItemsData
          .map((menuItem) => FoodItemViewModel.fromJson(menuItem))
          .toList();

      setState(() {
        _menuItems = fetchedMenuItems;
        _totalPages = totalPages;
        _currentPage = pageNumber - 1;
      });
    } else {
      print("Failed to fetch menu items. Status code: ${response?.statusCode}");
    }
  }

  void _showEditDialog(BuildContext context, int foodItemId) async {
    final response = await _menuApiService.getFoodItemById(foodItemId);
    if (response != null && response.statusCode == 200) {
      final responseBody = json.decode(response.body);
      final foodItemData = responseBody['data'];
      final foodItem = FoodItemViewModel.fromJson(foodItemData);

      showDialog(
        context: context,
        builder: (BuildContext context) {
          final _nameController = TextEditingController(text: foodItem.name);
          final _priceController =
              TextEditingController(text: foodItem.price.toString() + ' KM');
          final _descriptionController =
              TextEditingController(text: foodItem.description);

          List<SideDishViewModel> _selectedSideDishes =
              List.from(foodItem.sideDishes);
          bool _isAvailable = foodItem.isAvailable;

          return StatefulBuilder(
            builder: (BuildContext context, StateSetter setState) {
              return AlertDialog(
                title: Text('Uredi stavku menija'),
                content: SingleChildScrollView(
                  child: Column(
                    mainAxisSize: MainAxisSize.min,
                    children: [
                      TextField(
                        controller: _nameController,
                        decoration: InputDecoration(labelText: 'Naziv'),
                      ),
                      TextField(
                        controller: _priceController,
                        decoration: InputDecoration(labelText: 'Cijena'),
                      ),
                      TextField(
                        controller: _descriptionController,
                        decoration: InputDecoration(labelText: 'Opis'),
                      ),
                      SizedBox(height: 16),
                      Row(
                        mainAxisAlignment: MainAxisAlignment.spaceBetween,
                        children: [
                          Text('Dostupan'),
                          Switch(
                            value: _isAvailable,
                            onChanged: (value) {
                              setState(() {
                                _isAvailable = value;
                              });
                            },
                          ),
                        ],
                      ),
                      Text('Prilozi:'),
                      SizedBox(height: 8),
                      Padding(
                        padding: const EdgeInsets.symmetric(vertical: 8),
                        child: Wrap(
                          spacing: 8,
                          children: _selectedSideDishes.map((sideDish) {
                            return Chip(
                              label: Text(sideDish.name),
                              padding: EdgeInsets.symmetric(vertical: 3),
                              deleteIcon: Icon(Icons.close),
                              onDeleted: () {
                                setState(() {
                                  _selectedSideDishes.remove(sideDish);
                                });
                              },
                            );
                          }).toList(),
                        ),
                      ),
                      SizedBox(height: 8),
                      ElevatedButton(
                        onPressed: () async {
                          final List<SideDishViewModel>? selectedSideDishes =
                              await showDialog(
                            context: context,
                            builder: (BuildContext context) {
                              List<SideDishViewModel> tempSelectedSideDishes =
                                  List.from(_selectedSideDishes);
                              return StatefulBuilder(
                                builder: (BuildContext context,
                                    StateSetter setState) {
                                  return AlertDialog(
                                    title: Text('Dodaj priloge'),
                                    content: SingleChildScrollView(
                                      child: ListBody(
                                        children: _sideDishes.map((sideDish) {
                                          return CheckboxListTile(
                                            title: Text(sideDish.name),
                                            value: tempSelectedSideDishes
                                                .contains(sideDish),
                                            onChanged: (selected) {
                                              setState(() {
                                                if (selected!) {
                                                  tempSelectedSideDishes
                                                      .add(sideDish);
                                                } else {
                                                  tempSelectedSideDishes
                                                      .remove(sideDish);
                                                }
                                              });
                                            },
                                          );
                                        }).toList(),
                                      ),
                                    ),
                                    actions: [
                                      TextButton(
                                        onPressed: () {
                                          Navigator.of(context).pop();
                                        },
                                        child: Text('Otkaži'),
                                      ),
                                      ElevatedButton(
                                        onPressed: () {
                                          Navigator.of(context)
                                              .pop(tempSelectedSideDishes);
                                        },
                                        child: Text('Dodaj'),
                                      ),
                                    ],
                                  );
                                },
                              );
                            },
                          );

                          if (selectedSideDishes != null) {
                            setState(() {
                              _selectedSideDishes = selectedSideDishes;
                            });
                          }
                        },
                        child: Text('Dodaj prilog'),
                      ),
                    ],
                  ),
                ),
                actions: [
                  TextButton(
                    onPressed: () {
                      Navigator.of(context).pop();
                    },
                    child: Text('Otkaži'),
                  ),
                  ElevatedButton(
                    onPressed: () async {
                      final String priceText =
                          _priceController.text.replaceAll(' KM', '');
                      final double price = double.parse(priceText);
                      final List<int> sideDishIds = _selectedSideDishes
                          .map((sideDish) => sideDish.id)
                          .toList();

                      final bool updateSuccess =
                          await _menuApiService.updateFoodItem(
                        id: foodItem.id,
                        name: _nameController.text,
                        description: _descriptionController.text,
                        price: price,
                        isAvailable: _isAvailable,
                        sideDishIds: sideDishIds,
                      );

                      if (updateSuccess) {
                        // Refresh the food items list after successful update
                        _fetchMenuItems();
                        Navigator.of(context).pop();
                      } else {
                        // Show an error message or handle the failure scenario
                        print('Failed to update food item');
                      }
                    },
                    child: Text('Sačuvaj'),
                  ),
                ],
              );
            },
          );
        },
      );
    } else {
      print(
          'Failed to fetch food item by ID. Status code: ${response?.statusCode}');
    }
  }

  Widget _buildSearchAndFilter() {
    final TextEditingController _searchController =
        TextEditingController(text: _searchTerm);

    final List<Map<String, dynamic>> _availabilityOptions = [
      {'label': 'Svi', 'value': null},
      {'label': 'Dostupni', 'value': true},
      {'label': 'Nedostupni', 'value': false},
    ];

    _searchController.selection = TextSelection.fromPosition(
        TextPosition(offset: _searchController.text.length));

    void _handleSearchAndFilter() {
      setState(() {
        _fetchMenuItems(
          name: _searchTerm,
          isAvailable: _selectedAvailability == 'Dostupni'
              ? true
              : _selectedAvailability == 'Nedostupni'
                  ? false
                  : null,
          categoryName: _selectedCategory,
        );
      });
    }

    return Padding(
      padding: const EdgeInsets.symmetric(horizontal: 16.0),
      child: Row(
        mainAxisAlignment: MainAxisAlignment.start,
        children: [
          SizedBox(
            width: 300,
            height: 40,
            child: TextField(
              controller: _searchController,
              decoration: InputDecoration(
                labelText: 'Pretraži',
                border: OutlineInputBorder(),
              ),
              onChanged: (value) {
                _searchTerm = value;
                _handleSearchAndFilter();
              },
            ),
          ),
          SizedBox(width: 20),
          DropdownButton<String>(
            value: _selectedAvailability,
            underline: Container(
              height: 2,
              color: Colors.deepPurpleAccent,
            ),
            icon: Icon(Icons.arrow_downward, color: Colors.deepPurple),
            iconSize: 24,
            elevation: 16,
            style: TextStyle(color: Colors.deepPurple),
            onChanged: (newValue) {
              setState(() {
                _selectedAvailability = newValue!;
                _handleSearchAndFilter();
              });
            },
            items: _availabilityOptions.map<DropdownMenuItem<String>>((value) {
              return DropdownMenuItem<String>(
                value: value['label'],
                child: Text(value['label']),
              );
            }).toList(),
          ),
          SizedBox(width: 20),
          DropdownButton<String>(
            value: _selectedCategory,
            underline: Container(
              height: 2,
              color: Colors.deepPurpleAccent,
            ),
            icon: Icon(Icons.arrow_downward, color: Colors.deepPurple),
            iconSize: 24,
            elevation: 16,
            style: TextStyle(color: Colors.deepPurple),
            onChanged: (newValue) {
              setState(() {
                _selectedCategory = newValue!;
                _handleSearchAndFilter();
              });
            },
            items: _categories.map<DropdownMenuItem<String>>((String value) {
              return DropdownMenuItem<String>(
                value: value,
                child: Text(value),
              );
            }).toList(),
          ),
        ],
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: <Widget>[
        Padding(
          padding: EdgeInsets.all(16.0),
          child: Text(
            'Meni',
            style: TextStyle(fontSize: 24, fontWeight: FontWeight.bold),
          ),
        ),
        SizedBox(height: 16),
        _buildSearchAndFilter(),
        Expanded(
          child: Column(
            children: [
              Expanded(
                child: ClipRRect(
                  borderRadius: BorderRadius.circular(16),
                  child: _buildMenuItemsList(),
                ),
              ),
              Padding(
                padding: const EdgeInsets.only(top: 20.0, bottom: 20.0),
                child: Row(
                  mainAxisAlignment: MainAxisAlignment.spaceBetween,
                  children: [
                    Padding(
                      padding: const EdgeInsets.only(left: 16.0),
                      child: ElevatedButton(
                          onPressed: () => _showSideDishesDialog(context),
                          child: Text(
                            'Upravljaj prilozima',
                            style: TextStyle(color: Colors.black),
                          ),
                          style: ElevatedButton.styleFrom(
                            backgroundColor: Colors.yellow,
                            minimumSize: Size(100, 40),
                          )),
                    ),
                    Padding(
                      padding: const EdgeInsets.only(right: 16.0),
                      child: FloatingActionButton(
                        onPressed: () => _showAddFoodItemForm(context),
                        backgroundColor: Colors.orange,
                        child: Icon(Icons.add),
                      ),
                    ),
                  ],
                ),
              ),
              _buildPagination(),
            ],
          ),
        ),
      ],
    );
  }

  void _showAddFoodItemForm(BuildContext context) {
    final _formKey = GlobalKey<FormState>();
    String _name = '';
    String _description = '';
    double _price = 0.0;
    bool _isAvailable = true;
    bool _showSideDishes = false;

    showDialog(
      context: context,
      builder: (context) {
        return StatefulBuilder(
          builder: (context, setState) {
            return AlertDialog(
              title: Text('Dodaj novi proizvod'),
              content: SingleChildScrollView(
                child: Container(
                  width: 400,
                  child: Form(
                    key: _formKey,
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        TextFormField(
                          decoration: InputDecoration(
                              labelText: 'Naziv', border: OutlineInputBorder()),
                          maxLength: 20,
                          validator: (value) {
                            if (value == null || value.isEmpty) {
                              return 'Molimo unesite naziv';
                            }
                            return null;
                          },
                          onSaved: (value) => _name = value!,
                        ),
                        SizedBox(height: 8),
                        TextFormField(
                          decoration: InputDecoration(
                              labelText: 'Opis proizvoda',
                              border: OutlineInputBorder()),
                          maxLength: 40,
                          validator: (value) {
                            if (value == null || value.isEmpty) {
                              return 'Molimo unesite opis proizvoda';
                            }
                            return null;
                          },
                          onSaved: (value) => _description = value!,
                        ),
                        SizedBox(height: 8),
                        TextFormField(
                          decoration: InputDecoration(
                              labelText: 'Cijena',
                              border: OutlineInputBorder()),
                          keyboardType:
                              TextInputType.numberWithOptions(decimal: true),
                          validator: (value) {
                            if (value == null || value.isEmpty) {
                              return 'Molimo unesite cijenu';
                            }
                            if (double.tryParse(value) == null) {
                              return 'Molimo unesite validnu cijenu';
                            }
                            return null;
                          },
                          onSaved: (value) => _price = double.parse(value!),
                        ),
                        SizedBox(height: 8),
                        Row(
                          children: [
                            Text('Dostupno'),
                            Switch(
                              value: _isAvailable,
                              onChanged: (value) {
                                setState(() {
                                  _isAvailable = value;
                                });
                              },
                            ),
                          ],
                        ),
                        SizedBox(height: 16),
                        DropdownButtonFormField<int>(
                          decoration: InputDecoration(labelText: 'Kategorija'),
                          value: _selectedCategoryId,
                          onChanged: (value) {
                            setState(() {
                              _selectedCategoryId = value!;
                            });
                          },
                          items: _allCategories.isEmpty
                              ? []
                              : _allCategories.map((category) {
                                  return DropdownMenuItem<int>(
                                    value: category['id'],
                                    child: Text(category['name']),
                                  );
                                }).toList(),
                        ),
                        SizedBox(height: 16),
                        Row(
                          children: [
                            Text('Prilozi'),
                            IconButton(
                              icon: Icon(_showSideDishes
                                  ? Icons.arrow_drop_up
                                  : Icons.arrow_drop_down),
                              onPressed: () {
                                setState(() {
                                  _showSideDishes = !_showSideDishes;
                                });
                              },
                            ),
                          ],
                        ),
                        if (_showSideDishes)
                          ListView.builder(
                            shrinkWrap: true,
                            physics: NeverScrollableScrollPhysics(),
                            itemCount: _sideDishes.length,
                            itemBuilder: (context, index) {
                              SideDishViewModel sideDish = _sideDishes[index];
                              return CheckboxListTile(
                                title: Text(sideDish.name),
                                value:
                                    _selectedSideDishIds.contains(sideDish.id),
                                onChanged: (value) {
                                  setState(() {
                                    if (value!) {
                                      _selectedSideDishIds.add(sideDish.id);
                                    } else {
                                      _selectedSideDishIds.remove(sideDish.id);
                                    }
                                  });
                                },
                              );
                            },
                          ),
                      ],
                    ),
                  ),
                ),
              ),
              actions: [
                TextButton(
                  onPressed: () => Navigator.pop(context),
                  child: Text('Otkaži'),
                ),
                ElevatedButton(
                  onPressed: () async {
                    if (_formKey.currentState!.validate()) {
                      _formKey.currentState!.save();

                      bool success = await _menuApiService.createFoodItem(
                        name: _name,
                        description: _description,
                        price: _price,
                        isAvailable: _isAvailable,
                        categoryId: _selectedCategoryId,
                        sideDishIds: _selectedSideDishIds,
                      );

                      if (success) {
                        Navigator.pop(context);
                        setState(() {
                          _name = '';
                          _description = '';
                          _price = 0.0;
                          _isAvailable = true;
                          _selectedCategoryId = _allCategories.isNotEmpty
                              ? _allCategories.first['id']
                              : 0;
                          _selectedSideDishIds.clear();
                        });
                        _fetchMenuItems();
                        _fetchCategories(); // Refresh the menu items list
                      } else {
                        // Show an error message or handle the failure case
                      }
                    }
                  },
                  child: Text('Dodaj'),
                ),
              ],
            );
          },
        );
      },
    );
  }

  List<TableRow> _buildSideDishesTableRows(List<SideDishViewModel> sideDishes) {
    return sideDishes
        .map((sideDish) => TableRow(
              children: [
                Center(
                  child: Padding(
                    padding: const EdgeInsets.all(8.0),
                    child: Text(sideDish.name),
                  ),
                ),
                Center(
                  child: Padding(
                    padding: const EdgeInsets.all(8.0),
                    child: Text(sideDish.price.toString() + ' KM'),
                  ),
                ),
                Padding(
                  padding: const EdgeInsets.symmetric(vertical: 8.0),
                  child: Row(
                    mainAxisAlignment: MainAxisAlignment.center,
                    children: [
                      IconButton(
                        icon: Icon(Icons.edit, color: Colors.yellow),
                        onPressed: () async {
                          if (sideDish?.id != null) {
                            try {
                              SideDishViewModel sideDishs =
                                  await SideDishApiService()
                                      .getSideDishById(sideDish.id!);
                              this._showEditSideDishForm(
                                context,
                                sideDish,
                                () {
                                  setState(() {
                                    _fetchSideDishes();
                                  });
                                },
                                sideDishes,
                                _sideDishesTableState,
                              );
                            } catch (e) {
                              print(e);
                            }
                          }
                        },
                      ),
                      SizedBox(width: 20),
                      IconButton(
                        icon: Icon(Icons.delete, color: Colors.red),
                        onPressed: () async {
                          final confirmed = await showDialog<bool>(
                            context: context,
                            builder: (context) =>
                                _buildConfirmationDialog(context, sideDish),
                          );
                          if (confirmed != null && confirmed) {
                            try {
                              await SideDishApiService()
                                  .deleteSideDish(sideDish.id!);
                              setState(() {
                                _sideDishes.removeWhere(
                                    (dish) => dish.id == sideDish.id);
                              });
                            } catch (e) {
                              print(e);
                            }
                          }
                        },
                      ),
                    ],
                  ),
                ),
              ],
            ))
        .toList();
  }

  void _showSideDishesDialog(BuildContext context) async {
    final sideDishes = await SideDishApiService().getSideDishes();

    showDialog(
      context: context,
      builder: (context) {
        return AlertDialog(
          title: Text("Upravljaj prilozima"),
          content: SizedBox(
            width: 400,
            child: SingleChildScrollView(
              child: SideDishesTable(
                sideDishes: sideDishes,
                menuPageState: this,
                onTableStateInitialized: _setSideDishesTableState,
              ),
            ),
          ),
          actions: <Widget>[
            TextButton(
              child: Text('Zatvori'),
              onPressed: () {
                Navigator.of(context).pop();
              },
            ),
            TextButton(
              child: Text('Dodaj prilog'),
              onPressed: () {
                Navigator.of(context).pop();
                _showAddSideDishForm(context);
              },
            ),
          ],
        );
      },
    ).then((_) {
      setState(() {});
    });
  }

  Widget _buildConfirmationDialog(
      BuildContext context, SideDishViewModel sideDish) {
    return AlertDialog(
      title: Text('Potvrda brisanja'),
      content: Text(
          'Da li ste sigurni da želite izbrisati prilog "${sideDish.name}"?'),
      actions: [
        TextButton(
          child: Text('Ne'),
          onPressed: () => Navigator.of(context).pop(false),
        ),
        TextButton(
          child: Text('Da'),
          onPressed: () => Navigator.of(context).pop(true),
        ),
      ],
    );
  }

  void _showEditSideDishForm(
    BuildContext context,
    SideDishViewModel sideDish,
    VoidCallback onSaveCallback,
    List<SideDishViewModel> sideDishes,
    _SideDishesTableState sideDishesTableState, // Add this parameter
  ) {
    final GlobalKey<FormState> _formKey = GlobalKey<FormState>();
    final TextEditingController _nameController =
        TextEditingController(text: sideDish.name);
    final TextEditingController _priceController =
        TextEditingController(text: sideDish.price.toString());
    bool _isAvailable = sideDish.isAvailable;

    showDialog(
      context: context,
      builder: (context) {
        return AlertDialog(
          title: Text("Aktualiziraj prilog"),
          content: Form(
            key: _formKey,
            child: SingleChildScrollView(
              child: Column(
                mainAxisSize: MainAxisSize.min,
                children: [
                  TextFormField(
                    controller: _nameController,
                    decoration: InputDecoration(labelText: 'Naziv'),
                  ),
                  TextFormField(
                    controller: _priceController,
                    decoration: InputDecoration(labelText: 'Cijena'),
                    keyboardType:
                        TextInputType.numberWithOptions(decimal: true),
                  ),
                  SwitchListTile(
                    title: Text("Dostupan"),
                    value: _isAvailable,
                    onChanged: (bool value) {
                      _isAvailable = value;
                    },
                  ),
                ],
              ),
            ),
          ),
          actions: <Widget>[
            TextButton(
              child: Text('Otkaži'),
              onPressed: () {
                Navigator.of(context).pop();
              },
            ),
            TextButton(
              child: Text('Sačuvaj'),
              onPressed: () async {
                if (_formKey.currentState!.validate()) {
                  _formKey.currentState!.save();

                  try {
                    await SideDishApiService().updateSideDish(
                      sideDish.id!,
                      _nameController.text,
                      double.parse(_priceController.text),
                      _isAvailable,
                    );

                    sideDish.name = _nameController.text;
                    sideDish.price = double.parse(_priceController.text);
                    sideDish.isAvailable = _isAvailable;

                    // Call the setState method in the _SideDishesTableState
                    sideDishesTableState.setState(() {});

                    Navigator.of(context).pop();
                    onSaveCallback();
                  } catch (e) {
                    print('Error updating side dish: $e');
                  }
                }
              },
            ),
          ],
        );
      },
    );
  }

  void _showAddSideDishForm(BuildContext context) {
    final GlobalKey<FormState> _formKey = GlobalKey<FormState>();
    String _name = '';
    double _price = 0.0;
    bool _isAvailable = true;

    showDialog(
      context: context,
      builder: (context) {
        return AlertDialog(
          title: Text("Dodaj novi prilog"),
          content: Form(
            key: _formKey,
            child: SingleChildScrollView(
              child: Column(
                mainAxisSize: MainAxisSize.min,
                children: [
                  TextFormField(
                    decoration: InputDecoration(labelText: 'Naziv'),
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Molimo unesite naziv';
                      }
                      return null;
                    },
                    onSaved: (value) {
                      _name = value!;
                    },
                  ),
                  TextFormField(
                    decoration: InputDecoration(labelText: 'Cijena'),
                    keyboardType:
                        TextInputType.numberWithOptions(decimal: true),
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Molimo unesite cijenu';
                      }
                      if (double.tryParse(value) == null) {
                        return 'Molimo unesite validne podatke';
                      }
                      return null;
                    },
                    onSaved: (value) {
                      _price = double.parse(value!);
                    },
                  ),
                  SwitchListTile(
                    title: Text("Dostupnost"),
                    value: _isAvailable,
                    onChanged: (bool value) {
                      // Update the state of the _isAvailable variable
                      _isAvailable = value;
                    },
                  ),
                ],
              ),
            ),
          ),
          actions: <Widget>[
            TextButton(
              child: Text('Otkaži'),
              onPressed: () {
                Navigator.of(context).pop();
              },
            ),
            TextButton(
              child: Text('Sačuvaj'),
              onPressed: () async {
                if (_formKey.currentState!.validate()) {
                  _formKey.currentState!.save();
                  try {
                    await SideDishApiService()
                        .createSideDish(_name, _price, _isAvailable);
                    _fetchSideDishes();
                    Navigator.of(context).pop(); // Close the form dialog
                  } catch (e) {
                    print(e); // Handle or show error
                  }
                }
              },
            ),
          ],
        );
      },
    );
  }

  Widget _buildMenuItemsList() {
    Widget labelSection = Container(
      padding: EdgeInsets.symmetric(horizontal: 16, vertical: 12),
      margin: EdgeInsets.symmetric(horizontal: 16, vertical: 8),
      decoration: BoxDecoration(
        color: Colors.blueGrey[100],
        borderRadius: BorderRadius.circular(12),
        border: Border.all(color: Colors.grey.shade400),
      ),
      child: Row(
        children: <Widget>[
          Expanded(flex: 2, child: Text('Slika', textAlign: TextAlign.center)),
          Expanded(
            flex: 2,
            child: Center(child: Text('Naziv')),
          ),
          Expanded(flex: 2, child: Center(child: Text('Kategorija'))),
          Expanded(flex: 2, child: Text('Cijena')),
          Expanded(flex: 2, child: Text('Dostupnost')),
          Expanded(flex: 2, child: Text('Uredi', textAlign: TextAlign.center)),
          Expanded(flex: 2, child: Text('Ukloni', textAlign: TextAlign.center)),
        ],
      ),
    );

    return Column(
      children: [
        labelSection,
        Expanded(
          child: ListView.separated(
            itemCount: _menuItems.length,
            separatorBuilder: (context, index) =>
                Divider(color: Colors.grey[300]),
            itemBuilder: (context, index) {
              final menuItem = _menuItems[index];
              return Container(
                padding: EdgeInsets.symmetric(horizontal: 16, vertical: 12),
                margin: EdgeInsets.symmetric(horizontal: 16, vertical: 8),
                decoration: BoxDecoration(
                  color: Colors.grey[200],
                  borderRadius: BorderRadius.circular(12),
                  border: Border.all(color: Colors.grey.shade400),
                ),
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: <Widget>[
                    Row(
                      children: <Widget>[
                        Expanded(
                          flex: 2,
                          child: _buildMenuItemImage(menuItem.id),
                        ),
                        Expanded(
                          flex: 2,
                          child: Center(
                            child: Text(menuItem.name,
                                style: TextStyle(fontWeight: FontWeight.bold)),
                          ),
                        ),
                        Expanded(
                          flex: 2,
                          child: Center(
                            child: Text(menuItem.category.name),
                          ),
                        ),
                        Expanded(
                          flex: 2,
                          child: Text('${menuItem.price} KM'),
                        ),
                        Expanded(
                          flex: 2,
                          child: Text(
                              menuItem.isAvailable ? 'Dostupno' : 'Nedostupno',
                              style: TextStyle(
                                  color: menuItem.isAvailable
                                      ? Colors.green
                                      : Colors.red)),
                        ),
                        Expanded(
                          flex: 2,
                          child: ElevatedButton(
                            onPressed: () =>
                                _showEditDialog(context, menuItem.id),
                            child: Text('Uredi'),
                            style: ElevatedButton.styleFrom(
                              primary: Colors.yellow, // Background color
                              onPrimary: Colors.white, // Text color
                              shape: RoundedRectangleBorder(
                                borderRadius: BorderRadius.circular(30),
                              ),
                            ),
                          ),
                        ),
                        Expanded(
                          flex: 2,
                          child: ElevatedButton(
                            onPressed: () =>
                                _showRemoveDialog(context, menuItem.id),
                            child: Text('Ukloni'),
                            style: ElevatedButton.styleFrom(
                              primary: Colors.red, // Background color
                              onPrimary: Colors.white, // Text color
                              shape: RoundedRectangleBorder(
                                borderRadius: BorderRadius.circular(30),
                              ),
                            ),
                          ),
                        ),
                      ],
                    ),
                    Row(
                      children: [
                        Expanded(
                          flex: 2,
                          child: TextButton(
                            onPressed: () => _showLogoForm(context, menuItem),
                            child: Text('Logo'),
                          ),
                        ),
                        Expanded(
                          flex: 10,
                          child: SizedBox.shrink(),
                        ),
                      ],
                    ),
                  ],
                ),
              );
            },
          ),
        ),
      ],
    );
  }

  Future<void> _showLogoForm(
      BuildContext context, FoodItemViewModel menuItem) async {
    String? logoUrl;
    bool hasLogo = false;
    int? logoId;

    try {
      logoUrl = await _menuApiService.fetchImageUrl(menuItem.id);
      hasLogo = logoUrl != null && logoUrl.isNotEmpty;
      logoId = hasLogo ? await _menuApiService.fetchImageId(menuItem.id) : null;
    } catch (e) {
      print('Error fetching image URL: $e');
    }

    await showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: Text('Logo za ${menuItem.name}'),
          content: StatefulBuilder(
            builder: (BuildContext context, StateSetter setState) {
              return Column(
                mainAxisSize: MainAxisSize.min,
                children: [
                  Container(
                    width: 200,
                    height: 200,
                    decoration: BoxDecoration(
                      borderRadius: BorderRadius.circular(10),
                    ),
                    child: _buildImageWidget(hasLogo, logoUrl),
                  ),
                  SizedBox(height: 16),
                  ElevatedButton(
                    onPressed: () async {
                      await pickImage();
                      setState(() {});
                    },
                    child: Text('Promijenite Logo'),
                  ),
                ],
              );
            },
          ),
          actions: [
            TextButton(
              onPressed: () => Navigator.pop(context),
              child: Text('Otkaži'),
            ),
            ElevatedButton(
              onPressed: () async {
                if (_imagePath != null) {
                  if (hasLogo && logoId != null) {
                    bool deleteSuccess =
                        await _menuApiService.deleteImageUrl(logoId);
                    if (deleteSuccess) {
                      bool uploadSuccess = await uploadImage(menuItem.id);
                      if (uploadSuccess) {
                        setState(() {
                          _imagePath = null;
                        });
                        Navigator.pop(context);
                      }
                    }
                  } else {
                    bool uploadSuccess = await uploadImage(menuItem.id);
                    if (uploadSuccess) {
                      setState(() {
                        _imagePath = null;
                      });
                      Navigator.pop(context);
                    }
                  }
                }
              },
              child: Text('Sačuvaj'),
            ),
          ],
        );
      },
    );
  }

  Widget _buildImageWidget(bool hasLogo, String? logoUrl) {
    if (_imagePath != null) {
      return Image.file(
        File(_imagePath!),
        fit: BoxFit.cover,
      );
    } else if (hasLogo) {
      return Image.network(
        logoUrl!,
        fit: BoxFit.cover,
      );
    } else {
      return Image.network(
        "https://uxwing.com/wp-content/themes/uxwing/download/food-and-drinks/meal-food-icon.png",
        fit: BoxFit.cover,
      );
    }
  }

  Widget _buildMenuItemImage(int id) {
    return FutureBuilder<String>(
      future: _menuApiService.fetchImageUrl(id),
      builder: (BuildContext context, AsyncSnapshot<String> snapshot) {
        // Define the default image widget here, to be used in case of loading or errors.
        Widget imageWidget = Container(
            width: 60,
            height: 60,
            decoration: BoxDecoration(
              color: Colors.grey[200],

              // Default image or a loading indicator could be placed here.
            ),
            child: Image.network(
                "https://uxwing.com/wp-content/themes/uxwing/download/food-and-drinks/meal-food-icon.png") // Default icon
            );

        // When the Future is still processing, show a loading state.
        if (snapshot.connectionState == ConnectionState.waiting) {
          imageWidget = Container(
            width: 100,
            height: 100,
            decoration: BoxDecoration(
              color: Colors.grey[200],
              borderRadius: BorderRadius.circular(30),
            ),
            child: CircularProgressIndicator(), // Show a loading spinner.
          );
        } else if (snapshot.hasData) {
          // When data is available (which should always be the case now), display the image.
          imageWidget = Container(
            width: 100,
            height: 100,
            decoration: BoxDecoration(
              image: DecorationImage(
                image: NetworkImage(snapshot.data!),
                fit: BoxFit.contain,
              ),
            ),
          );
        } // No need for an else block for errors, as fetchImageUrl guarantees a URL

        return Padding(
          padding: EdgeInsets.all(8.0),
          child: imageWidget,
        );
      },
    );
  }

  void _showRemoveDialog(BuildContext context, int id) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: Text('Uklanjanje stavke menija'),
          content:
              Text('Da li ste sigurni da želite ukloniti ovu stavku menija?'),
          actions: <Widget>[
            TextButton(
              child: Text('Odustani'),
              style: TextButton.styleFrom(
                primary: Colors.grey,
              ),
              onPressed: () {
                Navigator.of(context).pop();
              },
            ),
            TextButton(
              child: Text('Ukloni'),
              style: TextButton.styleFrom(
                primary: Colors.red,
              ),
              onPressed: () async {
                try {
                  await _menuApiService.deleteFoodItem(id);
                  setState(() {
                    _fetchMenuItems();
                    _fetchCategories();
                  });
                  Navigator.of(context).pop();
                } catch (e) {
                  print('Error deleting menu item: $e');
                }
              },
            ),
          ],
        );
      },
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
                ? () => _fetchMenuItems(pageNumber: _currentPage)
                : null,
          ),
          Text('Page ${_currentPage + 1} of $_totalPages'),
          IconButton(
            icon: Icon(Icons.arrow_forward_ios),
            onPressed: _currentPage < _totalPages - 1
                ? () => _fetchMenuItems(pageNumber: _currentPage + 2)
                : null,
          ),
        ],
      ),
    );
  }
}

class SideDishesTable extends StatefulWidget {
  final List<SideDishViewModel> sideDishes;
  final _MenuPageState menuPageState;
  final Function(_SideDishesTableState) onTableStateInitialized;
  const SideDishesTable({
    Key? key,
    required this.sideDishes,
    required this.menuPageState,
    required this.onTableStateInitialized,
  }) : super(key: key);

  @override
  _SideDishesTableState createState() => _SideDishesTableState();
}

class _SideDishesTableState extends State<SideDishesTable> {
  late _MenuPageState _menuPageState;
  @override
  void initState() {
    super.initState();
    _menuPageState = widget.menuPageState;
    widget.onTableStateInitialized(this);
  }

  List<TableRow> _buildSideDishesTableRows(List<SideDishViewModel> sideDishes) {
    return sideDishes
        .map((sideDish) => TableRow(
              children: [
                Center(
                  child: Padding(
                    padding: const EdgeInsets.all(8.0),
                    child: Text(sideDish.name),
                  ),
                ),
                Center(
                  child: Padding(
                    padding: const EdgeInsets.all(8.0),
                    child: Text(sideDish.price.toString() + ' KM'),
                  ),
                ),
                Padding(
                  padding: const EdgeInsets.symmetric(vertical: 8.0),
                  child: Row(
                    mainAxisAlignment: MainAxisAlignment.center,
                    children: [
                      IconButton(
                        icon: Icon(Icons.edit, color: Colors.yellow),
                        onPressed: () async {
                          if (sideDish?.id != null) {
                            try {
                              SideDishViewModel sideDishs =
                                  await SideDishApiService()
                                      .getSideDishById(sideDish.id!);

                              _menuPageState
                                  ._showEditSideDishForm(context, sideDish, () {
                                setState(() {});
                              }, widget.sideDishes, this);
                            } catch (e) {
                              print(e);
                            }
                          }
                        },
                      ),
                      SizedBox(width: 20),
                      IconButton(
                        icon: Icon(Icons.delete, color: Colors.red),
                        onPressed: () async {
                          final confirmed = await showDialog<bool>(
                            context: context,
                            builder: (context) => _menuPageState
                                ._buildConfirmationDialog(context, sideDish),
                          );
                          if (confirmed != null && confirmed) {
                            try {
                              await SideDishApiService()
                                  .deleteSideDish(sideDish.id!);
                              setState(() {
                                widget.sideDishes.removeWhere(
                                    (dish) => dish.id == sideDish.id);
                              });
                            } catch (e) {
                              print(e);
                            }
                          }
                        },
                      ),
                    ],
                  ),
                ),
              ],
            ))
        .toList();
  }

  @override
  Widget build(BuildContext context) {
    return Table(
      border: TableBorder.all(color: Colors.grey),
      columnWidths: const {
        0: FlexColumnWidth(2),
        1: FlexColumnWidth(1),
        2: FlexColumnWidth(3),
      },
      children: [
        TableRow(children: [
          Center(
            child: Padding(
              padding: const EdgeInsets.all(8.0),
              child:
                  Text('Naziv', style: TextStyle(fontWeight: FontWeight.bold)),
            ),
          ),
          Center(
            child: Padding(
              padding: const EdgeInsets.all(8.0),
              child:
                  Text('Cijena', style: TextStyle(fontWeight: FontWeight.bold)),
            ),
          ),
          Center(
            child: Padding(
              padding: const EdgeInsets.all(8.0),
              child:
                  Text('Akcije', style: TextStyle(fontWeight: FontWeight.bold)),
            ),
          ),
        ]),
        ..._buildSideDishesTableRows(widget.sideDishes),
      ],
    );
  }
}
