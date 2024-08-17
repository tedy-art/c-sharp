using System;
using System.Linq;
using System.Collections.Generic;


class LINQMethodSyntaxExample
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var evenNumbers = numbers.Where(num => num % 2 == 0);

        Console.WriteLine("Even Number : ");
        foreach(var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
    }
}