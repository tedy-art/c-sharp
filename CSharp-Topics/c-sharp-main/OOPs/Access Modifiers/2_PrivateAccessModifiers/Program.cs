using System;

namespace MyPrivateAccessModifiers
{
    public class Car
    {
        private string model = "";  // Private field

        public void SetModel(string model)
        {
            this.model = model;  // Accessible within the same class
        }

        public string GetModel()
        {
            return model;  // Accessible within the same class
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.SetModel("Mustang");
            Console.WriteLine(myCar.GetModel());  // Accessible through public methods
        }
    }
}