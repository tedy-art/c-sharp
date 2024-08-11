// finally example if exception is handled.

using System;
public class ExExample
{
    public static void Main(string[] args)
    {
        try
        {
            int a = 10;
            int b = 0;
            int x = a / b;
        }
        catch (Exception e) 
        { 
            Console.WriteLine(e); 
        }
        finally 
        { 
            Console.WriteLine("Finally block is executed");
        }
        
        Console.WriteLine("Rest of the code");
        Console.ReadLine();
    }
}