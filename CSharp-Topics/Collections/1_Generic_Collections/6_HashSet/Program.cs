using System;
using System.Collections.Generic;

namespace genericHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numbers = new HashSet<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(2); // Duplicate, will not be added
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            Console.WriteLine(numbers.Contains(1));
            Console.WriteLine(numbers.Contains(6));
            Console.WriteLine(numbers);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}