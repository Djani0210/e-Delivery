import 'dart:convert';
import 'package:e_delivery_mobile/customer/screens/home/dto/restaurant_get_dto.dart';
import 'package:e_delivery_mobile/customer/screens/home/dto/user_data_dto.dart';
import 'package:e_delivery_mobile/customer/screens/order/checkout_page.dart';
import 'package:e_delivery_mobile/customer/screens/order/dto/orderitem_dto.dart';
import 'package:e_delivery_mobile/customer/screens/order/fooditem_page.dart';
import 'package:e_delivery_mobile/customer/screens/restaurants/api/restaurants_api.dart';
import 'package:e_delivery_mobile/customer/screens/restaurants/dto/category_with_fooditems.dart';
import 'package:e_delivery_mobile/storage_service.dart';
import 'package:flutter/foundation.dart';
import 'package:flutter/material.dart';
import 'package:flutter_rating_bar/flutter_rating_bar.dart';
import 'package:google_maps_flutter/google_maps_flutter.dart';
import 'package:carousel_slider/carousel_slider.dart';

class RestaurantDetails extends StatefulWidget {
  final int restaurantId;

  const RestaurantDetails({Key? key, required this.restaurantId})
      : super(key: key);

  @override
  _RestaurantDetailsState createState() => _RestaurantDetailsState();
}

class _RestaurantDetailsState extends State<RestaurantDetails> {
  RestaurantViewModel? _restaurant;
  bool _showMap = false;
  List<CategoryWithFoodItemsViewModel>? _categoriesWithFoodItems;
  int _selectedCategoryIndex = 0;
  final CarouselController _carouselController = CarouselController();
  Map<int, int> itemQuantities = {};
  List<OrderItem> orderItems = [];
  bool _showReviews = false;
  UserDataViewModel? _userDataViewModel;

  double _reviewGrade = 1.0;
  String _reviewDescription = '';

  final ScrollController _reviewScrollController = ScrollController();
  int _reviewsLoadedCount = 2;
  bool _hasMoreReviews = true;

  @override
  void initState() {
    super.initState();
    _loadUserData();
    _fetchDetails();
    _reviewScrollController.addListener(_onReviewScroll);
  }

  @override
  void dispose() {
    _reviewScrollController.dispose();
    super.dispose();
  }

  void _onReviewScroll() {
    if (_reviewScrollController.position.pixels ==
        _reviewScrollController.position.maxScrollExtent) {
      _loadMoreReviews();
    }
  }

  void _loadMoreReviews() {
    setState(() {
      _reviewsLoadedCount += 2;
      if (_reviewsLoadedCount >= _getSortedReviews().length) {
        _hasMoreReviews = false;
      }
    });
  }

  Future<void> _loadUserData() async {
    try {
      final userDataJson = await StorageService.storage.read(key: 'userData');
      if (userDataJson != null) {
        final userData = jsonDecode(userDataJson);

        setState(() {
          _userDataViewModel = UserDataViewModel.fromJson(userData);
        });
      }
    } catch (e) {
      print('Error loading user data: $e');
    }
  }

  bool _hasUserReviewed() {
    return _restaurant?.reviews
            .any((review) => review.userName == _userDataViewModel?.userName) ??
        false;
  }

  void _addOrderItem(OrderItem newOrderItem) {
    setState(() {
      final existingOrderItem = orderItems.firstWhere(
        (item) =>
            item.foodItemId == newOrderItem.foodItemId &&
            listEquals(item.sideDishIds, newOrderItem.sideDishIds),
        orElse: () => OrderItem(
          foodItemId: -1,
          sideDishIds: [],
          quantity: 0,
          cost: 0,
        ),
      );

      if (existingOrderItem.foodItemId != -1) {
        _updateOrderItemQuantity(
          existingOrderItem,
          existingOrderItem.quantity + newOrderItem.quantity,
        );
      } else {
        orderItems.add(newOrderItem);
      }
    });
  }

  void _updateOrderItemQuantity(OrderItem orderItem, int newQuantity) {
    setState(() {
      if (newQuantity <= 0) {
        orderItems.remove(orderItem);
      } else {
        final unitPrice = orderItem.cost / orderItem.quantity;
        orderItem.quantity = newQuantity;
        orderItem.cost = unitPrice * newQuantity;
      }
    });
  }

