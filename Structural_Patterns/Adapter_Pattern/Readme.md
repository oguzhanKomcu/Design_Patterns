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

<img src="https://www.bayramucuncu.com/wp-content/uploads/2013/05/Adapter.png" width="400" height="300">

## Diagram of my example I made.
<img src="https://user-images.githubusercontent.com/96787308/158055105-9278bc96-ca2f-48cc-b3c3-e7fc3f8f95d2.png" width="600" height="400">


