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

### Stripe Test Card Number
- Test card number: 4242 4242 4242 4242

## RabbitMQ Implementation
RabbitMQ is implemented for the restaurant application process. When a deliveryPerson searches for restaurants, they can apply to work for a restaurant. Upon application, an email is sent to the restaurant owner (desktop user). The owner can then click the confirmation button in the email to add the deliveryPerson to their restaurant.

### Email Credentials
- **desktop:** 
  - Gmail: belminedelivery@gmail.com
- **MobileDeliveryPerson:** 
  - Gmail: flutterhelpme2@gmail.com
- **MobileCustomer:** 
  - Gmail: kupac11111@gmail.com

Password for all 3 users: e-Deliverypassword123#

## Real-time Notifications and Chat
Notification sending and chat between MobileCustomer and MobileDeliveryPerson have been implemented using a combination of REST API and SignalR. Messages and notifications are sent in real-time and stored in the database.

### Notification Types
1. MobileDeliveryPerson receives notifications when assigned to an order by a desktop user.
2. MobileCustomer receives notifications when their order status is updated by a MobileDeliveryPerson.

**Important:** To receive notifications, please enable notifications for the e-Delivery app on your device.

## Google Maps Feature
When placing an order, the "Get Current Location" feature works on devices with location enabled. On emulators, the default location will be set to San Jose, California, USA.

## Additional Notes
- After applying to a restaurant as a MobileDeliveryPerson and receiving confirmation, the user must log in again for the changes to take effect.



