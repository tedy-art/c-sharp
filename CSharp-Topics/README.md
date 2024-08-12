# C# (C-Sharp)

# syllabus


| sr.no| Topic                              | Description                                                                 | Status       |
|------|------------------------------------|-----------------------------------------------------------------------------|--------------|
| 1    | Introduction to C#                 | first program													              | complete	 |
| 2    | Basic Syntax                       | Variables, data types, operators, comments                                  | complete	 |
| 3    | Control Structures                 | Conditional statements (if, switch), loops (for, while, do-while)           | complete	 |
| 4    | Methods                            | Defining methods, return types, parameters, method overloading              | complete	 |
| 5    | Object-Oriented Programming (OOP)  | Classes, objects, constructors, fields, properties, methods                 | complete     |
| 6    | Access Modifiers                   | Public private, protected, internal                                         | complete     |
| 7    | Properties (Get and Set)           | get, set methods                                                            | complete     |
| 8    | pillars of OOP's                   | encapsulation, abstraction, inheritance, and polymorphism                   | complete     |
| 9    | Exception Handling                 | Try-catch blocks, custom exceptions                                         | complete     |
| 10   | Collections                        | Arrays, lists, dictionaries, queues, stacks                                 | Incomplete   |
| 11   | LINQ Basics                        | Introduction to LINQ, basic queries, filtering, ordering                    | Incomplete   |
| 12   | File I/O                           | Reading from and writing to files                                           | Incomplete   |
| 13   | Introduction to .NET Framework     | Overview, Common Language Runtime (CLR), .NET libraries                     | Incomplete   |
| 14   | Basic Windows Forms Applications   | Creating a simple GUI application                                           | Incomplete   |
| 15   | Introduction to ASP.NET            | Basics of web development with ASP.NET                                      | Incomplete   |
| 16   | Debugging and Testing              | Debugging tools, unit testing with MSTest or NUnit                          | Incomplete   |
| 17   | Practice                           | Practice                                                                    | Incomplete   |
| 18   | Project                            | Simple project to apply learned concepts (e.g., a console application)      | Incomplete   |

---
# 1. What is C#??
- C# is a modern, innovative, open-source, cross-platform object-oriented programming language.
	- `Modern` : A programming language of today's era, updated and advanced.
	- `Innovative` : New and unique feature that make coding easy and powerful.
	- `Open-source` : Free and accessble code, Community support and rapid imporvement.
	- `Cross-platform` : Runs on windows, Linux and macOS
	- `Object-oriented` : Uses classes and objects to manage and reuse code effectively.

 ---
# 2. Syntax:
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
| \|\|     | Logical OR                  | `true || false`| `true`        |
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
|  \|      | Bitwise OR                  | `5 | 3`       | `7`           |
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


---
# 3. Control Structure
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
- the switch expression is evatute once.
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

### 1. while loop
### 2. for loop

## 1. while loop:
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
using System;

class Program
{
    static void Main()
    {
        string userInput;

        do
        {
            Console.WriteLine("Enter something (type 'exit' to quit):");
            userInput = Console.ReadLine();
            Console.WriteLine("You entered: " + userInput);
        } while (userInput != "exit");
    }
}

```


## 2.for loop 
- When you know exactly how many times you want to loop through a block of code, use the "for" loop instead of a while loop.

Syntax:
```
for(initialization; condition; increment/decrement)
{
    // code block to be executed.
}
```

**Initialization:** 
- Sets the starting value of the loop control variable(s).
- Execute once at the beginning of the loop.

**Condition:**
- Checks if the loop should continue.
- Evaluted before each iteration.
- if `true`, the loop executes; if `false`, the loop stop

**increment/decrement:**
- update the loop control variable(s).
- Executes after each iteration of the loop body.

Ex
```csharp
using System;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
```

O/p:
```
0
1
2
3
4
```

Ex2
```csharp
using System;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i= i+2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
```
O/p:
```
0
2
4
6
8
10
```

## Nested Loops:
```csharp
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      // Outer loop
      for (int i = 1; i <= 2; ++i) 
      {
        Console.WriteLine("Outer: " + i);  // Executes 2 times
        
        // Inner loop
        for (int j = 1; j <= 3; j++) 
        {
          Console.WriteLine(" Inner: " + j);  // Executes 6 times (2 * 3)
        }
      }    
    }
  }
}
```

O/P:
```
Outer: 1
 Inner: 1
 Inner: 2
 Inner: 3
Outer: 2
 Inner: 1
 Inner: 2
 Inner: 3
```

## The foreach loop
- There also a "foreach" loop, which is used to exclusively to loop through elements in an array.

Syntax:
```
foreach(type variablename in arrayname)
{
    //code block to be executed
}
```

Ex
```csharp
using System;

namespace foreachLoop
{
    class Program
    {
        string[] car = {"volvo", "BMW", "Ford", "Mazda"};
        foreach(string i in arr)
        {
            Console.WriteLine(i);
        }
    }
}
```

O/p:
```
volvo
BMW
Ford
Mazda
```

---
# 4. Methods
1. What is Method 
2. Defining methods
3. call a method
4. return types 
5. parameters & arguments
6. Method Overloading
7. Method Overriding

## 1. What is Method??
- a method is a block of code which only runs when it is called.
- You can pass data, known as parameter into a method.
- Methods are used to perform certain actions and they are also known as functions.

## 2. Defining methods

```csharp
class Program
{
    static void nameOfMethod(parameter)
    {
        // code to be executed
    }
}
```

Expaination:
- static -> access modifier
- void -> return type
- namrOfMethod -> defining method with `nameOfMethod`
- parameter -> A list of parameters the method accepts(if any)

## 3. call a method
- To call (execute) a method, write the method's name followed by two parentheses () and a semicolon;

Syntax:
```csharp
using System;

