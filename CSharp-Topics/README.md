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

## operators
- Operators are used to perform operation on variables and values.
- C# mein operators symbols hote hain jo specify karte hain kis type ka computation perform karna hai. 
- Yahan pe C# mein alag-alag types ke operators hai.

### 1. Arithmetic Operators
- Arithmetic operators basic mathematical operations ke liye use hote hain.

| Operator | Description                 | Example       | Result        |
|----------|-----------------------------|---------------|---------------|
| `+`      | Addition                    | `5 + 3`       | `8`           |
| `-`      | Subtraction                 | `5 - 3`       | `2`           |
| `*`      | Multiplication              | `5 * 3`       | `15`          |
| `/`      | Division                    | `6 / 3`       | `2`           |
| `%`      | Modulus (remainder)         | `5 % 3`       | `2`           |
| `++`     | Increment                   | `a++`         | `a = a + 1`   |
| `--`     | Decrement                   | `a--`         | `a = a - 1`   |

### 2. Relational Operators
- Relational operators do values ko compare karne ke liye use hote hain.

| Operator | Description                 | Example       | Result        |
|----------|-----------------------------|---------------|---------------|
| `==`     | Equal to                    | `5 == 3`      | `false`       |
| `!=`     | Not equal to                | `5 != 3`      | `true`        |
| `>`      | Greater than                | `5 > 3`       | `true`        |
| `<`      | Less than                   | `5 < 3`       | `false`       |
| `>=`     | Greater than or equal to    | `5 >= 3`      | `true`        |
| `<=`     | Less than or equal to       | `5 <= 3`      | `false`       |

### 3. Logical Operators
- Logical operators boolean values pe logical operations perform karne ke liye use hote hain.

| Operator | Description                 | Example       | Result        |
|----------|-----------------------------|---------------|---------------|
| `&&`     | Logical AND                 | `true && false`| `false`       |
| `||`     | Logical OR                  | `true || false`| `true`        |
| `!`      | Logical NOT                 | `!true`       | `false`       |

1. &&:
- return `true` if both condition are `true` else `false`

2. ||:
- return `true` if one of the condition is true

3. !:
- return `true` if condition return `false`

### 4. Assignment Operators
- Assignment operators variables ko values assign karne ke liye use hote hain.

| Operator | Description                 | Example       | Result        |
|----------|-----------------------------|---------------|---------------|
| `=`      | Assign                      | `a = 5`       | `a = 5`       |
| `+=`     | Add and assign              | `a += 3`      | `a = a + 3`   |
| `-=`     | Subtract and assign         | `a -= 3`      | `a = a - 3`   |
| `*=`     | Multiply and assign         | `a *= 3`      | `a = a * 3`   |
| `/=`     | Divide and assign           | `a /= 3`      | `a = a / 3`   |
| `%=`     | Modulus and assign          | `a %= 3`      | `a = a % 3`   |

### 5. Bitwise Operators
- Bitwise operators integers pe bit-level operations perform karne ke liye use hote hain.

| Operator | Description                 | Example       | Result        |
|----------|-----------------------------|---------------|---------------|
| `&`      | Bitwise AND                 | `5 & 3`       | `1`           |
| `|`      | Bitwise OR                  | `5 | 3`       | `7`           |
| `^`      | Bitwise XOR                 | `5 ^ 3`       | `6`           |
| `~`      | Bitwise complement          | `~5`          | `-6`          |
| `<<`     | Left shift                  | `5 << 1`      | `10`          |
| `>>`     | Right shift                 | `5 >> 1`      | `2`           |

### 6. Conditional (Ternary) Operator
- Conditional operator ek Boolean expression ki value ke basis pe do values me se ek ko return karta hai.

| Operator | Description                 | Example       | Result        |
|----------|-----------------------------|---------------|---------------|
| `? :`    | Conditional                 | `a > b ? a : b`| Returns `a` if `a > b`, else `b`|

### 7. Null-Coalescing Operator
- Null-coalescing operator left-hand operand ko return karta hai agar wo null nahi hai; 
- otherwise, ye right-hand operand ko return karta hai.

