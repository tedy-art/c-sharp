using System;

namespace MyConstructorSoManyParameterApplication
{
    class NewCarInfo
    {
        public string model;
        public string color;
        public int year;
    
        // Create a class constructor with multiple parameter
        public NewCarInfo(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
        
    }
}