# Activity: Recognizing Design Patterns - Answer Key

## Problem 1: Factory Pattern

- **Pattern:** Factory
- **Description:** The Factory pattern provides a way to create objects without specifying the exact class of the object. It uses a method to encapsulate the instantiation of objects, making the code more flexible.
- **Explanation:**
  - The `AnimalFactory` class contains a method `CreateAnimal()` that returns an instance of `Dog` or `Cat` based on the provided string.
  - This pattern is useful for cases where the client code should not be responsible for the concrete class instantiation.

---

## Problem 2: Observer Pattern

- **Pattern:** Observer
- **Description:** The Observer pattern defines a one-to-many relationship between objects. When one object (the subject) changes state, it notifies all registered observers.
- **Explanation:**
  - The `Subject` class manages a list of `IObserver` instances and notifies them of changes.
  - This pattern is beneficial in scenarios like implementing event handling, where multiple objects need to be updated in response to an event.
