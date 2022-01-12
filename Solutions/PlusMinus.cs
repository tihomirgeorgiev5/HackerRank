using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    public static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        int intResult = 0;
        double doubleResult = 0;
        string stringResult = String.Empty;

        int inputInt = int.Parse(Console.ReadLine());
        double inputDouble = double.Parse(Console.ReadLine());
        string inputString = Console.ReadLine();

        intResult = inputInt + i;
        Console.WriteLine(intResult);

        doubleResult = inputDouble + d ;
        Console.WriteLine($"{doubleResult:f1}");

        stringResult = s + inputString;
        Console.WriteLine(stringResult);

        

        // Declare second integer, double, and String variables.

        // Read and save an integer, double, and String to your variables.

        // Print the sum of both integer variables on a new line.

        // Print the sum of the double variables on a new line.

        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.

    }
}