# C# (C-Sharp)

# syllabus


| Week | Topic                              | Description                                                                 | Status       |
|------|------------------------------------|-----------------------------------------------------------------------------|--------------|
| 1    | Introduction to C#                 | History, setup environment, first program                                   | complete	 |
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
```c#
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
```C#
using System;
```
- yeh line `System` namespace ko import karti hai.
- iska matlab yeh hai ki aap `System` namespace ke under defined classes ko directly use kar sakte hai.
- e.g.: `Console` class, jo hamare program main use ho raha hai, `System` namespace mein defined hai.

```C#
namespace HelloWorld
{

}
```
-  Yeh line ek namespace define karti hai. 
- Namespace ka use code ko logically group karne aur naming conflicts ko avoid karne ke liye hota hai.
- Yahaan, humne apna namespace HelloWorld rakha hai.

```C#
	class Program
	{
	
	}
```
- Yeh line ek class define karti hai jiska naam Program hai.
- C# mein, sari code ek class ke andar likhi jati hai kyunki C# ek object-oriented language hai.

```C#
		static void Main(string[] args)
		{
		
		}
```
- Yeh method program ka entry point hai.
- Jab bhi aapka program run hota hai, execution iss method se start hota hai. 
- `static` ka matlab hai ki yeh method bina kisi object ke call kiya ja sakta hai.
- `void` return type batata hai ki yeh method kuch return nahi karega.
- `string[] args` command-line arguments ko represent karta hai jo program ke start hone par pass kiye ja sakte hain.

```C#
            Console.WriteLine("Hello, World!");
```
- Yeh line console par "Hello, World!" print karti hai. 
- `Console` class ka `WriteLine` method use hota hai output display karne ke liye.

### C# Comments
- single line Comments
```c#
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

- single line Comments
```c#
// import package using `using` keyword
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