namespace MethodDefCalling
{
    class Program
    {
        // defining a method
        static void myMethod()
        {
            Console.WriteLine("I just got executed!");
        }
        static void Main(string[] args)
        {
            // calling a method
            myMethod();

            // we can call method multiple time
            myMethod();
            myMethod();
            myMethod();
            myMethod();
            myMethod();
            Console.ReadLine();
        }
    }
}
```

O/p:
```
I just got executed!
I just got executed!
I just got executed!
I just got executed!
I just got executed!
I just got executed!
```

## 4. return types 
- the ruturn type of method specifies the type of value that the method will return to the caller.
- If method dose not return a value, its return type is `void`.
- Understanding return types is essential for desigining methods that produce useful results.

**Common Return Types:**
1. **void:** indicates that the method dose not return a value.
2. **Primitive Types:** `int`, `double`, `char`, `bool` etc.
3. **Complex Types:** `array`,`string`, and `object of classes`.
4. **Generic Types:** `List<T>`, `Dictionary<TKey, TValue>` etc.

---

### 1. Primitive return types
```csharp
using System;

namespace ReturnTypes
{
    class Program
    {
        static int add(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            int sum = add(5, 3);
            Console.WriteLine($"sum : {sum}");
        }
    }
}
```

O/p
```
sum : 8
```

### 2. Complex Return Type
- a method that returns an objects or a complex type.
```csharp
using System;

namespace ComplexReturnType
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = CreatePerson("John", "Doe");
            Console.WriteLine($"Name: {person.FirstName} {person.LastName}");
            Console.ReadLine();
        }

        static Person CreatePerson(string firstName, string lastName)
        {
            return new Person { FirstName = firstName, LastName = lastName };
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
```

O/p:
```
Name: John Doe
```

## 3.Generic Return Types:
- a method that returna a generic type, such as a `List<T>`.
```
using System;
using System.Collections.Generic;

namespace GenericReturnTypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = GetNames();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }

        static List<string> GetNames()
        {
            return new List<string> { "Alice", "Bob", "Charlie" };
        }
    }
}
```

## 5. parameters & arguments
- In Programming, perticularly in C#, parameter and arguments are related concepts that refer to values used in methods and functions.

### 1.Parameters:
- Definition:
    - Parameter are variables defined in the method signature.
    - They act as a placeholders for the values that will be passed to the method when it is called.
- Perpose:
    - They define the type and number of inputs that the method expects.

### 2. Arguments:
- Definition:
    - Arguments are the actul values passed to the method when it is called.
    - These are the data you provide to the method's parameter.
- Perpose:
    - They provide the actual data that the method will use.

```csharp
using System;

namespace ParameterAndArguments
{
    class Program
    {
        // `string fname` is a type and name of parameter
        static void myMethod(string fname)
        {
            Console.WriteLine(fname + " Refsnes");
        }
        
        static void Main(string[] args)
        {
            // "Liam","Jenney" & "Anja" are arguments of method
            myMethod("Liam");
            myMethod("Jenney");
            myMethod("Anja");
        }
    }
}
```

O/p
```
Liam Refsnes
Jenney Refsnes
Anja Refsnes
```

|Note                                                                          |
|------------------------------------------------------------------------------|
|**parameter** ka use hum method difine ke vakt karte hai(types are important) |
|**arguments** ka use hum method calling ke vakt karte hai(types are important)|

Ex.
```csharp
using System;

namespace ParameterArgumentExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method ko arguments ke sath call karna
            int result = Add(5, 3);
            Console.WriteLine("Sum: " + result);
        }

        // Method ko parameters ke sath define karna
        static int Add(int x, int y)
        {
            return x + y; // x aur y parameters hain
        }
    }
}
```
O/p:
```
Sum: 8
```

## 6. method overloading
- It is the common way of implementing polymorphism.
- It is the ability to redefine a function in more than one form.
- A user can implement function overloading by defining two or more functions in a class sharing the same name.

### Key Points:
1. Same Method : sab method ka name same hota hai
2. Different Parameter : Method ke parameter ka type, number ya order alag hona chahiye.
3. Compile-Time Polymorphism : Method overloading ko compile-time polymorphism bhi kaha jata hai kiyki yeh compile time pe hi decide hota hai ki kaunsa method call hoga.

Ex.
```
using System;

namespace MethodOverloading
{
    class Program
    {
        // Method with two int parameters
        static int add(int a, int b)
        {
            return a + b;
        }

        // Method with three int parameters
        static int add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Method with two double parameters
        static double add(double a, double b)
        {
            return a + b;
        }

        // Method with two string parameters
        static string add(string a, string b)
        {
            return $"{a} {b}";
        }

        static void Main(string[] args)
        {
            int resultTwoSum = add(5, 3);
            Console.WriteLine($"2 sum : {resultTwoSum}");

            int resultThreeSum = add(3, 4, 5);
            Console.WriteLine($"3 sum : {resultThreeSum}");

            double resultDoubleSum = add(51.11, 4.55);
            Console.WriteLine($"double : {resultDoubleSum}");

            string strConcate = add("I", "Tejas");
            Console.WriteLine($"str : {strConcate}");
        }
    }
}
```

O/p
```
2 sum : 8
3 sum : 12
double : 55.66
str : I Tejas
```

## 7. method Overriding:
- method overriding In c# is a feature of Object-oriented programming that allow a child class to provide a specific implentation of a method that is already defined in the base(parent) class.
- Ovrridden(child method) method in the derived class has same name, return type, and parameter as the method in the base(parent) class.
- This allow for polymorphic behaviour depending on the object that is calling it.

### Key Points
- **Inheritance:** 
  - Method overriding requires inheritance, as the method in the derived class overrides the method in the base class.
- **virtual Keyword:** 
  - The method in the base class that can be overridden must be marked with the virtual keyword.
- **override Keyword:** 
  - The method in the derived class that overrides the base class method must be marked with the override keyword.
- **Polymorphism:** 
  - Allows for dynamic method resolution at runtime, enabling different objects to call their own version of an overridden method.

```csharp
using System;

