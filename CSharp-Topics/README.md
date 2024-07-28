# C# (C-Sharp)

# syllabus


| sr.no| Topic                              | Description                                                                 | Status       |
|------|------------------------------------|-----------------------------------------------------------------------------|--------------|
| 1    | Introduction to C#                 | first program													              | complete	 |
| 2    | Basic Syntax                       | Variables, data types, operators, comments                                  | complete	 |
| 3    | Control Structures                 | Conditional statements (if, switch), loops (for, while, do-while)           | complete	 |
| 4    | Functions and Methods              | Defining methods, return types, parameters, method overloading              | complete	 |
| 5    | Object-Oriented Programming (OOP)  | Classes, objects, constructors, fields, properties, methods                 | Incomplete   |
| 6    | Inheritance and Polymorphism       | Base and derived classes, method overriding, polymorphism                   | Incomplete   |
| 7    | Interfaces and Abstract Classes    | Defining and implementing interfaces, abstract classes                      | Incomplete   |
| 8    | Exception Handling                 | Try-catch blocks, custom exceptions                                         | Incomplete   |
| 9    | Collections                        | Arrays, lists, dictionaries, queues, stacks                                 | Incomplete   |
| 10   | LINQ Basics                        | Introduction to LINQ, basic queries, filtering, ordering                    | Incomplete   |
| 11   | File I/O                           | Reading from and writing to files                                           | Incomplete   |
| 12   | Introduction to .NET Framework     | Overview, Common Language Runtime (CLR), .NET libraries                     | Incomplete   |
| 13   | Basic Windows Forms Applications   | Creating a simple GUI application                                           | Incomplete   |
| 14   | Introduction to ASP.NET            | Basics of web development with ASP.NET                                      | Incomplete   |
| 15   | Debugging and Testing              | Debugging tools, unit testing with MSTest or NUnit                          | Incomplete   |
| 16   | Project                            | Simple project to apply learned concepts (e.g., a console application)      | Incomplete   |


## What is C#??
- C# is a modern, innovative, open-source, cross-platform object-oriented programming language.
	- `Modern` : A programming language of today's era, updated and advanced.
	- `Innovative` : New and unique feature that make coding easy and powerful.
	- `Open-source` : Free and accessble code, Community support and rapid imporvement.
	- `Cross-platform` : Runs on windows, Linux and macOS
	- `Object-oriented` : Uses classes and objects to manage and reuse code effectively.

## Syntax:
```csharp
using System; // import package using `using` keyword

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}
	}
}
```

Expanation:
```csharp
using System;
```
- yeh line `System` namespace ko import karti hai.
- iska matlab yeh hai ki aap `System` namespace ke under defined classes ko directly use kar sakte hai.
- e.g.: `Console` class, jo hamare program main use ho raha hai, `System` namespace mein defined hai.

```csharp
namespace HelloWorld
{

}
```
-  Yeh line ek namespace define karti hai. 
- Namespace ka use code ko logically group karne aur naming conflicts ko avoid karne ke liye hota hai.
- Yahaan, humne apna namespace HelloWorld rakha hai.

```csharp
	class Program
	{
	
	}
```
- Yeh line ek class define karti hai jiska naam Program hai.
- C# mein, sari code ek class ke andar likhi jati hai kyunki C# ek object-oriented language hai.

```csharp
		static void Main(string[] args)
		{
		
		}
```
- Yeh method program ka entry point hai.
- Jab bhi aapka program run hota hai, execution iss method se start hota hai. 
- `static` ka matlab hai ki yeh method bina kisi object ke call kiya ja sakta hai.
- `void` return type batata hai ki yeh method kuch return nahi karega.
- `string[] args` command-line arguments ko represent karta hai jo program ke start hone par pass kiye ja sakte hain.

```csharp
            Console.WriteLine("Hello, World!");
```
- Yeh line console par "Hello, World!" print karti hai. 
- `Console` class ka `WriteLine` method use hota hai output display karne ke liye.

### C# Comments
- single line Comments
```csharp
// import package using `using` keyword
using System;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			// This is single line comment
			Console.WriteLine("Hello, World!");
		}
	}
}
```

- Multi line Comments
```csharp
/*
 import package using `using` keyword
*/
using System;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			 This is single line comment.
			 we can write multiple comments.
			*/
			Console.WriteLine("Hello, World!");
		}
	}
```

### Variables:
- Variables are containers for storing data values.

#### Declaring a Variable:
```csharp
int myNumber;
```
- int is the data type.
- myNumber is a variable name we declare.

#### Initializing Variables
```csharp
int myNumber = 10;

// or
int myNum;
myNum = 15;

```

### Data Types:
Sure! Here's the table with serial numbers added:

| Sr. No | Data Type | Description                                                     | Size                      |
|--------|-----------|-----------------------------------------------------------------|---------------------------|
| 1      | `int`     | Store integer value (32 bit)                                    | 4 bytes                   |
| 2      | `long`    | Store integer value (64 bit)                                    | 8 bytes                   |
| 3      | `float`   | Store floating-point number (32 bit)                            | 4 bytes                   |
| 4      | `double`  | 64-bit signed floating-point number                             | 8 bytes                   |
| 5      | `bool`    | Boolean value (`true` or `false`)                               | 1 bit (1 byte for storage)|
| 6      | `char`    | Store single character/letter (Single 16-bit Unicode character) | 2 bytes                   |
| 7      | `string`  | Store sequence of characters                                    | 2 bytes per character     |

```csharp
using System;

namespace DataTypesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // int example
            int age = 25;
            Console.WriteLine("Age: " + age);

            // long example
            long distanceToMoon = 384400000L; // Distance in meters
            Console.WriteLine("Distance to Moon: " + distanceToMoon + " meters");

            // float example
            float pi = 3.14F;
            Console.WriteLine("Value of Pi: " + pi);

            // double example
            double gravity = 9.81;
            Console.WriteLine("Gravity: " + gravity + " m/s²");

            // bool example
            bool isAlive = true;
            Console.WriteLine("Is Alive: " + isAlive);

            // char example
            char initial = 'A';
            Console.WriteLine("Initial: " + initial);

            // string example
            string greeting = "Hello, World!";
            Console.WriteLine("Greeting: " + greeting);
        }
    }
}
```
Ouptup:
```csharp
Age: 25
Distance to Moon: 384400000 meters
Value of Pi: 3.14
Gravity: 9.81 m/s²
Is Alive: True
Initial: A
Greeting: Hello, World!
```