using System;

namespace myApplication
{
    enum Level
    {
        Low,
        Medium,
        High
    }

    class Program
    {
        static void Main(string[] args)
        {
            Level myVar = Level.Medium;
            Console.WriteLine(myVar);
        }
    }
}