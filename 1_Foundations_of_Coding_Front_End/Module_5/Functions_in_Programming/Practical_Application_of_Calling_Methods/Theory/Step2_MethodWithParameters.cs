// Step 2: Creating a Method with Parameters
using System;

public class Program
{
    public static void Main() {
        // Call the method
        GreetUser("Alice");
    }

    // Method Definition
    static void GreetUser(string name) {
        Console.WriteLine("Hello " + name + "!");
    }
}
