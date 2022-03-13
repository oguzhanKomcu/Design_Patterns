# Singleton Design Pattern

<img src="https://treewebsolutions.com/uploads/article/65/the-singleton-pattern-in-php_ys3fRymTJ-TCrLVu.png" width="500" height="300">


The singleton design pattern ensures that only one instance of a given object exists during the lifetime of a program. If the object has been created, this pattern points to the reference of this object instead of a new creation. At the same time, this pattern aims to access the single created object at a global level from outside the relevant class. Since the singleton pattern requires the creation of only one object, the object must be created somewhere in the relevant class. This is possible with a static property or a static method. This static method will return the object created inside the class itself as a return value. This object is created inside the static method or property and assigned to the private element of the class. To access this singularly created object, it will be sufficient to return the reference of this private element.

The advantage of the singleton design pattern is that it saves memory as objects are not created on every request. Only a single instance is used repeatedly.


## UML model of Singleton Design Pattern

<img src="https://www.tutorialspoint.com/design_pattern/images/singleton_pattern_uml_diagram.jpg" width="400" height="300">

## Diagram of my example I made.
<img src="https://user-images.githubusercontent.com/96787308/158038797-f61978ef-2048-4a6a-9fc6-f31c45b4329b.png" width="600" height="400">



**There are basically three steps for a class to conform to the singleton design pattern;**
- Constructor must be private. This operation prevents the creation of objects with new.
- A static member of the same type as the Class is created.
- A static method must be created to access the static member.

You can check out the sample class work I have done about Singleton Design Pattern here.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Creational_Patterns/Singleton_Design_Pattern1/LAB/MusicPlayer.cs).

You can see the implementation of the sample class work I have done about the Singleton Design Pattern here.[GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Creational_Patterns/Singleton_Design_Pattern1/Program.cs).


