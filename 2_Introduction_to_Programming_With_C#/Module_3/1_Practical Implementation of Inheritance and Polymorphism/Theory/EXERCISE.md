# Activity: Practical Implementation of Inheritance and Polymorphism

## Objective

Implement inheritance and polymorphism in C# by creating base classes, derived classes, and interfaces.

## Description

This activity guides you through creating an application that demonstrates key object-oriented programming concepts: inheritance (base and derived classes), polymorphism (virtual and override keywords), and interfaces.

## Set Up Your Environment

Use the Visual Studio Code console application you created at the start of the course. Remove any existing code in the `Program.cs` file of your console application and create all the code in each step in that file.

---

## Step 1: Preparing the Application

You'll create a small application using the Visual Studio Code console application you created at the start of the course.

---

## Step 2: Creating a Base Class and Derived Classes

Create a base class called `Animal` and two derived classes `Dog` and `Cat`. This introduces you to the concept of inheritance, where `Dog` and `Cat` inherit properties and methods from `Animal`.

### Instructions

1. Define a base class `Animal` with a virtual method `MakeSound`.
2. Create two derived classes `Dog` and `Cat` that inherit from `Animal`.
3. Override the `MakeSound` method in each derived class.

---

## Step 3: Using the virtual and override Keywords

Explore how to call methods in a base class you created using the `virtual` and `override` keywords.

### Instructions

1. Above any existing classes in `Program.cs`, create a `Program` class.
2. In the `Program` class, create a `Main` method.
3. In the `Main` method, create instances of the `Dog` and `Cat` classes and then call the `MakeSound` method from instances of `Dog` and `Cat`.
4. To check your answer, run the Visual Studio Code console application.

---

## Step 4: Implementing Interfaces

Introduce interfaces to define a contract that classes can implement. Interfaces allow us to specify a set of methods that different classes must have.

### Instructions

1. Above any existing classes in `Program.cs`, define an interface called `IAnimal` with a method `Eat`.
2. Implement this interface in the `Animal` class and provide an implementation in the `Dog` and `Cat` classes.

---

## Step 5: Using the Interface

Explore how to call the interface methods from your main program.

### Instructions

1. In the `Main` method, underneath the existing method calls, call the `Eat` method from instances of `Dog` and `Cat`.
2. To check your answer, run the Visual Studio Code console application.

---

## Step 6: Polymorphism with Lists of Base Types and Interfaces

Use polymorphism to interact with objects of different classes through a common base type or interface. This allows us to call methods on different objects in a unified way.

### Instructions

1. Update the `Main` method by creating a list of `Animal` objects that includes instances of `Dog` and `Cat`.
2. Use a loop to call the `MakeSound` method on each object in the list.
3. To check your answer, run the Visual Studio Code console application.
