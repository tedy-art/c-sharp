using System;

namespace MultipleInheritance
{
    public interface IInterface1
    {
        void Method1();
    }

    public interface IInterface2
    {
        void Method2();
    }

    public class DerivedClass : IInterface1, IInterface2
    {
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }

        public void Method2()
        {
            Console.WriteLine("Method 2");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass();
            obj.Method1();  // Outputs: Method 1
            obj.Method2();  // Outputs: Method 2
        }
    }
}