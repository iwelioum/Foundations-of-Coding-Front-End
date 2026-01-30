# Activity: Control Structures - Answer Key

## Step 1: If-Else Statement for Ticket Pricing

### Solution

```csharp
using System;

public class Program
{
    public static void Main() {
        int age;
        Console.WriteLine("Enter your age: ");
        age = int.Parse(Console.ReadLine());

        if (age < 12)
        {
            Console.WriteLine("Half price ticket.");
        }
        else if (age <= 65)
        {
            Console.WriteLine("Full price ticket.");
        }
        else
        {
            Console.WriteLine("Senior discount ticket.");
        }
    }
}
```

**Code File:** See [Step1_TicketPricing.cs](Step1_TicketPricing.cs)

## Step 2: Switch Statement for Travel Mode Selection

### Solution

```csharp
using System;

public class Program
{
    public static void Main() {
        string mode;
        Console.WriteLine("Select travel mode (Bus/Train/Flight): ");
        mode = Console.ReadLine();

        switch (mode)
        {
            case "Bus":
                Console.WriteLine("Booking a bus ticket.");
                break;
            case "Train":
                Console.WriteLine("Booking a train ticket.");
                break;
            case "Flight":
                Console.WriteLine("Booking a flight ticket.");
                break;
            default:
                Console.WriteLine("Invalid selection. Please choose Bus, Train, or Flight.");
                break;
        }
    }
}
```
