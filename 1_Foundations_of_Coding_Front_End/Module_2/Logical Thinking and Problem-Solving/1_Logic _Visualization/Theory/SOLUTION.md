# Activity: Logic Visualization - Answer Key

## Task Solution: Check if a Number is Even or Odd

### Step 1: Define the Problem

Create a program that checks if a number is even or odd.

### Step 2: Identify Key Processes

- Prompt the user to input a number
- Check if the number is divisible by 2 with no remainder
- Print "Even number" if divisible by 2
- Print "Odd number" if not divisible by 2
- End the process

### Step 3: Flowchart

```
Start → Input Number → Number % 2 == 0?
  ├─ Yes → Print "Even number" → End
  └─ No → Print "Odd number" → End
```

### Step 4: Pseudocode

```
START Even_Odd_Check
  INPUT number
  IF number % 2 == 0 THEN
    PRINT "Even number"
  ELSE
    PRINT "Odd number"
  END IF
END Even_Odd_Check
```

### Step 5: C# Implementation Example

```csharp
using System;

class EvenOddChecker
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Even number");
        }
        else
        {
            Console.WriteLine("Odd number");
        }
    }
}
```

**Code File:** See [EvenOddChecker.cs](EvenOddChecker.cs)

---

## Additional Examples

### Example: Login System Solution

**Pseudocode:**

```
START Login_System
  INPUT username, password
  IF username AND password are valid THEN
    PRINT "Access granted"
    Grant user access
  ELSE
    PRINT "Access denied"
    Deny user access
  END IF
END Login_System
```

**C# Example:**

```csharp
using System;

class LoginSystem
{
    static void Main()
    {
        string validUsername = "admin";
        string validPassword = "password123";

        Console.WriteLine("Enter username:");
        string username = Console.ReadLine();
        Console.WriteLine("Enter password:");
        string password = Console.ReadLine();

        if (username == validUsername && password == validPassword)
        {
            Console.WriteLine("Access granted");
        }
        else
        {
            Console.WriteLine("Access denied");
        }
    }
}
```

**Code File:** See [LoginSystem.cs](LoginSystem.cs)

---

### Example: E-commerce Checkout Solution

**Pseudocode:**

```
START Checkout_Process
  WHILE user wants to select products LOOP
    SELECT product
    ADD selected product to shopping cart
    PROMPT "Select another product?" (Yes/No)
  END WHILE
  INPUT shipping details
  SELECT payment method
  CONFIRM order
  DISPLAY "Order confirmed"
END Checkout_Process
```

**C# Example:**

```csharp
using System;
using System.Collections.Generic;

class CheckoutProcess
{
    static void Main()
    {
        List<string> cart = new List<string>();
        string continueShop = "yes";

        while (continueShop.ToLower() == "yes")
        {
            Console.WriteLine("Enter product name:");
            string product = Console.ReadLine();
            cart.Add(product);

            Console.WriteLine("Select another product? (yes/no):");
            continueShop = Console.ReadLine();
        }

        Console.WriteLine("Enter shipping details:");
        string shippingDetails = Console.ReadLine();

        Console.WriteLine("Select payment method (credit card/PayPal):");
        string paymentMethod = Console.ReadLine();

        Console.WriteLine("Order confirmed!");
        Console.WriteLine($"Items: {string.Join(", ", cart)}");
        Console.WriteLine($"Shipping: {shippingDetails}");
        Console.WriteLine($"Payment: {paymentMethod}");
    }
}
```

**Code File:** See [CheckoutProcess.cs](CheckoutProcess.cs)
