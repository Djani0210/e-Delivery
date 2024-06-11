import 'package:e_delivery_mobile/customer/screens/order/dto/orderitem_dto.dart';
import 'package:e_delivery_mobile/customer/screens/restaurants/dto/category_with_fooditems.dart';
import 'package:flutter/material.dart';

class FoodItemPage extends StatefulWidget {
  final FoodItemViewModel foodItem;

  const FoodItemPage({Key? key, required this.foodItem}) : super(key: key);

  @override
  _FoodItemPageState createState() => _FoodItemPageState();
}

class _FoodItemPageState extends State<FoodItemPage> {
  Set<int> selectedSideDishes = {};
  int orderItemQuantity = 1;

  double _calculateTotalPrice() {
    double sideDishesTotal =
        widget.foodItem.sideDishes.fold(0, (sum, sideDish) {
      return sum +
          (selectedSideDishes.contains(sideDish.id) ? sideDish.price : 0);
    });
    return (widget.foodItem.price + sideDishesTotal) * orderItemQuantity;
  }

  void _addToOrder() {
    List<int> selectedSideDishIds = widget.foodItem.sideDishes
        .where((sideDish) => selectedSideDishes.contains(sideDish.id))
        .map((sideDish) => sideDish.id)
        .toList();

    OrderItem orderItem = OrderItem(
      foodItemId: widget.foodItem.id,
      sideDishIds: selectedSideDishIds,
      quantity: orderItemQuantity,
      cost: _calculateTotalPrice(),
    );

    if (Navigator.canPop(context)) {
      Navigator.pop(context, orderItem);
    }
  }

  @override
  Widget build(BuildContext context) {
    final imageUrl = widget.foodItem.foodItemPictures.isNotEmpty
        ? widget.foodItem.foodItemPictures.first.fileName
        : 'assets/images/no-image-found.jpg';
    final isNetworkImage =
        imageUrl.startsWith('http') || imageUrl.startsWith('https');

    return Scaffold(
      appBar: AppBar(
        title: Text(widget.foodItem.name),
        leading: IconButton(
          icon: const Icon(Icons.close),
          onPressed: () => Navigator.pop(context),
        ),
      ),
      body: Stack(
        children: [
          SingleChildScrollView(
            child: Padding(
              padding: const EdgeInsets.only(bottom: 80.0),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  isNetworkImage
                      ? Image.network(
                          imageUrl,
                          width: double.infinity,
                          height: 300,
                          fit: BoxFit.cover,
                        )
                      : Image.asset(
                          imageUrl,
                          width: double.infinity,
                          height: 300,
                          fit: BoxFit.cover,
                        ),
                  Padding(
                    padding: const EdgeInsets.all(16.0),
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Text(
                          widget.foodItem.name,
                          style: const TextStyle(
                              fontSize: 24, fontWeight: FontWeight.bold),
                        ),
                        const SizedBox(height: 8),
                        Text(
                          'KM ${widget.foodItem.price.toStringAsFixed(2)}',
                          style: const TextStyle(
                              fontSize: 16, fontWeight: FontWeight.bold),
                        ),
                        const SizedBox(height: 16),
                        Text(widget.foodItem.description),
                        const SizedBox(height: 8),
                        const Divider(),
                        const Text(
                          "Side dishes",
                          style: TextStyle(
                              fontSize: 24, fontWeight: FontWeight.bold),
                        ),
                        const SizedBox(height: 8),
                        _buildSideDishesSection(),
                        const SizedBox(height: 16),
                        const Divider(),
                        const Text(
                          "Quantity",
                          style: TextStyle(
                              fontSize: 24, fontWeight: FontWeight.bold),
                        ),
                        const SizedBox(height: 8),
                        _buildOrderItemCounter(),
                      ],
                    ),
                  ),
                ],
              ),
            ),
          ),
          Positioned(
            bottom: 0,
            left: 0,
            right: 0,
            child: Container(
              color: Colors.white,
              padding: const EdgeInsets.all(16.0),
              child: AddOrderItemButton(
                totalPrice: _calculateTotalPrice(),
                onPressed: _addToOrder,
              ),
            ),
          ),
        ],
      ),
    );
  }

  Widget _buildSideDishesSection() {
    if (widget.foodItem.sideDishes.isEmpty) {
      return Padding(
        padding: const EdgeInsets.symmetric(vertical: 8.0),
        child: Text(
          'No side dishes for this item',
          style: TextStyle(fontSize: 16, fontStyle: FontStyle.italic),
        ),
      );
    }

    return Column(
      children: widget.foodItem.sideDishes.map((sideDish) {
        return Column(
          children: [
            Padding(
              padding: const EdgeInsets.symmetric(vertical: 8.0),
              child: Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Expanded(
                    child: Text(
                      '${sideDish.name} (+ KM ${sideDish.price.toStringAsFixed(2)})',
                      style: TextStyle(fontSize: 16),
                    ),
                  ),
                  Checkbox(
                    value: selectedSideDishes.contains(sideDish.id),
                    onChanged: (value) {
                      setState(() {
                        if (value!) {
                          selectedSideDishes.add(sideDish.id);
                        } else {
                          selectedSideDishes.remove(sideDish.id);
                        }
                      });
                    },
                  ),
                ],
              ),
            ),
            Divider(),
          ],
        );
      }).toList(),
    );
  }

  Widget _buildOrderItemCounter() {
    return Row(
      mainAxisAlignment: MainAxisAlignment.center,
      children: [
        IconButton(
          icon: Icon(Icons.remove, color: Colors.red, size: 32),
          onPressed: orderItemQuantity > 1
              ? () {
                  setState(() {
                    orderItemQuantity--;
                  });
                }
              : null,
        ),
        Padding(
          padding: const EdgeInsets.symmetric(horizontal: 16.0),
          child: Text(
            '$orderItemQuantity',
            style: TextStyle(fontSize: 24, fontWeight: FontWeight.bold),
          ),
        ),
        IconButton(
          icon: Icon(Icons.add, color: Colors.green, size: 32),
          onPressed: () {
            setState(() {
              orderItemQuantity++;
            });
          },
        ),
      ],
    );
  }
}

class AddOrderItemButton extends StatelessWidget {
  final double totalPrice;
  final VoidCallback onPressed;

  const AddOrderItemButton({
    Key? key,
    required this.totalPrice,
    required this.onPressed,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Container(
      width: double.infinity,
      child: ElevatedButton(
        style: ElevatedButton.styleFrom(
          primary: Colors.green[800],
          onPrimary: Colors.white,
          padding: const EdgeInsets.symmetric(vertical: 16.0),
          textStyle: const TextStyle(
            fontSize: 18,
            fontWeight: FontWeight.bold,
          ),
          shape: RoundedRectangleBorder(
            borderRadius: BorderRadius.circular(12.0),
          ),
        ),
        onPressed: onPressed,
        child: Text('Add for KM ${totalPrice.toStringAsFixed(2)}'),
      ),
    );
  }
}