namespace MethodOverridingExample
{
    // Base class
    class Animal
    {
        // Virtual method
        public virtual void Speak()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    // Derived class
    class Dog : Animal
    {
        // Overriding method
        public override void Speak()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();  // Create a base class object
            Animal myDog = new Dog();        // Create a derived class object

            myAnimal.Speak();  // Calls the base class method
            myDog.Speak();     // Calls the overridden method in the derived class
        }
    }
}
```
---

# 5. Object-Oriented Programming (OOP):
1. Object-Oriented Programming
2. Classes(multiple classes) 
3. objects(multiple objects)
4. class Members
5. methods in class
6. constructors
7. fields
8. properties


### 1. Object-Oriented Programming
- Object-Oriented Programming(OOP) is a programming model where programs are orgainzed around objects and data rather than action and logic.
- OOP allows decomposing a problem into many entities called objects and then building data and functions around these objects.
- A class is the core of any modern Object-Oriented Programming languages such as C#.
- In OOP language, creating a class for represinting data is madatory.
- A class is a blueprint of an object that contains variables for storing data and functions to perform operation on data.
- A class will not occupy any memory space; hence it is only a logical representation of data.

Advantages of OOP:
- OOP is faster and easier to execute.
- OOP provides a clear structure for the programs.
- OOP help to keep the C# code DRY(don't repeat yourself) and makes the code easier to maintain, modify and debug.
- OOP makes it possible to create full reusable applications with less code and shorter development time.

### 2. Classes
- A blueprint for creating objects.
- it defines a type of object by building data and methods that operate on the data.

### 3. Objects
- An instance of a class.
- it contains actual data and methods defined in the class.

e.g.
```
sr.no class(blueprint for actual data)       object(actual data)
   1         fruit -                           Apple
                                               Banana
                                               Mango

   2         Car -                             Volvo
                                               Audi
                                               Toyoto
```

### Create A class
Syntax:
```
class Car
{
    // methods or code
}
```

### Creating an objects
- An object is created from a class.

Ex.
```
using System;

namespace ClassesAndObject
{
    class Car
    {
        string color = "Red";

        static void Main(string[] args)
        {
            // Creating an object
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
        }
    }
}
```

## Multiple classes and objects:
1. Multiple Objects
- hum ek class ke liye ek se jada objects bana sakte hai

ex.
```
using System;

namespace MultipleClassesAndObjects
{
    class Car
    {
        string color = "red";

        static void Main(string[] args)
        {
            // Multiple objects
            Car MyCarObject1 = new Car();
            Car MyCarObject2 = new Car();
            Console.WriteLine(MyCarObject1.color);
            Console.WriteLine(MyCarObject2.color);

        }
    }
}
```
O/p:
```
red
red
```

2. Multiple classes
- you can also create an object of a class and access it in another class.
- This is often used fro better organization of classes.
- One class has all method and fields and other class holds the `Main()` method.

Ex.

file name : Program.cs
```
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      // creating a class object from program1.cs
      Car myObj = new Car();
      Console.WriteLine(myObj.color);
    }
  }
}
```

file name : Program1.cs
```
using System;

namespace MyApplication
{
  class Car
  {
    public string color = "red";
  }
}
```

O/p:
```
red
```

### 4. class members
- fields aur methods jab classes ke andhar he toh unhe class member bualte hai.

|class Car       |
|----------------|
|color : red     |
|method : brake()|

color & method = class member

```
class Myclass
{
    // class members
    string color = "red"; // class members
    int maxSpeed = 200; // class members
    public void fullThrottle() // class members
    {
        Console.WriteLine("The car i going as fast as it can!");
    }

    static void Main(string[] args)
    {
        Car myObj = new Car();
        Console.WriteLine(myObj.color);
        Console.WriteLine(myObj.maxSpeed);
    }
}
```
|Note:                                                    |
|---------------------------------------------------------|
|we can access fields with help of objects using dot(".") |

- we can also leave the fields blank and modify then when creating the objects.

Ex.
```
class Car
{
    string color;
    int maxSpeed;

    static void Main(string[] args)
    {
        Car myObj = new Car();
        myObj.color = "red";
        myObj.maxSpeed = 200;
        Console.WriteLine(myObj.color);
        Console.WriteLine(myObj.maxSpeed);
    }
}
```
O/p
```
red
200
```

### 5. methods in class
- Methods normally belong to a class and they define how an object of a class behaves.
- just like fields we can access method as well but that method must be "public".

Ex.
```csharp
using System;

namespace myApplication
{
    class Car
    {
        string color;
        int maxSpeed;

        // Creating a method inside a class
        public void fullThrottle()
        {
            Console.WriteLine("This car is going as fast as it can!");
        }
        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.fullThrottle(); // calling method
        }
    }
}
```


### 6. constructors 
- A constructor is a special method that used to initialize objects.
- The advantages of constructor, is that it is called when an object of a class is created.
- It can be used to set initial values for fields.

Create a constructor:
```
using System;

namespace MyApplication
{
    class Car
    {
        public string model;

        // creating a constructor for Car class
        public Car()
        {
            model = "mustang";
        }

        static void Main(string[] args)
        {
            Car Ford = new Car();
            Console.WriteLine(Ford.model);
        }
    }
}
```
o/p:
```
mustang
```

|sr.no|Note|
|---|---|
| 1 | Constructor name match the class name. |
| 2 | Constructor cannot have a return type. |
| 3 | Constructor called when the object is created. |
| 4 | Constructor are created by c# if we not creae constructor however then we are unable to set initial values for fields.|

### Constructor Parameter:
- Constructor can also take parameters, which is used to initialize fields.

Ex.
```
using System;

