# BUILDER PATTERN

<img src="https://refactoring.guru/images/patterns/content/builder/builder-en.png?id=617612423ea3752477dc90929115b3ee" width="600" height="300">

# WHAT IS Builder Design Pattern ?

We can solve the issues with large number of parameters by providing a constructor with required parameters and then different setter methods to set the optional parameters. The problem with this approach is that the Object state will be inconsistent until unless all the attributes are set explicitly.

Builder pattern solves the issue with large number of optional parameters and inconsistent state by providing a way to build the object step-by-step and provide a method that will actually return the final Object.

# Advantage of Builder Design Pattern

The main advantages of Builder Pattern are as follows:

- It provides clear separation between the construction and representation of an object.
- It provides better control over construction process.
- It supports to change the internal representation of objects.

# UML model of Builder Design Pattern

<img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTMvIX23f9sJJBV0zBIuNqQJcghDd4omimkJg&usqp=CAU" width="500" height="300">

## Diagram of my example I made.

<img src="https://user-images.githubusercontent.com/96787308/158039138-b645c137-18a6-450b-800a-bbb6164d36d9.png" width="600" height="400">


# How is it applied ?

- Telephone is our object that we want to get as a result of the build. If you examine the schematic, it is produced by the ConcreteBuilder class. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Creational_Patterns/Builder_Pattern/Model/Telephone.cs).

- As you can see, "TelephoneBuilder" creates the object we call Telephone. It is the class that provides the basic features and hardware of the phone to be created.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Creational_Patterns/Builder_Pattern/Builder/TelephoneBuilder.cs).
 
- IBuilder provides the necessary interface for building the phone object. Notice that there is an inherited situation with the TelephoneBuilder object.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/tree/master/Creational_Patterns/Builder_Pattern/Interface).

- As a result of our design, it responds to the object production request by the Client through a Builder reference.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Creational_Patterns/Builder_Pattern/Program.cs).


