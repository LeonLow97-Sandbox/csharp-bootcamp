# Create C# Project in VS Code

- `dotnet new console -o <project_name>`

# .NET

## What is .NET?

- Application Development Platform, to build Desktop, Web and Mobile Apps.
- Developed by Microsoft.
- Provides fully managed, secured application execution environment.
- Supports multiple languages like C#.

## Why .NET?

- Secured execution environment.
- Wide variety of applications and languages.
- Code re-usability.

## Modules of .NET

- ASP.NET
    - Web Sites
        - Static Content (just display information)
    - Web Applications
        - Dynamic Content (Social networking website, E-Commerce, news website)
    - Web Services
        - re-usable programs on the web (accessible among multiple applications within the same organization.)
- C#.NET
    - Windows GUI Applications
    - Windows Services
        - Background process application. E.g., continuously sending mails to customers.
    - Console Applications

## CLI (Common Language Infrastructure)

- Application Source Code
    - Source Code written by the developer
    - Uses C#.NET / VB.NET
- Compiler
    - IL. Language-Neutral language which can't be executed by machine (Microsoft Intermediate Language)
    - Applications should be executed in a common way.
    - Converting source code to a common language.
    - C# compiled into a `.exe` file (intermediate language code).
- CLR (Common Language Runtime)
    - Execution Engine of all .NET Modules.
- Native Machine Code
    - Operating System: specific machine language.

## CLR (Common Language Runtime)

- "Execution Engine" for all .NET languages.
- Code-Execution Environment that executes all types of .NET applications.
- Applications developed in any .NET language runs based on "CLR" only.
- CLR is part of .NET framework; pre-installed in Windows.

#### Components of CLR

1. Class Loader
    - Loading classes from compiled source code to memory.
    - Loads a class, when it is needed (before creating object).
2. Memory Manager
    - Allocating necessary memory for objects
    - When an object is created in the code, certain amount of memory will be allocated for the object in application's "heap".
3. Garbage Collector:
    - Freeing (deleting) memory of objects.
    - Identifies all unreferenced objects and delete them in memory (RAM).
4. JIT (Just-In-Time) Compiler:
    - Convert the MSIL (intermediate language) Code into Native Machine Language.
    - Compiled the code of a class, when it is needed (before executing that particular class).
    - Every OS has it's own native machine language. Native machine language is then executed by the hardware.
    - Converts after class loader is done.
5. Exception Manager:
    - Raise notifications while run-time errors.
    - Creates exception logs.
6. Thread Manager:
    - Create threads (background process) to execute the code.
    - The entire program is treated as "Main Thread".
    - Developer can create sub threads (child threads) to do background processes.
7. Security Manager:
    - Verifies whether the application has permission to access system resources or not.
    - Before executing the application, it verifies whether the application has not been attacked by malicious programs & has necessary permissions to access files / folders and hardware resources.

## .NET Framework Architecture

- Consists of:
    1. CLR (Common Language Runtime)
        - Runtime Engine that is used to execute .NET applications.
    2. FCL (Framework Class Library)
        - Object-Oriented Collection of Classes that are used to develop applications.
        - Pre-defined classes. (E.g., `Console`)
- Common Language Specification
    - Win Forms
    - ASP.NET
    - WPF
    - Others...
- ADO.NET
    - for database connections
- Base Class Library
- Common Language Runtime

#### Base Class Library

- Contains a set of pre-defined classes that can be used in all types of .NET applications & languages for *general I/O Operations, type conversion, creation of threads* etc.
    - E.g., Console, String, StringBuilder

#### ADO.NET

- Contains a set of pre-defined classes that can be used in all types of .NET applications & languages for *connecting to databases, retrieving data from databases, inserting, updating, deleting rows* etc.
    - E.g., SqlConnection, SqlCommand

#### Win Forms

- Contains a set of pre-defined classes that can be used in *Windows GUI applications* for development of GUI elements such as form, textbox, button, checkbox, radio button, dropdownlist etc.
    - E.g., Form, Label, Button, Textbox

#### WPF

- Contains a set of pre-defined classes that can be used in *Rich Windows GUI applications* for development of GUI elements such as form, textbox, button, checkbox, radio button, dropdownlist etc.
    - E.g., Window, Label, Button, Textbox

#### ASP.NET

- Contains a set of pre-defined classes that can be used in *Web Applications* for development of GUI elements such as form, textbox, button, checkbox, radio button, dropdownlist etc.
    - E.g., Page, Label, Button, Textbox

#### Common Language Specification (CLS) 

- Contains a set of rules (concepts) that are common to all .NET languages such as C#.NET, VB.NET etc.
- Common rules of CLS:
    - CTS (Common Type System): Contains data types such as Int32, Int64, Single, Double etc.
    - Classes & Objects
    - Reference Variables
    - Method Parameters
    - Generics

## .NET 3.0 Features

- WPF (Windows Presentation Foundation):
    - Framework to develop rich Windows GUI Apps.
- WCF (Windows Communication Foundation):
    - Framework to develop Service Oriented Applications (SOA).
- WWF (Windows Workflow Foundation) 
    - Framework to develop task automation and transactions using workflows.

## Overview of .NET Core

- .NET Framework and .NET Core.
- .NET Core is Microsoft's Application Development Platform to develop any desktop, web, mobile and embedded (IoT) applications.
- Supports Windows, Linux, Mac, Android, ioS, Windows Phone devices
- Mainly used in Xamarin (mobile dev) and ASP.NET Core (web dev).
- Open Source (via MIT license)
- Contains the class library, which is a *subset of .NET Framework*.
- C#/VB.NET can be used for writing code of .NET Core.

## What is C#.NET?

- OOP Language
- Case Sensitive
- Strongly-Typed Language
- Compiler-based Language
- Compiled based on CLI; Executed by CLR.

# Namespaces

- Namespace is a collection of classes
- The goal of namespace is to group-up the classes that are meant for specific purpose.
- Can access the class of a namespace by using:
    - `namespace.class`
```cs
// Garage.Car
namespace Garage
{
    class Car {

    }
}
```

# Naming Conventions

|Naming Conventions|Description|
|:-:|:-:|
|camelCase|For all local variables, parameters|
|PascalCase|For all class names, structure names, namespace names, field names, method names, property names.|
|IPascalCase|For all interface names|
|_camelCase|For all private fields|






































