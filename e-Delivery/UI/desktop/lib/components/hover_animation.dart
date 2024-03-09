import 'package:flutter/material.dart';

class HoverAnimation extends StatefulWidget {
  const HoverAnimation({
    super.key,
    required this.child,
    this.size = const Size(440, 440),
    this.hoverColor = const Color(0xFFFBE851),
    this.bgColor = const Color(0xFFE9EFF3),
    this.offset = const Offset(8, 8),
    this.curve = Curves.easeOutBack,
    this.duration = const Duration(milliseconds: 300),
    this.border = const Border(),
  });
  final Widget child;
  final Size size;
  final Color hoverColor, bgColor;
  final Offset offset;
  final Curve curve;
  final Duration duration;
  final Border border;
  @override
  State<HoverAnimation> createState() => _HoverAnimationState();
}

class _HoverAnimationState extends State<HoverAnimation> {
  bool isHover = false;
  @override
  Widget build(BuildContext context) {
    return Stack(
      clipBehavior: Clip.none,
      alignment: Alignment.center,
      children: [
        Container(
          height: widget.size.height,
          width: widget.size.width,
          decoration: const BoxDecoration(
            borderRadius: BorderRadius.all(Radius.circular(12)),
            color: Colors.black,
          ),
        ),
        AnimatedPositioned(
          duration: widget.duration,
          curve: widget.curve,
          height: widget.size.height,
          width: widget.size.width,
          top: isHover ? -widget.offset.dx : 0,
          right: isHover ? widget.offset.dy : 0,
          child: InkWell(
            onTap: () {},
            onHover: (hover) {
              setState(() {
                isHover = hover;
              });
            },
            overlayColor: MaterialStateProperty.all(Colors.transparent),
            borderRadius: const BorderRadius.all(Radius.circular(12)),
            child: AnimatedContainer(
              duration: const Duration(milliseconds: 100),
              height: double.infinity,
              width: double.infinity,
              decoration: BoxDecoration(
                border: widget.border,
                borderRadius: const BorderRadius.all(Radius.circular(12)),
                color: isHover ? widget.hoverColor : widget.bgColor,
              ),
              child: widget.child,
            ),
          ),
        ),
      ],
    );
  }
}