namespace MyConstructorParameterApplication
{
    class Car
    {
        public string model;
        public string color;
        public int year;

        // creating a class constructor with parameter
        public Car(string modelName, string ModelColor, int modelYear)
        {
            model = modelName;
            // we can use as many parameter as we want
            color = ModelColor;
            year = modelYear;
        }

        static void Main(string[] args)
        {
            Car Ford = new Car("mustang", "Red", 1969);
            Console.WriteLine($"{Ford.color} {Ford.year} {Ford.model}.");
            Console.ReadLine();
        }
    }
}
```
O/p:
```
Red 1969 mustang
```

# 6. Access Modifiers
- Access ka use class, method properties, fields ya other member ke access level ko control karne ke liye hota hai.
- yeh access modifiers specify karta hai ki konse members ko konsa code access kar sakte hai.

|sr.no| modifier  | Description                                                                        |
|-----|-----------|------------------------------------------------------------------------------------|
|  1  | Public    | The code is accessible for all classes.                                            |
|  2  | Private   | The private members can be access only within the same class or struct.            |
|  3  | Protected | Protect members can be accessed within its class and by derived class instances.   |
|  4  | Internal  | The code is only accessible within its own assembly, but not from another assembly.|
|  5  | Protected Internal | The protected interal is combination of protected and internal access modifiers. |
|  6  | Private Protected | The private protected access modifier is a combination of private and protected. |


### 1.Public Access Modifiers:
- Public members can be accessed from any code in the same assembly or another assembly that refernces it.

Ex.
```csharp
public class Car{
    public string model;
}

class Program{
    static void Main(string[] args){
        Car myCar = new Car();
        myCar.model = "mustang";
        Console.WriteLine(myCar.model);
    }
}
```

### 2. Private Access Modifiers
- Private members can be access only within the same class or struct.

Ex.
```csharp
public class Car{
    private string model; // private field

    public void setModel(string mofrl){
        this.model = model; // Accessible within the same class
    }
}

class Program{
    static void Main(string[] args){
        Car myCar = new Car();
        myCar.setModel("mustang");
        Console.WriteLine(myCar.GetModel());
    }
}
```

### 3.Protected Access Modifiers

```
using System;

namespace MyProtectedAccessModifiers{
    public class Vehicle{
        protected string brand; // protected field

        public void setBrand(string brand){
            this.brand = brand; // Accissble within the same class
        }
    }

    public class Car : Vehicle{
        public void DisplayBrand(){
            Console.WriteLine(brand); // Accessible in child class
        }
    }

    class Program{
        static void Main(string[] args){
            Car myCar = new Car();
            myCar.setBrand("Ford");
            myCar.DisplayBrand(); // Accessible through child class method
        }
    }
}
```

### 4.Internal Access modifiers
- The code is only accessible within its own assembly, but not from another assembly.
- An assembly is a collection of types (classes, interfaces, etc) and resources (data). They are built to work together and form a logical unit of functionality.
- That's why when we run an assembly all classes and interfaces inside the assembly run together

#### Example: internal within the same Assembly
```csharp
using System;

namespace Assembly {

  class Student {
   internal string name = "Sheeran";
  }

  class Program {
    static void Main(string[] args) {
    
      // creating object of Student class
      Student theStudent = new Student();
      
      // accessing name field and printing it
      Console.WriteLine("Name: " + theStudent.name);
      Console.ReadLine();
    }
  }
}
```

O/p:
```
Name: Sheeran
```

#### Example: internal in different Assembly
**Assembly1**
```csharp
// Code on Assembly1
using System;

namespace Assembly1 {

  public class StudentName {
    internal string name = "Sheeran";
  }

  class Program {
    static void Main(string[] args) {
    }
  }
}
```

**Assembly2**
```
// Code on Assembly2
using System;

// access Assembly1
using Assembly1;

namespace Assembly2 {
  class Program {
    static void Main(string[] args) {
      StudentName student = new StudentName();

      // accessing name field from Assembly1
      Console.Write(student.name);
      Console.ReadLine();
     }
  }
}
```

o/p
```
Error    CS0122    'StudentName.name' is inaccessible due to its protection level
```
Exaplain:
This is because `name` is an internal field present in Assembly1.

### 5.protected internal Access Modifiers
- The protected internal is a combination of protected and internal access modifiers.
- When we declare a member protected internal, it can be accessed from the same assembly and the derived class of the containing class from any other assembly.

Ex.
```csharp
// Code on Assembly1
using System;

namespace Assembly1 {
  public class Greet {
    protected internal string msg="Hello";
  }

  class Program {
    static void Main(string[] args) {
      Greet greet = new Greet();
      Console.WriteLine(greet.msg);
      Console.ReadLine();
     }
  }
}
```
Output
```
Hello
```

- The above code is in Assembly1.
- In the above example, we have created a class named `Greet` with a field `msg`. Since the field is protected internal, we are able to access it from the Program class as they are in the same assembly.


Let's derive a class from Greet in another assembly and try to access the protected internal field msg from it.

```csharp
// Code on Assembly2
using System;

// access Assembly1
using Assembly1;

namespace Assembly2 {

