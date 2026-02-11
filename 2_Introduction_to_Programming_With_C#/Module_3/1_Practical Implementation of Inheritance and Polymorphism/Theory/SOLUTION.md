# Activity: Practical Implementation of Inheritance and Polymorphism - Answer Key

## Step 2: Creating a Base Class and Derived Classes

```csharp
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic animal sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}
```

**Code File:** See [Step2_AnimalClasses.cs](Steps/Step2_AnimalClasses.cs)

---

## Step 3: Using the virtual and override Keywords

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        Dog myDog = new Dog();
        Cat myCat = new Cat();

        myDog.MakeSound(); // Should print "Bark"
        myCat.MakeSound(); // Should print "Meow"
    }
}
```

---

## Step 4: Implementing Interfaces

```csharp
public interface IAnimal
{
    void Eat();
}

public class Animal : IAnimal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic animal sound");
    }

    public void Eat()
    {
        Console.WriteLine("Some generic animal food");
    }
}

public class Dog : Animal
{
    public void Eat()
    {
        Console.WriteLine("Kibble");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

public class Cat : Animal
{
    public void Eat()
    {
        Console.WriteLine("Tuna");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}
```

**Code File:** See [Step4_AnimalWithInterface.cs](Steps/Step4_AnimalWithInterface.cs)

---

## Step 5: Using the Interface

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        Dog myDog = new Dog();
        Cat myCat = new Cat();

        myDog.MakeSound(); // Should print "Bark"
        myCat.MakeSound(); // Should print "Meow"

        myDog.Eat(); // Should print "Kibble"
        myCat.Eat(); // Should print "Tuna"
    }
}
```

---

## Step 6: Polymorphism with Lists of Base Types and Interfaces

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();
        animals.Add(new Dog());
        animals.Add(new Cat());

        foreach (Animal animal in animals)
        {
            animal.MakeSound();
        }
    }
}
```

**Code File:** See [Step6_Polymorphism.cs](Steps/Step6_Polymorphism.cs)
