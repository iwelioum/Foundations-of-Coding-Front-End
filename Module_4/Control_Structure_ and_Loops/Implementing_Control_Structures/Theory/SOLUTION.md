# Activity: Implementing Control Structures - Answer Key

---

## Problem 1: Membership Fee Calculation System

### Solution

```csharp
using System;

public class Program {
    public static void Main() {
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the type of membership (basic/premium):");
        string membershipType = Console.ReadLine().ToLower();

        int fee = 0;

        if (age < 18) {
            if (membershipType == "basic") {
                fee = 15;
            } else if (membershipType == "premium") {
                fee = 25;
            }
        } else if (age >= 18 && age <= 60) {
            if (membershipType == "basic") {
                fee = 30;
            } else if (membershipType == "premium") {
                fee = 50;
            }
        } else if (age > 60) {
            if (membershipType == "basic") {
                fee = 20;
            } else if (membershipType == "premium") {
                fee = 35;
            }
        }

        Console.WriteLine("Your membership fee is: $" + fee);
    }
}
```

### Explanation

- **Age Check**: The program uses nested if-else statements to check the user's age bracket.
- **Membership Type**: Within each age bracket, it checks whether the user wants a basic or premium membership.
- **Fee Assignment**: Based on both age and membership type, the appropriate fee is assigned.
- **Output**: The final fee is displayed to the user.

**Code File:** See [Problem1_GymMembership.cs](Problem1_GymMembership.cs)

---

## Problem 2: Bank Account Management System

### Solution

```csharp
using System;

public class Program {
    public static void Main() {
        // Step 1: Prompt the user to enter the account type
        Console.WriteLine("What type of account are you opening? (savings/checking/business):");
        string accountType = Console.ReadLine().ToLower();

        // Step 2: Declare variables for interest rate and monthly fee
        double interestRate = 0;
        int monthlyFee = 0;

        // Step 3: Use switch statement to determine account details based on account type
        switch (accountType) {
            case "savings":
                // Handle savings account: Apply 2% interest rate
                interestRate = 0.02;
                Console.WriteLine("Interest rate is 2%");
                break;

            case "checking":
                // Handle checking account: Apply $10 monthly fee
                monthlyFee = 10;
                Console.WriteLine("Monthly fee is $10");
                break;

            case "business":
                // Handle business account: Apply 1% interest rate and $20 monthly fee
                interestRate = 0.01;
                monthlyFee = 20;
                Console.WriteLine("Interest rate is 1% and monthly fee is $20");
                break;

            default:
                // Handle invalid account type
                Console.WriteLine("Invalid account type");
                break;
        }
    }
}
```

### Explanation

- **User Input**: The program prompts the user to enter their account type.
- **Switch Statement**: Uses a switch statement to evaluate the account type.
- **Case Handling**: Each case applies the appropriate interest rate and/or monthly fee.
- **Default Case**: Handles invalid account types with an error message.

**Code File:** See [Problem2_BankAccount.cs](Problem2_BankAccount.cs)