  // derived class of Greet
  class Program: Greet {
    static void Main(string[] args) {
      Program greet = new Program();

      // accessing name field from Assembly1
      Console.Write(greet.msg);
      Console.ReadLine();
    }
  }
}
```
Output
```
Hello
```

- The above code is in Assembly2.

- In the above example, we have inherited the `Program` class from the `Greet` class(from Assembly1).

```
// accessing name field from Assembly1
Console.Write(greet.msg);
```

- We are able to access the `msg` from the `Greet` class of Assembly1 from Assembly2.
- This is because the `msg` is a protected internal field and we are trying to access it from the child class of `Greet`.

### 5.private internal Access Modifiers
- The private protected access modifier is a combination of private and protected. 
- It is available from the C# version 7.2 and later.

- When we declare a member private protected, it can only be accessed within the same class, and its derived class within the same assembly. 

For example,
```csharp
// Code in Assembly1
using System;

namespace Assembly1 {
  public class StudentName {
    private protected string name = "Sheeran";
  }

  //derived class of StudentName class
  class Program1 : StudentName {

    static void Main(string[] args) {

      Program1 student = new Program1();

      //  accessing name field from base class
      Console.Write(student.name);
      Console.ReadLine();
    }
  }
}
```

Output
```
Sheeran
```

- The above code is in Assembly1
- In the above example, we have created a class `StudentName` with a `private protected` field name.
- Notice that we have inherited the `Program1` class from the `StudentName` class.
- Since the `private protected` member can be accessed from derived classes within the same assembly, we are able to access `name` from the `Program1` class.

Let's derive a class from `StudentName` in another assembly and try to access the `private protected` field name from it. 
For example,
```csharp
// Code in Assembly2
using System;
//access Assembly1
using Assembly1;

namespace Assembly2 {

  //derived class of StudentName
  class Program : StudentName {
    static void Main(string[] args) {
      Program student = new Program();
    
      // accessing name field from Assembly1
      Console.Write(student.name);
      Console.ReadLine();
     }
  }
}
```

- The above code is in Assembly2

- In the above example, when we try to access the name field from the derived class of StudentName, we get an error.

O/p
```
Error    CS0122    'StudentName.name' is inaccessible due to its protection level    
```

- This is because the `name` field is in `Assembly1` and the derived class is in `Assembly2`.

| Note:                                                                                                                                           |
|-------------------------------------------------------------------------------------------------------------------------------------------------|
| We can also use access modifiers with types (classes, interface, etc). However, we can only use types with public and internal access modifiers.|

## 9. properties(get and set):
### Properties and Encapsulation
- Before we start to explain properties, you should have a basic understanding of "Encapsulation".

- The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users. To achieve this, you must:
    - declare fields/variables as private
    - provide public get and set methods, through properties, to access and update the value of a private field Properties

 
Properties:
- You learned from the previous chapter that private variables can only be accessed within the same class (an outside class has no access to it). However, sometimes we need to access them - and it can be done with properties.
- A property is like a combination of a variable and a method, and it has two methods: a get and a set method:

Example
```csharp
class Person
{
  private string name; // field

  public string Name   // property
  {
    get { return name; }   // get method
    set { name = value; }  // set method
  }
} 
```
 
#### Example explained
- The Name property is associated with the name field. It is a good practice to use the same name for both the property and the private field, but with an uppercase first letter.
- The get method returns the value of the variable name.
- The set method assigns a value to the name variable. The value keyword represents the value we assign to the property.
- If you don't fully understand it, take a look at the example below.

*Now we can use the Name property to access and update the private field of the Person class:**

### Example
```csharp
class Person
{
  private string name; // field
  public string Name   // property
  {
    get { return name; }
    set { name = value; }
  }
}

class Program
{
  static void Main(string[] args)
  {
    Person myObj = new Person();
    myObj.Name = "Liam";
    Console.WriteLine(myObj.Name);
  }
}
```

output:
```
Liam
```

### Automatic Properties (Short Hand)
- C# also provides a way to use short-hand / automatic properties, where you do not have to define the field for the property, and you only have to write get; and set; inside the property.
- The following example will produce the same result as the example above. The only difference is that there is less code:

Example
Using automatic properties:

```csharp
class Person
{
  public string Name  // property
  { get; set; }
}

class Program
{
  static void Main(string[] args)
  {
    Person myObj = new Person();
    myObj.Name = "Liam";
    Console.WriteLine(myObj.Name);
  }
}
```
output:
```
Liam
```

## 8. pillars of OOP's:

1. inheritance
2. abstraction
3. encapsulation
4. polymorphism


- To inherit from a class, use the `:` Symbol.

## `this ` Keyword
- this keyword refers to the current instance of a class.
- i.g.
```csharp
using System;

namespace ThisKeyword
{
    class Test
    {
        int num;

        Test(int num)
        {
            // this.num refers to the instance field
            this.num = num;
            Console.WriteLine("Object of this : " + this);
        }

        static void Main(string[] args)
        {
            Test t1 = new Test(4);
            Console.WriteLine("Object of t1 : "+ t1);
            Console.ReadLine();
        }
    }
}
```
O/p
```
Object of this : ThisKeyword.Test
Object of t1 : ThisKeyword.Test
```

## `static` Keyword:
- In C#, if we use a static keyword with class members, then there will be a single copy of the type member.
- And, all objects of the class share a single copy instead of creating individual copies.


Ex.
```csharp
using System;

namespace StaticKeyword {

  class Student {

    // static variable
    public static string department = "Computer Science";
  }

  class Program {
    static void Main(string[] argos) {
    
      // access static variable
      Console.WriteLine("Department: " + Student.department);
     
      Console.ReadLine();
    }
  }
}
```
o/p:
```
Department: Computer Science
```


## 1. inheritance
- inheritance is a fundamental concept in OOP that allows a class(called the derived/child/sub class) to inherit proprtties and behaviours(methods) from another class(called the base/super class).
- this mechanism enables code reuse, creates a natural hierarchy, and established an "Is-a" relationship between classes.

Types of inheritance:
1. Single Inheritance
2. Multilevel Inheritance
3. multiple Inheritance
4. Hirarchical Inheritance
5. hybrid Inheritace

## 1. Single Inheritance
- A class inherits from one base class.
- this is the most common from of inheritace.

Ex.
```csharp
using System;

