# Methods

## What are Methods?

- Method is a function (group of statements), to do some process based on fields.
- Methods are parts of the class.
- Methods can receive one or more input values as parameters and return a value.
- default accessModifier: `private`

```cs
// Syntax of Method
accessModifier modifier returnType MethodName(parameter1, parameter2)
{
    // Method body
}
```

## Access Modifiers of Methods

|Access Modifier|In the same class|In the child classes at the same assembly|In the other classes at the same assembly|Child classes at other assembly|Other classes at other assembly|
|:-:|:-:|:-:|:-:|:-:|:-:|
|private|Yes|No|No|No|No|
|protected|Yes|Yes|No|Yes|No|
|private protected|Yes|Yes|No|No|No|
|internal|Yes|Yes|Yes|No|No|
|protected internal|Yes|Yes|Yes|Yes|No|
|public|Yes|Yes|Yes|Yes|Yes|

# Encapsulation

## What is Encapsulation?

- A concept that binds together the data and operations that manipulate the data, and that keeps both safe from outside interference and misuse.
- Concept of grouping-up the data and manipulations.
- Encapsulation: **getters and setters**
    - can set logic inside these methods

# Abstraction

## What is Abstraction

- Abstraction is the concept of providing only limited data or operations to the code existing outside of the class.
- Concept of hiding some "private data / operations" and providing some "public data / operations" to the code outside of class.
- Class
    - Private Fields / Methods
    - Public Fields / Methods
        - Code that exist outside the class.

