  void _navigateToFoodItemPage(FoodItemViewModel foodItem) async {
    final result = await Navigator.push(
      context,
      MaterialPageRoute(
        builder: (context) => FoodItemPage(foodItem: foodItem),
      ),
    );

    if (result != null && result is OrderItem) {
      _addOrderItem(result);
    }
  }

  double _calculateTotalPrice() {
    return orderItems.fold(0, (sum, item) => sum + item.cost);
  }

  Future<void> _fetchDetails() async {
    try {
      _restaurant =
          await RestaurantsService().fetchRestaurantById(widget.restaurantId);
      double? score = await RestaurantsService()
          .getReviewScoreForRestaurantMobile(_restaurant?.id ?? 0);
      _restaurant?.reviewScore = score;
      print(score);

      _categoriesWithFoodItems = await RestaurantsService()
          .fetchCategoriesWithFoodItems(_restaurant!.id);

      setState(() {});
    } catch (e) {
      print('Failed to fetch restaurant details: $e');
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Restaurant Details'),
        leading: IconButton(
          icon: Icon(Icons.arrow_back),
          onPressed: () => Navigator.pop(context),
        ),
      ),
      body: _restaurant == null
          ? Center(child: CircularProgressIndicator())
          : Stack(
              children: [
                SingleChildScrollView(
                  child: Column(
                    children: [
                      _buildImageSection(),
                      RestaurantInfoSection(restaurant: _restaurant),
                      const SizedBox(height: 8),
                      const Divider(thickness: 2),
                      const SizedBox(height: 8),
                      _buildMenuSection(_categoriesWithFoodItems ?? []),
                      const SizedBox(height: 8),
                      const Divider(thickness: 2),
                      _buildLocationSection(),
                      const SizedBox(height: 8),
                      const Divider(thickness: 2),
                      const SizedBox(height: 8),
                      _buildReviewSection(),
                      const SizedBox(height: 80),
                    ],
                  ),
                ),
                Positioned(
                  bottom: 0,
                  left: 0,
                  right: 0,
                  child: Container(
                    color: Colors.white,
                    padding: const EdgeInsets.all(16.0),
                    child: CheckoutButton(
                      totalPrice: _calculateTotalPrice(),
                      orderItems: orderItems,
                      onCheckoutPressed: (updatedOrderItems) {
                        setState(() {
                          orderItems = updatedOrderItems;
                        });
                      },
                      restaurant: _restaurant!,
                    ),
                  ),
                ),
              ],
            ),
    );
  }

  Widget _buildMenuSection(
      List<CategoryWithFoodItemsViewModel> categoriesWithFoodItems) {
    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        Padding(
          padding: const EdgeInsets.symmetric(horizontal: 16, vertical: 8),
          child: Text(
            'Menu',
            style: TextStyle(fontSize: 18, fontWeight: FontWeight.bold),
          ),
        ),
        CarouselSlider(
          carouselController: _carouselController,
          items: categoriesWithFoodItems.map((category) {
            return GestureDetector(
              onTap: () {
                setState(() {
                  _selectedCategoryIndex =
                      categoriesWithFoodItems.indexOf(category);
                  _carouselController.animateToPage(
                    _selectedCategoryIndex,
                    duration: Duration(milliseconds: 300),
                    curve: Curves.easeInOut,
                  );
                });
              },
              child: Padding(
                padding: const EdgeInsets.symmetric(horizontal: 8),
                child: Center(
                  child: Text(
                    category.name,
                    style: TextStyle(
                      fontSize: 16,
                      color: _selectedCategoryIndex ==
                              categoriesWithFoodItems.indexOf(category)
                          ? Colors.orange
                          : Colors.black,
                    ),
                  ),
                ),
              ),
            );
          }).toList(),
          options: CarouselOptions(
            height: 50,
            enableInfiniteScroll: false,
            viewportFraction: 0.3,
            onPageChanged: (index, reason) {
              setState(() {
                _selectedCategoryIndex = index;
              });
            },
          ),
        ),
        StatefulBuilder(
          builder: (context, setState) {
            return ListView.builder(
              shrinkWrap: true,
              physics: NeverScrollableScrollPhysics(),
              itemCount: categoriesWithFoodItems[_selectedCategoryIndex]
                  .foodItems
                  .length,
              itemBuilder: (context, foodItemIndex) {
                final foodItem = categoriesWithFoodItems[_selectedCategoryIndex]
                    .foodItems[foodItemIndex];
                return Column(
                  children: [
                    _buildFoodItemRow(foodItem),
                    _buildOrderItemsForFoodItem(foodItem.id),
                  ],
                );
              },
            );
          },
        ),
      ],
    );
  }

  Widget _buildFoodItemRow(FoodItemViewModel foodItem) {
    itemQuantities.putIfAbsent(foodItem.id, () => 0);
    final imageUrl = foodItem.foodItemPictures.isNotEmpty
        ? foodItem.foodItemPictures.first.fileName
        : 'assets/images/no-image-found.jpg';
    final isNetworkImage =
        imageUrl.startsWith('http') || imageUrl.startsWith('https');

    return Column(
      children: [
        Padding(
          padding: const EdgeInsets.symmetric(horizontal: 16, vertical: 8),
          child: Row(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              isNetworkImage
                  ? Image.network(
                      imageUrl,
                      width: 80,
                      height: 80,
                      fit: BoxFit.cover,
                    )
                  : Image.asset(
                      imageUrl,
                      width: 80,
                      height: 80,
                      fit: BoxFit.cover,
                    ),
              Expanded(
                child: Padding(
                  padding: const EdgeInsets.symmetric(horizontal: 8),
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      Text(foodItem.name,
                          style: TextStyle(
                              fontSize: 16, fontWeight: FontWeight.bold)),
                      Text(foodItem.description),
                    ],
                  ),
                ),
              ),
              Column(
                crossAxisAlignment: CrossAxisAlignment.center,
                children: [
                  Text('KM ${foodItem.price.toStringAsFixed(2)}',
                      style:
                          TextStyle(fontSize: 16, fontWeight: FontWeight.bold)),
                  IconButton(
                    icon: Icon(Icons.add),
                    onPressed: () {
                      _navigateToFoodItemPage(foodItem);
                    },
                  ),
                ],
              ),
            ],
          ),
        ),
        Divider(),
      ],
    );
  }

  Widget _buildOrderItemsForFoodItem(int foodItemId) {
    final items =
        orderItems.where((item) => item.foodItemId == foodItemId).toList();
    if (items.isEmpty) return Container();

    return Column(
      children: items.map((orderItem) {
        final foodItem = _categoriesWithFoodItems!
            .expand((category) => category.foodItems)
            .firstWhere((item) => item.id == foodItemId);
        final sideDishes = orderItem.sideDishIds
            .map((id) =>
                foodItem.sideDishes.firstWhere((sideDish) => sideDish.id == id))
            .toList();

        return Column(
          children: [
            Container(
              color: Colors.grey[200],
              padding: const EdgeInsets.symmetric(horizontal: 16, vertical: 8),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Row(
                    children: [
                      Text(
                        '${orderItem.quantity}x',
                        style: TextStyle(
                            fontSize: 16, fontWeight: FontWeight.bold),
                      ),
                      const SizedBox(width: 16),
                      Expanded(
                        child: Column(
                          crossAxisAlignment: CrossAxisAlignment.start,
                          children: [
                            Text(
                              foodItem.name,
                              style: TextStyle(
                                  fontSize: 16, fontWeight: FontWeight.bold),
                            ),
                            const SizedBox(height: 4),
                            Text(
                              sideDishes
                                  .map((sideDish) => '${sideDish.name} ')
                                  .join(', '),
                              style: TextStyle(
                                  fontSize: 14, color: Colors.grey[700]),
                            ),
                          ],
                        ),
                      ),
                      Text(
                        'KM ${orderItem.cost.toStringAsFixed(2)}',
                        style: TextStyle(
                            fontSize: 16, fontWeight: FontWeight.bold),
                      ),
                    ],
                  ),
                  const SizedBox(height: 8),
                  Row(
                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                    children: [
                      IconButton(
                        icon: Icon(Icons.remove, color: Colors.orange),
                        onPressed: () => _updateOrderItemQuantity(
                            orderItem, orderItem.quantity - 1),
                      ),
                      IconButton(
                        icon: Icon(Icons.add, color: Colors.orange),
                        onPressed: () => _updateOrderItemQuantity(
                            orderItem, orderItem.quantity + 1),
                      ),
                    ],
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

  Widget _buildLocationSection() {
    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        InkWell(
          onTap: () {
            setState(() {
              _showMap = !_showMap;
            });
          },
          child: Padding(
            padding: const EdgeInsets.symmetric(horizontal: 16),
            child: Row(
              children: [
                Text(
                  'Location',
                  style: TextStyle(fontSize: 18, fontWeight: FontWeight.bold),
                ),
                SizedBox(width: 8),
                Icon(
                  _showMap ? Icons.arrow_drop_up : Icons.arrow_drop_down,
                  size: 24,
                ),
              ],
            ),
          ),
        ),
        if (_showMap)
          Padding(
            padding: const EdgeInsets.all(16),
            child: MapSelection(restaurant: _restaurant),
          ),
      ],
    );
  }

  Widget _buildImageSection() {
    final imageUrl =
        _restaurant?.logo?.fullImageUrl ?? 'assets/images/no-image-found.jpg';
    final isNetworkImage =
        imageUrl.startsWith('http') || imageUrl.startsWith('https');

    return Stack(
      children: [
        isNetworkImage
            ? Image.network(
                imageUrl,
                height: MediaQuery.of(context).size.height * 0.25,
                width: MediaQuery.of(context).size.width,
                fit: BoxFit.cover,
              )
            : Image.asset(
                imageUrl,
                height: MediaQuery.of(context).size.height * 0.25,
                width: MediaQuery.of(context).size.width,
                fit: BoxFit.contain,
              ),
        Positioned(
          bottom: 10,
          left: 10,
          child: Text(
            _restaurant!.name,
            style: TextStyle(
              color: Colors.white,
              fontSize: 24,
              fontWeight: FontWeight.bold,
              backgroundColor: Colors.black54,
            ),
          ),
        ),
      ],
    );
  }

  Widget _buildReviewSection() {
    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        InkWell(
          onTap: () {
            setState(() {
              _showReviews = !_showReviews;
            });
          },
          child: Padding(
            padding: const EdgeInsets.symmetric(horizontal: 16, vertical: 8),
            child: Row(
              mainAxisAlignment: MainAxisAlignment.spaceBetween,
              children: [
                Text(
                  'Reviews (${_restaurant!.reviews.length})',
                  style: TextStyle(fontSize: 18, fontWeight: FontWeight.bold),
                ),
                Icon(
                  _showReviews ? Icons.arrow_drop_up : Icons.arrow_drop_down,
                  size: 24,
                ),
                if (!_hasUserReviewed())
                  ElevatedButton(
                    onPressed: () {
                      _showReviewFormDialog(context);
                    },
                    style: ElevatedButton.styleFrom(
                      primary: Colors.green,
                      shape: RoundedRectangleBorder(
                        borderRadius: BorderRadius.circular(18.0),
                      ),
                    ),
                    child: Text('Write a review'),
                  ),
              ],
            ),
          ),
        ),
        if (_showReviews)
          Padding(
            padding: const EdgeInsets.all(16),
            child: Column(
              children: [
                ListView.builder(
                  shrinkWrap: true,
                  physics: NeverScrollableScrollPhysics(),
                  itemCount:
                      _getSortedReviews().take(_reviewsLoadedCount).length,
                  itemBuilder: (context, index) {
                    final review = _getSortedReviews()[index];
                    return Padding(
                      padding: const EdgeInsets.only(bottom: 16),
                      child: ReviewTile(
                        review: review,
                        currentUser: _userDataViewModel?.userName,
                        showReviewFormDialog: _showReviewFormDialog,
                        fetchDetails: _fetchDetails,
                      ),
                    );
                  },
                ),
                if (_hasMoreReviews)
                  ElevatedButton(
                    onPressed: _loadMoreReviews,
                    child: Text('Load More'),
                  ),
              ],
            ),
          ),
      ],
    );
  }

  void _showReviewFormDialog(BuildContext context,
      {double initialRating = 1.0, String initialDescription = ''}) {
    _reviewGrade = initialRating;
    _reviewDescription = initialDescription;
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: Text(initialRating == 1.0 && initialDescription.isEmpty
              ? 'Write a Review'
              : 'Edit Review'),
          content: SingleChildScrollView(
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Text(
                  'How would you rate this restaurant?',
                  style: TextStyle(fontSize: 18, fontWeight: FontWeight.bold),
                ),
                const SizedBox(height: 8),
                RatingBar.builder(
                  initialRating: _reviewGrade,
                  minRating: 1,
                  direction: Axis.horizontal,
                  allowHalfRating: true,
                  itemCount: 5,
                  itemSize: 50.0,
                  itemBuilder: (context, _) => Icon(
                    Icons.star,
                    color: Colors.amber,
                  ),
                  onRatingUpdate: (rating) {
                    setState(() {
                      _reviewGrade = rating;
                    });
                  },
                ),
                const SizedBox(height: 16),
                TextField(
                  maxLength: 140,
                  maxLines: 4,
                  controller: TextEditingController(text: _reviewDescription),
                  decoration: InputDecoration(
                    border: OutlineInputBorder(),
                    labelText: 'Write your review',
                  ),
                  onChanged: (value) {
                    setState(() {
                      _reviewDescription = value;
                    });
                  },
                ),
              ],
            ),
          ),
          actions: [
            TextButton(
              onPressed: () {
                Navigator.of(context).pop();
              },
              child: Text('Cancel'),
            ),
            ElevatedButton(
              onPressed: () async {
                try {
                  final info = await RestaurantsService().addOrUpdateReview(
                    _reviewGrade,
                    _reviewDescription,
                    _restaurant!.id,
                  );
                  Navigator.of(context).pop();
                  ScaffoldMessenger.of(context).showSnackBar(
                    SnackBar(
                        content: Center(
                            child: Text(
                      info,
                      style: info.contains('Created review.') ||
                              info.contains('Updated review.')
                          ? TextStyle(color: Colors.green)
                          : TextStyle(color: Colors.red),
                    ))),
                  );
                  setState(() {
                    _fetchDetails();
                  });
                } catch (e) {
                  Navigator.of(context).pop();
                  ScaffoldMessenger.of(context).showSnackBar(
                    SnackBar(
                        content: Center(
                            child: Text(
                      e.toString(),
                      style: const TextStyle(color: Colors.red),
                    ))),
                  );
                }
              },
              child: Text('Confirm'),
            ),
          ],
        );
      },
    );
  }

  List<ReviewViewModel> _getSortedReviews() {
    List<ReviewViewModel> reviews = List.from(_restaurant!.reviews);
    reviews.sort((a, b) {
      if (a.userName == _userDataViewModel?.userName) return -1;
      if (b.userName == _userDataViewModel?.userName) return 1;
      return 0;
    });
    return reviews;
  }
}

