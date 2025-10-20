# Reflection Example with NUnit

This project demonstrates how to use **Reflection** in C# to access and modify private members of a class, and how to validate this behavior using **NUnit** unit tests.

## Description

The goal of this project is to show how Reflection can be used to inspect and manipulate private properties of a class at runtime. This is useful in testing scenarios, frameworks, and advanced tooling.

---

## Project Structure

- **Person.cs**: Example class with a public property (`Name`) and a private property (`Age`).
- **PersonReflectionTests.cs**: Unit tests that use Reflection to access and modify the private `Age` property.

---

## What is Reflection?

[Reflection](https://learn.microsoft.com/en-us/dotnet/fundamentals/reflection/reflection) is a .NET feature that allows you to inspect and manipulate types, properties, methods, and fields at runtime, even if they are private or protected.

---

The tests use NUnit and Reflection to:

1. **Read the value of a private property (`Age`)**  
2. **Modify the value of a private property (`Age`) and verify the change**

## How to Run the Tests

1. Clone this repository.
2. Open the project in Visual Studio or your preferred IDE.
3. Restore NuGet packages if needed.
4. Run the tests using Visual Studio’s Test Explorer or the `dotnet test` command.

---

## Reference

- [Official .NET Reflection Documentation](https://learn.microsoft.com/en-us/dotnet/fundamentals/reflection/reflection)
