using System;

namespace propertiesGetSet
{
    class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "test";
            Console.WriteLine(p.Name);
            Console.ReadLine();
        }
    }
}