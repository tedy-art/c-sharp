using System;

namespace MyConstructorParameterApplication
{
    class CarInfo
    {
        public string model;

        // create a class constructor with parameter
        public CarInfo(string modelName)
        {
            model = modelName;
        }
    }
}