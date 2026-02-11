Activity: Methods in C#
Objective:

Use methods in C#: definition, syntax, and use cases.
Example 1: Defining a Method to Add Two Numbers
Problem Statement

Write a method that adds two numbers and returns the result. The method should take two integer parameters.
Step 1: Define the Method to Add Two Numbers

Code:

public int AddNumbers(int a, int b) {
     return a + b;
}

Line-by-Line Explanation:

    public: Access Modifier - Indicates that the method is accessible from other classes. It defines the visibility of the method.

    int: Return Type - Specifies that the method returns an integer value. This is crucial for defining what type of value the method will output.

    AddNumbers: Method Name - The name of the method. It should be descriptive and indicate what the method does.

    (int a, int b): Parameters - These are the inputs to the method. a and b are placeholders for the values that will be passed to the method. Both are of type int.

    { return a + b; }: Method Body - Contains the logic of the method. return a + b; calculates the sum of a and b and returns the result to the caller.

Step 2: Implement and Test the Method

Code:

using System;
public class Program {
	public static void Main() {


Console.WriteLine("Enter the first number:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = AddNumbers(num1, num2);

Console.WriteLine("The sum of the numbers is: " + result);

}
	static int AddNumbers(int a, int b) {
		return a + b;
	}
}

Line-by-Line Explanation:

    using System;: Namespace Import - Imports the System namespace, which is required for console input and output.

    class Program {: Class Definition - Defines a class named Program. In C#, methods must be contained within classes.

