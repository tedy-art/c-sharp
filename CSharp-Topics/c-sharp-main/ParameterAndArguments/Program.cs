using System;

namespace MyMethodParameterApplication
{
    class ParameterProgram
    {
        static void MyMethod(string fname)
        {
            Console.WriteLine($"{fname} Refsnes");
        }

        static void MyMethod2(string fname, int age){
            Console.WriteLine($"{fname} is {age}");
        }

        static void Main(string[] args){
            Console.WriteLine("Parameter And Arguments : ");
            MyMethod("Liam");
            MyMethod("Jenny");
            MyMethod("Anja");

            Console.WriteLine("\nParameter And Arguments : ");
            MyMethod2("Liam", 5);
            MyMethod2("Jenny", 8);
            MyMethod2("Anja", 31);
        }
    }
}