# C# Structs and Enums

## Overview

This directory contains projects that explore the use of structures (`structs`) and enumerations (`enums`) in C#. These C# data types provide a way to represent data that can be grouped together, like the attributes of an object, and to define a variable that can hold a set of named constants.

## Project Descriptions

Each file in this directory is dedicated to practical applications of structs and enums:

- **0-dog**
  - **Description**: Defines a `Dog` struct with basic attributes like name and age.
  
- **1-dog**
  - **Description**: Expands the `Dog` struct by adding additional members to enhance its representation.

- **2-dog**
  - **Description**: Introduces a constructor to the `Dog` struct, allowing for the initialization of its fields when creating an instance.

- **3-dog**
  - **Description**: Implements a method within the `Dog` struct that prints all of the dog's attributes to the standard output, demonstrating how methods can be used within structs to manipulate or display data.

These projects incrementally build on the concept of structs, starting from simple definitions to more complex implementations that include constructors and methods.

## Compilation and Usage

To work with these projects, make sure the .NET SDK is installed on your machine. Navigate to the specific project directory you wish to compile and run, then use the following commands:

#```bash
dotnet build
dotnet run

These commands compile the C# files and execute the application, allowing you to see how structs operate in practice, how they can be initialized, and how they differ from classes.


### Part 4: Additional Information
#```markdown
## Additional Information

Understanding the use of structs and enums in C# is crucial for writing efficient code in scenarios where immutability and value-type semantics are important. Structs, particularly, are useful in high-performance applications where the overhead of reference types (like objects) is costly.

## Collaborators
Mico Bledsoe** - (www.linkedin.com/in/micobledsoe)
