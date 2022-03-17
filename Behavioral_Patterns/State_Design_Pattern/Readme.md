
# State Design Pattern

<img src="https://www.evrenbal.com/wp-content/uploads/2021/10/state-tasarim-deseni.png" width="600" height="400">



The situational design pattern is considered one of the sub-branches of the behavioral design patterns. The state design pattern can be used when an object's state changes, its behavior changes, in other words, objects behave differently in different situations. From the user's point of view, it gives the impression of changing the object class. It allows adding and removing new behaviors as required by the application.

It is possible to do this event with if-else or switch structure, but using if-else or switch for each behavior will create confusion. Also, when we add a new behavior, we will have to play around with almost the entire program. However, if we use the state pattern, it allows simpler addition and subtraction of the behaviors required or desired by our program.


# UML model of Singleton Design Pattern

<img src="https://www.tutorialspoint.com/design_pattern/images/state_pattern_uml_diagram.jpg" width="700" height="500">

## Diagram of my example I made.

<img src="https://user-images.githubusercontent.com/96787308/158861748-9b7aa66b-af91-4a08-ab76-1a5dfe3411c0.png" width="600" height="600">


# How is it applied ?

-My motorcyle["Motorcyle"](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/State_Design_Pattern/Motorcycle.cs) class is the same as my context class, it is the class that will be used by the clients that will use the State Design Pattern. Delegates all work and behavior specific to the situation. The Context class communicates with Concrete State objects through the reference of the State interface. Therefore, clients cannot access state objects directly, since they hold the Concrete State object, which provides the behavior according to the current state.

-My [IState](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Creational_Patterns/Builder_Pattern/Builder/TelephoneBuilder.cs) interface is the interface where all state-specific behaviors are defined suitable for the scenario. It is designed as an abstract class or interface. It is implemented because it is the base for all Concrete State classes. Used by the Context object to access mutable functionality.[Closing](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Creational_Patterns/Builder_Pattern/Builder/TelephoneBuilder.cs) 
 
-I created my concrete objects ([RunState ](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/State_Design_Pattern/RunState.cs), [MovingState ](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/State_Design_Pattern/MovingState.cs), [StopSate ](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Command_Design_Pattern/InvokerFileOperations.cs), [OffState ](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/State_Design_Pattern/StopState.cs)) that implement the State interface. It provides the actual functionality to be used by the Context object. Each Concrete State class is essentially created to express a state and provides the behavior that can be applied to that state. It also provides instructions that cause the current state to change. Concrete State objects can be accessed by referencing the Context object.The important thing here is that both Context and Concrete State can set the Context's next state.

- I created my DoAction methods for the client inside my main() method.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/State_Design_Pattern/Program.cs).


