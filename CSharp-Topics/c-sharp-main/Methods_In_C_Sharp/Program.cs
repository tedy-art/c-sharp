using System;

namespace MyMethodApplication
{
    class MyMethodProgram
    {
        // Define a method
        static void MyMethod(){
            Console.WriteLine("I just got executed!");
        }
        static void Main(String[] args)
        {
            // Calling a method
            MyMethod(); 
        }
    }
}