// Handle user input and display a greeting
using System;

public class UserInput
{
    public static void GreetUser()
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello " + name + "!");
    }

    public static void Main(string[] args)
    {
        GreetUser();
    }
}
