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

## Reference Variables as Arguments

- If you pass 'reference variable' as argument, the reference (address) of object will be passed to the method.
- The parameter's data type will be the class name.
- If you make any changes to object in the method, the same will be affected automatically in the caller method, as you are accessing the same object.

```cs
// In Class
    public static int GetTotalQuantity(Product product1, Product product2, Product product3)
    {
        int total;
        total = product1.GetQuantityInStock() + product2.GetQuantityInStock() + product3.GetQuantityInStock();
        return total;
    }

// In Main
int totalQuantity = Product.GetTotalQuantity(product1, product2, product3);
```

## Default Arguments

- Default value of the parameter of a method.
- If you don't pass value to the parameter, the default value gets assigned to the parameter.
- To void bothering to pass value to the parameter; instead, take some default value into the parameter automatically, if the method caller has not supplied value to the parameter.

```cs
// Syntax
accessModifier modifier returnType MethodName(parameter1 = defaultValue)
{
    // Method body here
}
```

## Named Arguments

- Supply value to the parameter, based on parameter name.
- Can change order of parameters, while passing arguments.
- Parameter names are expressive (understandable) at method-calling time.

```cs
// Syntax (Calling a method)
MethodName(ParameterName: value, ParameterName: value);

// In Main
product1.CalculateTax(percentage:9.2);
```

## Method Overloading

- Writing multiple methods with same name in the same class, with different parameters.
- Caller would have several options, while calling a method.
- Difference between parameters of all methods 
- Depends on how many arguments the developer passes during method calling.

```cs
MethodName()
MethodName(int)
MethodName(string)
MethodName(int, string)
MethodName(string, int)
MethodName(string, string, int)

// In Class
    public void CalculateTax(double percentage = 4.5)
    {
    }

    public void CalculateTax(double cost, double percentage)
    {
    }
```
# Parameter Modifiers

- Specifies how the parameter receives a value

## Parameter Modifiers (`default`)

- The "Argument" will be assigned into the "Parameter", but not reverse
- Changes made to the parameter will not affect the argument variable
    - Parameter and argument are stored in different stacks.
- The default Parameter Modifier is `default`.

## Parameter Modifiers (`ref`)

- The "Argument" will be assigned into the "Parameter" and vice versa.
- The Argument must be a variable and must be **pre-initialized**.

```cs
// In Main
MethodName(ref Argument1, ...)

// In Class
MethodName(ref DataType Parameter1, ...)
{
    Parameter1 = value; // can modify the value of the argument in Main
}
```

## Parameter Modifiers (`out`)

- The "Argument" **will not be assigned** into the "Parameter" **but only reverse**.
- The Argument must be a variable' The Argument **can be un-initialized**.
- Used for real time projects where you want to return a specific value.

```cs
double Argument1
MethodName(out Argument1, ...)

// In C# 7.0, can declare variable directly while calling the method with 'out' parameter
MethodName(out type Argument1, ...)
product2.CalculateTax(out double p);
```

## Parameter Modifier (`in`)

- The "Argument" will be assigned into the "Parameter", but the **parameter becomes readonly**.
- Can't modify the value of parameter in the method; if you try to change, compile-time error will be shown.

```cs
// In Main
MethodName(in Argument1, ...)

// In Class
AccessModifier Modifier ReturnDataType MethodName(in DataType Parameter1, ...)
{
    ...
    Parameter1 = value; // error, can't change the value of parameter
}
```

## `ref` returns

- The reference of return variable will be assigned to receiving variable.

```cs

// In Class
class Student
{
    // public field
    public int grade = 2;

    // public method with ref return
    public ref int DoWork()
    {
        // return reference of 'grade' field
        return ref grade;
    }
}

// In Main
    static void Main()
    {
        ref int g = ref s.DoWork();
        g = 5;
        s.PrintGrade(); // 5
        Console.ReadKey();
    }
```

## Parameter Modifiers(`params`)

- All the set of arguments will be at a time received as an array into the parameter.
- The "params" parameter modifier can be used only for the last parameter of the method; and can be used only once for 1 method.
- Used when unsure of how many arguments will be received.

```cs
// In Main
MethodName(Argument1, Argument2, Argument3, ...)

// In Class
AccessModifier Modifier ReturnDataType MethodName(params DataType[] Parameter1, ...)
{
    ....
    Parameter1[index] // To access value based on index (can create for loop)
}
```




















