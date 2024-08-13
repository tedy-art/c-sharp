using System;
using System.Collections.Generic;

namespace genericSortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> students = new SortedDictionary<int, string>();

            students.Add(3, "John");
            students.Add(1, "Alice");
            students.Add(2, "Bob");

            foreach(var student in students)
            {
                Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
            }
        }
    }
}