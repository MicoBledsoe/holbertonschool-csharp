# C# Interfaces and Object Interaction

## Overview

This directory showcases various C# projects that explore the use of interfaces to define contracts for classes, enabling flexible and interchangeable object behaviors. Projects range from defining basic interfaces and abstract classes to implementing complex interactions using generic collections.

## Project Descriptions

Each file within this directory exemplifies different aspects of using interfaces in C# to facilitate interaction between objects:

- **0-abstract_thinking**
  - **Description**: Introduces an abstract class `Base` that includes a name property and an override of the ToString method, laying the groundwork for inheritance and implementation by other classes.

- **1-user_interface**
  - **Description**: Defines an interface `IInteractive` and applies it to a class, ensuring that all implementing classes provide a method for interaction.

- **2-doors**
  - **Description**: Expands on the previous project by creating a `Door` class that inherits from `Base` and implements the `IInteractive` interface to interact with the door (e.g., open and close actions).

- **3-decorations**
  - **Description**: Introduces a `Decoration` class that inherits from `Base` and implements multiple interfaces, demonstrating how a class can adhere to various contracts, enhancing its functionality and reuse.

- **4-keys**
  - **Description**: Adds a `Key` class that inherits from `Base` and implements the `ICollectable` interface, focusing on how objects can be made collectible in a game or application setting.

- **5-iterate_act**
  - **Description**: Develops a `RoomObjects` class that processes collections of interactive objects, showcasing how interfaces ensure that each object can be interacted with generically.

- **6-generic_iteration**
  - **Description**: Features a generic class `Objs<T>` that creates a collection of type-specific items, highlighting the use of generics along with interfaces to handle a variety of object types efficiently and flexibly.

## Compilation and Usage

To compile and run these projects, ensure you have the .NET SDK installed. Navigate to the specific project directory you wish to run, then use the following commands:

#```bash
dotnet build
dotnet run

These commands will compile the C# files and execute the application, enabling you to interact with the implementations and understand the practical applications of interfaces in C# programming.


### Part 4: Additional Information
#```markdown
## Additional Information

Interfaces are a crucial aspect of advanced C# programming, allowing developers to create systems that are modular and adaptable to change. These projects provide essential insights into designing systems where components can be easily tested, maintained, and extended over time.

## Collaborators
Mico Bledsoe** - (www.linkedin.com/in/micobledsoe)
