# Syntax of C# Program

- Main: Starting Point of Program Execution
- Main Method should be `static` method.
- A `static` method can be executed without creating any object for the class.
- Main method should return `void`.
- `void` is a keyword that specifies that the method does not return any value to the caller.
```cs
class ClassName
{
    static void Main()
    {

    }
}
```

## `System.Console.WriteLine`

```java
class Test
{
    static void Main()
    {
        System.Console.WriteLine("Hello Leon");
        System.Console.ReadKey();
    }
}
```

## `System.Console` class

- The `Console`is a class in `System` namespace, which provided a set of properties and methods to perform I/O operations in Console Applications (Command-Prompt Applications).
- It is a static class. So all the members of `Console` class are accessible without creating any object for the `Console` class.

## Members of `Console` Class

- `void Write(value)`: receives a value as parameter and displays the same value in Console.
- `void WriteLine(value)`: same as `Write` method but moves the cursor to the next line, after the value.
- `void ReadKey()`: waits until the user presses any key on the keyboard. Makes the console window wait for user's input.
- `void Clear()`: clears the console window. After clearing the screen, can display output again, using `Write()` or `WriteLine()` methods.
- `string ReadLine()`: accepts a string value from keyboard (entered by user) and returns the same. Always returns the value in `string` type only. Even numbers (digits) are treated as strings.

# Variables

- Variable is a named memory location in RAM, to store a particular type of value, during the program execution.
- All variables will be stored in **Stack**.
- For every method call, a new *Stack* will be created.
- The stack (along with the variables) will be deleted automatically, at the end of the method execution.

```cs
// Syntax
DataType VariableName

// Declaration with Initialization
DataType VariableName = value;

// Set value into Variable (after declaration)
VariableName = value;
```

- Variable name should not contain spaces and special characters (except underscore).

# Primitive Types

- "Type" specifies what type of value to be stored in memory
    - E.g., `int`, `string`, etc.
- "Non-Primitive" Types: string, Classes, Interfaces, Structures, Enumerations
- "Primitive" Types: int, long, byte, double, char, bool.
- `int.MinValue`, `int.MaxValue`

## Non-Numerical Data Types

- "char"
    - default value: \0
- "string"
    - default value: null
- "bool"
    - default value: false
- Default Literals: can get the default value of respective type using the following syntax:
    - `default(type)`
    - E.g., `default(int) = 0`

# Arithmetical Operators

|Operators|Description|
|:-:|:-:|
|+|Addition|
|-|Subtraction|
|*|Multiplication|
|/|Division|
|%|Remainder|
|=|Assigns to|
|+=|Add and Assigns to|
|-=|Subtract and Assigns to|
|*=|Multiple and Assigns to|
|/=|Divide and Assigns to|
|%=|Remainder Assigns to|

|Increment/Decrement Operators|Description|
|:-:|:-:|
|n++|**Post-Increment** (First it returns value, then increments)|
|++n|**Pre-Increment** (First it increments value, then returns)|
|n--|**Post-Decrement** (First it returns value, then decrements)|
|--m|**Pre-Decrement** (First it decrements value, then returns)|

# Comparison Operators

|Operators|Description|
|:-:|:-:|
|==|equal to|
|!=|not equal to|
|<|less than|
|>|greater than|
|<=|less than or equal to|
|>=|greater than or equal to|

# Logical Operators

|Operator|Description|
|:-:|:-:|
|`&&`|And (Both conditions must be true)|
|`||`|Or (Any one of the conditions must be true)|
|`!`|Not (Given condition will be reverse)|
|`^`|Logical Exclusive Or - XOR (Any one operand must be true) Evaluates both operands. If both are true, returns false.|

# Concatenation Operator

- `+` operator

# Ternary Conditional Operator

```cs
// Syntax
(condition) ? consequent : alternative
```

```cs
// Ternary Operator
int age = 20;
string title = (age < 13) ? "Child" : (age >= 13 && age <= 19) ? "Teenager" : "Adult";
System.Console.WriteLine(title); // adult
```

# `switch-case`

- Used to check a variable value, whether it matches with any one of the list of values.
- Among all cases, only one will execute.
- If all cases are not matched, it executes the "default case".

```cs
switch(variable) {
    case value1: statement1; break;
    case value2: statement2; break;
    case value3: statement3; break;
    ...
    default: statement; break;
}
```

# `while` loop

```cs
// Syntax: while

initialization;
while (condition)
{
    // while block
    increase / decrease here
}
```

# `do-while` loop

```cs
// Syntax: do-while
do 
{
    do-while block
    increase/decrease here
} while (condition)
```

# `for` loop

```cs
for (initialization; condition; increment) 
{
    for block
}
```

# `break` keyword

```cs
for (initialization; condition1; increment) {
    if (condition2) {
        break;
    }
    // for block code here
}
```

# `continue` keyword

```cs
for (initialization; condition1; increment) {
    if (condition2) {
        continue;
    }
    // for block code here
}
```










































