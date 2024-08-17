using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}


public class LinqSortingOrderByAndThenByMethod
{
    static void Main(string[] args)
    {
        string[] names = { "Jhon", "Anna", "Kyle", "Michael", "Zara" };


        // OrderBy()
        var sortNames = names.OrderBy(n => n);

        Console.WriteLine("OrderBy() method for ascending Order : ");
        foreach (var name in sortNames) {
            Console.WriteLine(name);

        }

        // OrderByDescending()
        var sortDescendingOrder = names.OrderByDescending(n => n);

        Console.WriteLine();
        Console.WriteLine("OrderByDecending() method for Decending Order : ");
        foreach (var name in sortDescendingOrder)
        {
            Console.WriteLine(name);
        }

        // ThenBy()
        var students = new List<Student>
        {
            new Student { Name = "John", Age = 18 },
            new Student { Name = "Anna", Age = 20 },
            new Student { Name = "Kyle", Age = 20 }
        };

        var sortedStudents = students.OrderBy(s => s.Age).ThenBy(s => s.Name);

        Console.WriteLine();
        Console.WriteLine("ThenBy() and OrderBy() method for ascending Order : ");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"{student.Name} - {student.Age}");
        }


        Console.ReadLine();
    }
    
}