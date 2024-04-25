import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:desktop/restaurant/api_calls/employee_api_calls.dart';
import 'package:desktop/restaurant/viewmodels/employees_get_VM.dart';

class EmployeesPage extends StatefulWidget {
  @override
  _EmployeesPageState createState() => _EmployeesPageState();
}

class _EmployeesPageState extends State<EmployeesPage> {
  final EmployeeApiService _employeeApiService = EmployeeApiService();
  List<EmployeeViewModel> _employees = [];
  int _currentPage = 0;
  int _totalPages = 0;
  final int _perPage = 3;
  String _searchTerm = '';
  bool? _isAvailable;
  String _selectedAvailability = 'Svi';

  @override
  void initState() {
    super.initState();
    _fetchEmployees();
  }

  Future<void> _fetchEmployees({
    int pageNumber = 1,
    bool? isAvailable,
    String? username,
  }) async {
    final response = await _employeeApiService.getRestaurantEmployees(
      pageNumber: pageNumber,
      itemsPerPage: _perPage,
      isAvailable: isAvailable,
      username: username,
    );
    if (response != null && response.statusCode == 200) {
      final Map<String, dynamic> responseBody = json.decode(response.body);
      final List<dynamic> employeesData = responseBody['data']['employees'];
      final int totalPages = responseBody['data']['totalPages'];

      final List<EmployeeViewModel> fetchedEmployees = employeesData
          .map((employee) => EmployeeViewModel.fromJson(employee))
          .toList();

      setState(() {
        _employees = fetchedEmployees;
        _totalPages = totalPages;
        _currentPage = pageNumber - 1;
      });
    } else {
      print("Failed to fetch employees. Status code: ${response?.statusCode}");
    }
  }

