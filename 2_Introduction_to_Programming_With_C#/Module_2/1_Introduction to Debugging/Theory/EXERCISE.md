# Activity: Introduction to Debugging

## Objective

Demonstrate how to use basic debugging techniques and tools, such as setting breakpoints, inspecting variable values, and stepping through code to identify and fix errors.

## Description

This activity will guide participants through debugging C# code, including identifying errors, understanding their causes, and applying fixes. It will start with two fully debugged examples and then provide two additional debugging problems for learners to solve. Common error types, such as syntax, runtime, and logical errors, will be addressed.

## Set Up Your Environment

1. Use the Visual Studio Code console application you created at the start of the course. Remove any existing code in the `Program.cs` file of your console application.
2. Copy and edit the code in this activity into the `Program.cs` file to complete the steps.

---

## Example 1: Dividing Two Numbers

### Problem

The code below is intended to divide two numbers and print the result. However, a runtime error occurs when the denominator is zero.

```csharp
// Method to divide two numbers
using System;
public class Program
{
    public static int DivideNumbers(int numerator, int denominator)
    {
        int result = numerator / denominator;
        return result;
    }

    public static void Main()
    {
        // Attempt to divide 10 by 0
        int result = DivideNumbers(10, 0);
        Console.WriteLine("The result is: " + result);
    }
}
```

### Steps to Debug

1. **Identify the Error:** When running the code, a runtime error occurs because dividing by zero is not allowed, leading to an "infinity" value or program crash.
2. **Set a Breakpoint:** Place a breakpoint at the division line (`int result = numerator / denominator;`) to pause execution and inspect the values.
3. **Inspect Variable Values:** Use the debugger to check if `denominator` is zero. If it is, that confirms the cause of the error.
4. **Add Error Handling:** Update the code to check for zero before dividing, returning an error message or alternative value if it occurs.

### Corrected Code

```csharp
// Method to divide two numbers with error handling
using System;
public class Program
{
    public static double DivideNumbers(double numerator, double denominator)
    {
        if (denominator == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return double.NaN; // Return "Not a Number" to indicate an error
        }

        double result = numerator / denominator;
        return result;
    }

    public static void Main()
    {
        // Attempt to divide 10 by 0
        double result = DivideNumbers(10, 0);
        Console.WriteLine("The result is: " + result);
    }
}
```

5. **Test the Code:** Run the program again to ensure that it correctly handles division by zero without crashing.

**Code File:** See [Example1_DivideNumbers.cs](Examples/Example1_DivideNumbers.cs)

---

## Example 2: Calculating the Average of an Array

### Problem

The following code calculates the average of an array of numbers. However, it fails with a runtime error when the array is empty.

```csharp
using System;
public class Program
{
    // Method to calculate the average of an array
    public static double CalculateAverage(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum / numbers.Length;
    }

    public static void Main()
    {
        int[] numbers = {}; // Empty array
        double average = CalculateAverage(numbers);
        Console.WriteLine("The average is: " + average);
    }
}
```

### Steps to Debug

1. **Identify the Error:** The code fails with a runtime error when dividing by `numbers.Length`, which is zero for an empty array.
2. **Set a Breakpoint:** Place a breakpoint on the line `return sum / numbers.Length;` to inspect the value of `numbers.Length`.
3. **Inspect Variable Values:** Check if `numbers.Length` is zero. If it is, the code will attempt to divide by zero, causing a runtime error.
4. **Add Error Handling:** Modify the code to handle empty arrays by checking if `numbers.Length` is zero and returning an appropriate message.

### Corrected Code

```csharp
using System;
public class Program
{
    // Method to calculate the average of an array with error handling
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers.Length == 0)
        {
            Console.WriteLine("Error: Cannot calculate the average of an empty array.");
            return double.NaN; // Return "Not a Number" to indicate an error
        }

        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return (double)sum / numbers.Length;
    }

    public static void Main()
    {
        int[] numbers = {}; // Empty array
        double average = CalculateAverage(numbers);
        Console.WriteLine("The average is: " + average);
    }
}
```

5. **Test the Code:** Re-run the program to ensure that it handles empty arrays gracefully without crashing.

**Code File:** See [Example2_CalculateAverage.cs](Examples/Example2_CalculateAverage.cs)

---

## Problems to Complete

### Problem 1: Calculating Discounts

The code below is meant to calculate the final price after applying a discount to a product. However, it does not produce the correct output due to a logical error.

```csharp
public class Program
{
    // Method to calculate the final price after a discount
    public static double ApplyDiscount(double price, double discountPercentage)
    {
        return price - discountPercentage;
    }

    public static void Main()
    {
        double finalPrice = ApplyDiscount(1000, 15);
        Console.WriteLine("The final price is: " + finalPrice);
    }
}
```

### Instructions

1. Identify the error in the `ApplyDiscount` method.
2. Use the debugger to inspect values and understand why the output is incorrect.
3. Correct the code to calculate the discount as a percentage of the original price.

**Code File:** See [Problem1_ApplyDiscount.cs](Problems/Problem1_ApplyDiscount.cs)

---

### Problem 2: Finding the Maximum Number in an Array

The following code tries to find the maximum number in an array. It has a logical error that causes it to produce incorrect results when all the numbers are negative.

```csharp
public class Program
{
    public static int FindMax(int[] numbers)
    {
        int max = 0;
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

### Instructions

1. Identify why the `FindMax` method fails with an array of negative numbers.
2. Use breakpoints and variable inspection to find the issue.
3. Correct the code to correctly find the maximum value even if all numbers are negative.

**Code File:** See [Problem2_FindMax.cs](Problems/Problem2_FindMax.cs)
