# Activity: Implementing Control Structures

## Objective

Practice solving decision-making scenarios using advanced if-else statements and complex switch cases to control program flow by evaluating variable values and program states.

## Description

In this activity, you'll use if-else statements and switch cases to control program flow in scenarios like tax calculations and phone plan selection. You'll then apply these skills to create a gym membership fee system and a bank account management system.

---

## Example 1: Advanced If-Else Statements – Tax Calculation System

### Problem Statement

You are tasked with developing a tax calculation system. The program must calculate the tax rate based on the user's income and whether they are a resident or a non-resident. The tax rates are as follows:

- If the income is less than $50,000, residents are taxed at 10%, and non-residents at 15%.
- If the income is between $50,000 and $100,000, residents are taxed at 20%, and non-residents at 25%.
- If the income is over $100,000, residents are taxed at 30%, and non-residents at 35%.

### Step-by-Step Code Construction with Syntax Explanation

#### Step 1: Start with the Primary Condition

```csharp
if (income < 50000) {
```

**Explanation:**

- `if`: This is the basic if-statement that evaluates a condition. If the condition inside the parentheses is true, the code inside the block `{}` will execute.
- `income < 50000`: This is a comparison operator. It checks whether the value of income is less than 50,000.
- `{ }`: Curly braces enclose the block of code that runs when the condition is true.

#### Step 2: Add Nested If-Else to Check Residency

```csharp
if (isResident) {
    taxRate = 0.10;  // 10% tax for residents
} else {
    taxRate = 0.15;  // 15% tax for non-residents
}
```

**Explanation:**

- `isResident`: This is a boolean variable. It holds either true or false.
- `taxRate = 0.10;`: The equal sign `=` is the assignment operator. It assigns the value 0.10 (or 10%) to the variable `taxRate`.
- `else`: If the first condition is false, the program moves to the else block and applies the non-resident tax rate of 15%.

#### Step 3: Handle the Next Income Bracket

```csharp
} else if (income >= 50000 && income <= 100000) {
    if (isResident) {
        taxRate = 0.20;  // 20% tax for residents
    } else {
        taxRate = 0.25;  // 25% tax for non-residents
    }
}
```

**Explanation:**

- `else if`: Used when we need to check another condition if the first if condition is false.
- `income >= 50000 && income <= 100000`: Uses the `>=` and `<=` operators to check if income falls between $50,000 and $100,000. The `&&` operator means both conditions must be true.

#### Step 4: Handle the Final Income Bracket

```csharp
} else {
    if (isResident) {
        taxRate = 0.30;  // 30% tax for residents
    } else {
        taxRate = 0.35;  // 35% tax for non-residents
    }
}
```

#### Step 5: Calculate and Print the Tax

```csharp
tax = income * taxRate;
Console.WriteLine("The tax is: $" + tax);
```

**Explanation:**

- `tax = income * taxRate;`: Uses the multiplication operator `*` to calculate the tax.
- `Console.WriteLine`: Prints output to the console.

#### Complete C# Code Example

```csharp
using System;

public class Program {
    public static void Main() {
        // Step 1: Prompt the user for input
        Console.WriteLine("Enter your income:");
        double income = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Are you a resident? (yes/no):");
        string residentInput = Console.ReadLine();
        bool isResident = residentInput.ToLower() == "yes";

        double taxRate = 0;
        double tax;

        // Step 2: Use advanced if-else statements to calculate tax
        if (income < 50000) {
            if (isResident) {
                taxRate = 0.10;  // 10% tax for residents
            } else {
                taxRate = 0.15;  // 15% tax for non-residents
            }
        } else if (income >= 50000 && income <= 100000) {
            if (isResident) {
                taxRate = 0.20;  // 20% tax for residents
            } else {
                taxRate = 0.25;  // 25% tax for non-residents
            }
        } else {
            if (isResident) {
                taxRate = 0.30;  // 30% tax for residents
            } else {
                taxRate = 0.35;  // 35% tax for non-residents
            }
        }

        // Step 3: Calculate and print the tax
        tax = income * taxRate;
        Console.WriteLine("The tax is: $" + tax);
    }
}
```

---

## Example 2: Complex Switch Cases – Phone Plan Selector

### Problem Statement

