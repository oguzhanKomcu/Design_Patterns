# BRİDGE PATTERN

<img src="https://i.pinimg.com/564x/18/45/38/1845384404af55b2a73a1394775f21e9.jpg" width="700" height="400">



The bridge pattern separates the abstraction from the implementation, allowing the two to work independently of each other. While doing this, they transfer the tasks of the program to different classes by using layered structure, aggregation and inheritance.

The key point of the Bridge design pattern is that the abstraction classes and the realizing classes are in a separate hierarchical structure. There is a superclass in both hierarchical structures and these superclasses are aware of each other. Therefore, the details are hidden.

We can use this pattern in the following situation. You have 2 different building groups in your system. These groups have different realizations. Using these structures by keeping their references over certain interfaces, instead of knowing each other's implementation level, will prevent complex hierarchical structures.

### WHEN SHOULD I USE THE BRIDGE DESIGN PATTERN?

   - If you want to completely separate the implementations from the client…
   - If you don't want to bind the implementations directly to the abstraction that communicates with the client...
   - If you want to make changes in implementations without rebuilding the Abstraction class…

# UML model of Singleton Design Pattern

<img src="https://miro.medium.com/max/1248/1*BS7mqHvCJPr0HCmnXUi1kA.png" width="700" height="400">

## Diagram of my example I made.

<img src="https://user-images.githubusercontent.com/96787308/158056843-9f4cc023-3cd3-40fe-8b90-66a03929c8f2.png" width="800" height="650">

# How is it applied ?

- First of all, I created my operating systems. These are inherited from the [IRUN](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Bridge_Pattern/IRun.cs) interface. I created my pseudo-methods in my OS classes to run the incoming browser. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/tree/master/Structural_Patterns/Bridge_Pattern/OS).

- In order to make my browsers suitable for the desired operating system, it inherited from the [Convert](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Bridge_Pattern/Convert.cs). class and its constructor method took an object of type "IRUN". Later, I created a transform method.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Bridge_Pattern/Browser/GoogleChrome.cs).
 
- Finally, I completed my bridge process in the console application. Thus, thanks to the "Bridge Pattern" I applied, my browsers became operational in any desired operating system. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Bridge_Pattern/Program.cs).

