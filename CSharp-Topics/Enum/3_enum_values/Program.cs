using System;

namespace myApplication
{
    class Program
    {
        enum Months
        {
            January,
            Februrary,
            March,
            April,
            May,
            June,
            July
        }

        static void Main(string[] args)
        {
            int myNum = (int)Months.April;
            Console.WriteLine(myNum);
        }
    }
}