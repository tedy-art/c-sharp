using System;

namespace MyApplication{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("if statement : ");
            Console.WriteLine("If given condition is true then execute this(if block) block.");
            if (20 > 10){
                Console.WriteLine("20 is greater than 10.");
            }
            int x = 20;
            int y = 18;
            if (x > y){
                Console.WriteLine("x is greater than y");
            }
            
            Console.WriteLine("\n\n");
            Console.WriteLine("else statement : ");
            Console.WriteLine("if \'if\' statement is then else Conditon execute.");
            int a = 20;
            int b = 22;
            if (a > b){
                Console.WriteLine("a is greater than b");
            }
            else{
                Console.WriteLine("b is greater than a");
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("else if statement : ");
            Console.WriteLine("if \'if statement\' yeh tab ran karenga jab if ki condition false ho jayeli aur iss statement ke o/p more than ek hoge toh \'else if\' ka use hoga");
            Console.WriteLine("Enter value for K : ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for J : ");
            int j = Convert.ToInt32(Console.ReadLine());
            if (k < j){
                Console.WriteLine("j is greater than k");
            }
            else if (k > j){
                Console.WriteLine("k is greater than j");
            }
            else if (k == j){
                Console.WriteLine("k and j are both same value");
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("Short hand if...else(Ternary Operator) :");
            int time = 20;
            if (time < 18){
                Console.WriteLine("Good Day");
            }
            else{
                Console.WriteLine("Good Evening");
            }
        }
    }
}