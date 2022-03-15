# Iterator Design Pattern

<img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRW2oqOGXau8EjE8ud-ZifE0eyHX3XN9EoSZw&usqp=CAU" width="600" height="300">

Repetitive design pattern, to minimize the link between the structure and working style of a list with other parts of the application; It is used to abstract the objects in the list from the application, respectively.

E.g ; The foreach loop is an iterative mechanism. As a matter of fact, we can generally think of the resource-like structures used by this mechanism as collections and arrays. If we pay attention to the inheritance of these structures, they derive from the IEnumerable interface and become accessible at a common point thanks to this type. In addition, IEnumerable type gives iteration feature to the class it inherits.


## Advantages	       

- It supports variations in the traversal of a collection.
- It simplifies the interface to the collection.              

## Disadvantages

- When you want to access a collection of objects without exposing its internal representation.
- When there are multiple traversals of objects need to be supported in the collection.


## UML model of Singleton Design Pattern

<img src="https://sceweb.sce.uhcl.edu/helm/WEBPAGES-SoftwareDesignPatterns/myfiles/TableContents/Module-19/iterator_pattern_uml_diagram.jpg" width="800" height="400">

## Diagram of my example I made

<img src="https://user-images.githubusercontent.com/96787308/158474156-59b10c1d-474f-4c48-a49c-eeb502c6a847.png" width="800" height="600">

# How is it applied ?

- It is the interface that requires the creation of an Iterator from an IIterator interface type to navigate through the dataset. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Iterator_Design_Pattern/ITransporter.cs).

- This interface determines all the terms and signatures of navigating the dataset. In other words, it acts as an enumerator. Long story short, it defines the operations/controls/conditions/issues required so that we can retrieve the data/objects while looping through the dataset we have.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Iterator_Design_Pattern/Iterator.cs)
 
- The client will now be able to create objects from a single place by accessing a single Facade class, combining classes.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Iterator_Design_Pattern/ContactTransporter.cs)
- It is the class that implements the Iterator interface, contains iteration methods and features, and undertakes the enumerator function that we mentioned above.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Iterator_Design_Pattern/Contact_Iterator.cs).
- I can access the elements in the dataset using my design pattern according to the specified conditions.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Behavioral_Patterns/Iterator_Design_Pattern/Program.cs).
