# Decorator Pattern

<img src="https://refactoring.guru/images/patterns/content/decorator/decorator-comic-1.png?id=80d95baacbfb91f5bcdbdc7814b0c64d" width="700" height="400">


The purpose of the Decorator design pattern is to add properties to objects dynamically, and the object itself must be in a separate location, unaware of the properties being added. In other words, if we want to give certain properties to objects in certain parts of the code and we want to do this in a way that is separated from the object's own class, we should use the decorator design pattern.

Decorator pattern both expands the system and brings a solution to the problem with the principle of single responsibility and interface separation.

Note that this pattern allows responsibilities to be added to an object, not methods to an object's interface. The interface presented to the client must remain constant as successive layers are specified.

## The most important features of the Decorator design pattern

- The main object is not aware that it is decorated. In other words, the features added with the decorator are not actually the features that it contains in its own class.
- The class of the main object becomes one big class that contains all the necessary unnecessary options.
- All decorator classes are independent of each other.
- Decorator classes can be combined and matched among themselves.

## UML model of Singleton Design Pattern

<img src="https://www.oreilly.com/library/view/learning-javascript-design/9781449334840/httpatomoreillycomsourceoreillyimages1547817.png" width="500" height="300">

## Diagram of my example I made.

<img src="https://user-images.githubusercontent.com/96787308/158077695-be3fd548-2860-4199-841c-a850cf51fe27.png" width="500" height="600">


# How is it applied ?

- Here I created the class of the object on which the properties and behaviors will be dynamically added. If an additional property comes on this object, I will apply it in subclasses that inherit from my decorator class.By the way, cycling is very enjoyable. You feel better mentally and physically. :blush: [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Decorator_Pattern/Concrete/Bike.cs).

- I created the interface that the Component and Decorator class inherit. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Decorator_Pattern/Interface/IAdditional_Feature.cs)
 
- My class to which feature and behavior are added dynamically. This class inherited from decarator base "BikeDecoratorBaseA" class. My base class "IAdditional_Feature" inherited from my interface. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Decorator_Pattern/Decorators/BikeDecoratorBaseA.cs)

- Finally, I made my transactions for the client and finished my design. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Decorator_Pattern/Program.cs).
