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
  String _selectedAvailability = 'All';

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
      {'label': 'All', 'value': null},
      {'label': 'Available', 'value': true},
      {'label': 'Unavailable', 'value': false},
    ];

    // This is to prevent the cursor from jumping to the end of the input text
    // after each character is typed
    _searchController.selection = TextSelection.fromPosition(
        TextPosition(offset: _searchController.text.length));

    void _handleSearchAndFilter() {
      setState(() {
        _fetchEmployees(
          username: _searchTerm,
          isAvailable: _selectedAvailability == 'Available'
              ? true
              : _selectedAvailability == 'Unavailable'
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
                labelText: 'Search',
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
            'Delivery people',
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
                  child: _buildEmployeesList(),
                ),
              ),
              _buildPagination(),
            ],
          ),
        ),
      ],
    );
  }

  Widget _buildEmployeesList() {
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
          Expanded(flex: 2, child: Text('Image', textAlign: TextAlign.center)),
          Expanded(
            flex: 3,
            child: Center(child: Text('Name')),
          ),
          Expanded(flex: 3, child: Text('Contact')),
          Expanded(flex: 3, child: Text('Availability')),
          Expanded(flex: 3, child: Text('Working hours')),
          Expanded(flex: 2, child: Text('Action', textAlign: TextAlign.center)),
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
                        child: Text('${employee.userName} ',
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
                          employee.isAvailable ? 'Available' : 'Unavailable',
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
                        child: Text('Remove'),
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
    return TimeOfDay.fromDateTime(DateTime.parse('0000-01-01 $time'))
        .format(context);
  }

  void _showRemoveDialog(BuildContext context, String id) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: Text('Remove Employee'),
          content: Text('Are you sure you want to remove this employee?'),
          actions: <Widget>[
            TextButton(
              child: Text('Cancel'),
              style: TextButton.styleFrom(
                primary: Colors.grey, // Color for the text
              ),
              onPressed: () {
                Navigator.of(context).pop(); // Close the dialog
              },
            ),
            ElevatedButton(
              child: Text('Confirm'),
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
