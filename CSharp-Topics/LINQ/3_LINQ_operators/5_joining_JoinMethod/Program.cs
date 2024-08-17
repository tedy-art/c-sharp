using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{ 
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Enrollment
{
    public int StudentId { get; set; }
    public string Course { get; set; }
}

public class LinqJoining_JoinMethod
{
    static void Main(string[] args)
    {
        var students = new List<Student>
        {
            new Student { Id = 1, Name = "John"},
            new Student { Id = 2, Name = "Anna"}
        };

        var enrollments = new List<Enrollment>
        {
            new Enrollment { StudentId = 1, Course = "Math" },
            new Enrollment { StudentId = 2, Course = "Science"}
        };

        var studentEnrollments = students.Join(
            enrollments,
            student => student.Id,
            enrollment => enrollment.StudentId,
            (student, enrollment) => new { student.Name, enrollment.Course}
        );

        foreach ( var se in studentEnrollments )
        {
            Console.WriteLine($"{se.Name} is enrolled in {se.Course}.");
        }
        Console.ReadLine();
    }
}