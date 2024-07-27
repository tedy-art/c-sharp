using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // String Data Type
            String name = "John";
            Console.WriteLine(name);

            // int Data Type
            int myNum = 15;
            Console.WriteLine($"number 1 {myNum}");


            // Another Way to assign value to variable
            int myNum1;
            myNum1 = 30;
            Console.WriteLine($"number 2 {myNum1}");

            // Another way to change assigned values
            int myNum2 = 15;
            myNum2 = 20;
            Console.WriteLine($"number 3 {myNum2}");

            // Other types
            int MyNum = 5;
            double myDouble = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";
            Console.WriteLine($"\n integer : {MyNum},\n Double : {myDouble},\n Char : {myLetter},\n Boolean : {myBool},\n String : {myText}");
        }
    }
}