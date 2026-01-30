# Activity: Introduction to Functions in Programming - Answer Key

## Problem 1: Creating a Function for Circle Area Calculation

### Solution Steps

1. Create the function to calculate the area of a circle:

```csharp
double CalculateCircleArea(double radius)
{
    return Math.PI * radius * radius;
}
```

2. Prompt the user to input the radius:

```csharp
Console.WriteLine("Enter the radius of the circle:");
double radius = Convert.ToDouble(Console.ReadLine());
```

3. Call the function to calculate the area:

```csharp
double area = CalculateCircleArea(radius);
```

4. Output the result:

```csharp
Console.WriteLine("The area of the circle is: " + area);
```

### Complete Code

```csharp
using System;

class Program {
    static void Main() {
        Console.WriteLine("Enter the radius of the circle:");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = CalculateCircleArea(radius);
        Console.WriteLine("The area of the circle is: " + area);
    }

    static double CalculateCircleArea(double radius) {
        return Math.PI * radius * radius;
    }
}
```

**Code File:** See [Problem1_CircleArea.cs](Problem1_CircleArea.cs)

---

## Problem 2: Trapezoid Area Calculation

### Complete Code

```csharp
using System;

public class Program {
    public static void Main() {
        Console.WriteLine("Enter the length of the first parallel side (a):");
        decimal a = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Enter the length of the second parallel side (b):");
        decimal b = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Enter the height of the trapezoid:");
        decimal height = Convert.ToDecimal(Console.ReadLine());

        decimal area = CalculateTrapezoidArea(a, b, height);
        Console.WriteLine("The area of the trapezoid is: " + area);
    }

    static decimal CalculateTrapezoidArea(decimal a, decimal b, decimal height) {
        return (a + b) / 2 * height;
    }
}
```

**Code File:** See [Problem2_TrapezoidArea.cs](Problem2_TrapezoidArea.cs)
