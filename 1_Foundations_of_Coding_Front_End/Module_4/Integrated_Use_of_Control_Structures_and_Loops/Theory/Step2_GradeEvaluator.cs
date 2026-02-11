// Step 2: Using If-Else to Evaluate Grades
using System;

public class Program
{
    public static void Main()
    {
        int[] grades = { 85, 92, 78, 64, 89 };

        for (int i = 0; i < grades.Length; i++) {
            int grade = grades[i];
            string result;
            if (grade >= 65) {
                result = "Pass";
            } else {
                result = "Fail";
            }
            Console.WriteLine($"Score: {grade} Result: {result}");
        }
    }
}
