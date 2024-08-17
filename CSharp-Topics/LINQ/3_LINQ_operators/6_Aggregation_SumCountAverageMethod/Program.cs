using System;
using System.Linq;
using System.Collections.Generic;

public class LinqAggregation_SumCountAvgMethod
{
    static void Main(string[] args)
    {
        // Sum
        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = numbers.Sum();
        Console.WriteLine($"sum : {sum}");

        // Count
        int count = numbers.Count();
        Console.WriteLine($"count : {count}");

        // Averages 
        double avg = numbers.Average();
        Console.WriteLine($"Average : {avg}");

        Console.ReadLine();
    }
}