| Operator | Description                 | Example       | Result        |
|----------|-----------------------------|---------------|---------------|
| `??`     | Null-coalescing             | `a ?? b`      | Returns `a` if `a` is not null, else `b`|

### 8. Type Operators
- Type operators type checks aur type conversions perform karne ke liye use hote hain.

| Operator | Description                 | Example       | Result        |
|----------|-----------------------------|---------------|---------------|
| `is`     | Type compatibility check    | `a is string` | Returns `true` if `a` is of type `string` |
| `as`     | Type conversion             | `obj as string`| Converts `obj` to `string` if possible, else `null`|

### Example Usage

```csharp
using System;

namespace OperatorsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arithmetic Operators
            int a = 10;
            int b = 5;
            Console.WriteLine("Addition: " + (a + b));
            Console.WriteLine("Subtraction: " + (a - b));
            Console.WriteLine("Multiplication: " + (a * b));
            Console.WriteLine("Division: " + (a / b));
            Console.WriteLine("Modulus: " + (a % b));

            // Relational Operators
            Console.WriteLine("Equal: " + (a == b));
            Console.WriteLine("Not Equal: " + (a != b));
            Console.WriteLine("Greater than: " + (a > b));
            Console.WriteLine("Less than: " + (a < b));

            // Logical Operators
            bool x = true;
            bool y = false;
            Console.WriteLine("Logical AND: " + (x && y));
            Console.WriteLine("Logical OR: " + (x || y));
            Console.WriteLine("Logical NOT: " + (!x));

            // Assignment Operators
            int c = 10;
            c += 5;
            Console.WriteLine("Add and assign: " + c);
            c -= 3;
            Console.WriteLine("Subtract and assign: " + c);

            // Bitwise Operators
            int m = 5;  // 0101 in binary
            int n = 3;  // 0011 in binary
            Console.WriteLine("Bitwise AND: " + (m & n));  // 0001 in binary
            Console.WriteLine("Bitwise OR: " + (m | n));   // 0111 in binary
            Console.WriteLine("Bitwise XOR: " + (m ^ n));  // 0110 in binary

            // Conditional (Ternary) Operator
            int max = (a > b) ? a : b;
            Console.WriteLine("Max value: " + max);

            // Null-Coalescing Operator
            string str = null;
            string result = str ?? "Default value";
            Console.WriteLine("Null-Coalescing: " + result);

            // Type Operators
            object obj = "Hello";
            if (obj is string)
            {
                Console.WriteLine("obj is a string");
            }

            string str2 = obj as string;
            if (str2 != null)
            {
                Console.WriteLine("str2: " + str2);
            }
        }
    }
}
```
O/p
```csharp
Addition: 15
Subtraction: 5
Multiplication: 50
Division: 2
Modulus: 0
Equal: False
Not Equal: True
Greater than: True
Less than: False
Logical AND: False
Logical OR: True
Logical NOT: False
Add and assign: 15
Subtract and assign: 12
Bitwise AND: 1
Bitwise OR: 7
Bitwise XOR: 6
Max value: 10
Null-Coalescing: Default value
obj is a string
str2: Hello 
```

## Control Structure
### Conditional Statments
1. if statement
2. switch statement

## 1.if statment:
- The `if` statement in C# is used to execute a block of code only if a specified condition is true.
- it's a fundamental control structure for making decisions in your program.
Syntax:
```csharp
if(condition)
{
    // code to execute if the condition is true
}
```

Ex:
```csharp
int x = 20;
int y = 18;

if(x>y)
{
    Console.WriteLine("x is greater than y")
}
```
o/p:
```csharp
x is greater than y
```

### if-else statement
- In an if-else statement, if the condition in the if statement evaluates to false, then the else block will execute. 
- The else block provides an alternative set of instructions that will run only when the if condition is not met.
Syntex:
```csharp
if (condition)
{
    // code execute if the condtion is true
}
else
{
    // code execute if the condition is false
}
```

Ex. 
```csharp
using System;

namespace IfElseStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 3;

            if (number > 5):
            {
                Console.WriteLine("The number is greater than 5");
            }
            else
            {
                Console.WriteLine("The number is 5 or less")
            }
        }
    }
}
```

O/p:
```csharp
The number is 5 or less.
```

