using System;

public class InvalidAgeException : Exception
{
    // Constructor that accepts just the message
    public InvalidAgeException(string message)
        : base(message)
    {
    }

    // Optional: Constructor that accepts the message and an inner exception
    public InvalidAgeException(string message, Exception inner)
        : base(message, inner)
    {
    }
}

public class UserValidation
{
    public static void ValidateAge(int age)
    {
        if (age < 18)
        {
            throw new InvalidAgeException("Sorry, age must be 18 or older.");
        }
        else
        {
            Console.WriteLine("Age is valid.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        try
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            UserValidation.ValidateAge(age);
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine($"Custom Exception: {ex.Message}");
        }

        Console.WriteLine("Program ended.");
    }
}
