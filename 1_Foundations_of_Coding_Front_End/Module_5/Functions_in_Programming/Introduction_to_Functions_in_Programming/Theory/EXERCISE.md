Introduction to Functions in Programming

Objective:

Use functions to create reusable code blocks.
Example 1: Writing a Function to Calculate the Area of a Rectangle
Problem Statement

Write a function that calculates the area of a rectangle. The function should accept two input parameters: the length and the width of the rectangle. The program will prompt the user for these values, use the function to compute the area, and then display the result.
Step-by-Step Code Construction
Step 1: Define the Function to Calculate the Rectangle's Area

Write a function that takes two parameters, length and width, and returns the area of the rectangle.

Code:

double CalculateRectangleArea(double length, double width)
{
    return length * width;
}

Explanation:

    double CalculateRectangleArea: This line defines a function that returns a double value. The function is named CalculateRectangleArea. Inside the parentheses, we declare two parameters: length and width. These parameters represent the length and width of the rectangle and will be passed into the function when it is called.

    return length * width: This line returns the product of length and width, which calculates the area of the rectangle.

Step 2: Call the Rectangle Area Function

Prompt the user to input the length and width of the rectangle, call the function CalculateRectangleArea, and print the area.

Code:

Console.WriteLine("Enter the length of the rectangle:");double length = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the width of the rectangle:");double width = Convert.ToDouble(Console.ReadLine());

double area = CalculateRectangleArea(length, width);
Console.WriteLine("The area of the rectangle is: " + area);

Explanation:

    Convert.ToDouble(Console.ReadLine()): This reads the user’s input as a string and converts it to a double, allowing us to perform mathematical calculations.

    CalculateRectangleArea(length, width): This calls the CalculateRectangleArea function with the user’s inputs. The function calculates the area of the rectangle and returns the result.

    Console.WriteLine("The area of the rectangle is: " + area): This prints the calculated area to the console.

Step Statement: Full Code for Rectangle Area Calculation

Now that we’ve defined the function and learned how to call it, we can run the full code block for the rectangle area calculation together. This block includes user input, function definition, and output to the console.
Full Code Block: Rectangle Area Function

1. Create the function to calculate the area of a rectangle:

double CalculateRectangleArea(double length, double width)
{
    return length * width;
}

2. Prompt the user to input the length and width:

Console.WriteLine("Enter the length of the rectangle:");
double length = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the width of the rectangle:");
double width = Convert.ToDouble(Console.ReadLine());

3. Call the function to calculate the area:

double area = CalculateRectangleArea(length, width);

4. Output the result:

Console.WriteLine("The area of the rectangle is: " + area);

You can draft and run your code directly in Dot Net Fiddle
, a simple online editor for .NET projects. If you prefer, you can also use a text editor like Notepad or Visual Studio Code, but DotNetFiddle is great for testing and running your code quickly! If you would like to run the code below, visit Dot Net Fiddle
, delete the code on the page, paste the code into the left-hand side, and select run. 

using System;

class Program
{
    // Function to calculate the area of a rectangle
    static double CalculateRectangleArea(double length, double width)
    {
        return length * width;
    }

    static void Main(string[] args)
    {
        // Prompt the user to input the length and width
        Console.WriteLine("Enter the length of the rectangle:");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the width of the rectangle:");
        double width = Convert.ToDouble(Console.ReadLine());

        // Call the function to calculate the area
        double area = CalculateRectangleArea(length, width);

        // Output the result
        Console.WriteLine("The area of the rectangle is: " + area);
    }
}

Example 2: Writing a Function to Calculate the Area of a Triangle
Problem Statement

Write a function that calculates the area of a triangle. The function should accept two input parameters: the base and the height of the triangle. The program will prompt the user for these values, use the function to compute the area, and then display the result.
Step-by-Step Code Construction
Step 1: Define the Function to Calculate the Triangle's Area

Write a function that takes two parameters, baseLength and height, and returns the area of the triangle.

Code:

double CalculateTriangleArea(double baseLength, double height)
{
    return 0.5 * baseLength * height;
}

