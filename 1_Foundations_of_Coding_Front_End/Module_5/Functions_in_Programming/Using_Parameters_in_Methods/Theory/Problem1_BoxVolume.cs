// Problem 1: Calculate the Volume of a Rectangular Box
using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the length of the box:");
        int length = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the width of the box:");
        int width = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height of the box:");
        int height = int.Parse(Console.ReadLine());

        int volume = CalculateVolume(length, width, height);
        Console.WriteLine("The volume of the rectangular box is: " + volume);
    }

    public static int CalculateVolume(int length, int width, int height)
    {
        int volume = length * width * height;
        return volume;
    }
}
