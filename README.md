# DotNet_DesignPrinciples_SOLID

Demonstration of SOLID Design Principles

---

Developed with Visual Studio 2015 Community

---

###Techs
|Tech|
|----|
|C#|

---

### Single Responsibility Principle (SRP)

#### DEFINITION
A class should have only a single responsibility (i.e. only one potential change in the software's specification should be able to affect the specification of the class).


#### THE PROBLEM
Check out the 'Order' class under the 'Problem' folder in the 'SingleResponsibilityPrinciple' project

This class is trying to do the following

1. Update Inventory
2. Notify the customer
3. Charge a credit card

These are not the responsibility of the Order class.

#### THE SOLUTION
Check out the 'Solution' folder in the 'SingleResponsibilityPrinciple' project.

We refactered the code so that inventory management, customer notification and payment services are seperated into their respective interfaces, and then injected these services into the 'Order' class.

---

### Open Closed Principle (OCP)

#### DEFINITION
Software entities should be open for extension, but closed for modification.


#### THE PROBLEM
Check out the 'ShoppingCart' class under the 'Problem' folder in the 'OpenClosedPrinciple' project

The problem lies with the 'TotalAmount' function. It uses several IF/ELSE statements to decide how to calculate the price total. 

Here are some additional pricing strategies that might need to be introduced further down the line.

1. Price per unit
2. Price per unit of weight, such as price per kilogram
3. Special discount prices: buy 3, get 1 for free
4. Price depending on the Customer’s loyalty: loyal customers get 10% off

In the real world, pricing strategies change all the time so adding more rules or changing existing rules will lead to more complex code, introduction of new bugs, re-testing a function that had already passed it's original test.

#### THE SOLUTION
Check out the 'Solution' folder in the 'OpenClosedPrinciple' project.

We will use the 'Strategy Pattern' to seperate pricing rules and inject the appropriate one for each order item.

---

###Resources
|Title|Author|Website|
|-----|------|-------|
|[SOLID Principles in C# - An Overview](http://www.codeguru.com/columns/experts/solid-principles-in-c-an-overview.htm)| V.N.S Arun| codeguru|
|[SOLID Principles in C#](http://www.c-sharpcorner.com/uploadfile/damubetha/solid-principles-in-c-sharp/)|Damodhar Naidu|C# Corner|
|[SOLID design principles in .NET: the Single Responsibility Principle](https://dotnetcodr.com/2013/08/12/solid-design-principles-in-net-the-single-responsibility-principle/)|Andras Nemes|dotnetcodr|
|[SOLID (object oriented design)](https://en.wikipedia.org/wiki/SOLID_(object-oriented_design))||Wikipedia|
