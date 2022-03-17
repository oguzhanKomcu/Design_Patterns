# Template Design Pattern

<img src="https://refactoring.guru/images/patterns/diagrams/template-method/live-example.png?id=2485d52852f87da06c9cc0e2fd257d6a" width="600" height="400">

The template method pattern belongs to the behavioral design patterns group. The template method pattern abstractly defines the steps required for a process and specifies how a template method and algorithm will work. Subclasses enable the algorithm to work according to their own wishes by implementing one or more of the methods required for the algorithm within their own structure. Thus, reusability of the code is avoided by avoiding code repetition, and it is ensured that an arrangement to be made in the algorithm skeleton is made from a single place. For example, with a method that will be placed in the parent class and defined, it can be made to interfere with the flow of the subclass.

# UML model of Singleton Design Pattern

<img src="https://miro.medium.com/max/1382/1*ayWiwk1YjAlLUYzN9fleqw.png" width="600" height="400">

## Diagram of my example I made.

<img src="https://user-images.githubusercontent.com/96787308/158880917-f0bdbcb7-9e31-4a07-9658-78a4ccc3f8ed.png" width="600" height="600">


# How is it applied ?

- Create my abstract class [Bank_Account](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Template_Method_Design_Pattern/Bank_Account.cs) which physically houses the sequential operations in the Template Method and algorithm.
smoke. 

-My classes where the operations to be overridden are implemented.[Investment](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Template_Method_Design_Pattern/Investment.cs).[Demand_deposit](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Template_Method_Design_Pattern/Demand_deposit.cs).[Term_deposit](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Template_Method_Design_Pattern/Term_deposit.cs).
 
- I called my TemplateMethod on application side. Thus, I avoided the possible code confusion. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Template_Method_Design_Pattern/Program.cs).
