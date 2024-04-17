# C# Text-Based Inventory Management System

## Overview

This directory contains a comprehensive inventory management system developed as a console application in C#. The project utilizes object-oriented principles and data serialization to manage and store inventory data effectively, providing a functional and user-friendly text-based interface.

## Project Components

This inventory management system is broken down into several components, each serving a specific function within the application:

- **InventoryLibrary**
  - **Description**: Contains the core classes and methods for the inventory management system, including item definitions, inventory operations, and data handling logic.

- **InventoryManager**
  - **Description**: A console application that serves as the user interface for interacting with the inventory system. It allows users to add, delete, and manage inventory items through text commands.

- **storage**
  - **Description**: Handles data persistence by serializing inventory data to a file and deserializing it back into objects when the application starts. This ensures that inventory data is maintained between sessions.

- **InventoryManagement.Tests**
  - **Description**: Includes unit tests for the application, ensuring that all functionalities are correctly implemented and that changes do not break existing features.

- **InventoryManagement.sln**
  - **Description**: The solution file that organizes the projects and dependencies within the Visual Studio environment.

Each component is designed to work together seamlessly, providing a robust system for managing inventory through a simple text-based interface.

## Compilation and Usage

To compile and run this project, ensure you have the .NET SDK and Visual Studio (or a similar IDE that supports C# and .NET development) installed. Follow these steps:

1. Navigate to the project root directory.
2. Open the `InventoryManagement.sln` file with Visual Studio.
3. Build the solution to compile all the projects.
4. Run the `InventoryManager` project to start the text-based interface.

#```bash
dotnet run --project InventoryManager

This will launch the console application, where you can interact with the inventory system using the provided commands.


### Part 4: Additional Information
#```markdown
## Additional Information

This project exemplifies practical C# development, covering aspects like object-oriented programming, data serialization, unit testing, and the creation of user interfaces in console applications. It serves as an excellent case study in building comprehensive systems with C#.

## Collaborators
Mico Bledsoe** - (www.linkedin.com/in/micobledsoe)
