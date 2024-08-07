using System;

namespace HybridInheritance
{
    public class BaseClass
    {
        public void BaseMethod()
        {
            Console.WriteLine("Base Method");
        }
    }

    public interface IInterface
    {
        void IInterfaceMethod();
    }

    public class DerivedClass : BaseClass, IInterface
    {
        public void IInterfaceMethod()
        {
            Console.WriteLine("Interface Method");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass();
            obj.BaseMethod();
            obj.IInterfaceMethod();
        }
    }
}