class ReviewTile extends StatefulWidget {
  final ReviewViewModel review;
  final String? currentUser;
  final Function(BuildContext,
      {double initialRating, String initialDescription}) showReviewFormDialog;
  final Function() fetchDetails;
  const ReviewTile(
      {Key? key,
      required this.review,
      this.currentUser,
      required this.showReviewFormDialog,
      required this.fetchDetails})
      : super(key: key);

  @override
  _ReviewTileState createState() => _ReviewTileState();
}

class _ReviewTileState extends State<ReviewTile> {
  bool _isExpanded = false;

  @override
  Widget build(BuildContext context) {
    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        Row(
          children: [
            Icon(Icons.person, size: 40),
            const SizedBox(width: 8),
            Expanded(
              child: Text(
                widget.review.userName,
                style: TextStyle(fontSize: 16, fontWeight: FontWeight.bold),
              ),
            ),
            if (widget.review.userName == widget.currentUser)
              PopupMenuButton<String>(
                onSelected: (value) {
                  if (value == 'edit') {
                    widget.showReviewFormDialog(
                      context,
                      initialRating: widget.review.grade,
                      initialDescription: widget.review.description,
                    );
                  } else if (value == 'delete') {
                    _showDeleteConfirmationDialog(context);
                  }
                },
                itemBuilder: (BuildContext context) {
                  return {'Edit', 'Delete'}.map((String choice) {
                    return PopupMenuItem<String>(
                      value: choice.toLowerCase(),
                      child: Text(choice),
                    );
                  }).toList();
                },
              ),
          ],
        ),
        const SizedBox(height: 8),
        Row(
          children: [
            RatingBar.builder(
              initialRating: widget.review.grade,
              minRating: 1,
              direction: Axis.horizontal,
              allowHalfRating: true,
              itemCount: 5,
              itemSize: 20.0,
              ignoreGestures: true,
              itemBuilder: (context, _) => Icon(
                Icons.star,
                color: Colors.amber,
              ),
              onRatingUpdate: (rating) {},
            ),
            const SizedBox(width: 8),
            Text(widget.review.createdDate),
          ],
        ),
        const SizedBox(height: 8),
        Text(
          _isExpanded || widget.review.description.length <= 70
              ? widget.review.description
              : widget.review.description.substring(0, 70) + '...',
          style: TextStyle(fontSize: 16),
        ),
        if (widget.review.description.length > 70)
          InkWell(
            onTap: () {
              setState(() {
                _isExpanded = !_isExpanded;
              });
            },
            child: Text(
              _isExpanded ? 'Read less' : 'Read more',
              style: TextStyle(color: Colors.blue),
            ),
          ),
        const Divider(),
      ],
    );
  }

  void _showDeleteConfirmationDialog(BuildContext context) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: Text('Delete Review'),
          content: Text('Are you sure you want to delete this review?'),
          actions: [
            TextButton(
              onPressed: () {
                Navigator.of(context).pop();
              },
              child: Text('Cancel'),
            ),
            ElevatedButton(
              onPressed: () async {
                try {
                  final info =
                      await RestaurantsService().deleteReview(widget.review.id);
                  Navigator.of(context).pop();
                  ScaffoldMessenger.of(context).showSnackBar(
                    SnackBar(
                        content: Center(
                            child: Text(
                      info,
                      style: TextStyle(color: Colors.green),
                    ))),
                  );
                  widget.fetchDetails();
                } catch (e) {
                  Navigator.of(context).pop();
                  ScaffoldMessenger.of(context).showSnackBar(
                    SnackBar(content: Text(e.toString())),
                  );
                }
              },
              child: Text('Delete'),
            ),
          ],
        );
      },
    );
  }
}

