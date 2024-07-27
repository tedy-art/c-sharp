using System;

namespace MyApplication{
    class Program{
        static void Main(string[] args){
            Console.WriteLine($"Constants : ");

            const int myInt = 15;
            // myInt = 20; // Error
            Console.WriteLine($"Constants : {myInt}");

            // Display Variable
            Console.WriteLine("Anohter way to Display Variable");
            Console.WriteLine("WriteLine() : ");
            string name = "John";
            Console.WriteLine("Hello" + name);

            Console.WriteLine($"Anohter way to Display Variable : ");
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            Console.WriteLine($"Anohter way to Display Variable : ");
            int x = 5;
            int y = 6;
            Console.WriteLine(x + y);

            int a = 5, b=6, c = 90;
            Console.WriteLine(a+b+c);
            
            int a1, b1, c1;
            a1 = b1 = c1 = 50;
            Console.WriteLine(a1+b1+c1);


        }
    }
}