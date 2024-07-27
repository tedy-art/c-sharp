using System;

namespace MyApplication
{
  // creatng class  
  class Car
  {
    string color = "red";

    static void Main(string[] args)
    {
      // creating objects
      Car myObj = new Car();
      Console.WriteLine(myObj.color);
    }
  }
}