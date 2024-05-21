# CSharpNUnitExercises

## Overview

This project is designed to help developers, especially those transitioning from a Java background, get familiar with .NET features using NUnit for testing. The exercises include implementing methods for various classes and structs, exploring concepts like source generators, structs, and required properties in .NET 8.

## Project Structure

- **BrokenCode.cs**: Contains intentionally broken methods. Developers need to fix these to pass the tests.
- **Geometry.cs**: Contains methods related to geometrical calculations involving structs.
- **MathOperations.cs**: Contains methods to perform various mathematical operations using C# libraries.
- **Numbers.cs**: Contains methods to calculate mathematical values like VAT, hypotenuse length, and Fibonacci numbers.
- **Person.cs**: A record used to demonstrate .NET 8 features like primary constructors and required properties.
- **Point.cs**: A struct representing a point in 2D space, used for geometrical calculations.
- **Properties.cs**: Contains methods for manipulating properties of a `Person` object.
- **StringUtilities.cs**: Contains methods for various string manipulations.

## Running the Tests

### Prerequisites

Ensure you have the .NET SDK installed. You can download it from the [.NET download page](https://dotnet.microsoft.com/download).

### Instructions

1. **Clone the repository**:
   ```sh
   git clone https://github.com/tvergilio/csharp-nunit-exercises.git
   cd CSharpNUnitExercises
   ```

2. **Build the solution**:
   ```sh
   dotnet build
   ```

3. **Run the tests**:
   ```sh
   dotnet test
   ```

## Notes

- Each test class is designed to guide you through the process of implementing the corresponding methods.
- Focus on understanding the .NET features highlighted in each class.
- Use the tests to verify your implementation and ensure correctness.