namespace SingleInheritance
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
        }
    }
}
```

O/P
```
Eating...
Barking...
```

## 2.Multilevel Inheritance
- In multilevel Inheritance, a class is derived class, creating a chain inheritance.

Ex.
```csharp
using System;

namespace MultilevelInheritance
{
    public class BaseClass
    { 
        public void BaseMethod()
        {
            Console.WriteLine("Base Method");
        }
    }

    public class IntermediateClass : BaseClass
    {
        public void IntermediateMethod()
        {
            Console.WriteLine("Intermediate Method");
        }
    }

    public class DerivedClass : IntermediateClass
    { 
        public void DerivedMethod()
        {
            Console.WriteLine("Derived Method");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass();
            obj.BaseMethod();
            obj.IntermediateMethod();
            obj.DerivedMethod();
        }
    }
}
```

O/p
```
Base Method
Intermediate Method
Derived Method
```

## 3. Multiple Inheritance
- C# dose not support multiple Inheritance directly(i.e. class connot inherit from more than one class).
- however, it supports multiple inheritance through interfaces, where a class can implement multiple interfaces.

```csharp
using System;

namespace MultipleInheritance
{
    public interface IInterface1
    {
        void Method1();
    }

    public interface IInterface2
    {
        void Method2();
    }

    public class DerivedClass : IInterface1, IInterface2
    {
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }

        public void Method2()
        {
            Console.WriteLine("Method 2");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass();
            obj.Method1();  // Outputs: Method 1
            obj.Method2();  // Outputs: Method 2
        }
    }
}
```

O/p:
```
Method 1
Method 2
```

## 4. Hirarchical Inheritance
- in Hirarchical Inheritance, multiple drived classes inherit from single base class.

Ex.
```csharp
using System;

namespace HierarchicalInheritance
{
    public class BaseClass
    {
        public void BaseMethod()
        {
            Console.WriteLine("Base Method");
        }
    }

    public class DerivedClass1 : BaseClass
    {
        public void DerivedMethod1()
        {
            Console.WriteLine("Derived Method 1");
        }
    }

    public class DerviedClass2: BaseClass
    {
        public void DerivedMethod2()
        {
            Console.WriteLine("Derived Method 2");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            DerivedClass1 obj1 = new DerivedClass1();
            obj1.BaseMethod();
            obj1.DerivedMethod1();

            DerviedClass2 obj2 = new DerviedClass2();
            obj2.BaseMethod();
            obj2.DerivedMethod2();
        }
    }
}
```
O/p
```
Base Method
Derived Method 1
Base Method
Derived Method 2
```

## 5. hybrid Inheritance
- Hybrid Inheritance is a combination of two or more than types of inheritance.
- Since C# dose not support multiple inheritance directly, Hybrid Inheritance is typically achived through interfaces.

Ex.
```
using System;

namespace HybridInheritance
{
    public class BaseClass
    {
        public void BaseMethod()
        {
            Console.WriteLine("Base Method");
        }
    }

    public interface IInterface
    {
        void IInterfaceMethod();
    }

    public class DerivedClass : BaseClass, IInterface
    {
        public void IInterfaceMethod()
        {
            Console.WriteLine("Interface Method");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass();
            obj.BaseMethod();
            obj.IInterfaceMethod();
        }
    }
}
```

O/p:
```
Base Method
Interface Method
```

## 2. abstraction:
- Abstraction is one of the fundamental principle of OOP.
- It involves hiding the complex implementation details of an object nd exposing only the necessary features to the outside world.
- Abstraction allows programmers to focus on what an object dose rather than how it dose it.
- This helps in reducing complexity and increasing the efficiency of the code.

### Key Concepts:
1. Abstract classes
2. Interfaces


### 1. Abstract classes:
- An Abstract class connot be instantiated directly and is meant to be aubclassed.
- It can contain abstract method(method without implementation) as well as concrete method(method with implementation).
- the subclasses of the abstract class are responsible for providing implementations for the abstract method.

### 1.2. Abstract Method:
- Can only be used in an abstract class and it does not have a body.
- The body is provided by the derived by the derived class(inherited from).

An abstract class can have both abstract and regular method:

Ex.
```
abstract class Animal
{
    public abstract void animalSound();

    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
}
```

| Note                                                                                |
|-------------------------------------------------------------------------------------|
| from the example above, it is `not possible` to create an object of an `Animal` class.|

Ex.
```
Animal obj = new Animal(); // error
```
- To access the abstract class, it must be inherited from another class.

Ex.
```
using System;

namespace MyApplication
{
  // Abstract class
  abstract class Animal
  {
    // Abstract method (does not have a body)
    public abstract void animalSound();
    // Regular method
    public void sleep()
    {
      Console.WriteLine("Zzz");
    }
  }
  
  // Derived class (inherit from Animal)
  class Pig : Animal
  {
    public override void animalSound()
    {
      // The body of animalSound() is provided here
      Console.WriteLine("The pig says: wee wee");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Pig myPig = new Pig();  // Create a Pig object
      myPig.animalSound();
      myPig.sleep();
    }
  }
}
```

O/p
```
The pig says: wee wee
Zzz
```

Ex2:
```csharp
using System;

namespace abstractClassAndMethods
{
    // Abstract class
    public abstract class Animal
    {
        // Abstract method(with no implementation)
        public abstract void MakeSound();

        // Concrete Method
        public void Sleep()
        {
            Console.WriteLine("Sleeping..");
        }
    }

