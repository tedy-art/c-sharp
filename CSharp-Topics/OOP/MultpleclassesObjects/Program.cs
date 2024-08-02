using System;

namespace MultipleClassesAndObjects
{
    class Car
    {
        string color = "red";

        static void Main(string[] args)
        {
            Car MyCarObject1 = new Car();
            Car MyCarObject2 = new Car();
            Console.WriteLine(MyCarObject1.color);
            Console.WriteLine(MyCarObject2.color);
            Console.ReadLine();
        }
    }
}