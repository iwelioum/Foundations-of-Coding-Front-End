Using Parameters in Methods
Objective:

Use methods and parameters to create reusable code blocks in C# that perform basic calculations.
Example 1: Basic Method – Calculating the Area of a Rectangle

Problem Statement:

You are tasked with writing a method in C# that calculates the area of a rectangle. The method should accept two integer parameters: length and width. The method should return the calculated area, which is the product of the two parameters.
Step 1: Define the Method with Parameters

public static int CalculateArea(int length, int width)
{
// Code to calculate area
}

Explanation:

    public: The method is accessible from outside its class.

    static: This indicates the method or variable belongs to the class itself, not to any instance of the class.

    int: This indicates that the method will return an integer value.

    CalculateArea: The name of the method, which describes its functionality.

    int length, int width: These are the method’s parameters. They allow you to pass values (length and width) to the method when you call it.

Step 2: Implement the Logic to Calculate the Area

public static int CalculateArea(int length, int width)
{
int area = length * width;
return area;
}

Explanation:

    int area = length * width;: This line of code multiplies the two parameters, length and width, and stores the result in a variable called area.

    return area;: This line returns the calculated area from the method back to the caller.

Step 3: Use the Method in the Main Program

using System;

public class Program
{
    // The Main method: Entry point of the program
    public static void Main()
    {
        // Prompt the user for the length of the rectangle
        Console.WriteLine("Enter the length of the rectangle:");
        int length = int.Parse(Console.ReadLine());

        // Prompt the user for the width of the rectangle
        Console.WriteLine("Enter the width of the rectangle:");
        int width = int.Parse(Console.ReadLine());

        // Call the function to calculate the area and store the result in 'area'
        int area = CalculateArea(length, width);

        // Output the result
        Console.WriteLine("The area of the rectangle is: " + area);
    }

    // Define the method to calculate the rectangle's area
    public static int CalculateArea(int length, int width)
    {
        int area = length * width; 
        return area;
    }
}

Explanation:

    Console.WriteLine("Enter the length of the rectangle:");: This line requests input from the user

    int length = int.Parse(Console.ReadLine());: This line reads the user’s input for the length of the rectangle and converts it into an integer.

    int area = CalculateArea(length, width);: This line calls the CalculateArea method, passing the user inputs length and width as arguments.

    Console.WriteLine("The area of the rectangle is: " + area);: This line prints the result of the method call, displaying the calculated area to the user.

In order to run the code, visit Dot Net Fiddle
, delete the code on the page, paste the code above into the left-hand side,  and select run.
Example 2: Advanced Method – Calculating the Perimeter of a Rectangle

Problem Statement:

Write a method in C# that calculates the perimeter of a rectangle. The method should accept two integer parameters: length and width. The method should return the perimeter, calculated using the formula:

Perimeter = 2 * (length + width).
Step 1: Define the Method with Parameters

public static int CalculatePerimeter(int length, int width)
{
// Code to calculate perimeter
}

Explanation:

    public: The method is accessible from other classes.

    static: This indicates the method or variable belongs to the class itself, not to any instance of the class.

    int: The return type of the method, indicating that it will return an integer value.

    CalculatePerimeter: The name of the method.

    int length, int width: These parameters allow the method to accept the length and width values when it is called.

Step 2: Implement the Logic to Calculate the Perimeter

public static int CalculatePerimeter(int length, int width)
{
int perimeter = 2 * (length + width);
return perimeter;
}

Explanation:

    int perimeter = 2 * (length + width);: This line calculates the perimeter of the rectangle by summing the length and width and then multiplying the result by 2.

    return perimeter;: This returns the calculated perimeter to the calling method.

Step 3: Use the Method in the Main Program

using System;

public class Program

{
    public static void Main()
    {
        Console.WriteLine("Enter the length of the rectangle:");
        int length = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the width of the rectangle:");
        int width = int.Parse(Console.ReadLine());

        int perimeter = CalculatePerimeter(length, width);

        Console.WriteLine("The perimeter of the rectangle is: " + perimeter);
    }

    public static int CalculatePerimeter(int length, int width)
    {
        return 2 * (length + width);
    }
}

Explanation:

    Console.WriteLine("Enter the length of the rectangle:");: This line requests input from the user

    int length = int.Parse(Console.ReadLine());: This line reads the user’s input for the length of the rectangle and converts it into an integer.

    int perimeter = CalculatePerimeter(length, width);: This line calls the CalculatePerimeter method, passing the user inputs length and width as arguments.

    Console.WriteLine("The perimeter of the rectangle is: " + perimeter);: This prints the perimeter to the console.

In order to run the code, visit Dot Net Fiddle
, delete the code on the page, paste the code above into the left-hand side,  and select run.
Problem 1: Calculate the Volume of a Rectangular Box

Problem Statement:

Write a method that calculates the volume of a rectangular box. The method should accept three integer parameters: length, width, and height. The method should return the volume calculated as:

Volume = length * width * height.

You can draft and run your code directly in Dot Net Fiddle
, a simple online editor for .NET projects. If you prefer, you can also use a text editor like Notepad or Visual Studio Code, but DotNetFiddle is great for testing and running your code quickly! In order to run your code, visit Dot Net Fiddle
, delete the code on the page, paste your code into the left-hand side,  and select run.
Problem 2: Calculate the Average of Three Numbers

Problem Statement:

Write a method that calculates the average of three integer numbers. The method should accept three parameters: num1, num2, and num3. The method should return the average as an integer.

You can draft and run your code directly in Dot Net Fiddle
, a simple online editor for .NET projects. If you prefer, you can also use a text editor like Notepad or Visual Studio Code, but DotNetFiddle is great for testing and running your code quickly! In order to run your code, visit Dot Net Fiddle
, delete the code on the page, paste your code into the left-hand side,  and select run.