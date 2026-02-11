// Step 1: Integrating If-Else with Loops - Even Number Validator
using System;

public class Program
{
    public static void Main()
    {
        int input;
        do {
            Console.WriteLine("Enter an even number between 1 and 10:");
            input = int.Parse(Console.ReadLine());
            if (input >= 1 && input <= 10 && input % 2 == 0) {
                Console.WriteLine("Valid input: " + input);
                break;
            } else {
                Console.WriteLine("Invalid input. Please try again.");
            }
        } while (true);
    }
}
