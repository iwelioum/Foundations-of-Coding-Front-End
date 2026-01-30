// Step 3: Using Methods with Return Values
using System;

public class Program
{
    public static void Main() {
        // Call the method and store the result
        int sum = CalculateSum(5, 7);
        Console.WriteLine("The sum is: " + sum);
    }

    // Method Definition
    static int CalculateSum(int a, int b) {
        return a + b;
    }
}
