# PROTOTYPE PATTERN

<img src="https://refactoring.guru/images/patterns/content/prototype/prototype-comic-2-en.png?id=e1df2dc39404c5eb2d485b7ae7c9914f" width="600" height="400">


The Prototype pattern is generally used when we have an instance of the class (prototype) and we'd like to create new objects by just copying the prototype.Let's use an analogy to better understand this pattern. In some games, we want trees or buildings in the background. We may realize that we don't have to create new trees or buildings and render them on the screen every time the character moves. So, we create an instance of the tree first. Then we can create as many trees as we want from this instance (prototype) and update their positions. We may also choose to change the color of the trees for a new level in the game. The Prototype pattern is quite similar. Instead of creating new objects, we just have to clone the prototypical instance.

The working logic is as follows. You create an array of objects that are structured in various ways. When you need an object as you have configured it, you clone a prototype instead of creating a new object from scratch.

# UML model of Singleton Design Pattern

<img src="https://www.dofactory.com/images/diagrams/net/prototype.gif" width="500" height="300">

## Diagram of my example I made.

<img src="https://user-images.githubusercontent.com/96787308/158040463-bae42745-6a0b-4fc3-b41e-7926f2440748.png" width="500" height="400">


# How is it applied ?

- It is a class that allows copying of new objects and contains the Clone method for this operation. It can be designed as an abstract class or interface. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Creational_Patterns/Prototype_Pattern1/Prototype/IPrototypeStudent.cs).

- They are objects that will implement the abstract class and will be used for any purpose in the project. In other words, these are the classes in the project where we will apply the Prototype Design Pattern. I created my "clone" method in this class. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Creational_Patterns/Prototype_Pattern1/Model/Student.cs).
 
- Here, I created the console application that will create the request.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Creational_Patterns/Prototype_Pattern1/Program.cs).

- Thus, I can produce as much as I want from the same object.


