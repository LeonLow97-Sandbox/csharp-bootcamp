# Object Oriented Programming

## Object Oriented Programming

- Programming Model for Scalable Applications.
- OOP helps to group-up some data and its operations as a single unit called "Object".

## Object

- A small unit (entity) in the program that represents a real-world person or thing.
- Objects are stores inside Heap.
- Objects stores fields.
- Object associates with all methods of its class. Object can call methods of its class.

## Class

- Class is a model of objects.
- Class represents structure (list of fields and methods) of data that you want to store in similar objects.

## Method

- Method is a collection of statements to perform certain operation (process or work), such as performing some calculation, displaying some output, checking some conditions, etc.
- Method should be a member (part) of class.

## Syntax

```cs
accessModifier modifier class ClassName
{
    Fields
    Methods
    Constructors
    Properties
    Events
    Destructors
}

```

## `accessModifier`

1. Internal Class (**default**)
   - accessible within the same assembly.
2. Public Class
   - accessible in the same assembly and also in other assemblies.
   - have to create them under the same "solution".
   - Right-click a class --> Add --> Reference

## `modifier` (optional)

1. static
   - static class contains only static members
2. Abstract
   - Abstract class can additionally contain abstract methods.
3. Sealed
   - Sealed class can't be inherited.
4. Partial
   - Multiple partial classes that have same name, are combined into single class.

## Creating Objects

1. Creating Reference Variable (stored in stack)
   `className referenceVariable`
2. Create Object and Store its reference into the Reference Variable (stored in Heap)
   `new ClassName();`

## Summary

- Object is a programmatic representation of a person or thing.
- All objects are created based on classes; stored in heap.
- For each application execution, a new heap will be created (and only one).
- All reference variables (local variables of methods) are stored in stack. For each method call, a new stack will be created.
- Method is a collection of statements to perform some operation / calculation.
- Class supports 2 access modifiers: `internal` and `public`.
- Class supports 4 modifiers: `static`, `abstract`, `sealed`, `partial`.
- Objects store actual data (group of fields) & can access methods os class.
- A reference variable stores address of an (only one) object.