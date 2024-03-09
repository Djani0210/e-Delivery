import 'package:flutter/material.dart';

class OrderDetailsPage extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(
          'Detalji Narudžbe',
          style: TextStyle(color: Colors.black),
        ),
        backgroundColor:
            Colors.yellowAccent, // Updated to yellow color as requested
        leading: IconButton(
          icon: Icon(Icons.arrow_back, color: Colors.black),
          onPressed: () {
            Navigator.of(context).pop();
          },
        ),
      ),
      body: Padding(
        padding: const EdgeInsets.all(20.0),
        child: Row(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Expanded(
              child: Column(
                children: [
                  OrderInfoHeaderSection(),
                  SizedBox(height: 20),
                  Text(
                    "Sadržaj narudžbe:",
                    style: TextStyle(
                      fontWeight: FontWeight.bold,
                      fontSize: 18.0,
                    ),
                  ),
                  SizedBox(height: 30),
                  OrderItemsLabelSection(),
                  OrderItemsSection(),
                ],
              ),
            ),
            SizedBox(width: 20), // Adds space between the sections
            OrderSummarySection(), // This will take the size as per its content
          ],
        ),
      ),
    );
  }
}

class OrderInfoHeaderSection extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Card(
      shape: RoundedRectangleBorder(
        borderRadius: BorderRadius.circular(10.0),
      ),
      elevation: 4.0,
      child: Padding(
        padding: const EdgeInsets.symmetric(horizontal: 20.0, vertical: 10.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Text('Broj narudžbe: #1999',
                style: Theme.of(context).textTheme.headline6),
            Text('Datum narudžbe: 10.18.2023. 17:23',
                style: TextStyle(color: Colors.grey[700])),
          ],
        ),
      ),
    );
  }
}

class OrderItemsLabelSection extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Container(
      padding: const EdgeInsets.all(8.0),
      child: Row(
        mainAxisAlignment: MainAxisAlignment.spaceBetween,
        children: [
          Text('Slika', style: TextStyle(fontWeight: FontWeight.bold)),
          Text('Naziv jela', style: TextStyle(fontWeight: FontWeight.bold)),
          Text('Kategorija', style: TextStyle(fontWeight: FontWeight.bold)),
          Text('Cijena', style: TextStyle(fontWeight: FontWeight.bold)),
          Text('Količina', style: TextStyle(fontWeight: FontWeight.bold)),
        ],
      ),
    );
  }
}

class OrderItemsSection extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    // This list can be generated dynamically based on the order details
    final List<Map<String, dynamic>> orderItems = [
      {
        'imagePath': 'assets/images/1.jpg',
        'name': 'Hamburger',
        'category': 'Burgeri',
        'price': '7 KM',
        'quantity': '3',
      },
      // Add more items here
    ];

    return Card(
      elevation: 4.0,
      child: Container(
        padding: EdgeInsets.all(20.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            for (var item in orderItems) OrderItemWidget(item: item),
          ],
        ),
      ),
    );
  }
}

class OrderItemWidget extends StatelessWidget {
  final Map<String, dynamic> item;

  OrderItemWidget({required this.item});

  @override
  Widget build(BuildContext context) {
    return Container(
      padding: EdgeInsets.symmetric(vertical: 8.0),
      child: Row(
        mainAxisAlignment: MainAxisAlignment.spaceBetween,
        children: <Widget>[
          Image.asset(item['imagePath'], width: 50, height: 50),
          Text(item['name']),
          Text(item['category']),
          Text(item['price']),
          Text('Količina: ${item['quantity']}'),
        ],
      ),
    );
  }
}

class OrderSummarySection extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Container(
      width: 500,
      height: 600, // Set the width as requested
      padding:
          EdgeInsets.only(top: 20.0), // Aligns vertically with OrderItemSection
      child: Card(
        shape: RoundedRectangleBorder(
          borderRadius:
              BorderRadius.circular(10.0), // Rounded edges for the card
        ),
        color: Colors.grey[200], // Light grey background color for the card
        child: Padding(
          padding: EdgeInsets.all(16.0), // Padding inside the card
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Text('Plaćanje:',
                      style:
                          TextStyle(fontWeight: FontWeight.bold, fontSize: 16)),
                  Text('gotovina', style: TextStyle(fontSize: 16)),
                ],
              ),
              SizedBox(height: 16.0), // Spacing between the rows
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Text('Status:',
                      style:
                          TextStyle(fontWeight: FontWeight.bold, fontSize: 16)),
                  Text('dostavljeno', style: TextStyle(fontSize: 16)),
                ],
              ),
              SizedBox(height: 16.0),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Text('Ime kupca:',
                      style:
                          TextStyle(fontWeight: FontWeight.bold, fontSize: 16)),
                  Text('Majstor', style: TextStyle(fontSize: 16)),
                ],
              ),
              SizedBox(height: 16.0),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Text('Adresa kupca:',
                      style:
                          TextStyle(fontWeight: FontWeight.bold, fontSize: 16)),
                  Text('Musala BB', style: TextStyle(fontSize: 16)),
                ],
              ),
              SizedBox(height: 16.0),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Text('Alergije:',
                      style:
                          TextStyle(fontWeight: FontWeight.bold, fontSize: 16)),
                  Text('Nema', style: TextStyle(fontSize: 16)),
                ],
              ),
              SizedBox(height: 16.0),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Text('Dostavljač:',
                      style:
                          TextStyle(fontWeight: FontWeight.bold, fontSize: 16)),
                  Text('Dino Dinić', style: TextStyle(fontSize: 16)),
                ],
              ),
              SizedBox(height: 16.0),
              ElevatedButton(
                onPressed: () {},
                child: Text('Dodaj dostavljača'),
                style: ElevatedButton.styleFrom(
                  primary:
                      Theme.of(context).primaryColor, // Button background color
                  padding:
                      EdgeInsets.symmetric(vertical: 16.0), // Button padding
                  textStyle: TextStyle(
                      fontSize: 16,
                      fontWeight: FontWeight.bold), // Button text style
                ),
              ),
              Divider(color: Colors.grey[400]),
              Padding(
                padding: const EdgeInsets.only(bottom: 16.0, top: 16.0),
                child: Text('Detalji Plaćanja',
                    style:
                        TextStyle(fontWeight: FontWeight.bold, fontSize: 18)),
              ),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Text('Cijena narudžbe:',
                      style:
                          TextStyle(fontWeight: FontWeight.bold, fontSize: 16)),
                  Text('21 KM', style: TextStyle(fontSize: 16)),
                ],
              ),
              SizedBox(height: 16.0),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Text('Trošak dostave:',
                      style:
                          TextStyle(fontWeight: FontWeight.bold, fontSize: 16)),
                  Text('2 KM', style: TextStyle(fontSize: 16)),
                ],
              ),
              SizedBox(height: 16.0),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Text('Ukupna cijena:',
                      style:
                          TextStyle(fontWeight: FontWeight.bold, fontSize: 16)),
                  Text('23 KM', style: TextStyle(fontSize: 16)),
                ],
              ),
              SizedBox(height: 16.0),
            ],
          ),
        ),
      ),
    );
  }
}
