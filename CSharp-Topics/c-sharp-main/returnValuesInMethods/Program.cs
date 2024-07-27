using System;

namespace MyApplication{
    class Program{
        // Method That return an integer value
        public int Add(int a, int b){
            return a+b;
        }

        static void Main(String[] args){
            Program program = new Program();
            int sum = program.Add(3, 4);
            Console.WriteLine($"Sum : {sum}");
        }
    }
}