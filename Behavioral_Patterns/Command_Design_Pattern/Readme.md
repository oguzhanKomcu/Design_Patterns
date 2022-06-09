# Command Design Pattern

<img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS5Aa6M06Uf8ztRZKN2Rmym_2PdZYkjbx3mMg&usqp=CAU" width="600" height="200">

# WHAT IS Command Design Pattern ?

When we do not know the process of performing operations on an object or the object to be used is not known, the desired operation with the command design pattern is transformed into an object, and it is aimed to perform the operation by the receiving object.

# When is it used?

Let's say there are 4 buttons and each button does different operations. Instead of checking which button is clicked with if-else and running the relevant operation, or instead of writing 4 different methods for each button click event, we create classes for the operations to be performed (such as Open, Close, Save) by using the command design pattern. Then, we can create objects from these classes within the onclick events of these buttons and call the execute() method. In this way, we get rid of the complex if-else structure.

#Advantage of command pattern
- It separates the object that invokes the operation from the object that actually performs the operation.
- It makes easy to add new commands, because existing classes remain unchanged.
# Usage of command pattern:


- When you need parameterize objects according to an action perform.
- When you need to create and execute requests at different times.
- When you need to support rollback, logging or transaction functionality.

# UML model of Singleton Design Pattern

<img src="https://www.codeproject.com/KB/architecture/commandpatterndemo/2.jpg" width="500" height="300">

## Diagram of my example I made.

<img src="https://user-images.githubusercontent.com/96787308/158271029-8c031767-e46d-4d99-93ef-5be568cc3861.png" width="600" height="400">


# How is it applied ?

- Every command should have a common interface. I created an ["ICommand"](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Command_Design_Pattern/ICommand.cs). interface for it.

- I created my objects ( [Save](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Creational_Patterns/Builder_Pattern/Builder/TelephoneBuilder.cs), [Opening](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Creational_Patterns/Builder_Pattern/Builder/TelephoneBuilder.cs), [Closing](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Creational_Patterns/Builder_Pattern/Builder/TelephoneBuilder.cs)) that will receive the order.
 
- To run the target method, I created the ExecuteAll() procedure of the invoker object I created. The client will directly run the commands with this method in this class.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Command_Design_Pattern/InvokerFileOperations.cs).

- The client DI passes the command object to the invoker object so that it can execute the command.Execute() method from within the invoker.Execute() method.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Command_Design_Pattern/Program.cs).


