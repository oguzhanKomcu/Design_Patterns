# Mediator Design Pattern

<img src="https://user-images.githubusercontent.com/96787308/158479708-5c3c5e9d-1ca3-4dab-82ef-58576341521f.png" width="700" height="400">

Agent pattern is generally used for managing objects, providing and managing communication between them from a central point. This reduces the link between objects and makes only one class responsible for coordinating other classes as the master class.

The pattern is generally used as much as the number of classes of the written program. Logic and computation are distributed among these classes. Also, in very advanced programs, communication between classes becomes more and more complex, affecting the progress and readability of the code. When the agent pattern is used, communication is not provided directly between classes. There is an agent pattern between classes and it manages the classes. Thus, inter-object dependency is reduced and the program becomes more convenient to manage and develop. In short, the mediator design pattern is used to reduce dependencies between classes and facilitate communication between them.


# Usage areas:

- It is used for objects that are difficult to understand and complexly structured.
- It is used in advanced objective structures to prevent a change made to an object from affecting other objects.
- It is used to enable distribution among objects without the need for new classifications.

# Advantages


- Easy to understand: The agent pattern hides all the complex activities done by peers and makes it easier for users to understand the interactions and the system.

- Resolved co-staffs: Co-staffs can be added, modified, and removed so they are less structurally interdependent. Therefore, intermediary pattern and collegue can be used independently.
- Protocol convenience: The agent pattern prefers multiple communication over one-to-one interaction as it provides several central access points.
- Subclass boundaries: Since the agent pattern is native, it can subclass while changing behavior, but the peer remains the same.

# Disadvantages

- Complex structure: The intermediary structure can have a complex structure as it generally handles many co-workers, which makes it difficult to understand and develop.


## UML model of Singleton Design Pattern

<img src="http://3.bp.blogspot.com/-z40Tb8qIK_0/UpiNaG0MG1I/AAAAAAAAAqI/uZ4vKAHddT0/s1600/mediator.gif" width="800" height="400">

## Diagram of my example I made

<img src="https://user-images.githubusercontent.com/96787308/158481277-f4ff11b4-9bae-4f56-9091-8297ce693ea2.png" width="800" height="600">

# How is it applied ?

- It is the interface of the Mediator object that will act as an intermediary between objects.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Mediator_Design_Pattern/IWhatsappGroupMediator.cs).

- Concrete class that derives from the Mediator interface and is responsible for inter-object communication. It keeps the Colleague references in which it will communicate and provides the necessary functionality.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Mediator_Design_Pattern/ConcreteMediator.cs)
 
- It is the interface that the objects that will provide communication / communication between them will implement. They keep the Concrete Mediator reference within themselves. Thus, they know through which intermediary they communicate indirectly with other objects. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Mediator_Design_Pattern/User.cs)
- It is the class that implements the Iterator interface, contains iteration methods and features, and undertakes the enumerator function that we mentioned above.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Iterator_Design_Pattern/Contact_Iterator.cs).
- Colleague arayüzünü uygulamış ve birbirleriyle iletşim/haberleşme sağlayacak olan somut nesnelerdir.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Mediator_Design_Pattern/ConcreteUser.cs).
