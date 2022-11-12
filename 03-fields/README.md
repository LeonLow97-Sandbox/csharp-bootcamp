# Fields

# What are Fields?

- Variables that are declared in teh class; stored in the objects.

## Add ClassLibrary into Main Application

- Right click solution of Main Application
- Add New Project (Select class library not console)
- Reference (ref to the class library)
- Thus, now fields in ClassLibrary are accessible in the main console application.
- Ensure that the class is `public` to be accessible to the main console.

```cs
public class Product
{
    // Fields
    public int productID;
    public string productName;
    public double cost;
    public int quantity;
}
```

## `accessModifier` for field

- Access Modifier specifies the accessibility of fields, where the fields can be accessible, they provide security for the fields.
- Access Modifiers in C#:
    - private (**default**)
    - protected
    - private protected
    - internal
    - protected internal
    - public

|Access Modifier|In the same class|In the child classes at the same assembly|In the other classes at the same assembly|Child classes at other assembly|Other classes at other assembly|
|:-:|:-:|:-:|:-:|:-:|:-:|
|private|Yes|No|No|No|No|
|protected|Yes|Yes|No|Yes|No|
|private protected|Yes|Yes|No|No|No|
|internal|Yes|Yes|Yes|No|No|
|protected internal|Yes|Yes|Yes|Yes|No|
|public|Yes|Yes|Yes|Yes|Yes|

```cs
// DomesticProduct class is the 'child' and Product class is the 'parent'
public class DomesticProduct:Product
{

}
```

## Static Fields

- Static fields are stored outside the object (inside Class Memory in Heap).
- Static fields are common to all objects of a class.
```cs
class BankAccount 
{
    long accountNumber
    string accountHolderName;
    double currentBalance;
    static string bankName; // bankName is common for all objects
}
```

||Instance Fields|Static Fields|
|:-:|:-:|:-:|
|Storage|Stored in Objects|Stored in Class's memory|
|Related To|Represents data related to objects|Represents common data that belongs to all objects.|
|Declaration|Declared without "static" keyword|Declared with "static" keyword.|
|Accessible With|Accessible with object (through reference variable)|Accessible with class name only (not with object)|
|Memory Allocation|Allocated separately for each object, because instance fields are stored "inside" the objects.|Allocated only once for the entire program; i.e., when the class is used for the first time while executing the program.|

## Constant Fields (`const` keyword)

- Constant Fields are like static fields, that are common to all objects of the class.
- Can't change the value of constant field.
- Constant Fields are accessible with class name [not with object].
- Constant Fields are not stored in the object; will not be stored anywhere.
- Constant Fields will be replaced with its value, while compilation; so it will not be stored anywhere in memory.
- Constant Fields must be initialized, in line with declaration (with a literal value only).
- Constants can also be declared as 'local constants' (in a method).

```cs
// Syntax of Constant Fields
AccessModifier const type FieldName = value;
```

## Readonly Fields (`readonly` keyword)

- Readonly Fields are like instance fields, that is stored in every object, individually.
- Can't change the value of readonly field.
- Readonly Fields are accessible with reference object [with object].
- Readonly Fields must be initialized, either "in-line" with declaration" or "in the constructor".

```cs
// Syntax of readonly Fields
AccessModifier readonly DataType FieldName = value;
```

# Summary

- Fields are variables that are declared in the class; but stored in objects.
- Access modifiers of fields: private, protected, private protected, internal, protected internal, public.
- Modifiers of fields: static, const readonly.
- Instance fields are individual for each object; Static fields are common (one-time) for all objects.
- Constants must be initialized along with declaration; Readonly fields must be initialized either 'along with declaration' or in 'instance constructor'.