    // Derived class(subclass) and inheriting abstract class
    public class Dog : Animal
    { 
        // Providing implementation for the abstract class
        public override void MakeSound()
        {
            Console.WriteLine("woof!");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.MakeSound();
            dog.Sleep();
        }
    }
}
```

O/p:
```
woof
Sleeping...
```

## 2. Interfaces
- An interface is a completely "abstract class", which can only contain abstract methods and properties(with empty bodies).
- It contain declarations of methods, properties, events or indexers, but it dose not provide implementation.
- A class or struct that implements an interface must provide implementations for all members declared in the interface.

Ex.
```csharp
using System;

namespace InterfaceAbstraction
{
    // interface
    public interface IAnimal
    {
        void MakeSound();
        void Sleep();
    }

    // class implementing the interface
    public class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow!");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }
    }
    public class Program
    { 
        public static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.MakeSound();
            cat.Sleep();
            Console.ReadLine();
        }
    }
}
```

o/p:
```
Meow!
Sleeping...
```

### Multiple Interfaces:
- to implement multiple interfaces, separate them with a comma:
Ex>
```csharp
using System;

namespace MyApplication
{
    interface IFirstInterface
    {
        void myMethod(); // interface method
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }

    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text..");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DemoClass myObj = new DemoClass();
            myObj.myMethod();
            myObj.myOtherMethod();
            Console.ReadLine();
        }
    }
}
```

O/p:
```
Some text...
Some other text...
```


## 3. Encapsulation
- Encapsulation is defined as the wrapping up of data and information under a single unit.
- It is the mechanism that binds together the data and the functions that manipulate them.
- In a different way, encapsulation is a protective shield that prevents the data from being accessed by the code outside this shield.

- **Technically in encapsulation**, the variables or data of a class are hidden from any other class and can be accessed only through any member function of its own class in which they are declared.
- **As in encapsulation**, the data in a class is hidden from other classes, so it is also known as data-hiding.
- **Encapsulation can be achieved by:** Declaring all the variables in the class as private and using C# Properties in the class to set and get the values of variables.

```csharp
using System;

namespace EncapsulationExample
{
    public class DemoEncap
    {
        // private variables declared
        // these can only be accessed by
        // public methods of class
        private string studentName;
        private int studentAge;

        // using accessors to get and
        // set the value of studentName
        public string Name
        {
            get { return studentName; }
            set { studentName = value; }
        }

        // using accessors to get and
        // set the value of studentAge
        public int Age
        {
            get { return studentAge; }
            set { studentAge = value; }
        }
    }

    // Driver Class
    class GFG
    {
        // Main Method
        static public void Main()
        {
            // creating object
            DemoEncap obj = new DemoEncap();

            // calls set accessor of the property Name,
            // and pass "Ankita" as value of the
            // standard field 'value'
            obj.Name = "Ankita";

            // calls set accessor of the property Age,
            // and pass "21" as value of the
            // standard field 'value'
            obj.Age = 21;

            // Displaying values of the variables
            Console.WriteLine("Name: " + obj.Name);
            Console.WriteLine("Age: " + obj.Age);
        }
    }
}
```
O/p:
```
Name: Ankita
Age: 21
```

Advantages of Encapsulation:
- **Data Hiding:** The user will have no idea about the inner implementation of the class. It will not be visible to the user that how the class is stored values in the variables. He only knows that we are passing the values to accessors and variables are getting initialized to that value.
- **Increased Flexibility:** We can make the variables of the class as read-only or write-only depending on our requirement. If we wish to make the variables as read-only then we have to only use Get Accessor in the code. If we wish to make the variables as write-only then we have to only use Set Accessor.
- **Reusability:** Encapsulation also improves the re-usability and easy to change with new requirements.
- **Testing code is easy:** Encapsulated code is easy to test for unit testing.

Ex.2
```csharp
using System;

namespace BankAccountApp
{
    public class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount(1000);

            myAccount.Deposit(500);
            Console.WriteLine("Balance: " + myAccount.GetBalance());

            myAccount.Withdraw(2000);
            Console.WriteLine("Balance: " + myAccount.GetBalance());

            myAccount.Withdraw(500);
            Console.WriteLine("Balance: " + myAccount.GetBalance());

            Console.ReadLine();
        }
    }
}
```

O/p:
```
Balance: 1500
Insufficient funds.
Balance: 1500
Balance: 1000
```

## 4.Polymorphism
- Polymorphism means "many forms", and it occurs when we have many classes that are related to each other by inheritance.

There are two types of polymorphism:
1. Compile Time Polymorphism(static polymorphism)
2. Runtime Polymorphism(Dynamic Polymorphism)

1. Compile Time Polymorphism:
- It is achived by method overloading and operator overloading.
- it is also known as static binding or early binding.

2. Runtime Polymorphism:
- Runtime polymorphism is achived by method overriding.
- Runtime polymorphism is also known as dynamic binding or late binding.

**1. Method Overloading**
- Method Overloading occurs when multiple methods in the same class have the same name but differ in the number or type of parameters. 
- This allows you to define multiple behaviors for the same method name depending on the input parameters.

**2. Operator Overloading**
- Operator Overloading allows you to redefine the behavior of standard operators (like +, -, *, etc.) for user-defined types such as classes and structs.
- This can make operations on these types more intuitive and readable.

Ex. of method overloading
```csharp
using System;

namespace methodOverloading
{
    public class Calculator
    {
        // Method to add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Overloaded method to add three integers
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Overloaded method to add two doubles
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Calculator calc = new Calculator();

            // Calling different overloaded versions of the Add method
            Console.WriteLine(calc.Add(2, 3));        // Outputs: 5
            Console.WriteLine(calc.Add(2, 3, 4));     // Outputs: 9
            Console.WriteLine(calc.Add(2.5, 3.5));    // Outputs: 6.0
        }
    }
}
```
O/p
```
5
9
6
```

Ex. Operator Overloading
```csharp
using System;

