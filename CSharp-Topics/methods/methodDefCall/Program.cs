using System;

namespace MethodDefCalling
{
    class Program
    {
        // defining a method
        static void myMethod()
        {
            Console.WriteLine("I just got executed!");
        }
        static void Main(string[] args)
        {
            // calling a method
            myMethod();

            // we can call method multiple time
            myMethod();
            myMethod();
            myMethod();
            myMethod();
            myMethod();
            Console.ReadLine();
        }
    }
}