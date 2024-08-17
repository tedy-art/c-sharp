using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class LinqProjection_selectMethod
{
    static void Main(string[] args)
    {
        var students = new List<Student>()
        {
            new Student { Name = "John", Age = 18},
            new Student { Name = "Anna", Age = 20}
        };

        Console.WriteLine("Student name Collections : ");
        var StudentNames = students.Select( s => s.Name);

        foreach (var name in StudentNames)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("Student Age Collection : ");
        var StudentAge = students.Select(a => a.Age);

        foreach (var age in StudentAge)
        {
            Console.WriteLine(age);
        }
        Console.ReadLine();
    }
}