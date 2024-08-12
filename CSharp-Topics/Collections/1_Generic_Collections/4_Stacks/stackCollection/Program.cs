using System;
using System.Collections.Generic;

namespace genericStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> steak = new Stack<string>();
            steak.Push("Rare");
            steak.Push("Medium Rare");
            steak.Push("Medium");
            steak.Push("Well Done");

            foreach (string s in steak)
            {
                Console.WriteLine(s);
            }
        }
    }
}