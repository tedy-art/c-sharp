using System;


namespace OperatorOverloading
{
    public class Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        // Constructor
        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // Overloading the + operator to add two Complex objects
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        // Overriding the ToString method to display the complex number
        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }

    public class Program
    {
        public static void Main()
        {
            Complex c1 = new Complex(1.5, 2.5);
            Complex c2 = new Complex(3.0, 4.0);

            // Using the overloaded + operator to add two complex numbers
            Complex result = c1 + c2;
    
            Console.WriteLine(result);  // Outputs: 4.5 + 6.5i
        }
    }
}