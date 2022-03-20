# Strategy Design Pattern

<img src="http://sourcemaking.com/files/sm/images/patterns/Strategy_example1.gif" width="600" height="400">

If a function has more than one way of doing it, it is a design pattern that can be used when it is desired to use this functionality with different versions. When we have more than one concrete strategy class that does the same job in different ways, presenting them to the client through a strategy class, giving the strategy class the interface, which is the common ancestor of these concrete types, will make our work easier when a new one is added to these concrete types in the future, in this case all we have to do is It will be sufficient to derive this concrete type from the common interface. This is exactly what the Strategy design pattern does.

Strategy pattern defines a family of algorithms, encapsulates each one of them and makes them interchangeable at run time within that family.

## Now let’s understand what each one of them actually means.

- Family of Algorithms: This means this pattern provides a set of algorithms using one of which at run time you can achieve the desired output.
- Encapsulate each one of the: This pattern allows you to place your algorithms in different classes (encapsulate them).
- Makes the algorithm interchangeable: The beauty with strategy pattern is that we can select at run time which algorithm we want to apply to our object and can also replace them with one another.

# UML model of Singleton Design Pattern

<img src="https://indiedevart.files.wordpress.com/2016/06/strategy.png" width="600" height="400">

## Diagram of my example I made.

<img src="https://user-images.githubusercontent.com/96787308/158873092-716ef3a0-1804-4fde-a370-72b0ccbb44ae.png" width="600" height="600">


# How is it applied ?

- I created an interface for my Strategy classes. [IStrategy](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Strategy_Design_Pattern/IStrategy.cs)

- [StrategyImp](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Strategy_Design_Pattern/StrategyImp.cs). is our strategy class. The client will completely communicate with this class and the submitted arguments will be evaluated over this class.
 
- My concrete classes inherit from the IStrategy interface. Thus, the method is the same but the functions are changed, according to the client's strategy.[Collection Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Strategy_Design_Pattern/Collection.cs) [Divide](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Strategy_Design_Pattern/Divide.cs)[Extraction](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Strategy_Design_Pattern/Extraction.cs)[Impact](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Strategy_Design_Pattern/Impact.cs)

- All that needs to be done by the client is to send the relevant parameter to the StrategyImp class, which is our strategy class, and run it. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Strategy_Design_Pattern/Program.cs).
