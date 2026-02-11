# Activity: Translating Algorithms into C# Code - Answer Key

---

## Problem 1: Calculating the Sum of an Array

### Solution

```csharp
// Initialize an array of integers
int[] numbers = { 1, 2, 3, 4, 5 };
int sum = 0;

// Loop through each number in the array
foreach (int number in numbers)
{
    // Add each number to the sum
    sum += number;
}

// Output the sum
Console.WriteLine("The sum of the array is: " + sum);
```

### Explanation

- **Initialization:** An array `numbers` is created with five integers, and a variable `sum` is initialized to 0.
- **Iteration:** A `foreach` loop iterates through each number in the array.
- **Accumulation:** Each number is added to the `sum` variable using the `+=` operator.
- **Output:** The final sum is displayed to the user.

**Code File:** See [Problem1_ArraySum.cs](Problem1_ArraySum.cs)

---

## Problem 2: Counting the Number of Vowels in a String

### Solution

```csharp
// Initialize a string
string text = "Hello World";
int vowelCount = 0;

// Loop through each character in the string
foreach (char c in text.ToLower())
{
    // Check if the character is a vowel
    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
    {
        vowelCount++;
    }
}

// Output the number of vowels
Console.WriteLine("The number of vowels is: " + vowelCount);
```

### Explanation

- **Initialization:** A string `text` is created with the value "Hello World", and `vowelCount` is initialized to 0.
- **Iteration:** A `foreach` loop iterates through each character in the string. The `.ToLower()` method converts all characters to lowercase for easier comparison.
- **Condition Check:** An `if` statement checks if the character is a vowel (a, e, i, o, u).
- **Counting:** If the character is a vowel, `vowelCount` is incremented.
- **Output:** The total number of vowels is displayed to the user.

**Code File:** See [Problem2_VowelCount.cs](Problem2_VowelCount.cs)
