# Activity: Writing Simple Programs in C# - Answer Key

## Step 1: Creating a Simple Calculator

```csharp
public class Calculator
{
    public static int number1;
    public static int number2;

    public static int Add()
    {
        return number1 + number2;
    }
}
```

---

## Step 2: Executing the Calculator Program

```csharp
using System;
public class Calculator
{
    public static int number1 = 5;
    public static int number2 = 10;

    public static int Add()
    {
        return number1 + number2;
    }

    public static void Main(string[] args)
    {
        int result = Add();
        Console.WriteLine("The sum is: " + result);
    }
}
```

**Code File:** See [Step1_Calculator.cs](Steps/Step1_Calculator.cs)

---

## Step 3: Creating a Loop to Display Numbers

```csharp
using System;
public class NumberDisplay
{
    public static void DisplayNumbers()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static void Main(string[] args)
    {
        DisplayNumbers();
    }
}
```

**Code File:** See [Step2_NumberDisplay.cs](Steps/Step2_NumberDisplay.cs)

---

## Step 4: Handling User Input

```csharp
using System;
public class UserInput
{
    public static void GreetUser()
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello " + name + "!");
    }

    public static void Main(string[] args)
    {
        GreetUser();
    }
}
```

**Code File:** See [Step3_UserInput.cs](Steps/Step3_UserInput.cs)
