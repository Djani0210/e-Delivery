# e-Delivery
### Setup Instructions
1. Open a terminal inside the solution folder.
2. Run the following commands:</br>
- docker-compose build </br>
- docker-compose up


## Flutter Desktop

### Administrator
- **Username:** admin
- **Password:** test

### Desktop
- **Username:** desktop
- **Password:** test



### Setup Instructions


Run the following commands:
</br>
- flutter pub get </br>
- flutter run


### Note
- Choose option number 1 (windows) when prompted.

---

## Flutter Mobile

### MobileClient
- **Username:** MobileClient
- **Password:** test

### MobileDeliveryPerson
- **Username:** MobileDeliveryPerson
- **Password:** test

### Setup Instructions
Run the following commands:
</br>
- flutter pub get </br>
- flutter run



### Using Stripe Keys
- If you want to use your own Stripe keys, use the following command: </br>
flutter run --dart-define stripePublishableKey=yourStripePublishableKey --dart-define stripeSecretKey=yourStripeSecretKey


### Stripe Test Card Number
- Test card number: 4242 4242 4242 4242

### RabbitMq 
RabbitMQ is implemented in the way that when a deliveryPerson searches for restaurants he can apply to. When he chooses a restaurant and applies, an email is sent to the owner of that restaurant ie. desktop user. The owner then clicks the confirmation button which makes the deliveryPerson part of his restaurant.
The credentials to the  user emails are the following (mobile 
user: desktop
gmail : belminedelivery@gmail.com

user: MobileDeliveryPerson
gmail: flutterhelpme2@gmail.com

user: MobileCustomer
gmail : kupac11111@gmail.com

Password for all 3 users are : e-Deliverypassword123#
