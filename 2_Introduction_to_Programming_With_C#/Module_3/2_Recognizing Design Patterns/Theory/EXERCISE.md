# Activity: Recognizing Design Patterns

## Objective

Recognize and describe common design patterns in object-oriented programming.

## Description

This activity provides code examples where participants must identify common design patterns, such as Singleton, Factory, Adapter, and Observer. The examples will illustrate how these patterns solve specific problems in software design. After the examples, learners will analyze additional code snippets to recognize the patterns used.

---

## Example 1: Singleton Pattern

### Code Example

The following code ensures that a class has only one instance and provides a global point of access.

```csharp
public class Database
{
    private static Database instance;
    private static readonly object lockObject = new object();

    // Private constructor prevents instantiation from other classes
    private Database() { }

    public static Database GetInstance()
    {
        if (instance == null)
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new Database();
                }
            }
        }
        return instance;
    }

    public void Connect()
    {
        Console.WriteLine("Database connected.");
    }
}

public class Program
{
    public static void Main()
    {
        Database db1 = Database.GetInstance();
        Database db2 = Database.GetInstance();

        db1.Connect();
        Console.WriteLine(object.ReferenceEquals(db1, db2)); // Outputs: True
    }
}
```

### Identify the Pattern

- **Pattern:** Singleton
- **Description:** The Singleton pattern restricts the instantiation of a class to one "single" instance and provides a global point of access to it.
- **Explanation:**
  - The `Database` class contains a private static instance variable and a private constructor to prevent multiple instances.
  - The `GetInstance()` method ensures that only one instance of `Database` is created using a double-check locking mechanism.
  - This pattern is useful for managing shared resources, like database connections, where only one instance should exist.

**Code File:** See [Example1_Singleton.cs](Examples/Example1_Singleton.cs)

---

## Example 2: Adapter Pattern

### Code Example

This code demonstrates converting an interface of a class into another interface clients expect.

```csharp
// Target interface
public interface ITarget
{
    void Request();
}

// Adaptee class
public class Adaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("Specific request is called.");
    }
}

// Adapter class
public class Adapter : ITarget
{
    private Adaptee adaptee;

    public Adapter(Adaptee adaptee)
    {
        this.adaptee = adaptee;
    }

    public void Request()
    {
        // Convert the interface of Adaptee to the Target interface
        adaptee.SpecificRequest();
    }
}

public class Program
{
    public static void Main()
    {
        Adaptee adaptee = new Adaptee();
        ITarget target = new Adapter(adaptee);

        target.Request(); // Outputs: Specific request is called.
    }
}
```

### Identify the Pattern

- **Pattern:** Adapter
- **Description:** The Adapter pattern allows incompatible interfaces to work together by wrapping an existing class with a new interface.
- **Explanation:**
  - The `Adapter` class implements the `ITarget` interface and contains an instance of the `Adaptee` class.
  - The `Request()` method in `Adapter` converts calls to `SpecificRequest()` from the `Adaptee`.
  - This pattern is useful when integrating third-party libraries that do not match the expected interface.

**Code File:** See [Example2_Adapter.cs](Examples/Example2_Adapter.cs)

---

## Problems to Complete

### Problem 1

Identify the design pattern used in this code:

```csharp
public abstract class Animal
{
    public abstract void Speak();
}

public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Woof!");
    }
}

public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Meow!");
    }
}

public class AnimalFactory
{
    public static Animal CreateAnimal(string type)
    {
        if (type == "Dog")
        {
            return new Dog();
        }
        else if (type == "Cat")
        {
            return new Cat();
        }
        else
        {
            throw new ArgumentException("Invalid animal type");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Animal dog = AnimalFactory.CreateAnimal("Dog");
        dog.Speak(); // Outputs: Woof!

        Animal cat = AnimalFactory.CreateAnimal("Cat");
        cat.Speak(); // Outputs: Meow!
    }
}
```

### Instructions

1. Identify the design pattern used in the code above.
2. Describe how this pattern helps to solve the problem.

**Code File:** See [Problem1_Factory.cs](Problems/Problem1_Factory.cs)

---

### Problem 2

Identify the design pattern used in this code:

```csharp
public interface IObserver
{
    void Update(string message);
}

public class ConcreteObserver : IObserver
{
    private string name;

    public ConcreteObserver(string name)
    {
        this.name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{name} received message: {message}");
    }
}

public class Subject
{
    private List<IObserver> observers = new List<IObserver>();

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify(string message)
    {
        foreach (var observer in observers)
        {
            observer.Update(message);
        }
    }
}

public class Program
{
    public static void Main()
    {
        Subject subject = new Subject();

        IObserver observer1 = new ConcreteObserver("Observer 1");
        IObserver observer2 = new ConcreteObserver("Observer 2");

        subject.Attach(observer1);
        subject.Attach(observer2);

        subject.Notify("Hello, Observers!");
    }
}
```

### Instructions

1. Identify the design pattern used in the code above.
2. Explain how this pattern is useful in real-world scenarios.

**Code File:** See [Problem2_Observer.cs](Problems/Problem2_Observer.cs)
