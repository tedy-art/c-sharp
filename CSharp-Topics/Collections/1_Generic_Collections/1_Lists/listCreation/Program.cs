using System;
using System.Collections.Generic;

namespace genericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> GenericList = new List<int>();
            GenericList.Add(30);
            GenericList.Add(60);
            GenericList.Add(90);
            GenericList.Add(120);

            foreach(int x in GenericList)
            {
                Console.WriteLine(x);
            }
        }
    }
}