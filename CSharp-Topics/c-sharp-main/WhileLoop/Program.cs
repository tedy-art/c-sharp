using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("While loop : ");
        int i = 0;
        while (i < 5){
            Console.WriteLine(i);
            i++;
        }

        Console.WriteLine("Do/While loop : ");
        int x = 0;
        do
        {
            Console.WriteLine(x);
            x++;
        }
        while (x < 5);
    }
  }
}