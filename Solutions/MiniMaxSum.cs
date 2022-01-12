using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        
        long minSum = 0;
        long maxSum = 0;
        long minNum = arr.Min();
        long maxNum = arr.Max();
        
        while (minNum != maxNum)
        {
            for (int i = 0; i < arr.Count; i++)
            {

                if (arr[i] != minNum)
                {
                    maxSum += arr[i];
                }
                if (arr[i] != maxNum)
                {
                    minSum += arr[i];
                }



            }
            break;

           
        }
        if (minNum == maxNum)
        {
            for (int j = 0; j < arr.Count - 1; j++)
            {
                minSum += arr[j];
                maxSum += arr[j];
            }
        }
        
        Console.WriteLine($"{minSum} {maxSum}");

    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
