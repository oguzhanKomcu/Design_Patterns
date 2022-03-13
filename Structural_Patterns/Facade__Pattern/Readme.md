# Facade Pattern

<img src="https://springframework.guru/wp-content/uploads/2015/07/Facade02.png" width="700" height="400">

Facade is a structural design pattern that provides a simplified interface to a library, a framework, or any other complex set of classes.

If we try to understand this in simpler terms, then we can say that a room is a façade and just by looking at it from outside the door, one can not predict what is inside the room and how the room is structured from inside. Thus, Façade is a general term for simplifying the outward appearance of a complex or large system.

In software terms, Facade pattern hides the complexities of the systems and provides a simple interface to the clients.

The facade pattern is implemented when a segment of the client community needs a simplified interface for the overall functionality of a complex subsystem.

## Advantages	                                        
- Minimizes complexity of sub-systems	                
- Aids principle of loose coupling	              
- Software becomes more flexible and easily expandable	
## Disadvantages
- Complex implementation (especially with existing code)
- Approach is coupled to an additional level of indirection
- High degree of dependence at facade interface


## UML model of Singleton Design Pattern

<img src="http://cagataykiziltan.net/wp-content/uploads/2018/09/Facade-Design-Pattern-in-C-UML-Diagram.png" width="600" height="400">

## Diagram of my example I made

<img src="https://user-images.githubusercontent.com/96787308/158079166-b3a1cf4f-5023-47cc-979c-31425eef7284.png" width="800" height="600">

# How is it applied ?

- The Facade class will not encapsulate subclasses. It will provide a simple interface to their functions. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Facade__Pattern/FacadeManufacturer.cs).

- I created [SendNotification](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Adapter_Pattern/Adapter/SendNotification.cs) class to send. I will do all my sending operations with this class. The "Send()" method in this class accepts only [INotification](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Adapter_Pattern/Interface/INotification.cs) type objects.
 
- I wrote an adapter class named [PushNotificationAdepter](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Adapter_Pattern/Adapter/PushNotificationAdepter.cs) for the CustomerRecord class. This class takes a class of type [CustomerRecord](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Adapter_Pattern/Model/CustomerRecord.cs). from the outside and is made suitable for the "INotification" interface.

- I made the latest operations for the Client in the Console application.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Adapter_Pattern/Program.cs).
