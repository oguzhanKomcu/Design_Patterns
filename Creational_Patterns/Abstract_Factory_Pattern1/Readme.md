# Abstract Factory Pattern

<img src="https://digitalpulsion.com/wp-content/uploads/Abstract-Factory-Design-Pattern-digitalpulsion-younes-rabdi.png" width="600" height="400">

Abstract Factory provides interface to create objects from each class of product family. As long as your code creates objects through this interface, an incorrect version of a product that does not match products already created by your application will not be created. The client requests a product from the factory. Whatever variant of the product is returned, it always matches the type produced by the same factory object.

### Factory Method Pattern  VS  Abstract Factory Pattern

- Factory Method Pattern aims to produce more than one relational object with a request to be made through a single class through a common interface and to reduce the dependency of the client on the produced object to zero at the time of object production.

- Abstract Factory Pattern, on the other hand, provides the production of more than one relational object not by a single interface, but by defining a different interface for each product family.

# Advantages
- We can make sure that the products we bought from the factory are compatible with each other.
 
- Open/Closed Principle: We can produce new product versions without breaking the existing client code.
 
- Single Responsibility Principle : By making the product creation code in one place , we can ensure that the code is fed more easily .
 
- It is a basic design pattern for Dependency Injection (DI).


# UML model of Singleton Design Pattern

<img src="https://sourcemaking.com/files/v2/content/patterns/Abstract_Factory.png" width="600" height="400">

## Diagram of my example I made.
<img src="https://user-images.githubusercontent.com/96787308/158037752-013a6dfb-33e8-428f-87ba-6fb2e6ba7de9.png" width="600" height="400">



# How is it applied ?

- Abstract Product , it is the abstract class of the products to be produced. It carries all member structures in certain products as signatures and implements it into Concrete Product structures. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/tree/master/Creational_Patterns/Abstract_Factory_Pattern1/ModelInterface).

- Concrete Product are the actual concrete classes of the product family the client wants to produce.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/tree/master/Creational_Patterns/Abstract_Factory_Pattern1/Model).
 
- Abstract Factory is the structure that provides an interface to the factory classes that will create the product family.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/tree/master/Creational_Patterns/Abstract_Factory_Pattern1/Factory).

- In concrete classes that inherit from the [ISPEED](github.com/cobanov) interface, I have specified the speed relative to the tools.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/tree/master/Creational_Patterns/Abstract_Factory_Pattern1/Speed).

- My factories are the factories that make up the main product family. Here I created an "ISPEED" type method to create an object from its class according to its speed. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/tree/master/Creational_Patterns/Abstract_Factory_Pattern1/Factory).

- In my latest "Program" class I created a console applet for this entire build. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Creational_Patterns/Abstract_Factory_Pattern1/Program.cs).

