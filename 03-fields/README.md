# Fields

# What are Fields?

- Variables that are declared in teh class; stored in the objects.

## `accessModifier` for field

- private (**default**)
- protected
- private protected
- internal
- protected internal
- public

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








