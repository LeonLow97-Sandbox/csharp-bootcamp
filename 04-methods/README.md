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
    
## Local Variables and Parameters

- Parameter: Value received from the method caller
    - stored in the stack of the method.
    - for every method call, a new stack will be created.
- Local variables: value will be initialized in the method itself.
    - local variables are stored in the same stack as parameters.
    - deleted from stack at the end of method execution.

## `this` keyword

- The `this` keyword refers to "current object", which method has invoked the method.
- The `this` keyword is available only within the "instance methods" (for non-static methods).
- For static methods (no objects), `this` keyword is unavailable.

```cs
// by default, this way we are already accessing the current object:
public void SetProductID(int value)
{
    productID = value;
}

//can also put the `this` keyword (same thing)
public void SetProductID(int value)
{
    this.productID = value;
}

// but if your parameter and field have the same name, must use `this` keyword:
public void SetProductID(int productID)
{
    // this.productID references the FIELD
    this.productID = productID;
}
```

## Static Methods

||Instance Methods|Static Methods|
|:-:|:-:|:-:|
|Association|Associated with Objects|Associated with Class.|
|Manipulates|Manipulates instance fields|Manipulates static fields.|
|Declaration|Declared without `static` keyword.|Declared with `static` keyword.|
|Accessible With|Accessible with object (through reference variable)|Accessible with class name only (not with object)|
|Can access (fields)|Can access both instance fields and static fields.|Can't access instance fields but can access static fields only.|
|Can access (methods)|Can access both instance methods and static methods.|Can't access instance methods but can access static methods only.|
|`this` keyword|Can use `this` keyword, as there must be "current object" to call instance method.|Can't use `this` keyword as there is NO "current object" while calling instance methods.|




















