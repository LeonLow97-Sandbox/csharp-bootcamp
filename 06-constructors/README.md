# Constructors

- Constructor's name should be same as class name.
- Constructor is recommended to be 'public' member or 'internal' member
- Constructor can have 1 or more parameters.
- Constructor can't return any value; so no return type.
- A class can have 1 or more constructors,  but all constructors of the class must have different types of parameters.

## Instance Constructors

- Special method of class, which contains initialization logic of fields.
- Initialization of Fields.
- Constructor initializes the fields and also contains the additional initialization logic (if any).
- `modifier`: static

```cs
accessModifier modifier ClassName(parameter1, parameter2)
{
    Initialize Fields Here    
}
```

## Static Constructor

- Initializes static fields
- Uses `modifier` static.

|Instance Constructor|Static Constructor|
|:-:|:-:|
|Initializes instance fields|Initializes static fields|
|Executes automatically every time when a new object is created for the class.|Executes only once, i.e. when first object is created for the class or when the class is accessed for the first time during the execution of Main method.|
|`private` by default|`public` by default|
|Can use any of access modifiers|Access modifier can't be changed|
|Can contain any initialization logic, that should be executed every time when a new object is created for the class.|Can contain any initialization logic, that should be executed only *once* i.e. when a new object is created for the class.|
|can use `this` keyword|cannot use `this` keyword|

## Types of Constructor

|Parameter-less constructor|Parameterized constructor|
|:-:|:-:|
|Constructor without parameters|Constructor with 1 or more parameters|
|It generally initializes fields with some literal values (or) contains some general-initialization logic of object|Generally initializes fields by assigning values of parameters into fields.|

|Implicit Constructor (after compilation)|Explicit Constructor (while coding)|
|:-:|:-:|
|If there is a class without constructor, then the constructor automatically provides an empty constructor, while compilation, which initializes nothing. It is called as "Implicit Constructor" or "Default Constructor".|The constructor (parameter-less or parameterized) while is created by the developer is called as "Explicit Constructor"|
|To satisfy the rule "Class should have a constructor".|C# compiler doesn't provide any implicit constructor.|

## Constructor Overloading

- Writing multiple constructors with same name in the class, with different set of parameters (like method overloading).
- It is recommended to write a parameter-less constructor in the class, in case of constructor overloading.

## Object Initializer

- Special syntax to initialize fields / properties of class along with creating the object.
- Executes after the constructor.
- It is only for initialization of fields / properties, after creating object; it can't have any initialization logic.

```cs
// - `new Class()` --> Constructor --> Object Initializer
new ClassName() {field1 = value, field2 = value, ...}

Employee emp4 = new Employee() { empName = "Alfred", job = "Engineer" };
```

# Summary

- Instance constructor: initializes instant fields but also can access static fields.
- Static constructor: initializes static fields; can't access instance fields.
- Default (empty constructor) is provided automatically by C# compiler, if the developer creates a class without any constructor.
- Recommended to write a parameter-less constructor first, if you are creating parameterized constructor.
- Use 'object initializer' if you want to initialize desired fields of an object, as soon as a new object is created.








