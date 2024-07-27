using System;


namespace MyNameTestApplication
{
    class fullName
    {
        public string? firstName;
        public string? lastName;
        public int pinCode;

        public void getFullName()
        {
            Console.WriteLine($"My full name is {firstName} {lastName}.");
        }
    }
}