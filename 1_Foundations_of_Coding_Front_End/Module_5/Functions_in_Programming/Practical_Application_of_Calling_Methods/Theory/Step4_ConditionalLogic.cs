// Step 4: Combining Methods and Conditional Logic
using System;

public class Program
{
    public static void Main() {
        // Call the method
        int number = -3;
        bool result = IsPositive(number);
        if (result) {
            Console.WriteLine("The number is positive.");
        } else {
            Console.WriteLine("The number is not positive.");
        }
    }

    static bool IsPositive(int number) {
        if (number > 0) {
            return true;
        } else {
            return false;
        }
    }
}
