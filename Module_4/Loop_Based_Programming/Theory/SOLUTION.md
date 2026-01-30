# Activity: Loop-Based Programming for Repetitive Tasks - Answer Key

## Step 1: Using a For Loop to Calculate Total Scores

### Solution

```csharp
using System;

public class Program
{
    public static void Main()
    {
        int[] scores = { 85, 90, 78, 92, 88 };
        int total = 0;

        for (int i = 0; i < scores.Length; i++) {
            total += scores[i];
        }

        Console.WriteLine("Total score: " + total);
    }
}
```

**Code File:** See [Step1_TotalScores.cs](Step1_TotalScores.cs)

### Explanation

- **Array Declaration:** The scores are stored in an array.
- **For Loop:** Iterates through each element in the array.
- **Accumulation:** Each score is added to the total variable.
- **Output:** The final total is displayed to the user.