  Widget _buildSearchAndFilter() {
    // No need to reinitialize the controller every build
    final TextEditingController _searchController =
        TextEditingController(text: _searchTerm);

    // You may want to move this outside of build to prevent recreating it on every build
    final List<Map<String, dynamic>> _availabilityOptions = [
      {'label': 'Svi', 'value': null},
      {'label': 'Dostupni', 'value': true},
      {'label': 'Nedostupni', 'value': false},
    ];

    // This is to prevent the cursor from jumping to the end of the input text
    // after each character is typed
    _searchController.selection = TextSelection.fromPosition(
        TextPosition(offset: _searchController.text.length));

    void _handleSearchAndFilter() {
      setState(() {
        _fetchEmployees(
          username: _searchTerm,
          isAvailable: _selectedAvailability == 'Dostupni'
              ? true
              : _selectedAvailability == 'Nedostupni'
                  ? false
                  : null,
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
                _searchTerm = value; // Update the searchTerm with each change
                _handleSearchAndFilter(); // Filter with every change
              },
            ),
          ),
          SizedBox(width: 20), // Spacing between search field and dropdown
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
            'Dostavljači',
            style: TextStyle(fontSize: 24, fontWeight: FontWeight.bold),
          ),
        ),
        SizedBox(height: 16),
        _buildSearchAndFilter(),
        Expanded(
          // This will ensure the list and pagination occupy the remaining space
          child: Column(
            children: [
              Expanded(
                // Allows the employee list to take up all available space
                child: ClipRRect(
                  borderRadius: BorderRadius.circular(16),
                  child: _buildEmployeesList(),
                ),
              ),
              _buildPagination(), // Keeps pagination at the bottom
            ],
          ),
        ),
      ],
    );
  }

  Widget _buildEmployeesList() {
    // Header row with labels
    Widget labelSection = Container(
      padding: EdgeInsets.symmetric(horizontal: 16, vertical: 12),
      margin: EdgeInsets.symmetric(horizontal: 16, vertical: 8),
      decoration: BoxDecoration(
        color: Colors.blueGrey[100], // Slightly different color for the header
        borderRadius: BorderRadius.circular(12),
        border: Border.all(color: Colors.grey.shade400),
      ),
      child: Row(
        children: <Widget>[
          Expanded(flex: 2, child: Text('Slika', textAlign: TextAlign.center)),
          Expanded(
            flex: 3,
            child: Center(child: Text('Ime i prezime')),
          ),
          Expanded(flex: 3, child: Text('Kontakt')),
          Expanded(flex: 3, child: Text('Dostupnost')),
          Expanded(flex: 3, child: Text('Radno vrijeme')),
          Expanded(flex: 2, child: Text('Akcija', textAlign: TextAlign.center)),
        ],
      ),
    );

    return Column(
      children: [
        labelSection,
        Expanded(
          child: ListView.separated(
            itemCount: _employees.length,
            separatorBuilder: (context, index) =>
                Divider(color: Colors.grey[300]),
            itemBuilder: (context, index) {
              final employee = _employees[index];
              return Container(
                padding: EdgeInsets.symmetric(horizontal: 16, vertical: 12),
                margin: EdgeInsets.symmetric(horizontal: 16, vertical: 8),
                decoration: BoxDecoration(
                  color: Colors.grey[200],
                  borderRadius: BorderRadius.circular(12),
                  border: Border.all(color: Colors.grey.shade400),
                ),
                child: Row(
                  children: <Widget>[
                    Expanded(
                      flex: 2,
                      child: _buildEmployeeImage(employee.id),
                    ),
                    Expanded(
                      flex: 3,
                      child: Center(
                        child: Text(
                            '${employee.firstName} ${employee.lastName}',
                            style: TextStyle(fontWeight: FontWeight.bold)),
                      ),
                    ),
                    Expanded(
                      flex: 3,
                      child: Text(employee.phoneNumber),
                    ),
                    Expanded(
                      flex: 3,
                      child: Text(
                          employee.isAvailable ? 'Dostupan' : 'Nedostupan',
                          style: TextStyle(
                              color: employee.isAvailable
                                  ? Colors.green
                                  : Colors.red)),
                    ),
                    Expanded(
                      flex: 3,
                      child: Text(
                          '${_formatTime(employee.workFrom)} - ${_formatTime(employee.workUntil)}'),
                    ),
                    Expanded(
                      flex: 2,
                      child: TextButton(
                        onPressed: () =>
                            _showRemoveDialog(context, employee.id),
                        child: Text('Ukloni'),
                        style: TextButton.styleFrom(
                          primary: Colors.white,
                          backgroundColor: Colors.red,
                          shape: RoundedRectangleBorder(
                            borderRadius: BorderRadius.circular(30),
                          ),
                        ),
                      ),
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

  Widget _buildEmployeeImage(String id) {
    return FutureBuilder<String>(
      future: _employeeApiService.fetchImageUrl(id),
      builder: (BuildContext context, AsyncSnapshot<String> snapshot) {
        Widget imageWidget;
        if (snapshot.connectionState == ConnectionState.waiting) {
          imageWidget = Container(
            width: 60, // Define your preferred width
            height: 60, // Define your preferred height
            decoration: BoxDecoration(
              color: Colors.grey[200],
              borderRadius:
                  BorderRadius.circular(30), // Adjust for rounded corners
            ),
          );
        } else if (snapshot.hasError || !snapshot.hasData) {
          imageWidget = Container(
            width: 80, // Define your preferred width
            height: 80, // Define your preferred height
            decoration: BoxDecoration(
              color: Colors.grey[200],
              borderRadius:
                  BorderRadius.circular(30), // Adjust for rounded corners
            ),
            child: Icon(Icons.error, color: Colors.red),
          );
        } else {
          imageWidget = Container(
            width: 100, // Define your preferred width
            height: 100, // Define your preferred height
            decoration: BoxDecoration(
              borderRadius:
                  BorderRadius.circular(30), // Adjust for rounded corners
              image: DecorationImage(
                image: NetworkImage(snapshot.data!),
                fit: BoxFit
                    .contain, // This will cover the space, cropping as needed
              ),
            ),
          );
        }
        return Padding(
          padding: EdgeInsets.all(8.0),
          child: imageWidget,
        );
      },
    );
  }

  String _formatTime(String time) {
    // Assume 'time' is in the format 'HH:mm:ss'
    return TimeOfDay.fromDateTime(DateTime.parse('0000-01-01 $time'))
        .format(context);
  }

  void _showRemoveDialog(BuildContext context, String id) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: Text('Uklanjanje dostavljača'),
          content:
              Text('Da li ste sigurni da želite ukloniti ovog dostavljača?'),
          actions: <Widget>[
            TextButton(
              child: Text('Odustani'),
              style: TextButton.styleFrom(
                primary: Colors.grey, // Color for the text
              ),
              onPressed: () {
                Navigator.of(context).pop(); // Close the dialog
              },
            ),
            ElevatedButton(
              child: Text('Potvrdi'),
              style: ElevatedButton.styleFrom(
                primary: Colors.red, // Background color
              ),
              onPressed: () async {
                Navigator.of(context).pop(); // Close the dialog
                final success = await _employeeApiService.removeEmployee(id);
                if (success) {
                  _fetchEmployees(); // Refresh the employee list
                } else {
                  // Optionally show a failure message
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
                ? () => _fetchEmployees(pageNumber: _currentPage)
                : null,
          ),
          Text('Page ${_currentPage + 1} of $_totalPages'),
          IconButton(
            icon: Icon(Icons.arrow_forward_ios),
            onPressed: _currentPage < _totalPages - 1
                ? () => _fetchEmployees(pageNumber: _currentPage + 2)
                : null,
          ),
        ],
      ),
    );
  }
}
