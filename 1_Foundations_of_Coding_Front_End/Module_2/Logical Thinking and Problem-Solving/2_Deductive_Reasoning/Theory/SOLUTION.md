# Activity: Using Deductive Reasoning to Write Pseudocode - Answer Key

## Problem 1: Integers

### Problem Statement

Write pseudocode to create a program that determines whether a number is positive, negative, or zero. Use deductive reasoning to establish the logical flow of the program.

### Solution

#### Applying Deductive Reasoning

1. **Identify the Premises:**
   - A number is positive if it is greater than 0.
   - A number is negative if it is less than 0.
   - A number is zero if it equals 0.

2. **Analyze the Premises:**
   - These three categories cover all possible numbers.
   - They are mutually exclusive.

3. **Draw a Conclusion:**
   - By checking if the number is greater than 0, less than 0, or neither, we can determine its classification.

4. **Test the Conclusion:**
   - Test with 5 (positive), -3 (negative), and 0 (zero).

#### Pseudocode
```
Start 
Ask user for number 
If number is greater than 0
    Display to user "Positive" 
Otherwise If number is less than 0
    Display to user "Negative" 
Otherwise
    Display to user "Zero" 
End
```

---

## Problem 2: Senior Discount

### Problem Statement

Write pseudocode to create a program that checks whether a person is eligible for a senior citizen discount. The program should take the person's age as input. If the age is 65 or older, print "Eligible for senior discount"; otherwise, print "Not eligible for senior discount".

### Solution

#### Applying Deductive Reasoning

1. **Identify the Premises:**
   - A person is eligible for senior discount if age is 65 or older.
   - A person is not eligible if age is less than 65.

2. **Analyze the Premises:**
   - These two categories cover all possible ages.
   - They are mutually exclusive.

3. **Draw a Conclusion:**
   - By checking if the age is greater than or equal to 65, we can determine eligibility.

4. **Test the Conclusion:**
   - Test with age 70 (eligible) and age 45 (not eligible).

#### Pseudocode
```
Start 
Get age 
If age is greater than or equal to 65
    Display to user "Eligible for senior discount" 
Otherwise
    Display to user "Not eligible for senior discount" 
End
```