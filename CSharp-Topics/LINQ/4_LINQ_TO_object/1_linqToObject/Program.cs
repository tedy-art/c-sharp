using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
    }

    public static void Main(string[] args)
    {
        // Initialize a list of employees
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "John", Department = "IT", Age = 28, Salary = 60000 },
            new Employee { Name = "Anna", Department = "HR", Age = 25, Salary = 50000 },
            new Employee { Name = "Mike", Department = "IT", Age = 32, Salary = 75000 },
            new Employee { Name = "Sara", Department = "Finance", Age = 29, Salary = 65000 },
            new Employee { Name = "Paul", Department = "HR", Age = 26, Salary = 52000 },
        };

        // Example 1: Filter employees from the IT department
        var itEmployees = employees.Where(e => e.Department == "IT");

        Console.WriteLine("Employees in the IT department:");
        foreach (var emp in itEmployees)
        {
            Console.WriteLine($"{emp.Name}, Age: {emp.Age}, Salary: {emp.Salary}");
        }

        // Example 2: Group employees by department
        var employeesByDepartment = employees.GroupBy(e => e.Department);

        Console.WriteLine("\nEmployees grouped by department:");
        foreach (var group in employeesByDepartment)
        {
            Console.WriteLine($"Department: {group.Key}");
            foreach (var emp in group)
            {
                Console.WriteLine($" - {emp.Name}, Age: {emp.Age}, Salary: {emp.Salary}");
            }
        }

        // Example 3: Project only names and salaries of employees
        var employeeInfo = employees.Select(e => new { e.Name, e.Salary });

        Console.WriteLine("\nEmployee names and salaries:");
        foreach (var info in employeeInfo)
        {
            Console.WriteLine($"{info.Name}, Salary: {info.Salary}");
        }

        // Example 4: Calculate the average salary of all employees
        var averageSalary = employees.Average(e => e.Salary);

        Console.WriteLine($"\nAverage Salary: {averageSalary}");

        Console.ReadLine();
    }
}
