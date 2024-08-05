using System;

namespace getAndSetMethod
{
    class Person
    {
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Test";
            Console.WriteLine(p.Name);
            Console.ReadLine();
        }
    }
}