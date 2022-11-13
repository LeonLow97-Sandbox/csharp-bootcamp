# Type Conversion

## Introduction to Type Conversion

- A process of converting a value from one type (source type) to another type (destination type).

## Implicit Casting

- The 'lower-numerical type' can be automatically (implicitly) converted into 'higher-numerical type'.
    - depends on number of bytes.

## Explicit Casting

- Manually converting a value from 1 data type to another data type, by specifying the destination data type within brackets, at left-hand side of the source value.
- **Loose Conversion**: If the _destination type is not sufficient-enough to store the converted value_, the value may loose.
- `(DestinationDataType) SourceValue`
- When to use?
    - At all cases of implicit casting.
    - At all cases of explicit casting.
    - Child class to Parent class.

## `Parse`

- The string value can be converted into any numerical data type, by using "Parsing" technique.
    - E.g., `string` --> `int`
- The source value must contain digits only, shouldn't contain spaces, alphabets, or special characters.
- If the source value is invalid, it raises `FormatException`.
- `DestinationDataType.Parse(SourceValue)`

```cs
    static void Main(string[] args)
    {
        // string
        string a = "100";

        // int
        int b;

        // string to int
        b = int.Parse(a);

        Console.WriteLine(a); // "100" as string
        Console.WriteLine(b); // 100 as int

        Console.ReadKey();
    }
```

## `TryParse`

- Same as parse but checks the source value before conversion.
- Is string value convertible to numerical type?
    - If yes, return true.
    - If no, return false.
- Avoid `FormatException`
- `bool variable = DestinationType.TryParse(SourceValue, out DestinationVariable);`
- If return false, `DestinationVariable` is 0.

## Conversion Methods

- Pre-defined method, which converts any primitive type (and also 'string') to any other primitive type.
    - E.g., string --> int and int --> string
- `System.Convert` is a class, which contains a set of pre-defined methods.
- It raises `FormatException`, if the source value if invalid.
- For each data type, we have a conversion method.
- All conversion methods are static methods.
- `type destinationVariable = Convert.ConversionMethod(SourceValue);`

# Summary

- For all the possible cases of 'implicit casting' and 'explicit casting', it is preferred to use 'explicit casting' or 'conversion methods' always.
- For conversion from 'string' to 'numerical type', use `TryParse`, instead of `Parse` as `TryParse` avoids exceptions.
- For conversion of value from any type to any type, use conversion method.













