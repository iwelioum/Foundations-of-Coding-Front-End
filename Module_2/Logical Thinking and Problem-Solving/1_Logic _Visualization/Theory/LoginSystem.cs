// Login System Example
using System;

class LoginSystem
{
    static void Main()
    {
        string validUsername = "admin";
        string validPassword = "password123";

        Console.WriteLine("Enter username:");
        string username = Console.ReadLine();
        Console.WriteLine("Enter password:");
        string password = Console.ReadLine();

        if (username == validUsername && password == validPassword)
        {
            Console.WriteLine("Access granted");
        }
        else
        {
            Console.WriteLine("Access denied");
        }
    }
}
