# Visitor Design Pattern

<img src="https://i.pinimg.com/originals/d9/1e/81/d91e81b2490bdca2eb76ebcd8d540774.jpg" width="700" height="400">

Visitor design pattern allows you to add new behaviors to an existing object without changing the object structure.

Visitor pattern separates the non-related behaviors from the object and put them into a separate object. Visitor pattern creates a separate object for each new functionality.

This pattern supports both single responsibility and open/closed SOLID principles. By implementing this pattern, your object can delegate responsibilities to different objects. For e.g. you have an Employee object which has responsibility of CRUD operations. But you have to add another responsibility to an Employee object to generate reports. By using this visitor pattern, you can add behaviors for generating report without modifying the Employee object. Your Employee object also follow the open/closed principle. As you don't have to modify Employee object when you have to add new behavior.

# UML model of Singleton Design Pattern

<img src="https://dotnettrickscloud.blob.core.windows.net/img/designpatterns/visitor-design-pattern.png" width="700" height="550">

## Diagram of my example I made.

<img src="https://user-images.githubusercontent.com/96787308/158888503-72c20445-9664-4434-8439-d4a8227dafea.png" width="700" height="600">


# How is it applied ?

-It is the interface of the visitor classes that will host new functionalities in practice. All visitors derive from this interface, allowing us to inject multiple behaviors into real objects through dependency injection. [IVisitor](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Visitor_Design_Pattern/IVisitor.cs)

- They are tangible visitor objects that contain the required functionality. They derive from the Visitor interface. [GetIdVisitor](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Visitor_Design_Pattern/Classes/GetIdVisitor.cs)  [GetPriceVisitor](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Visitor_Design_Pattern/Classes/GetPriceVisitor.cs)
 
- It is the interface that contains the signature of the required method to inject the new functionality needed into real objects. The mentioned method has a parameter in the Visitor reference, and the Concrete Visitor, which contains the desired behavior, is passed to the relevant real object via this parameter. Thus, all real objects that implement this interface can quickly exhibit different behaviors by incorporating all Concrete Visitors derived from the Visitor in the system. [IBaseEntity](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Visitor_Design_Pattern/IBaseEntity.cs)

- They are real/original objects to which new functionalities are desired to be gained in the application. That is, it is the class where visitors stop by and do business, even if they are not family members. Implements the Element interface. [Categories](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Visitor_Design_Pattern/Classes/Categories.cs)  [Products](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Visitor_Design_Pattern/Classes/Products.cs)

- I completed my design by writing the methods required for the client. By writing other visitor classes like this, we can make the new methods executable without changing our class. [Github  Page](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Visitor_Design_Pattern/Program.cs)