    static void Main() {: Main Method - The entry point of the program where execution starts. static means it can be called without creating an instance of the class, and void indicates it does not return a value.

    Console.WriteLine("Enter the first number:");: Prompt for Input - Displays a message asking the user to enter the first number.

    int num1 = Convert.ToInt32(Console.ReadLine());: Read and Convert Input - Reads the user’s input from the console, converts it to an integer, and assigns it to num1.

    Console.WriteLine("Enter the second number:");: Prompt for Input - Displays a message asking the user to enter the second number.

    int num2 = Convert.ToInt32(Console.ReadLine());: Read and Convert Input - Reads the second input, converts it to an integer, and assigns it to num2.

    int result = AddNumbers(num1, num2);: Call Method - Calls the AddNumbers method with num1 and num2 as arguments and stores the result in result.

    Console.WriteLine("The sum of the numbers is: " + result);: Display Result - Outputs the result of the addition to the console.

    static int AddNumbers(int a, int b) {: Method Definition - Defines the AddNumbers method that takes two integer parameters and returns their sum.

    return a + b;: Return Statement - Calculates the sum and returns it.

Step 3: Run the code

Now that we have built the full code, if you would like to run the code below, visit Dot Net Fiddle
, delete the code on the page, paste the code below into the left-hand side, and select run. 

using System;
public class Program {
   public static void Main() {
        Console.WriteLine("Enter the original price:");
        decimal originalPrice = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Enter the discount rate (as a decimal, e.g., 0.20 for 20%):");
        decimal discountRate = Convert.ToDecimal(Console.ReadLine());

        decimal finalPrice = CalculateDiscount(originalPrice, discountRate);
        Console.WriteLine("The final price after discount is: " + finalPrice);
    }

    static decimal CalculateDiscount(decimal originalPrice, decimal discountRate) {
        return originalPrice * (1 - discountRate);
    }
}

Line-by-Line Explanation:

    using System;: Namespace Import - Imports the System namespace, which is required for console input and output.

    class Program {: Class Definition - Defines a class named Program. In C#, methods must be contained within classes.

    static void Main() {: Main Method - The entry point of the program where execution starts. static means it can be called without creating an instance of the class, and void indicates it does not return a value.

    Console.WriteLine("Enter the first number:");: Prompt for Input - Displays a message asking the user to enter the first number.

    int num1 = Convert.ToInt32(Console.ReadLine());: Read and Convert Input - Reads the user’s input from the console, converts it to an integer, and assigns it to num1.

    Console.WriteLine("Enter the second number:");: Prompt for Input - Displays a message asking the user to enter the second number.

    int num2 = Convert.ToInt32(Console.ReadLine());: Read and Convert Input - Reads the second input, converts it to an integer, and assigns it to num2.

    int result = AddNumbers(num1, num2);: Call Method - Calls the AddNumbers method with num1 and num2 as arguments and stores the result in result.

    Console.WriteLine("The sum of the numbers is: " + result);: Display Result - Outputs the result of the addition to the console.

    static int AddNumbers(int a, int b) {: Method Definition - Defines the AddNumbers method that takes two integer parameters and returns their sum.

    return a + b;: Return Statement - Calculates the sum and returns it.

Step 3: Run the code

Now that we have built the full code, if you would like to run the code below, visit Dot Net Fiddle
, delete the code on the page, paste the code below into the left-hand side, and select run. 

Example 2: Creating a Method to Calculate the Discount on a Product

Problem Statement

Write a method to calculate the discount on a product. The method should take two parameters: the original price and the discount rate, and return the final price after applying the discount.
Step 1: Define the Method to Calculate Discount

Code:

public decimal CalculateDiscount(decimal originalPrice, decimal discountRate) {
return originalPrice * (1 - discountRate);
}

Line-by-Line Explanation:

    public: Access Modifier - Makes the method accessible from other classes.

    decimal: Return Type - Specifies that the method returns a decimal value. This is suitable for financial calculations requiring precision.

    CalculateDiscount: Method Name - The name of the method, describing its function.

    (decimal originalPrice, decimal discountRate): Parameters - originalPrice and discountRate are the inputs to the method, both of type decimal.

    { return originalPrice * (1 - discountRate); }: Method Body - Calculates the final price after discount. 1 - discountRate gives the proportion of the price that remains after applying the discount.

Step 2: Implement and Test the Method

Code:

using System;
public class Program {
   public static void Main() {
        Console.WriteLine("Enter the original price:");
        decimal originalPrice = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Enter the discount rate (as a decimal, e.g., 0.20 for 20%):");
        decimal discountRate = Convert.ToDecimal(Console.ReadLine());

        decimal finalPrice = CalculateDiscount(originalPrice, discountRate);
        Console.WriteLine("The final price after discount is: " + finalPrice);
    }

    static decimal CalculateDiscount(decimal originalPrice, decimal discountRate) {
        return originalPrice * (1 - discountRate);
    }
}

Line-by-Line Explanation:

    using System;: Namespace Import - Imports the required namespace for console operations.

    class Program {: Class Definition - Defines a class named Program.

    static void Main() {: Main Method - The entry point of the application.

    Console.WriteLine("Enter the original price:");: Prompt for Input - Asks the user to input the original price.

    decimal originalPrice = Convert.ToDecimal(Console.ReadLine());: Read and Convert Input - Reads the user input and converts it to a decimal.

    Console.WriteLine("Enter the discount rate (as a decimal, e.g., 0.20 for 20%):");: Prompt for Input - Asks the user to input the discount rate.

    decimal discountRate = Convert.ToDecimal(Console.ReadLine());: Read and Convert Input - Reads the discount rate and converts it to a decimal.

    decimal finalPrice = CalculateDiscount(originalPrice, discountRate);: Call Method - Calls the CalculateDiscount method with the user-provided values.

    Console.WriteLine("The final price after discount is: " + finalPrice);: Display Result - Outputs the final price after applying the discount.

    static decimal CalculateDiscount(decimal originalPrice, decimal discountRate) {: Method Definition - Defines the CalculateDiscount method.

    return originalPrice * (1 - discountRate);: Return Statement - Computes and returns the final price after discount.

Step 3: Run the code

Now that we have built the full code, if you would like to run the code below, visit Dot Net Fiddle
, delete the code on the page, paste the code below into the left-hand side, and select run. 

using System;
public class Program {
   public static void Main() {
        Console.WriteLine("Enter the original price:");
        decimal originalPrice = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Enter the discount rate (as a decimal, e.g., 0.20 for 20%):");
        decimal discountRate = Convert.ToDecimal(Console.ReadLine());

        decimal finalPrice = CalculateDiscount(originalPrice, discountRate);
        Console.WriteLine("The final price after discount is: " + finalPrice);
    }

    static decimal CalculateDiscount(decimal originalPrice, decimal discountRate) {
        return originalPrice * (1 - discountRate);
    }
}
using System;
public class Program {
   public static void Main() {
        Console.WriteLine("Enter the original price:");
        decimal originalPrice = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Enter the discount rate (as a decimal, e.g., 0.20 for 20%):");
        decimal discountRate = Convert.ToDecimal(Console.ReadLine());

        decimal finalPrice = CalculateDiscount(originalPrice, discountRate);
        Console.WriteLine("The final price after discount is: " + finalPrice);
    }

    static decimal CalculateDiscount(decimal originalPrice, decimal discountRate) {
        return originalPrice * (1 - discountRate);
    }
}

Problem 1: Creating a Function for Circle Area Calculation

Problem Statement

Write a method to calculate the area of a circle. The method should accept one input parameter: the radius of the circle. The program should prompt the user for this value, use the method to compute the area, and then display the result.

Formula: The area of a circle is given by π * r^2 where r is the radius of the circle.

You can draft and run your code directly in Dot Net Fiddle
, a simple online editor for .NET projects. If you prefer, you can also use a text editor like Notepad or Visual Studio Code, but DotNetFiddle is great for testing and running your code quickly! To run your code, visit Dot Net Fiddle
, delete the code on the page, paste your code into the left-hand side, and select run.
Problem 2: Creating a Function for Trapezoid Area Calculation

Problem Statement

Write a method to calculate the area of a trapezoid. The method should accept three input parameters: the length of the two parallel sides (a and b) and the height. The program should prompt the user for these values, use the method to compute the area, and then display the result.

Formula: The area of a trapezoid is given by (a + b) / 2 * height.

You can draft and run your code directly in Dot Net Fiddle
, a simple online editor for .NET projects. If you prefer, you can also use a text editor like Notepad or Visual Studio Code, but DotNetFiddle is great for testing and running your code quickly! To run your code, visit Dot Net Fiddle
, delete the code on the page, paste your code into the left-hand side, and select run.