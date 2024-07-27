using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int myInt = 10;
      double myDouble = 5.25;
      bool myBool = true;
      string myText = "Hello";
      long myNum = 15000000000L;
      float myNumFloat = 5.75F;


      Console.WriteLine($"Interger : {myInt}");
      Console.WriteLine($"Double : {myDouble}");
      Console.WriteLine($"Boolean : {myBool}");
      Console.WriteLine($"Sting : {myText}");
      Console.WriteLine($"long : {myNum}");
      Console.WriteLine($"Float : {myNumFloat}");

      Console.WriteLine($"\n \n Type Casting : ");

      int myIntConvert = 10;
      double myDoubleConvert = 5.25;
      bool myBoolConvert = true;

      Console.WriteLine($"Convert int to string : {Convert.ToString(myIntConvert)}");
      Console.WriteLine($"Convert int to double : {Convert.ToDouble(myIntConvert)}");
      Console.WriteLine($"Convert double to int : {Convert.ToInt32(myDoubleConvert)}");
      Console.WriteLine($"Convert bool to string : {Convert.ToString(myBoolConvert)}");
      }
  }
}