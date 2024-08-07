using System;

namespace MultilevelInheritance
{
    public class BaseClass
    { 
        public void BaseMethod()
        {
            Console.WriteLine("Base Method");
        }
    }

    public class IntermediateClass : BaseClass
    {
        public void IntermediateMethod()
        {
            Console.WriteLine("Intermediate Method");
        }
    }

    public class DerivedClass : IntermediateClass
    { 
        public void DerivedMethod()
        {
            Console.WriteLine("Derived Method");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass();
            obj.BaseMethod();
            obj.IntermediateMethod();
            obj.DerivedMethod();
        }
    }
}