# Activity: Translating Algorithms into C# Code

## Objective

Translate algorithms from pseudocode into functional C# code by following structured examples and solving problems.

## Description

In this activity, you'll translate pseudocode into functional C# code by implementing algorithms. You'll practice with examples like finding the largest number in an array and checking if a number is even or odd. You'll then apply these skills to solve problems such as calculating the sum of an array and counting vowels in a string.

---

## Example 1: Finding the Largest Number in an Array

### Problem Statement

Write an algorithm to find the largest number in a given array of integers.

### 1. Pseudocode

```
Start
Create variable largest and set it to the first number in the array
For each number in the array
    If number is greater than largest
        Set variable largest to number
End For
Display to user value of variable largest
End
```

### 2. Translation

- **Initialization:** The array `numbers` is defined with some integer values, and `largest` is initialized to the first element of the array.
- **Iteration:** A `foreach` loop is used to iterate through each element in the array.
- **Comparison:** An `if` statement checks if the current number is greater than `largest`. If it is, `largest` is updated.
- **Output:** The largest number is printed after the loop completes.

### 3. C# Code

```csharp
// Initialize an array of integers
int[] numbers = { 5, 8, 3, 4, 2 };
int largest = numbers[0];

// Loop through each number in the array
foreach (int number in numbers)
{
    // Check if the current number is greater than the largest
    if (number > largest)
    {
        largest = number;
    }
}

// Output the largest number
Console.WriteLine("The largest number is: " + largest);
```

---

## Example 2: Checking If a Number is Even or Odd

### Problem Statement

Write an algorithm to check if a given number is even or odd.

### 1. Pseudocode

```
Start
Ask user for number
If remainder of number divided by 2 is equal to 0
    Display "Number is even"
Otherwise
    Display "Number is odd"
End
```

### 2. Translation

- **Initialization:** The variable `number` is set to 42.
- **Condition Check:** The `if` statement checks if the remainder of `number` divided by 2 is zero using the modulus operator `%`.
- **Output:** Based on the result of the condition, it prints either "The number is even." or "The number is odd.".

### 3. C# Code

```csharp
// Declare and initialize a number
int number = 42;

// Check if the number is even or odd
if (number % 2 == 0)
{
    Console.WriteLine("The number is even.");
}
else
{
    Console.WriteLine("The number is odd.");
}
```

---

## Student Problems to Solve

### Problem 1: Calculating the Sum of an Array

#### Problem Statement

Write an algorithm that calculates the sum of all numbers in a given array of integers.

#### 1. Pseudocode

```
Start
Create variable sum and set it to 0
For each number in the array
    Add number to sum
End For
Display the value of variable sum to user
End
```

#### 2. Translate to C#

Write your C# code here.

---

### Problem 2: Counting the Number of Vowels in a String

#### Problem Statement

Write an algorithm to count the number of vowels (a, e, i, o, u) in a given string.

#### 1. Pseudocode

```
Start
Create variable vowelCount and set to 0
For each character in the string
    If character is a vowel
        Add 1 to vowelCount
End For
Print vowelCount
End
```

#### 2. Translate to C#

Write your C# code here.
