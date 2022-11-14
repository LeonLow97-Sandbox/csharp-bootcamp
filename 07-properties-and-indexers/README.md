# Properties and Indexers

## Creating Properties

- Receive the incoming value; validate the value; assign value into field.
    - Property = someValue;
    - Is the value valid?
        - If yes, assign value into field.
        - If no, skip the value (don't store the value into field).
- Property is a collection of 2 accessors (get-accessor and set-accessor).
- Prefix `_` underscore indicates that it is a private field.

|Get Accessor|Set Accessor|
|:-:|:-:|
|||

```cs
class Car
{
    // Declaration of Private Field
    private string _carBrand;

    public string CarBrand
    {
        // Validation & Initialization of Field
        set 
        {
            this._carBrand = value;     // E.g., CarBrand = value
        }

        // Returning value of field
        get 
        {
            return _carBrand;  // E.g., CarBrand
        }
    }
}
```

### Features and Advantages of Properties



