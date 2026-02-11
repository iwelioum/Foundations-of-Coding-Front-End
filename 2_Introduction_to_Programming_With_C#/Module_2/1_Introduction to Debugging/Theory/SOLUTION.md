# Activity: Introduction to Debugging - Answer Key

## Problem 1: Calculating Discounts

### Identify the Error

The code subtracts the discount percentage directly from the price instead of calculating the discounted amount.

### Corrected Code

```csharp
using System;
public class Program
{
    // Method to calculate the final price after a discount
    public static double ApplyDiscount(double price, double discountPercentage)
    {
        double discountAmount = price * (discountPercentage / 100);
        return price - discountAmount;
    }

    public static void Main()
    {
        double finalPrice = ApplyDiscount(1000, 15);
        Console.WriteLine("The final price is: " + finalPrice);
    }
}
```

**Code File:** See [Solution1_ApplyDiscount.cs](Solutions/Solution1_ApplyDiscount.cs)

---

## Problem 2: Finding the Maximum Number in an Array

### Identify the Error

The code initializes `max` to zero, causing it to fail when all numbers in the array are negative.

### Corrected Code

```csharp
public class Program
{
    public static int FindMax(int[] numbers)
    {
        int max = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }

    public static void Main()
    {
        int[] myNumbers = { -5, -10, -3, -8, -2 };
        int maxNumber = FindMax(myNumbers);
        Console.WriteLine("The maximum number is: " + maxNumber);
    }
}
```

**Code File:** See [Solution2_FindMax.cs](Solutions/Solution2_FindMax.cs)
