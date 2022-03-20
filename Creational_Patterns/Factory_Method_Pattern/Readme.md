# Factory Method Design Pattern

 <img src="https://miro.medium.com/max/1294/1*Q9I-wrmv8-hL3JJqTSEVoA.png" width="600" height="400">
 
 # What is Factory Method Design Pattern?
 It is a creative design pattern that basically separates the interface and object creation functions by leaving the object creation to subclasses and using a single interface for object creation.

 If we say what the Factory Design Pattern solves, you can think of it like this when I will produce objects from more than one relational class. You may need different types of objects at certain steps in your algorithm. You can create these objects via if – else or switch structures, depending on the situation. Of course, it cannot be thought that doing this every time is very time and code-saving. Instead of requesting an object from the class I want to create, we can produce the required object over a single instance with the Factory Pattern.
 
# UML model of Factory Method Design Pattern
 
<img src="https://www.dofactory.com/img/diagrams/net/factory.png" width="500" height="250">

## Diagram of my example I made.

<img src="https://user-images.githubusercontent.com/96787308/158038958-9fdaeca0-e12e-4402-8a4f-0d4ddffc74e8.png" width="700" height="600">

# How is it applied?

- All subclasses must inherit from the same parent class. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Creational_Patterns/Factory_Method_Pattern/LAB/Interface/IFurniture.cs)

- I created my subclass by implementing it from my "IFurniture" interface. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Creational_Patterns/Factory_Method_Pattern/LAB/Concrete/Cupboard.cs)
 
- To implement the factory pattern, I defined a factory method in the "FurnitureCreator" class, the return type of the method should be the parent class. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Creational_Patterns/Factory_Method_Pattern/LAB/FurnitureCreator.cs)

- We need to allow subclasses to create an object based on the parameter passed to the factory method. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Creational_Patterns/Factory_Method_Pattern/Program.cs)
