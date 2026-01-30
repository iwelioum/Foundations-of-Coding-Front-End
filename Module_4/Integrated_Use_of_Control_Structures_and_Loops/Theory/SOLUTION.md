# Activity: Integrated Use of Control Structures and Loops - Answer Key

## Step 1: Integrating If-Else with Loops

### Solution

```csharp
using System;

public class Program
{
    public static void Main()
    {
        int input;
        do {
            Console.WriteLine("Enter an even number between 1 and 10:");
            input = int.Parse(Console.ReadLine());
            if (input >= 1 && input <= 10 && input % 2 == 0) {
                Console.WriteLine("Valid input: " + input);
                break;
            } else {
                Console.WriteLine("Invalid input. Please try again.");
            }
        } while (true);
    }
}
```

**Code File:** See [Step1_EvenNumberValidator.cs](Step1_EvenNumberValidator.cs)

---

## Step 2: Using If-Else to Evaluate Grades

### Solution

```csharp
using System;

public class Program
{
    public static void Main()
    {
        int[] grades = { 85, 92, 78, 64, 89 };

        for (int i = 0; i < grades.Length; i++) {
            int grade = grades[i];
            string result;
            if (grade >= 65) {
                result = "Pass";
            } else {
                result = "Fail";
            }
            Console.WriteLine($"Score: {grade} Result: {result}");
        }
    }
}
```

**Code File:** See [Step2_GradeEvaluator.cs](Step2_GradeEvaluator.cs)

---

## Step 3: Integrating Switch Statements with Loops

### Solution

```csharp
using System;

public class Program
{
    public static void Main()
    {
        string[] orderStatuses = { "Pending", "Shipped", "Delivered", "Cancelled" };

        for (int i = 0; i < orderStatuses.Length; i++) {
            string status = orderStatuses[i];
            switch (status) {
                case "Pending":
                    Console.WriteLine("Order is pending.");
                    break;
                case "Shipped":
                    Console.WriteLine("Order has been shipped.");
                    break;
                case "Delivered":
                    Console.WriteLine("Order has been delivered.");
                    break;
                case "Cancelled":
                    Console.WriteLine("Order has been cancelled.");
                    break;
                default:
                    Console.WriteLine("Unknown status.");
                    break;
            }
        }
    }
}
```

**Code File:** See [Step3_OrderStatus.cs](Step3_OrderStatus.cs)
