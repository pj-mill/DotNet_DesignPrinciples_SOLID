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

We need to refacter the code so that inventory management, customer notification and payment services are sperated into their respective interfaces/classes.

---

###Resources
|Title|Author|Website|
|-----|------|-------|
|[SOLID Principles in C# - An Overview](http://www.codeguru.com/columns/experts/solid-principles-in-c-an-overview.htm)| V.N.S Arun| codeguru|
|[SOLID Principles in C#](http://www.c-sharpcorner.com/uploadfile/damubetha/solid-principles-in-c-sharp/)|Damodhar Naidu|C# Corner|
|[SOLID design principles in .NET: the Single Responsibility Principle](https://dotnetcodr.com/2013/08/12/solid-design-principles-in-net-the-single-responsibility-principle/)|Andras Nemes|dotnetcodr|
|[SOLID](https://en.wikipedia.org/wiki/SOLID_(object-oriented_design)||Wikipedia|
