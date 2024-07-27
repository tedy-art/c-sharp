using System;
using MyCarApplication;
using MyNameTestApplication;

namespace MyMainClassApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.color = "Red";
            Ford.year = 1969;

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.color = "White";
            Opel.year = 2005;

            fullName mySelf = new fullName();
            mySelf.firstName = "Tejas";
            mySelf.lastName = "Falke";
            mySelf.pinCode = 414111;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);
            mySelf.getFullName();
        }
    }
}