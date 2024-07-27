using System;
using System.Security.Cryptography.X509Certificates;

namespace MyPublicAccessModifiersApplication
{
    public class Car
    {
        public string? model;  // Public field
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.model = "Mustang";  // Accessible
            Console.WriteLine(myCar.model);
        }
    }

}