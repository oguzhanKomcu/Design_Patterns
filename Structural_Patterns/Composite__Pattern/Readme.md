# COMPOSİTE PATTERN

<img src="https://refactoring.guru/images/patterns/diagrams/composite/problem-en.png?id=3320d7ddc5bdc3e43752bb4393710794" width="500" height="400">


The compound pattern provides the use of a group of objects that are different from each other as if they were a single whole object. The job of compound patterns is to combine objects into a tree structure and rearrange and shape the part-whole relationship throughout the application.

## Conditions of use
If the developer has to use a collection of objects of the same type or different types at the request of the user, he can use a compound pattern to avoid confusion and confusion.

## Structure of Compound Design Pattern

- They are the basic abstract definitions for compounds.
- Creates the interface of objects for compound operation.
- It performs the default behavior in the interface of all classes.
-It defines an interface to allow us to access and control child components.

### Leaf

- Represents child objects in a compound operation.
- All component methods are completed by leaves.

### Composite

- It represents components with leaves.
- Realize the methods that guide their children.
- He usually implements his compound methods by assigning his children.

# UML Model Of Singleton Design Pattern

<img src="https://www.gencayyildiz.com/blog/wp-content/uploads/2021/10/C-Composite-Design-PatternComposite-Tasarim-Deseni-1.jpg" width="500" height="300">

## Diagram of my example I made.

<img src="https://user-images.githubusercontent.com/96787308/158058192-63c4ec74-72a7-47df-b9e8-bad6d050c9c1.png" width="750" height="600">

# How is it applied ?

- It is the class that corresponds to the complex objects in the tree structure. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Composite__Pattern/EmployeeComposite.cs).

- It is an abstract class that describes simple and complex objects in the tree structure and the common areas of these objects.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Composite__Pattern/Official.cs).
 
- It is a single Component object, which is the most basic element in the tree structure and does not contain sub-breaks. That is, it refers to the simple object.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Composite__Pattern/SUB_AUTHORITY.cs).

- I created a console application as a result of our design.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Composite__Pattern/Program.cs).

