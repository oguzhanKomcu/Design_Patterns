# Proxy Design Pattern

<img src="https://sourcemaking.com/files/v2/content/patterns/Proxy_example1.png" width="700" height="400">

A proxy pattern is created when an existing object is desired to be accessed. By placing a new layer between the object and the client, the object is shared in a controlled manner. Thus, the client does not come into direct contact with the processing class. Thanks to this situation, it is ensured that there is no decrease in the performance of the operation. Therefore, the proxy pattern is used in processes that bring too much load.

In the surrogate pattern design pattern, there is a real object and a surrogate object. The surrogate object uses the functions of the real object. That is, the client does its operation through the proxy object. Therefore, the work of the real object is determined by the decision of the surrogate object. Thanks to the surrogate object, access to the object will not be frequent and the process will be more efficient.

# When is it used?

- When creating an object that takes time to create
- When an object needs to be created by remote access
- When some checks need to be done before accessing the object
- It can be useful when access to the object is restricted.


## UML model of Singleton Design Pattern

<img src="https://www.dofactory.com/img/diagrams/net/proxy.png" width="700" height="500">

## Diagram of my example I made.

<img src="https://user-images.githubusercontent.com/96787308/158083404-4d9ac82d-0d63-4b92-90c3-f9381e658ed4.png" width="700" height="600">


# How is it applied ?

- It is our Interface or abstract class that will enable the client to work with a single type. It is the structure from which our Real Subject and Proxy objects derive. [Github Page](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Proxy_Design_Pattern/IInformation_Profile.cs)

- Here I created our actual object that will perform the actual work of the current job. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Proxy_Design_Pattern/Profile_Owner.cs)
 
- It is our proxy class. It will respond to the requests of the client by carrying the Real Subject reference in it. Naturally, the client will be able to access the real object indirectly via the proxy. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Proxy_Design_Pattern/ProfileProxy.cs)

- When my client wants to do it, it will be able to generate it from my direl "Proxy" class in a controlled manner. [GitHub Pages](https://github.com/oguzhanKomcu/Design_Patterns/blob/master/Structural_Patterns/Proxy_Design_Pattern/Program.cs).
