# Properties and Indexers

## Creating Properties

- Receive the incoming value; validate the value; assign value into field.
  - Property = someValue;
  - Is the value valid?
    - If yes, assign value into field.
    - If no, skip the value (don't store the value into field).
- Property is a collection of 2 accessors (get-accessor and set-accessor).
- Prefix `_` underscore indicates that it is a private field.

| Get Accessor | Set Accessor |
| :----------: | :----------: |
|              |              |

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

|                            Readonly property                            |                         Write-only property                          |
| :---------------------------------------------------------------------: | :------------------------------------------------------------------: |
|                     Contains ONLY **get-accessor**                      |                    Contains ONLY **set-accessor**                    |
| Reads & returns the value of field; but not modifies the value of field | Validates & assign incoming value into field; but not read the value |

```cs
// Readonly Property
accessModifier type PropertyName
{
    get
    {
        return field;
    }
}

// Write-only Property
accessModifier type PropertyName
{
    set
    {
        field = value;
    }
}
```

## Auto-Implemented Properties

- Property with no definition for set-accessor and get-accessor.
    - auto create these 2 accessors
    - useful only when you don't want to write any validation or calculation logic.
- Used to create property easily (with shorter syntax).
- Creates a private field (with name as `_propertyName`) automatically, while compilation-time.
- Auto-implemented property can be 'write-only' property (if only set-accessor created) or 'read-only' property (if only get-accessor created).

```cs
accessModifier modifier type propertyName
{
    accessModifier set; // field = value
    accessModifier get; // return field
}
```

```cs
// auto-implemented property
public string NativePlace { get; set; }

// setting internal accessModifier
public string NativePlace { internal get; set; }
// In Main
Console.WriteLine(emp1.NativePlace); // this is now not allowed
emp1.NativePlace = "New Delhi"; // this is allowed
```
