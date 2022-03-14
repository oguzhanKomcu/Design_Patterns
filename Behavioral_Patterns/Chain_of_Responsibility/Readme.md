# Chain of Responsibility Pattern

<img src="https://refactoring.guru/images/patterns/content/chain-of-responsibility/chain-of-responsibility-3x.png" width="800" height="500">

# WHAT IS Chain of Responsibility Pattern ?

The chain of responsibility pattern is used when we do not know which object should respond to a request sent to the system, or when we need to prevent a tight connection between the object making the request and the object providing the service. In this design pattern, all related objects providing services are associated with each other. An object recognizes the next object in the chain and forwards it to the next object if it cannot respond to the request. This process continues until it finds the correct service provider object in the chain.

## Advantage of Chain of Responsibility Pattern
- It reduces the coupling.
- It adds flexibility while assigning the responsibilities to objects.
- It allows a set of classes to act as one; events produced in one class can be sent to other handler classes with the help of composition.

## Usage of Chain of Responsibility Pattern

- When more than one object can handle a request and the handler is unknown.
- When the group of objects that can handle the request must be specified in dynamic way.

# UML model of Singleton Design Pattern

<img src="https://miro.medium.com/max/1122/1*cgS_U86kK-ToUoI-F5BSeQ.png" width="700" height="400">

## Diagram of my example I made.

<img src="https://user-images.githubusercontent.com/96787308/158267493-a36cd633-aa3a-4d17-a9cb-b7cd3ace4a24.png" width="800" height="500">


# How is it applied ?

- It defines an interface for handling the requests. Also, this can be an abstract class which will primarily receive the request and forward the request to chain of handlers.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Chain_of_Responsibility/ProblemSolverEmployeeBase.cs).

- These classes are responsible for processing the requests they receive. If a particular class cannot fulfill the request, it sends the request to the other class.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Creational_Patterns/Builder_Pattern/Builder/TelephoneBuilder.cs).
 
- IBuilder provides the necessary interface for building the phone object. Notice that there is an inherited situation with the TelephoneBuilder object.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/tree/master/Creational_Patterns/Builder_Pattern/Interface).

- As a result of our design, it responds to the object production request by the Client through a Builder reference.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Creational_Patterns/Builder_Pattern/Program.cs).
