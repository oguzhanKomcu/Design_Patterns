# Flyweight Design Pattern


<img src="https://refactoring.guru/images/patterns/content/flyweight/flyweight.png?id=e34fbacb847dd609b5e68aaf252c4db0" width="700" height="400">


Flyweight pattern is a design pattern that allows us to minimize memory usage from object generation. If the memory consumption is caused by handling too many objects together, we can use the flyweight design pattern here.

So how does the flyweight design pattern do this memory minimization? The Flyweight design pattern allows to reduce the creation of commonly used objects with pool logic.

If we talk about the structure of the Flyweight design pattern, we have a class called FlyweightFactory in this pattern. In this class, it keeps the list of classes that inherit the Flyweight class, that is, the classes that we will produce again and again, and gives access to this list to the client with a method. When the client wants to generate an object through this method, the method first checks whether this object exists in the list, that is, in the object pool. If there is, it gives from this list. If not, it first adds it to this list and then returns what it has added.

## Advantages

- Increases application performance in terms of object creation since there is no requirement of creating an object for every request.
 
- Causes the application to consume less memory, since the object already exists in memory and no new object must be created because of the pool.

## UML model of Singleton Design Pattern

<img src="http://cagataykiziltan.net/wp-content/uploads/2020/08/Flyweight-768x416.gif" width="700" height="500">

## Diagram of my example I made.

<img src="https://user-images.githubusercontent.com/96787308/158081334-c90bf5c7-478c-4a46-a36b-254848fafe1f.png" width="700" height="600">


# How is it applied ?

- Here I gave an example over a basket for computer equipment and created my classes. [Keyboard](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Flyweight_Design_Pattern/Keyboard.cs), [Headset](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Flyweight_Design_Pattern/Headset.cs), [Mouse](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Flyweight_Design_Pattern/Mouse.cs)

- I created an abstract class that inherits my classes. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Flyweight_Design_Pattern/Equipment.cs)
 
- It is a factory class used by a client class to retrieve data from a concrete flyweight. This class is also responsible for creating a repository of an existing object. Therefore, when the already requested data request arrives, it returns data from the pool. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Flyweight_Design_Pattern/EquipmentFactory.cs)

- For the client, I produced from the list according to the products requested. If there is a request for the same product again, I gave the same object. I implemented them in my main method. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Flyweight_Design_Pattern/Program.cs).
