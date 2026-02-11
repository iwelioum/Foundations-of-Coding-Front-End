# Activity: Algorithm Structures - Answer Key

## Problem 1: Discount Eligibility

### Solution
```
Start
Create a variable total_spending and set it to the value of the input for "Enter total spending amount:"
IF total_spending greater than or equal to 100 THEN
    Display to user "10% discount applied."
ELSE
    Display to user "No discount."
END IF
End
```

### Explanation

This pseudocode uses a conditional statement (if/then) to check if the total spending is $100 or more. If it is, a discount is applied; otherwise, no discount is given. The structure ensures a straightforward decision-making process based on a single condition.

---

## Problem 2: Book Categorization

### Solution
```
Start
SET genre = input("Enter the genre of the book:")
IF genre is "Fiction" THEN
    Display to user "Category: Fiction"
OTHERWISE IF genre is "Non-Fiction" THEN
    Display to user "Category: Non-Fiction"
OTHERWISE IF genre is "Science Fiction" THEN
    Display to user "Category: Science Fiction"
OTHERWISE
    Display to user "Category: Unknown"
END IF
End
```

### Explanation

This pseudocode uses a series of conditional statements (if/else if/else) to categorize books based on their genre. Each condition checks if the genre matches a specific category and prints the appropriate message. If none of the conditions are met, the program outputs "Category: Unknown."

---

## Problem 3: Even or Odd Number

### Solution
```
Start
Create a variable number and set it to the value of the input of "Enter a number:"
IF number divisible by 2 has a remainder of 0 THEN
    Display to user "Even number."
OTHERWISE
    Display to user "Odd number."
END IF
End
```

### Explanation

This pseudocode uses a binary decision structure to determine if a number is even or odd. The condition "number divisible by 2 has a remainder of 0" checks if the number is divisible by 2 without a remainder (even). If true, it prints "Even number"; otherwise, it prints "Odd number." The if/else structure efficiently handles the two possible outcomes.