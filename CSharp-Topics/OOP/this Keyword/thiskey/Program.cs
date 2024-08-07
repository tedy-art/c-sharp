using System;

namespace ThisKeyword
{
    class Test
    {
        int num;

        Test(int num)
        {
            // this.num refers to the instance field
            this.num = num;
            Console.WriteLine("Object of this : " + this);
        }

        static void Main(string[] args)
        {
            Test t1 = new Test(4);
            Console.WriteLine("Object of t1 : "+ t1);
            Console.ReadLine();
        }
    }
}