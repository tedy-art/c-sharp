using System;
using System.Linq;
using System.Collections.Generic;

class LINQQuerySyntaxExample
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var evenNumbers = from num in numbers
                          where num % 2 == 0
                          select num;

        Console.WriteLine("Even numbers : ");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
    }
}