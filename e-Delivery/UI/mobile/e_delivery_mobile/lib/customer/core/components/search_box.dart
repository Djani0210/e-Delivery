import 'package:e_delivery_mobile/customer/core/constants/app_defaults.dart';
import 'package:e_delivery_mobile/customer/core/constants/app_icons.dart';
import 'package:e_delivery_mobile/customer/screens/home/components/restaurant_list.dart';
import 'package:e_delivery_mobile/customer/screens/home/dto/restaurant_get_dto.dart';
import 'package:flutter/material.dart';
import 'package:flutter_svg/svg.dart';

class SearchBox extends StatefulWidget {
  final ValueChanged<String>? onChanged;
  final Function(RestaurantViewModel) onRestaurantSelected;
  final List<RestaurantViewModel> restaurants;

  const SearchBox({
    Key? key,
    this.onChanged,
    required this.onRestaurantSelected,
    required this.restaurants,
  }) : super(key: key);

  @override
  _SearchBoxState createState() => _SearchBoxState();
}

class _SearchBoxState extends State<SearchBox> {
  final _focusNode = FocusNode();
  OverlayEntry? _overlayEntry;
  String _searchQuery = '';

  @override
  void initState() {
    super.initState();
    _focusNode.addListener(_onFocusChanged);
  }

  @override
  void dispose() {
    _focusNode.removeListener(_onFocusChanged);
    _focusNode.dispose();
    super.dispose();
  }

  void _onFocusChanged() {
    if (_focusNode.hasFocus && _searchQuery.isNotEmpty) {
      _showOverlay(filteredRestaurants);
    } else {
      _hideOverlay();
    }
  }

  List<RestaurantViewModel> get filteredRestaurants {
    return widget.restaurants
        .where((restaurant) =>
            restaurant.name.toLowerCase().contains(_searchQuery.toLowerCase()))
        .toList();
  }

  void _showOverlay(List<RestaurantViewModel> filteredRestaurants) {
    final overlay = Overlay.of(context);
    final renderBox = context.findRenderObject() as RenderBox;
    final size = renderBox.size;
    final offset = renderBox.localToGlobal(Offset.zero);

    _overlayEntry = OverlayEntry(
      builder: (context) => Positioned(
        left: offset.dx,
        top: offset.dy + size.height + 8,
        width: size.width,
        child: RestaurantList(
          restaurants: filteredRestaurants,
          onRestaurantSelected: widget.onRestaurantSelected,
        ),
      ),
    );

    overlay.insert(_overlayEntry!);
  }

  void _hideOverlay() {
    _overlayEntry?.remove();
    _overlayEntry = null;
  }

  void _onSearchQueryChanged(String query) {
    setState(() {
      _searchQuery = query;
    });
    widget.onChanged?.call(query);
    _filterRestaurants();
    if (query.isEmpty) {
      _hideOverlay();
    } else {
      _updateOverlay(filteredRestaurants);
    }
  }

  void _filterRestaurants() {
    final filteredRestaurants = widget.restaurants
        .where((restaurant) =>
            restaurant.name.toLowerCase().contains(_searchQuery.toLowerCase()))
        .toList();
    _updateOverlay(filteredRestaurants);
  }

  void _updateOverlay(List<RestaurantViewModel> filteredRestaurants) {
    if (filteredRestaurants.isEmpty || filteredRestaurants.first == "") {
      _hideOverlay();
      return;
    }
    if (_overlayEntry == null) {
      _showOverlay(filteredRestaurants);
    } else {
      _overlayEntry!.markNeedsBuild();
    }
  }

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.symmetric(horizontal: AppDefaults.padding),
      child: TextFormField(
        focusNode: _focusNode,
        onChanged: _onSearchQueryChanged,
        decoration: InputDecoration(
          fillColor: Colors.grey.shade200,
          filled: true,
          hintText: 'Search restaurants',
          prefixIcon: Padding(
            padding: const EdgeInsets.all(8),
            child: SvgPicture.asset(AppIcons.search),
          ),
          border: OutlineInputBorder(
            borderRadius: AppDefaults.borderRadius,
            borderSide: const BorderSide(width: 0.1),
          ),
          focusedBorder: OutlineInputBorder(
            borderRadius: AppDefaults.borderRadius,
            borderSide: BorderSide.none,
          ),
          enabledBorder: OutlineInputBorder(
            borderRadius: AppDefaults.borderRadius,
            borderSide: BorderSide.none,
          ),
          prefixIconConstraints: const BoxConstraints(maxWidth: 48),
        ),
      ),
    );
  }
}
