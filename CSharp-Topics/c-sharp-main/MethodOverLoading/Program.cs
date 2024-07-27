using System;

namespace MyApplication
{
    class Program
    {
        // Method defination
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }
        // Method defination
        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            // Method overloading 
            // Same method's name but different operations
            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }  
    }
}