### else if
- The `else if` statement in C# is used to specify a new condition if the previous `if` condition if `false`.
- It allows you to chain multiple conditions together, providing more complex decision-making capabilities.

Syntax
```csharp
if (condition1)
{
    // Code to execute if condition1 is true
}
else if (condition2)
{
    // Code to execute if condition2 is true
}
else
{
    // Code to execute if none of the above conditions are true
}
```
Ex:
```csharp
using System;

namespace ElseIfExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;

            if (number > 10)
            {
                Console.WriteLine("The number is greater than 10.");
            }
            else if (number == 10)
            {
                Console.WriteLine("The number is exactly 10.");
            }
            else if (number > 5)
            {
                Console.WriteLine("The number is greater than 5 but less than 10.");
            }
            else
            {
                Console.WriteLine("The number is 5 or less.");
            }
        }
    }
}

```
O/p:
```csharp
The number is exactly 10.
```

## 2. switch statement
- The `switch` statement in C# is used to select one of many code blocks to be executed.
- It's more readable alternative to using multiple `if-else` if statements when you need to compare the same variable to different values.

Syntax:
```csharp
switch (expression)
{
    case value1:
        // Code to execute if expression equals value1
        break;
    case value2:
        // Code to execute if expression equals value2
        break;
    // Add more cases as needed
    default:
        // Code to execute if none of the cases match
        break;
}
```
Execute lines:
- the swith expression is evatute once.
- The value of expression is compared with the value of each case.
- If there is any match, the associated block is executed

Ex.
```csharp
using System;

namespace SwitchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 3;

            switch (number)
            {
                case 1:
                    Console.WriteLine("The number is one.");
                    break;
                case 2:
                    Console.WriteLine("The number is two.");
                    break;
                case 3:
                    Console.WriteLine("The number is three.");
                    break;
                case 4:
                    Console.WriteLine("The number is four.");
                    break;
                default:
                    Console.WriteLine("The number is not between 1 and 4.");
                    break;
            }
        }
    }
}
```
O/p:
```csharp
The number is three.
```

### Enhances example with Fall-through:
- if you want to execute the same code for multiple cases, you can use fall-through by omitting the `break` statment.

```csharp
using System;

namespace SwitchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            char grade = 'B';

            switch (grade)
            {
                case 'A':
                case 'B':
                case 'C':
                    Console.WriteLine("Passing grade.");
                    break;
                case 'D':
                case 'F':
                    Console.WriteLine("Failing grade.");
                    break;
                default:
                    Console.WriteLine("Invalid grade.");
                    break;
            }
        }
    }
}
```

O/p:
```csharp
Passing grade.
```

## Loops in C#

# 1. while loop
# 2. for loop

# 1. while loop:
- `while loop` is used to `iterate` a part of the progam several times.
- if the number of iteration is not fixed, it is recommended to use `while loop` than `for loop`.

Syntax
```csharp
while(condition)
{
    // code to be executed
}
```

|Note:                                                                                                        |
|-------------------------------------------------------------------------------------------------------------|
|`while` loop ka use karke ek block ko repeatedly execute kar sakte ho jab tak specified condition ` rahti hai|

Ex>
```csharp
using System;

namespace WhileLoopEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.ReadLine();
        }
    }
}
```
o/p
```csharp
1
2
3
4
5
```

## Example with user input
- Yeh code user se input lega aur jab tak condtion true hai tab tak yeh run karega
```csharp
using System;

class Program
{
    static void Main()
    {
        string userInput = "";

        while (userInput != "exit")
        {
            Console.WriteLine("Enter something (type 'exit' to quit):");
            userInput = Console.ReadLine();
            Console.WriteLine("You entered: " + userInput);
        }
    }
}
```

## do-while loop:
- The do-while is a variant of the while loop.
- This loop will execute the code block once
- before checking if the condition is true, then it will repeat the loop as long as the condition is true.

Syntax
```
do
{
    // block to be executed
}
while(condtion);
```

```
using System;

namespace doWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            
            do
            {
                Console.WriteLine(i);
            }
            while(i < 5);
        }
    }
}
```
o/p:
```
1
2
3
4
5
```

**Example with user input:**
- get input from user in *do while* loop:

```

```
