using System;

namespace HierarchicalInheritance
{
    public class BaseClass
    {
        public void BaseMethod()
        {
            Console.WriteLine("Base Method");
        }
    }

    public class DerivedClass1 : BaseClass
    {
        public void DerivedMethod1()
        {
            Console.WriteLine("Derived Method 1");
        }
    }

    public class DerviedClass2: BaseClass
    {
        public void DerivedMethod2()
        {
            Console.WriteLine("Derived Method 2");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            DerivedClass1 obj1 = new DerivedClass1();
            obj1.BaseMethod();
            obj1.DerivedMethod1();

            DerviedClass2 obj2 = new DerviedClass2();
            obj2.BaseMethod();
            obj2.DerivedMethod2();
        }
    }
}