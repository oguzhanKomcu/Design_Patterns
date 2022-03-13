# Adapter Pattern

<img src="https://miro.medium.com/max/783/1*KvlbDdR0rjo1MnoJyNZBEw.png" width="700" height="400">

The Adapter Pattern is a design pattern that makes interfaces specific to one class compatible with other classes. Adapters also offer the opportunity to work with each other for classes that cannot work with each other due to incompatible interfaces.

## Some of the features of the adapter die are

- It converts the interface of a class to a new interface requested by the client.
- It allows classes with incompatible interfaces to work with each other.
- It wraps the existing class with a new interface.
- Integrates an old component into the newly created system.

## Conditions of use

In some cases, the interface of a toolkit or class library cannot be used because it is incompatible with the interface required for the application. In this case the library is not modified because the source code may be unknown. Even if the source code is thought to be known, it is not a correct solution to change the library one by one for each application. The adapter mold has been developed to engage in such situations. In short, the adapter pattern is used when a desired class does not match the requirements of the interface to be used.

## UML model of Singleton Design Pattern

<img src="https://www.bayramucuncu.com/wp-content/uploads/2013/05/Adapter.png" width="500" height="300">

## Diagram of my example I made.
<img src="https://user-images.githubusercontent.com/96787308/158055105-9278bc96-ca2f-48cc-b3c3-e7fc3f8f95d2.png" width="500" height="600">

# How is it applied ?

- I created classes to receive "Email", "sms" and "CustomerRecord". While my "Email" and "sms" classes can inherit from the [INotification](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Adapter_Pattern/Interface/INotification.cs) interface, my "CustomerRecord" class did not inherit from the "INotification" interface because it did not do the same thing. Here I need to create an adapter class for it to do things collaboratively. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/tree/master/Structural_Patterns/Adapter_Pattern/Model).

- I created [SendNotification](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Adapter_Pattern/Adapter/SendNotification.cs) class to send. I will do all my sending operations with this class. The "Send()" method in this class accepts only [INotification](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Adapter_Pattern/Interface/INotification.cs) type objects.
 
- I wrote an adapter class named [PushNotificationAdepter](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Adapter_Pattern/Adapter/PushNotificationAdepter.cs) for the CustomerRecord class. This class takes a class of type [CustomerRecord](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Adapter_Pattern/Model/CustomerRecord.cs). from the outside and is made suitable for the "INotification" interface.

- I made the latest operations for the Client in the Console application.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Adapter_Pattern/Program.cs).