namespace OperatorOverloading
{
    public class Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        // Constructor
        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // Overloading the + operator to add two Complex objects
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        // Overriding the ToString method to display the complex number
        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }

    public class Program
    {
        public static void Main()
        {
            Complex c1 = new Complex(1.5, 2.5);
            Complex c2 = new Complex(3.0, 4.0);

            // Using the overloaded + operator to add two complex numbers
            Complex result = c1 + c2;

            Console.WriteLine(result);  // Outputs: 4.5 + 6.5i
        }
    }
}
```

O/p
```
4.5 + 6.5i
```

Ex. Method overriding
```
using System;


namespace OperatorOverriding
{
    public class Animal
    {
        // Virtual method in the base class
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    public class Dog : Animal
    {
        // Overriding the MakeSound method in the derived class
        public override void MakeSound()
        {
            Console.WriteLine("The dog says: Woof!");
        }
    }

    public class Cat : Animal
    {
        // Overriding the MakeSound method in the derived class
        public override void MakeSound()
        {
            Console.WriteLine("The cat says: Meow!");
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Base class reference pointing to a derived class object
            Animal myAnimal;

            // Creating a Dog object and assigning it to an Animal reference
            myAnimal = new Dog();
            myAnimal.MakeSound();  // Outputs: The dog says: Woof!

            // Creating a Cat object and assigning it to an Animal reference
            myAnimal = new Cat();
            myAnimal.MakeSound();  // Outputs: The cat says: Meow!

            // Creating an Animal object and calling its method
            myAnimal = new Animal();
            myAnimal.MakeSound();  // Outputs: The animal makes a sound
        }
    }
}
```

O/p
```
The dog says: Woof!
The cat says: Meow!
The animal makes a sound
```

# 9. Exception Handling
- Exception handling in c# is a process to handle runtime errors.
- we perform exception handling so that normal flow of the applications can be maintained even after runtime errors.
- exception is an event or object which is throw at runtime.
- all exception the derived from System.Exception class.
- it is a runtime error which can be handled.
- if we don't handle the exception, it prints exception message and terminates the program.

### Advantages:
- It maintains the noraml flow of the applications.
- In such case, rest of the code is executed event after exception.

### Exception Classes:
| SR.NO | Exception                 	| Description                                                               |
|-------|-------------------------------|---------------------------------------------------------------------------|
|   1.  | System.DivideByZeroException	| handles the error generated by dividing a number with zero.               |
|   2.  | System.NullReferenceException	| handles the error generated by referencing the null object.               |
|   3.  | System.InvalidCastException	| handles the error generated by invalid typecasting.                       |
|   4.  | System.IO.IOException	handles | the Input Output errors.                                                  |
|   5.  | System.FieldAccessException	| handles the error generated by invalid private or protected field access. |


## 1) try-catch block
- The try block in c# is used to place the code that may throw exception.
- The catch block is used to handled the exceptions.

```csharp
using System;

namespace tryCatchExample
{
    public class ExExample
    {
        public static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int x = a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Rest of the code");
            Console.ReadLine();
        }
    }
}
```

O/p
```
System.DivideByZeroException: Attempted to divide by zero.
Rest of the code
```

## 2) Finally block
- c# finally block is used to execute important code which is to be executed whether exception is handled or not
- it must be preceded by catch or try block.

Ex. c# finally example if exception is handled.
```
using System;
public class ExExample
{
    public static void Main(string[] args)
    {
        try
        {
            int a = 10;
            int b = 0;
            int x = a / b;
        }
        catch (Exception e) 
        { 
            Console.WriteLine(e); 
        }
        finally 
        { 
            Console.WriteLine("Finally block is executed");
        }
        
        Console.WriteLine("Rest of the code");
        Console.ReadLine();
    }
}
```

O/p
```
System.DivideByZeroException: Attempted to divide by zero.
   at ExExample.Main(String[] args) in E:\C Sharp\c-sharp\CSharp-Topics\ExceptionHanding\2_finally\2_finally_block\Program.cs:line 10
Finally block is executed
Rest of the code
```

Ex. C# finally example if exception is not handled
```
using System;  
public class ExExample  
{  
    public static void Main(string[] args)  
    {  
        try  
        {  
            int a = 10;  
            int b = 0;  
            int x = a / b;  
        }  
        catch (NullReferenceException e) { Console.WriteLine(e); }  
        finally { Console.WriteLine("Finally block is executed"); }  
        Console.WriteLine("Rest of the code");  
    }  
}  
```
Output:

```
Unhandled Exception: System.DivideBy
```

## Custom Exceptions:
- C# allows us to create user-defined or custom exception. 
- It is used to make the meaningful exception. 
- To do this, we need to inherit Exception class.

```
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
```

O/p:
```
Enter your age: 16
Custom Exception: Sorry, age must be 18 or older.
Program ended.

Enter your age: 20
Age is valid.
Program ended.

```


## Key Benefits of Custom Exceptions:
**Clarity:** Custom exceptions provide more meaningful error messages, making your code easier to understand and debug.
**Separation of Concerns:** They allow you to differentiate between different types of errors and handle them appropriately.
**Extensibility:** You can add custom properties and methods to convey more information about the error, which can be useful for logging or user feedback.

## throw Keyword:
- In C#, the keyword "throw" is used to create and throw an exception object to indicate an error that's occurred while running a program.
- The runtime then searches for the most compatible exception handler. 

- You can throw exceptions for errors that can't be trapped within the normal flow of the program, such as:
    - File open errors
    - IO errors
    - Zero divisors
    - Invalid parameter values
    - Inappropriate object calls
    - Arguments that cause an exception


# 10 Collections
- Arrays
- lists
- dictionaries
- queues
- stacks