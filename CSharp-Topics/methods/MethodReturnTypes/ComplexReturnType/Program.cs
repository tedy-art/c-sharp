using System;

namespace ComplexReturnType
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = CreatePerson("John", "Doe");
            Console.WriteLine($"Name: {person.FirstName} {person.LastName}");
            Console.ReadLine();
        }

        static Person CreatePerson(string firstName, string lastName)
        {
            return new Person { FirstName = firstName, LastName = lastName };
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}