using System;

namespace ClassesAndObject
{
    class Car
    {
        string color = "Red";

        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
        }
    }
}