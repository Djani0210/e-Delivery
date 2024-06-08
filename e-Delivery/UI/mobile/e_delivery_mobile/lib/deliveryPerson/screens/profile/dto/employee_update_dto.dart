class DeliveryPersonUpdateDTO {
  bool? isAvailable;
  String? workFrom;
  String? workUntil;

  DeliveryPersonUpdateDTO({this.isAvailable, this.workFrom, this.workUntil});

  Map<String, dynamic> toJson() {
    return {
      'isAvailable': isAvailable,
      'workFrom': workFrom,
      'workUntil': workUntil,
    };
  }
}
