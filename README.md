# DESIGN PATTERN

![alt text](https://miro.medium.com/max/630/0*MJm0gosQpDVaToFB.png)

## What Are Design Patterns?

Design patterns are the solution to common problems software developers face during software development.These solutions have been achieved by trial and error by countless software developers over a long period of time. They then gave names to the optimum solutions they found for certain problems. GOF has included 23 Design Patterns in its books. But over time, developers have found more than these. While developing your project, you can create your own design pattern and find your own solution. However, since the purpose of design patterns is not to reinvent the wheel, it would be best for you to know the existing solutions and use them where appropriate.

Design Patterns exist to help us developers. They allow us to implement tried and tested solutions (also used by other developers) to known problems, thus saving time and effort during code implementation. It also makes it easier to communicate by defining common words to talk about specific problems, for example you can say “in this case you can use a factory” and other developers will know what to do.

## Benefits of Design Patterns

- Foresee and rectify future problems easily.
- Helps in maintaining binary compatibility with subsequent releases.
- Just by following SOLID Principles helps greatly in agile or adaptive software development.
- The solution facilitates the development of highly cohesive modules with minimal coupling. Thus, increasing extensibility and reusability.
- There are some patterns like Facade, Proxy, etc which encapsulates the complexity in itself to provide easy and intuitive interface to the client. Thus, making the overall system easier to understand and reduce learning curve.
- Design Patterns make communication between designers and developers more crystal and precise. A developer can immediately picture the high-level design in their heads when they refer to the name of the pattern used to solve a particular issue when discussing software design.

## Types of Design Patterns

According to the design pattern reference book Design Patterns - Elements of Reusable Object-Oriented Software, there are 23 design patterns that can be classified into three categories: Creative, Structural, and Behavioral patterns.
 
- ***Creational Design Patterns*** : These design patterns provide a way to create objects while hiding the creation logic, rather than instantiating objects directly using new operator. This gives program more flexibility in deciding which objects need to be created for a given use case. Here I gave examples of patterns belonging to the category of Creational. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/tree/master/Creational_Patterns)

- ***Structural Design Patterns*** : These design patterns concern class and object composition. Concept of inheritance is used to compose interfaces and define ways to compose objects to obtain new functionalities.Here I gave examples of patterns belonging to the Structural category. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/tree/master/Structural_Patterns)
 
- ***Behavioral Design Patterns*** : These design patterns are specifically concerned with communication between objects.Here I gave examples of patterns belonging to the Behavioral category. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/tree/master/Behavioral_Patterns)


## Elements of the Design Pattern

The book 'Design Patterns' says that a pattern has four basic elements: 

- Problem : Problem explains when to apply the pattern, explains the problem and its context.

- Solution : Defines the elements, relationships, responsibilities and collaborations that make up the design. Solutions do not define a concrete implementation because a model is like a template that can be applied in many different situations, but provides an abstract definition of a design problem and how a general arrangement of elements (classes and objects) solves it.
- Results: The results of applying the pattern.