Explanation:

    double CalculateTriangleArea: This defines a function that returns a double value. The function is named CalculateTriangleArea. It accepts two parameters: baseLength and height. The function will return the calculated area of the triangle.

    return 0.5 * baseLength * height: The formula for the area of a triangle is 0.5 * base * height. This line returns the result of the calculation.

Step 2: Call the Triangle Area Function

Prompt the user to input the base and height of the triangle, call the function CalculateTriangleArea, and print the area.

Code:

Console.WriteLine("Enter the base length of the triangle:");double baseLength = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the height of the triangle:");double height = Convert.ToDouble(Console.ReadLine());

double area = CalculateTriangleArea(baseLength, height);
Console.WriteLine("The area of the triangle is: " + area);

Explanation:

    Convert.ToDouble(Console.ReadLine()): This reads the user’s input and converts it into a double so it can be used in calculations.

    CalculateTriangleArea(baseLength, height): This calls the CalculateTriangleArea function, passing in the values provided by the user. The function returns the calculated area of the triangle, which is stored in the area variable.

    Console.WriteLine("The area of the triangle is: " + area): This prints the calculated area to the console.

Step Statement: Full Code for Triangle Area Calculation

With both the function defined and the logic to call it, here is the full code block that can be run. It includes input prompts, function definition, and output. 
Full Code Block: Triangle Area Function

1. Create the function to calculate the area of a triangle:

static double CalculateTriangleArea(double baseLength, double height)
{
    return 0.5 * baseLength * height;
}

2. Prompt the user to input the base and height:

Console.WriteLine("Enter the base length of the triangle:");
double baseLength = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the height of the triangle:");
double height = Convert.ToDouble(Console.ReadLine());

3. Call the function to calculate the area:

double area = CalculateTriangleArea(baseLength, height);

4. Output the result:

Console.WriteLine("The area of the triangle is: " + area); 

You can draft and run your code directly in Dot Net Fiddle
, a simple online editor for .NET projects. If you prefer, you can also use a text editor like Notepad or Visual Studio Code, but DotNetFiddle is great for testing and running your code quickly! If you would like to run the code below, visit Dot Net Fiddle
, delete the code on the page, paste the code into the left-hand side, and select run

using System;
public class Program
{
    // Function to calculate the area of a triangle
    static double CalculateTriangleArea(double baseLength, double height)
    {
        return 0.5 * baseLength * height;
    }
    public static void Main()
    {
        // Prompt the user to input the base length
        Console.WriteLine("Enter the base length of the triangle:");
        double baseLength = Convert.ToDouble(Console.ReadLine());
        // Prompt the user to input the height
        Console.WriteLine("Enter the height of the triangle:");
        double height = Convert.ToDouble(Console.ReadLine());
        // Call the function to calculate the area
        double area = CalculateTriangleArea(baseLength, height);
        // Output the result
        Console.WriteLine("The area of the triangle is: " + area);
    }
}

Problem 1: Creating a Function for Circle Area Calculation
Problem Statement

Write a function to calculate the area of a circle. The function should accept one input parameter: the radius of the circle. The program should prompt the user for this value, use the function to compute the area, and then display the result.

Formula: The area of a circle is given by π * r^2 where r is the radius of the circle. For Pi you will use the code Math.PI.

You can draft and run your code directly in Dot Net Fiddle
, a simple online editor for .NET projects. If you prefer, you can also use a text editor like Notepad or Visual Studio Code, but DotNetFiddle is great for testing and running your code quickly! To run your code, visit Dot Net Fiddle
, delete the code on the page, paste your code into the left-hand side, and select run.
Problem 2: Creating a Function for Trapezoid Area Calculation
Problem Statement

Write a function to calculate the area of a trapezoid. The function should accept three input parameters: the length of the two parallel sides (a and b) and the height. The program should prompt the user for these values, use the function to compute the area, and then display the result.

Formula: The area of a trapezoid is given by (a + b) / 2 * height.

You can draft and run your code directly in Dot Net Fiddle
, a simple online editor for .NET projects. If you prefer, you can also use a text editor like Notepad or Visual Studio Code, but DotNetFiddle is great for testing and running your code quickly! To run your code, visit Dot Net Fiddle
, delete the code on the page, paste your code into the left-hand side, and select run.