# Activity: Using Deductive Reasoning to Write Pseudocode

## Objective

Use pseudocode to outline the logical flow of a program by applying principles of deductive reasoning. This process helps systematically solve problems by breaking them down into premises, drawing conclusions, and testing those conclusions.

## Description

In this activity, you'll apply deductive reasoning to write pseudocode. We'll start with two guided examples to illustrate the process. Then, you'll solve two problems independently, outlining the logical flow and writing the pseudocode to implement your solutions.

---

## Example 1: Leap Year

### Problem Statement

You are tasked with creating a program to check if a given year is a leap year. A year is a leap year if it is divisible by 4, but not every year divisible by 100 is a leap year unless it is also divisible by 400.

### Applying Deductive Reasoning

1. **Identify the Premises:**
   - A year is a leap year if it is divisible by 4.
   - If the year is divisible by 100, it is not a leap year unless it is also divisible by 400.

2. **Analyze the Premises:**
   - From the premises, we conclude that if a year is divisible by 400, it is a leap year.
   - If a year is not divisible by 400 but is divisible by 100, it is not a leap year.
   - If a year is divisible by 4 and not by 100, it is a leap year.

3. **Draw a Conclusion:**
   - Based on the analysis, the conditions for checking leap years can be structured logically to cover all cases.

4. **Test the Conclusion:**
   - Test the logic with known leap years (e.g., 2000, 1600) and non-leap years (e.g., 1700, 1800).

5. **Explanation:**
   - **Input:** The user is prompted to input a year.
   - **Conditional Checks:** Using the premises:
     - First, check if year divisible by 4
     - Then, check if the year is divisible by 100.
     - Lastly, check if it is divisible by 400.

6. **Write the Pseudocode:**
```
Start
Input year
If (year is divisible by 4)
  And (year not divisible by 100
       Or if year is divisible by 100 and also divisible by 400
      )
    Display to user "Leap year"
  Otherwise print "Not a leap year"
End
```

---

## Example 2: Simple Grading System

### Problem Statement

Imagine you are creating a program to determine the letter grade for a student based on their numerical score. The grading system is as follows:

- A score of 90 or above is an "A".
- A score of 80 to 89 is a "B".
- A score of 70 to 79 is a "C".
- A score of 60 to 69 is a "D".
- A score below 60 is an "F".

### Applying Deductive Reasoning

1. **Identify the Premises:**
   - A score of 90 or above is classified as "A".
   - A score between 80 and 89 is classified as "B".
   - A score between 70 and 79 is classified as "C".
   - A score between 60 and 69 is classified as "D".
   - A score below 60 is classified as "F".

2. **Analyze the Premises:**
   - The grades are mutually exclusive and cover all possible scores.
   - Each score range can be checked using a series of conditional checks.

3. **Draw a Conclusion:**
   - By checking the score ranges in a descending order from the highest to the lowest, the correct letter grade can be assigned.

4. **Test the Conclusion:**
   - Test the logic with different scores to see if they fall into the correct grading category (e.g., 95 should be "A", 85 should be "B").

5. **Explanation:**
   - **Input:** The user is prompted to input a numerical score.
   - **Conditional Checks:** Using the premises:
     - Check if the score is 90 or above to assign an "A".
     - Check if the score is between 80 and 89 to assign a "B".
     - Continue checking the ranges until all cases are covered.
   - **Output:** Based on the checks, the program outputs the appropriate letter grade.

6. **Write the Pseudocode:**
```
Start 
Ask user for score 
If score is greater than or equal to 90
    Display to user "Grade A" 
Otherwise If score is greater than or equal to 80
    Display to user "Grade B" 
Otherwise If score is greater than or equal to 70
    Display to user "Grade C" 
Otherwise If score is greater than or equal to 60
    Display to user "Grade D" 
Otherwise
    Display to user "Grade F" 
End
```

---

## Problem 1: Integers

### Problem Statement

Write pseudocode to create a program that determines whether a number is positive, negative, or zero. Use deductive reasoning to establish the logical flow of the program.

---

## Problem 2: Senior Discount

### Problem Statement

Write pseudocode to create a program that checks whether a person is eligible for a senior citizen discount. The program should take the person's age as input. If the age is 65 or older, print "Eligible for senior discount"; otherwise, print "Not eligible for senior discount".