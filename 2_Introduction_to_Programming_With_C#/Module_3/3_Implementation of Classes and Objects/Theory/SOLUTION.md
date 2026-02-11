# Activity: Implementation of Classes and Objects - Answer Key

## Step 2: Creating a Basic Class

```csharp
public class Person
{
    // Define the Name property
    public string Name { get; set; }

    // Define the Age property
    public int Age { get; set; }
}
```

**Code File:** See [Step2_PersonClass.cs](Steps/Step2_PersonClass.cs)

---

## Step 3: Creating Objects

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        // Create the first Person object
        Person friend = new Person();
        friend.Name = "John Doe";
        friend.Age = 30;

        // Create the second Person object
        Person colleague = new Person();
        colleague.Name = "Jane Smith";
        colleague.Age = 25;
    }
}
```

---

## Step 4: Creating Methods

```csharp
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Define the Greet method
    public void Greet()
    {
        Console.WriteLine("Hello, my name is " + Name);
    }
}
```

---

## Step 5: Using Methods in Objects

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        // Create the first Person object
        Person friend = new Person();
        friend.Name = "John Doe";
        friend.Age = 30;

        // Create the second Person object
        Person colleague = new Person();
        colleague.Name = "Jane Smith";
        colleague.Age = 25;

        // Call the Greet method on each object
        friend.Greet(); // Output: Hello, my name is John Doe
        colleague.Greet(); // Output: Hello, my name is Jane Smith
    }
}
```

**Expected Output:**

```
Hello, my name is John Doe
Hello, my name is Jane Smith
```

---

## Step 6: Practicing with Multiple Objects

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        // Create the first Person object
        Person friend = new Person();
        friend.Name = "John Doe";
        friend.Age = 30;

        // Create the second Person object
        Person colleague = new Person();
        colleague.Name = "Jane Smith";
        colleague.Age = 25;

        // Create the third Person object
        Person newPerson = new Person();
        newPerson.Name = "Mike Johnson";
        newPerson.Age = 35;

        // Call the Greet method on each object
        friend.Greet(); // Output: Hello, my name is John Doe
        colleague.Greet(); // Output: Hello, my name is Jane Smith
        newPerson.Greet(); // Output: Hello, my name is Mike Johnson
    }
}
```

**Expected Output:**

```
Hello, my name is John Doe
Hello, my name is Jane Smith
Hello, my name is Mike Johnson
```

**Code File:** See [Step5_PersonComplete.cs](Steps/Step5_PersonComplete.cs)
