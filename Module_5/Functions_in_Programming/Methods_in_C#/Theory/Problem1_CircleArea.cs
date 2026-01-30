// Problem 1: Creating a Function for Circle Area Calculation
using System;

class Program {
    static void Main() {
        // Prompt the user for the radius of the circle
        Console.WriteLine("Enter the radius of the circle:");
        double radius = Convert.ToDouble(Console.ReadLine());

        // Call the function to calculate the area and store the result in 'area'
        double area = CalculateCircleArea(radius);

        // Output the result
        Console.WriteLine("The area of the circle is: " + area);
    }

    // Define the method to calculate the circle's area
    static double CalculateCircleArea(double radius) {
        return Math.PI * radius * radius;
    }
}
