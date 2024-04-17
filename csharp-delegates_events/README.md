# C# Delegates and Events

## Overview

This directory contains a series of projects focused on understanding and implementing delegates and events in C#. Delegates and events are fundamental for designing extensible and flexible applications in C# by enabling a publisher/subscriber model that facilitates communication between objects.

## Projects Description

Each project in this directory is designed to demonstrate a specific aspect of delegates and events in the C# programming language:

- **0-universal_health**
  - **Description**: Defines a public class `Player` with a health system. It demonstrates basic class construction with health attributes.
  - **Functionality**: Initializes player health and provides feedback if the initial health is set below zero.

- **1-damage_delegation**
  - **Description**: Introduces a delegate `CalculateHealth` that manages modifications to the player's health.
  - **Functionality**: Allows external methods to affect the player's health through a delegate, illustrating the concept of encapsulation and separation of concerns.

- **2-validation**
  - **Description**: Adds validation to ensure the player’s health changes do not set the health below zero or above the maximum without applying changes.
  - **Functionality**: Demonstrates defensive programming by validating changes before applying them to ensure the player's health remains within logical bounds.

- **3-modified_behavior**
  - **Description**: Incorporates an enumeration `Modifier` with values Weak, Base, Strong to affect the player's health changes.
  - **Functionality**: Uses enums in conjunction with delegates to apply different health modification strategies.

- **4-check_yourself**
  - **Description**: Implements a new class `CurrentHPArgs` that inherits from `EventArgs` to pass event data.
  - **Functionality**: Enhances the event system by allowing custom data to be passed when events are triggered, providing more detailed context during event handling.

- **5-eventful**
  - **Description**: Adds a method `HPValueWarning` inside the `Player` class to trigger events based on health status.
  - **Functionality**: Utilizes events to notify other parts of the program when the player's health reaches critical levels, demonstrating how events can be used to monitor state changes within an object.

## Compilation and Usage

To work with these projects, ensure you have the .NET SDK installed and your development environment set up for C# development. Here’s how you can compile and run any of the projects:

Navigate to the project directory:
#```bash
cd csharp-delegates_events/<project_folder>

dotnet build
dotnet run

This compiles the C# files and executes the resulting application, allowing you to see delegates and events in action.


### Part 4: Additional Information
#```markdown
## Additional Information

Understanding delegates and events is crucial for advanced C# programming, particularly when building applications that require components to communicate efficiently without being tightly coupled. These projects provide foundational knowledge and practical experience in using these features effectively.

## Collaborators
Mico Bledsoe** - (www.linkedin.com/in/micobledsoe)
