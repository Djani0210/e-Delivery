import 'package:e_delivery_mobile/deliveryPerson/screens/profile/api/employee_profile_service.dart';
import 'package:e_delivery_mobile/deliveryPerson/screens/profile/dto/employee_update_dto.dart';
import 'package:flutter/material.dart';
import 'package:e_delivery_mobile/deliveryPerson/screens/Home/dto/delivery_person_get_dto.dart';
import 'package:intl/intl.dart';

class UpdateEmployeeAvailabilityPage extends StatefulWidget {
  final DeliveryPersonGetDTO userData;
  final Function onUpdated;

  const UpdateEmployeeAvailabilityPage(
      {Key? key, required this.userData, required this.onUpdated})
      : super(key: key);

  @override
  _UpdateEmployeeAvailabilityPageState createState() =>
      _UpdateEmployeeAvailabilityPageState();
}

class _UpdateEmployeeAvailabilityPageState
    extends State<UpdateEmployeeAvailabilityPage> {
  late bool isAvailable;
  late TimeOfDay workFrom;
  late TimeOfDay workUntil;

  @override
  void initState() {
    super.initState();
    isAvailable = widget.userData.isAvailable ?? false;
    workFrom = _parseTime(widget.userData.workFrom);
    workUntil = _parseTime(widget.userData.workUntil);
  }

  TimeOfDay _parseTime(String? time) {
    if (time == null) return TimeOfDay(hour: 9, minute: 0);
    final format = DateFormat("HH:mm:ss");
    return TimeOfDay.fromDateTime(format.parse(time));
  }

  Future<void> _selectTime(BuildContext context, bool isStartTime) async {
    final TimeOfDay? picked = await showTimePicker(
      context: context,
      initialTime: isStartTime ? workFrom : workUntil,
      initialEntryMode: TimePickerEntryMode.input,
      builder: (BuildContext context, Widget? child) {
        return MediaQuery(
          data: MediaQuery.of(context).copyWith(alwaysUse24HourFormat: true),
          child: child!,
        );
      },
    );
    if (picked != null) {
      setState(() {
        if (isStartTime) {
          workFrom = picked;
        } else {
          workUntil = picked;
        }
      });
    }
  }

  Future<void> _updateAvailability() async {
    final String formattedWorkFrom = _formatTimeOfDay(workFrom);
    final String formattedWorkUntil = _formatTimeOfDay(workUntil);

    final dto = DeliveryPersonUpdateDTO(
      isAvailable: isAvailable,
      workFrom: formattedWorkFrom,
      workUntil: formattedWorkUntil,
    );

    try {
      final response =
          await EmployeeProfileService().updateDeliveryPersonAvailability(dto);
      if (response.statusCode == 200) {
        widget.onUpdated();
        Navigator.pop(context);
        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(
            content: Center(
              child: Text("Updated"),
            ),
            behavior: SnackBarBehavior.floating,
            duration: Duration(seconds: 2),
          ),
        );
      } else {
        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(
            content: Text("Failed to update"),
            behavior: SnackBarBehavior.floating,
            duration: Duration(seconds: 2),
          ),
        );
      }
    } catch (e) {
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          content: Text("Error: $e"),
          behavior: SnackBarBehavior.floating,
          duration: Duration(seconds: 2),
        ),
      );
    }
  }

  String _formatTimeOfDay(TimeOfDay time) {
    final now = DateTime.now();
    final dt = DateTime(now.year, now.month, now.day, time.hour, time.minute);
    final format = DateFormat("HH:mm");
    return format.format(dt);
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Update Availability'),
      ),
      body: Padding(
        padding: const EdgeInsets.all(16.0),
        child: Column(
          children: [
            SwitchListTile(
              title: Text('Available'),
              value: isAvailable,
              onChanged: (bool value) {
                setState(() {
                  isAvailable = value;
                });
              },
            ),
            ListTile(
              title: Text('Work From'),
              subtitle: Text(workFrom.format(context)),
              onTap: () => _selectTime(context, true),
            ),
            ListTile(
              title: Text('Work Until'),
              subtitle: Text(workUntil.format(context)),
              onTap: () => _selectTime(context, false),
            ),
            SizedBox(height: 20),
            ElevatedButton(
              onPressed: _updateAvailability,
              child: Text('Save Changes'),
            ),
          ],
        ),
      ),
    );
  }
}
