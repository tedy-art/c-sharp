using System;
using System.Collections.Generic;

namespace genericSortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> numbers = new SortedSet<int>();
            numbers.Add(5);
            numbers.Add(1);
            numbers.Add(3);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}