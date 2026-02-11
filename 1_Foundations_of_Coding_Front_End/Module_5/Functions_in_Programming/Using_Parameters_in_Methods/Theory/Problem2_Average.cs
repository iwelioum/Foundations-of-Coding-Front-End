// Problem 2: Calculate the Average of Three Numbers
using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter third number:");
        int num3 = int.Parse(Console.ReadLine());

        int average = CalculateAverage(num1, num2, num3);
        Console.WriteLine("The average is: " + average);
    }

    public static int CalculateAverage(int num1, int num2, int num3)
    {
        int average = (num1 + num2 + num3) / 3;
        return average;
    }
}
