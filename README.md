# CSharpNUnitExercises

## Overview

This project is designed to help developers, especially those transitioning from a Java background, get familiar with .NET features using NUnit for testing. The exercises include implementing methods for various classes and structs, exploring concepts like source generators, structs, and required properties in .NET 8.

## Project Structure

- **BrokenCode.cs**: Contains intentionally broken methods. Fix these to pass the tests.
- **Geometry.cs**: Contains methods related to geometrical calculations involving structs.
- **MathOperations.cs**: Contains methods to perform various mathematical operations using C# libraries.
- **Numbers.cs**: Contains methods to calculate mathematical values like VAT, hypotenuse length, and Fibonacci numbers.
- **Person.cs**: A record used to demonstrate .NET 8 features like primary constructors and required properties.
- **Point.cs**: A struct representing a point in 2D space, used for geometrical calculations.
- **Properties.cs**: Contains methods for manipulating properties of a `Person` object.
- **StringUtilities.cs**: Contains methods for various string manipulations.

## Running the Tests

### Prerequisites

Ensure you have the .NET SDK and JetBrains Rider installed. You can download the .NET SDK from the [.NET download page](https://dotnet.microsoft.com/download) and Rider from the [JetBrains website](https://www.jetbrains.com/rider/).

### Instructions

1. **Clone the repository**:
   ```sh
   git clone https://github.com/tvergilio/CSharpNUnitExercises.git
   cd CSharpNUnitExercises
   ```

2. **Open the solution in Rider**:
   - Open JetBrains Rider.
   - Click on `Open` and select the `CSharpNUnitExercises` solution file (`CSharpNUnitExercises.sln`).

3. **Build the solution**:
   - In Rider, go to `Build` in the top menu and select `Build Solution`.

4. **Run the tests**:
   - In the Solution Explorer, right-click on the `Tests` project.
   - Select `Run Unit Tests` from the context menu.
   - Alternatively, you can run all tests by going to `Tests` in the top menu and selecting `Run Unit Tests`.

### Test Results

Most tests will fail initially, but this is intentional. The tests are designed to guide you through your implementation. As you implement the methods in the corresponding classes, more tests will pass. 

