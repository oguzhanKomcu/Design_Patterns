# Template Design Pattern

<img src="https://refactoring.guru/images/patterns/diagrams/template-method/live-example.png?id=2485d52852f87da06c9cc0e2fd257d6a" width="600" height="400">

The template method pattern belongs to the behavioral design patterns group. The template method pattern abstractly defines the steps required for a process and specifies how a template method and algorithm will work. Subclasses enable the algorithm to work according to their own wishes by implementing one or more of the methods required for the algorithm within their own structure. Thus, reusability of the code is avoided by avoiding code repetition, and it is ensured that an arrangement to be made in the algorithm skeleton is made from a single place. For example, with a method that will be placed in the parent class and defined, it can be made to interfere with the flow of the subclass.

# UML model of Singleton Design Pattern

<img src="https://miro.medium.com/max/1382/1*ayWiwk1YjAlLUYzN9fleqw.png" width="600" height="400">

## Diagram of my example I made.

<img src="https://user-images.githubusercontent.com/96787308/158880917-f0bdbcb7-9e31-4a07-9658-78a4ccc3f8ed.png" width="600" height="600">


# How is it applied ?

- I created an interface for my Strategy classes. [IStrategy](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Strategy_Design_Pattern/IStrategy.cs)

- [StrategyImp](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Strategy_Design_Pattern/StrategyImp.cs). is our strategy class. The client will completely communicate with this class and the submitted arguments will be evaluated over this class.
 
- My concrete classes inherit from the IStrategy interface. Thus, the method is the same but the functions are changed, according to the client's strategy.[Collection Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Strategy_Design_Pattern/Collection.cs) [Divide](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Strategy_Design_Pattern/Divide.cs)[Extraction](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Strategy_Design_Pattern/Extraction.cs)[Impact](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Strategy_Design_Pattern/Impact.cs)

- All that needs to be done by the client is to send the relevant parameter to the StrategyImp class, which is our strategy class, and run it. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Strategy_Design_Pattern/Program.cs).
