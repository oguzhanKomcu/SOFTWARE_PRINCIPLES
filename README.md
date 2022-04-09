# SOFTWARE_PRINCIPLES

The principles that we take behind us while developing projects or programming sometimes make our lives easier, and sometimes open our horizons and imagination. When we apply these principles, our projects become more organized, developable and understandable.

In fact, OOP alone cannot function without these principles. Thanks to these principles, they achieve their purpose and complement each other.

Solid principles are the most important part of our software principles, but before that, we have some principles that should be our principle in software development that should be known.

These principles are :

## Kiss Principle : Keep it Simple Stupid

KISS is a principle that suggests striving for simplicity.This principle, which was first expressed in the American navy in the 1960s, is one of the most important programming principles today. Suggests choosing the simplest and most straightforward solution possible when solving a problem.
KISS rejects the idea that complex solutions are more "intelligent" solutions. Most engineers/programmers think they are doing "intelligent" work by finding complex solutions and building complex structures. A person looking from the outside thinks that the harder he understands, the more added value he produces. But the challenge is to simplify. In software processes, the code/software architecture tends to grow and become more complex over time. The important and difficult thing is to provide the desired functionality at the minimum complexity level.

## Yangi Principle : You Aren’t Gonna Need It !

Like the KISS principle, YAGNI aims to avoid complexity, especially from adding functionality you think you may need in the future.In other words, he says, do not do the work of the later, much earlier, in case you need it in the future. Because both a waste of time and various errors may be encountered in our software afterwards. It says that we should always implement things when we really need them. Because maybe we won't even need it in the future and we will tire ourselves out by trying to write it.

## DRY Principle : Don’t Repeat Yourself !

The Repetition of Oneself (DRY) principle states that repetition in logic must be eliminated by abstraction; Duplicates in the process should be eliminated through automation. Duplicating is a waste. Adding additional, redundant code to a codebase increases the amount of work required to expand and maintain software in the future.

Successful application of the DRY principle means that when there is a change in the system, we do not think about whether other logical elements will be affected by this change. In addition, since the effects on the associated logical elements will be predictable, the process will be handled properly and the changes can be managed up-to-date.


# SOLID PRINCIPLES

![alt text](https://dijitalseruven.com/wp-content/uploads/2021/02/SOLID-1024x341.jpg)


## SRP (Single Responsibility Principle)

![alt text](https://i0.wp.com/www.mustafakahraman.net/wp-content/uploads/2018/09/single-responsibility-principle.png?resize=700%2C373)


The Single Responsibility Principle states that every function, class, module, or service should have a single, clearly defined responsibility.This principle explains to us that it is wrong to load more than one responsibilities, functions into a class, method. In other words, a class/function/module should have only one reason to change.Your code becomes much easier to understand, maintain, and modify when you define your functions or classes to be focused and responsible for a single functionality.

Consider the confusion and clutter that can happen when our models have elements that don't belong to their function. So an element that doesn't work for him in the model may lead to other errors in the future.

Here she first showed the misuse with a bad example. [GitHub Pages](https://github.com/oguzhanKomcu/SOFTWARE_PRINCIPLES/tree/master/SOLID_Principles/1.SRP/BadExample).

Here, too, I have shown how we get better results when we follow the principle. [GitHub Pages](https://github.com/oguzhanKomcu/SOFTWARE_PRINCIPLES/tree/master/SOLID_Principles/1.SRP/GoodExample).

##  OCP (Open/Closed Principle) 


![alt text](https://miro.medium.com/max/1400/1*XEtQ5hCa0uYTGQ38usgquQ.jpeg)

According to this principle, classes should be open to development and closed to change.OCP requires assets that can be broadly adapted but also remain unchanged. At this point, we need to create duplicate entities with special behaviors with the subject of polymorphism. That is, it should not be changing its behavior and should be able to acquire new features. When we do not comply with this principle, we have to make changes to our methods or functions when new updates are constantly coming.This may not seem very important in small projects, but as the projects grow, the problems may increase because we do not follow the principle.

Here I have shown an example made without following my principle. [GitHub Pages](https://github.com/oguzhanKomcu/SOFTWARE_PRINCIPLES/blob/master/SOLID_Principles/2.OCP/BadExample/BadShape.cs).

Here, too, I have shown how we get better results when we follow the principle. [GitHub Pages](https://github.com/oguzhanKomcu/SOFTWARE_PRINCIPLES/tree/master/SOLID_Principles/2.OCP/GoodExample).

## LSP (Liskov Substitution Principle) 



Traits inside the inherited class must also be used in the inheriting class. In other words, if the inheriting abstract class is a base class, it should not contain the metholders, properties, and fields that are not valid in all subclasses. Although there are elements that are not required to be overridden in the abstact class, the subclass still inherits this method.

Here, with a bad example, I have shown the situations that can occur when the principle is not followed. [GitHub Pages](https://github.com/oguzhanKomcu/SOFTWARE_PRINCIPLES/tree/master/SOLID_Principles/3.LSP/BadExample).

Here I have shown the good result when the principle is followed. [GitHub Pages](https://github.com/oguzhanKomcu/SOFTWARE_PRINCIPLES/tree/master/SOLID_Principles/3.LSP/GoodExample).

## ISP (Interface Segregation Principle)

![alt text](https://jfiaffe.files.wordpress.com/2015/02/multi-cables.jpg)

It is the principle that argues that we should create more customized interfaces instead of collecting all the responsibilities into a single interface. In other words, it wants us to create the capability that the subclass will not use in the interface. Because all methods and properties created in the interface must be in the implement class with it, and the bodies of these methods are filled in that implemented class. When the class does not use this method, it unnecessarily retains it.It would be a more correct approach for the classes to create and implement their own capabilities in different interfaces.

Here I have shown the plight that occurs when this principle is not applied. [GitHub Pages](https://github.com/oguzhanKomcu/SOFTWARE_PRINCIPLES/tree/master/SOLID_Principles/4.ISP/BadExamples).

Here I have shown my example, which allows us to achieve better results when the principle is followed. [GitHub Pages](https://github.com/oguzhanKomcu/SOFTWARE_PRINCIPLES/tree/master/SOLID_Principles/4.ISP/GoodExamples).

## DIP (Dependency Inversion Principle)

![alt text](https://user-images.githubusercontent.com/96787308/162573983-0668c49d-82fe-41f8-845b-508b54dbf2e3.png)


Top-level classes should not depend on lower-level classes, the relationship should be provided using abstraction or interface.Abstraction should not depend on details, on the contrary, details should depend on abstractions.This principle tells us that we have to make these principles.In general programming, high-level processing methods are dependent on low-level processing methods. So they call those methods.Because low-level methods will require changes to lower-level methods, higher-level methods also have to undergo changes.

When this principle is not followed, we constantly create new objects between our layers and classes. This means a lot of objects in big projects. This also affects performance.Likewise, a change to a method that performs high-level operations requires that all the methods it depends on change. Reusability is almost impossible in a project with such tightly coupled methods. In other words, when we want to reuse a small change made in another project, we have to reference many classes in the project.

Here I have shown an example made without following my principle. [GitHub Pages](https://github.com/oguzhanKomcu/SOFTWARE_PRINCIPLES/tree/master/SOLID_Principles/5.DIP/BadExample).

Here I have shown my example, which allows us to achieve better results when the principle is followed. [GitHub Pages](https://github.com/oguzhanKomcu/SOFTWARE_PRINCIPLES/tree/master/SOLID_Principles/5.DIP/GoodExample).