class CheckoutButton extends StatefulWidget {
  final double totalPrice;
  final List<OrderItem> orderItems;
  final Function(List<OrderItem>) onCheckoutPressed;
  final RestaurantViewModel restaurant;

  const CheckoutButton({
    Key? key,
    required this.totalPrice,
    required this.orderItems,
    required this.onCheckoutPressed,
    required this.restaurant,
  }) : super(key: key);

  @override
  _CheckoutButtonState createState() => _CheckoutButtonState();
}

class _CheckoutButtonState extends State<CheckoutButton> {
  @override
  Widget build(BuildContext context) {
    if (widget.totalPrice == 0) {
      return Container();
    }
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
        onPressed: () async {
          final updatedOrderItems = await Navigator.push(
            context,
            MaterialPageRoute(
              builder: (context) => CheckoutPage(
                  orderItems: widget.orderItems, restaurant: widget.restaurant),
            ),
          );
          if (updatedOrderItems != null) {
            widget.onCheckoutPressed(updatedOrderItems);
          }
        },
        child:
            Text('Go to checkout - KM ${widget.totalPrice.toStringAsFixed(2)}'),
      ),
    );
  }
}

class RestaurantInfoSection extends StatelessWidget {
  final RestaurantViewModel? restaurant;

  const RestaurantInfoSection({Key? key, this.restaurant}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.all(16.0),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Text(
            restaurant!.name,
            style: TextStyle(fontSize: 22, fontWeight: FontWeight.bold),
          ),
          Text(restaurant!.address, style: TextStyle(fontSize: 18)),
          SizedBox(height: 16),
          Row(
            mainAxisAlignment: MainAxisAlignment.spaceEvenly,
            children: [
              _buildIconText(Icons.star, Colors.amber,
                  '${restaurant!.reviewScore?.toStringAsFixed(1) ?? "N/A"}'),
              _buildIconText(Icons.access_time, Colors.black,
                  '${restaurant!.deliveryTime} min'),
              _buildIconText(Icons.delivery_dining, Colors.black,
                  'KM ${restaurant!.deliveryCharge.toStringAsFixed(2)}'),
            ],
          ),
        ],
      ),
    );
  }

  Widget _buildIconText(IconData icon, Color color, String text) {
    return Row(
      mainAxisSize: MainAxisSize.min,
      children: [
        Icon(icon, color: color),
        SizedBox(width: 4),
        Text(text),
      ],
    );
  }
}

class MapSelection extends StatelessWidget {
  final RestaurantViewModel? restaurant;

  const MapSelection({Key? key, this.restaurant}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Container(
      height: 200,
      child: GoogleMap(
        initialCameraPosition: CameraPosition(
          target: LatLng(double.parse(restaurant!.location.latitude),
              double.parse(restaurant!.location.longitude)),
          zoom: 15,
        ),
        mapType: MapType.terrain,
        markers: Set.from([
          Marker(
            markerId: MarkerId(restaurant!.location.id.toString()),
            position: LatLng(double.parse(restaurant!.location.latitude),
                double.parse(restaurant!.location.longitude)),
            infoWindow: InfoWindow(title: restaurant!.name),
          ),
        ]),
      ),
    );
  }
}
