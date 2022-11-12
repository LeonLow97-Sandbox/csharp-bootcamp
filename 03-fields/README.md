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








