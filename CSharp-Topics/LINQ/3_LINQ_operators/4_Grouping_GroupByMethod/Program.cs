using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class LinqGrouping_GroupByMethod
{
    static void Main(string[] args)
    {
        var students = new List<Student>
        {
            new Student { Name = "John", Age = 20},
            new Student { Name = "Anna", Age = 18},
            new Student { Name = "Kyle", Age = 20}
        };

        var groupedStudent = students.GroupBy(s => s.Age);

        foreach (var group in groupedStudent)
        {
            Console.WriteLine($"Age Grouped : {group.Key}");
            foreach (var student in group)
            {
                Console.WriteLine(student.Name);
            }
        }
        Console.ReadLine();
    }
}