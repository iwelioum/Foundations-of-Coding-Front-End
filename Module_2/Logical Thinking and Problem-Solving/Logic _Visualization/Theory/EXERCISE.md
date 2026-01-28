# Activity: Logic Visualization

## Objective

Demonstrate how software developers can use flowcharts and pseudocode to plan and visualize logical program flow before writing code.

## Description

This activity will provide examples of how logical processes, such as sequences, control structures, and iterations, can be created and using flowcharts and pseudocode. By visualizing these processes, you can ensure that your code follows a logical and efficient path.

## Example 1: Creating a Login System Flowchart and Pseudocode

### Step 1: Define the Problem

Create a login system where users can enter their username and password. The system should validate these credentials and allow or deny access.

### Step 2: Identify Key Processes

- Input username and password
- Validate credentials
- Check database for stored validation
- Access Granted (Flowchart): If credentials are valid, the user is granted access
- Access Denied (Flowchart): If credentials are invalid, the user is denied access
- End (Flowchart): Represents the end of the process

### Step 3: Draw the Flowchart
```
Start → Input Username and Password → Validate Credentials → Credentials Valid? 
  ├─ Yes → Access Granted → End
  └─ No → Access Denied → End
```

### Step 4: Translate to Pseudocode
```
Start Flowchart — Use the login system with a special "Start" symbol, which corresponds to initializing the program in pseudocode.

Input Username and Password — Flowchart uses the input symbol (parallelogram) to directly translate into a command that prompts the user for their username and password.

Validate Credentials (Diamond) — Check if the username and password match the stored data.

Access Granted (Rectangle) — If credentials are valid, the user is granted access.

Access Denied (Rectangle) — If credentials are invalid, the user is denied access.

End (Flowchart) — End Pseudocode: The flowchart ends with an "End" symbol, which corresponds to concluding the login in pseudocode.

Pseudocode:
START Login_System
INPUT username, password
IF user credentials are valid THEN
  DISPLAY "Access granted"
  Grant access
ELSE
  DISPLAY "Access denied"
  Deny access
END IF
END Login_System
```

---

## Example 2: Creating an E-commerce Checkout Process Flowchart and Pseudocode

### Step 1: Define the Problem

Develop an e-commerce checkout process that includes selecting products, adding them to the cart, entering shipping details, selecting a payment method, and confirming the order.

### Step 2: Identify Key Processes

- Select products
- Add products to cart
- Enter shipping details
- Select payment method
- Confirm order

### Step 3: Draw the Flowchart
```
Start → Select Products → Add to Cart? 
  ├─ Yes → Add to Cart → Select More Products?
  │         ├─ Yes → Go back to Select Products
  │         └─ No → Enter Shipping Details → Select Payment Method → Confirm Order → End
  └─ No → End
```

### Step 4: Translate to Pseudocode
```
Start Flowchart — Use the checkout process, starting with the "Start" symbol.

Select Products (Rectangle) — Use user interface products to purchase.

Add Products (Rectangle) — Selected products are added to the shopping cart.

Input Shipping Details (Rectangle) — User enters their shipping information.

Select Payment Method (Rectangle) — User chooses a payment option, either credit card or a digital payment platforms.

Confirm Order (Rectangle) — Confirm and finalize the checkout process.

End Flowchart — End Pseudocode: The flowchart ends the conclusion of the transaction, which is reflected in the termination of the business process a process is completed.

Pseudocode:
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

---

## Activity Task

**Task:** Create a flowchart and pseudocode for a simple program that checks if a number is even or odd. If the result is even, the program should return "even number". If the result is odd, the program should return "odd number".

### Instructions

1. Define the problem
2. Identify key processes
3. Draw the flowchart
4. Write pseudocode
5. Pseudocode

