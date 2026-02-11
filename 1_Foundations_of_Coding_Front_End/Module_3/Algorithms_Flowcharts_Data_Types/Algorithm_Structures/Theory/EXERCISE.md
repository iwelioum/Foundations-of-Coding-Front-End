# Activity: Implementing Conditional and Binary Decision Structures

## Objective

Demonstrate how developers can use conditional (if/then) and binary decision structures to manage and navigate choices in programming.

## Description

This activity involves analyzing scenarios, selecting appropriate algorithm structures, and then writing pseudocode to implement those structures. We'll begin with two fully worked examples, followed by a task for you to complete independently.

---

## Example 1: Checking Voting Eligibility

### Problem Statement

Develop a program that checks if a person is eligible to vote. If their age is 18 or older, the program should print "You are eligible to vote." Otherwise, it should print "You are not eligible to vote yet."

### Process

#### Step 1: Define the Problem

We need a program that checks if a person is eligible to vote. If their age is 18 or older on the date of the election, the program should print "You are eligible to vote." Otherwise, it should print "You are not eligible to vote yet."

#### Step 2: Identify Key Processes

- **Input the Person's Age:** The program needs to know the age of the person on the date of the election to make a decision. This means the first key process is to gather input data from the user, which is their age.
- **Check Age Condition:** The decision depends on whether the age is 18 or older. Thus, we need a process to check the age against the condition of being at least 18.
- **Print a Message Based on the Age:** Depending on the result of the age check, the program should print a specific message. There are two possible outcomes, so the key process here is to select the appropriate message.

#### Step 3: Explanation

These processes are identified based on the requirement to decide voting eligibility. The age input is essential because it's the data upon which the decision is based. Checking the age against a condition directly addresses the problem's requirements, and printing a message provides the necessary output for the user.

#### Step 4: Decide on an Algorithm Structure

To decide on the appropriate algorithm structure, consider the following questions:

- Are there multiple conditions to check? No, there is just one condition: whether the age is 18 or older.
- Is the decision between two outcomes? Yes, either eligible or not eligible.
- Does the problem involve classifying items into multiple categories? No, only two possibilities.

**Chosen Structure:** A conditional statement (if/then) is appropriate. This structure is well-suited for checking if a condition is true or false and making a decision based on that.

#### Step 5: Create the Pseudocode
```
Start
Get age
IF age is greater than or equal to 18 THEN
    Display to user "You are eligible to vote."
OTHERWISE
    Display to user "You are not eligible to vote yet."
END IF
End
```

---

## Example 2: Categorizing Festival Attendees

### Problem Statement

For an outdoor festival, categorize attendees based on age: if they are 21 or older, they get an "Adult" wristband; otherwise, they get a "Minor" wristband.

### Process

#### Step 1: Define the Problem

Categorize festival attendees based on their age to determine wristband type.

#### Step 2: Identify Key Processes

- **Input the Person's Age:** Similar to the first example, the age is crucial information required to make a decision. Hence, inputting the age is the first process.
- **Check Age Condition:** The program needs to check if the age is 21 or older to decide which wristband to assign.
- **Print a Message Based on the Age:** The program should output the type of wristband the attendee should receive based on their age.

#### Step 3: Explanation

These processes are similar to the voting eligibility example, but the condition changes to 21 years. The decision on what type of wristband to issue is based on this input. The core processes of input, condition checking, and output are directly derived from the requirements.

#### Step 4: Decide on an Algorithm Structure

To decide on the appropriate algorithm structure, consider the following questions:

- Are there multiple conditions to check? No, there is only one condition: whether the person is 21 or older.
- Is the decision binary (two possible outcomes)? Yes, either "Adult" or "Minor."
- Does the problem involve complex decision-making or classification? No, it's a straightforward check.

**Chosen Structure:** A binary decision structure is ideal here because it handles two outcomes efficiently. Using an if/else statement can easily manage this condition.

#### Step 5: Create the Pseudocode
```
Start
Get age
IF age is greater than or equal to 21 THEN
    Display to user "Adult wristband."
OTHERWISE
    Display to user "Minor wristband."
END IF
End
```

---

## Example 3: Grading System

### Problem Statement

Write a program that takes a student's score as input. If the score is 90 or above, the grade is "A." If it's between 80 and 89, the grade is "B." If it's between 70 and 79, the grade is "C." Otherwise, the grade is "F."

### Process

#### Step 1: Define the Problem

Determine a student's letter grade based on their numerical score.

#### Step 2: Identify Key Processes

- **Input the Student's Score:** The program needs to gather the score to determine the grade.
- **Check Score Range:** Multiple ranges need to be checked to determine the correct grade (90+, 80-89, 70-79, below 70).
- **Print the Appropriate Grade:** The program should output the corresponding grade based on the score range.

#### Step 3: Explanation

The key processes involve taking an input (the score), checking multiple conditions to determine the appropriate grade, and then outputting that grade. This is necessary to meet the requirement of categorizing scores into grades.

#### Step 4: Decide on an Algorithm Structure

To decide on the appropriate algorithm structure, consider the following questions:

- Are there multiple conditions to check? Yes, there are multiple ranges to check.
- Is the decision binary? No, there are more than two possible outcomes (A, B, C, F).
- Does the problem involve classification into several categories? Yes, the problem involves classifying scores into more than two categories.

**Chosen Structure:** A series of conditional statements (if/else if/else) is suitable for this scenario. It allows for checking each condition in sequence until one is true, which is efficient for handling multiple possible outcomes.

#### Step 5: Create the Pseudocode
```
Start
Get score
IF score is greater than or equal to 90 THEN
    Display to user "Grade A."
OTHERWISE IF score is greater than or equal to 80 THEN
    Display to user "Grade B."
OTHERWISE IF score is greater than or equal to 70 THEN
    Display to user "Grade C."
OTHERWISE
    Display to user "Grade F."
END IF
End
```

---

## Problem 1: Discount Eligibility

### Scenario

You are tasked with creating a program to determine if a customer is eligible for a discount. The program should check the total amount a customer has spent and decide if they qualify for a discount.

### Instructions

1. Write a program that takes the total spending amount as input.
2. If the customer has spent $100 or more, print "10% discount applied."
3. If the customer has spent less than $100, print "No discount."

---

## Problem 2: Book Categorization

### Scenario

A library needs to categorize books based on their genre. You need to develop a program that helps categorize each book correctly.

### Instructions

1. Write a program that takes the genre of a book as input.
2. If the genre is "Fiction," print "Category: Fiction."
3. If the genre is "Non-Fiction," print "Category: Non-Fiction."
4. If the genre is "Science Fiction," print "Category: Science Fiction."
5. If the genre does not match any of these, print "Category: Unknown."

---

## Problem 3: Even or Odd Number

### Scenario

You need to create a program that determines whether a given number is even or odd.

### Instructions

1. Write a program that takes a number as input.
2. If the number is even, print "Even number."
3. If the number is odd, print "Odd number."