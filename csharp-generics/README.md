# C# Generics - Queue<T> Implementation

## Overview

This directory is dedicated to demonstrating the power and flexibility of generics in C# through a series of exercises involving a custom `Queue<T>` class. Generics allow for the creation of type-safe data structures without committing to actual data types, enhancing code reusability and reducing bugs.

## Detailed Project Descriptions

Each file in this directory builds upon a custom generic `Queue<T>` class, adding functionality and showcasing the versatility of generics in managing collections:

- **0-queue**
  - **Description**: Introduces the `Queue<T>` class that implements basic queue operations. The class also includes a method to check the type of the elements stored in the queue.
  
- **1-enqueue**
  - **Description**: Adds the `Enqueue` method to the `Queue<T>` class, allowing elements to be added to the queue. Each element is wrapped in a `Node` class instance, demonstrating nested class usage within generics.

- **2-dequeue**
  - **Description**: Implements the `Dequeue` method, which removes and returns the element at the front of the queue, showcasing how to handle potentially empty collections safely.

- **3-peek**
  - **Description**: Provides the `Peek` method that returns the element at the front of the queue without removing it, essential for observing the next item to be processed.

- **4-print**
  - **Description**: Adds a `Print` method that outputs each element in the queue, demonstrating iteration over custom generic collections.

- **5-concatenate**
  - **Description**: Features a `Concatenate` method that combines all elements into a single string, which is practical only for queues of type `String` or `Char`. This method emphasizes the importance of type constraints in generic methods.

## Compilation and Usage

To compile and run the projects within this directory, ensure that you have the .NET SDK installed on your machine. Use the following commands to build and execute the applications:

#```bash
cd path/to/project-directory
dotnet build
dotnet run

These commands compile the C# files and execute the resulting assembly, allowing you to test the functionalities of the generic Queue<T> class implemented across various scenarios.


### Part 4: Additional Information and Learning Outcomes
#```markdown
## Additional Information and Learning Outcomes

Through these projects, learners can gain a solid understanding of generics in C#, which are crucial for creating flexible and reusable code. The `Queue<T>` class exercises also serve as an excellent introduction to more complex data structure implementations and their practical applications in software development.

## Collaborators
Mico Bledsoe** - (www.linkedin.com/in/micobledsoe)
