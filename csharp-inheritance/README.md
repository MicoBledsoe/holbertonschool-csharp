# C# Inheritance and Polymorphism

## Overview

This directory contains projects that explore the fundamental concepts of inheritance and polymorphism in C#. The exercises demonstrate how classes can inherit properties and methods from other classes, how to override inherited methods, and how to check object types and properties dynamically.

## Project Descriptions

Each file in this directory highlights different aspects of inheritance and polymorphism through simple yet insightful C# classes:

- **0-is**
  - **Description**: Checks if the given object is of type `int`.

- **1-instance**
  - **Description**: Checks if the object is an instance of a specified class or a subclass thereof.

- **2-subclass**
  - **Description**: Determines if a given class is a subclass of another class.

- **3-type_get**
  - **Description**: Uses reflection to print the names of the properties and methods of any object.

- **4-inherit**
  - **Description**: Defines an empty class `Dog` that inherits from another empty class `Animal`.

- **5-shape**
  - **Description**: Introduces a base class `Shape` with a method that throws an exception indicating the method is not implemented.

- **6-shape**
  - **Description**: Implements a `Rectangle` class that inherits from `Shape` and includes properties like width and height.

- **7-shape**
  - **Description**: Extends the `Rectangle` class functionality to override the inherited method and handle dimensions correctly.

- **8-shape**
  - **Description**: Adds a `Square` class that inherits from `Rectangle` and demonstrates proper use of polymorphism.

- **9-shape**
  - **Description**: Further develops the `Square` class to correctly implement methods to adjust the size of the square and to calculate its area.

Each project is carefully designed to build upon the previous one, gradually introducing more complex scenarios and deeper understanding of how inheritance works in C#.

## Compilation and Usage

Ensure you have the .NET SDK installed on your computer to work with these projects. To compile and run a project, navigate to the project directory and use the following commands:

#```bash
dotnet build
dotnet run

This will compile the C# files and execute the application, allowing you to see the implementation of inheritance and polymorphism in action.


### Part 4: Additional Information
#```markdown
## Additional Information

Understanding inheritance and polymorphism is crucial for designing robust and maintainable object-oriented applications. These concepts allow for the creation of a more organized and modular codebase, where common behaviors can be defined once and used by multiple subclasses, reducing redundancy and increasing code reusability.

## Collaborators
Mico Bledsoe** - (www.linkedin.com/in/micobledsoe)
