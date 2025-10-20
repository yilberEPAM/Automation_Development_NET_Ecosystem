# NUnit Dependency Injection Example

This project demonstrates how to use **Dependency Injection (DI)** in unit tests with **NUnit** and **Microsoft.Extensions.DependencyInjection**. The goal is to show how to set up a DI container in your test project and resolve dependencies for your test classes.

---

## Description

Dependency Injection is a design pattern that allows you to decouple your classes from their dependencies, making your code more modular, testable, and maintainable. In this project, we use DI to inject an implementation of the `ICalculator` interface into our unit tests.

---

## Project Structure

- **ICalculator.cs**: Interface that defines a simple addition method.
- **Calculator.cs**: Concrete implementation of the `ICalculator` interface.
- **CalculatorTests.cs**: NUnit test class that sets up a DI container and resolves the `ICalculator` dependency for testing.

---

## How Dependency Injection Works

We use the `Microsoft.Extensions.DependencyInjection` library to create a service container. In the test setup, we register the `ICalculator` interface and its implementation (`Calculator`). Before each test, we build the service provider and resolve the required service.

---

## How to Run the Tests

1. Clone this repository.
2. Open the project in Visual Studio or your preferred IDE.
3. Restore NuGet packages if needed.
4. Run the tests using Visual Studio’s Test Explorer or the `dotnet test` command.

---

## Reference

- [Microsoft Documentation: Dependency Injection in .NET](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection)
- [NUnit Documentation](https://nunit.org/)