You are developing a program to help users choose a phone plan based on the amount of data they want and whether they need international calling. The available plans are:

- **Basic Plan**: 2GB of data, no international calling.
- **Standard Plan**: 5GB of data, no international calling.
- **Premium Plan**: 10GB of data, with international calling.
- **Elite Plan**: Unlimited data, with international calling.

### Step-by-Step Code Construction with Syntax Explanation

#### Step 1: Start with a Switch Based on Data Usage

```csharp
switch (dataNeeds) {
```

**Explanation:**

- `switch (dataNeeds)`: The switch statement evaluates a single variable. The program compares the value of `dataNeeds` against a series of case labels.

#### Step 2: Add Cases to Handle Data Ranges

```csharp
case 2:
    plan = "Basic Plan";
    break;
```

**Explanation:**

- `case 2`: This case checks if the user requested 2GB of data.
- `plan = "Basic Plan";`: Assigns the string "Basic Plan" to the variable plan.
- `break;`: Tells the program to exit the switch statement after executing this case.

```csharp
case 5:
    plan = "Standard Plan";
    break;
```

#### Step 3: Handle Premium and Unlimited Plans

```csharp
case 10:
    if (wantsInternationalCalling) {
        plan = "Premium Plan";
    } else {
        plan = "Standard Plan";
    }
    break;

case -1:
    plan = "Unlimited Plan";
    break;
```

**Explanation:**

- `case 10`: Checks if the data requested is 10GB. Uses an if statement to check if the user wants international calling.
- `case -1`: Placeholder to represent "unlimited" data.

#### Step 4: Default Case

```csharp
default:
    plan = "Invalid data request";
    break;
}
```

**Explanation:**

- `default`: Acts as a fallback. If none of the other cases are true, this block will run.

#### Complete C# Code Example

```csharp
using System;

public class Program {
    public static void Main() {
        // Step 1: Prompt the user for input
        Console.WriteLine("Enter your data usage (in GB):");
        double dataUsage = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Do you want international calling? (yes/no):");
        string intlCallingInput = Console.ReadLine();
        bool wantsInternationalCalling = intlCallingInput.ToLower() == "yes";

        string plan = "";

        // Step 2: Use switch statement to select the plan
        switch (dataUsage) {
            case 2:
                plan = "Basic Plan";
                Console.WriteLine("You are choosing the Basic Plan");
                break;

            case 5:
                plan = "Standard Plan";
                Console.WriteLine("You are choosing the Standard Plan");
                break;

            case 10:
                if (wantsInternationalCalling) {
                    plan = "Premium Plan";
                    Console.WriteLine("You are choosing the Premium Plan with International Calling");
                } else {
                    plan = "Standard Plan";
                    Console.WriteLine("You are choosing the Standard Plan");
                }
                break;

            case -1:
                plan = "Unlimited Plan";
                Console.WriteLine("You are choosing the Unlimited Plan with International Calling");
                break;

            default:
                Console.WriteLine("Invalid data request");
                break;
        }
    }
}
```

---

## Student Problems to Solve

### Problem 1: Membership Fee Calculation System

#### Problem Statement

You are developing a program to calculate the membership fee for a gym. The fee depends on the user's age and membership type:

- For users under 18, the fee is $15 for a basic membership and $25 for a premium membership.
- For users between 18 and 60, the fee is $30 for a basic membership and $50 for a premium membership.
- For users over 60, the fee is $20 for a basic membership and $35 for a premium membership.

#### Instructions

Write an advanced if-else statement to calculate the membership fee based on age and membership type.

You can draft and run your code directly in [Dot Net Fiddle](https://dotnetfiddle.net/), a simple online editor for .NET projects.

---

### Problem 2: Bank Account Management System

#### Problem Statement

You are developing a bank account management system. The program must manage different types of bank accounts and apply the correct fees or interest rates based on the account type:

- **Savings Account**: Apply a 2% interest rate.
- **Checking Account**: Apply a $10 monthly fee.
- **Business Account**: Apply a 1% interest rate and a $20 monthly fee.
- For all other account types, display an error message.

#### Instructions

Write a switch case to handle different account types and apply the correct fees or interest rates.

You can draft and run your code directly in [Dot Net Fiddle](https://dotnetfiddle.net/).
