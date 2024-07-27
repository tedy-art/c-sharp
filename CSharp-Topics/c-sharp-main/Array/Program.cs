using System;
using System.Linq;

namespace ArrayNew
{
    class arrayProgam
    {
        static void Main(string[] args)
        {
            // Accessing Element
            string[] cars = ["Volvo", "BMW", "Ford", "Mazda"];
            Console.WriteLine($"the 0th index element : {cars[0]}");

            // Change an array element
            cars[0] = "Opel";
            Console.WriteLine("Change Element to another : " +cars[0]);

            // Array length
            Console.WriteLine("Length of array is : "+cars.Length);

            // Loop through array
            Console.WriteLine("\nFor loop with an array : ");
            for (int i = 0; i<cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            // Sort element in an array
            Console.WriteLine("\nSort str element in an array");
            string[] cars1 = ["Tata","Honda","HT","Mahindra"];
            Array.Sort(cars1);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nSort int element in an array");
            int[] myNumbers = [5, 1, 8, 9];
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nOther inbuilt method like 1)Max() 2)min() and 3)sum() :");
            Console.WriteLine("Import using System.Linq");
            Console.WriteLine($"Max element in an array : {myNumbers.Max()}");
            Console.WriteLine($"Min element in an array : {myNumbers.Min()}");
            Console.WriteLine($"Sum of the an array : {myNumbers.Sum()}");

            Console.WriteLine("\nMultiDimensional Array :");
            int[,] numbers = {{1, 4, 2}, {3, 6, 8}};
            Console.WriteLine($"No. 0th array and 2nd element : {numbers[0,2]}");

            Console.WriteLine("\nChanging element in MultiDimensional Array :");
            numbers[0, 0] = 5;
            Console.WriteLine($"Change element on index of array = 0 and element index 0 : {numbers[0, 0]}");


            Console.WriteLine("\nLoop Through a 2D array using foreach loop : ");
            int[,] numbers2 = {{1, 4, 2}, {3, 6, 8}};
            foreach (int i in numbers2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nUse \'GetLength\' for getting no of rows and columns");
            Console.WriteLine("Loop Through a 2D array using for loop : ");
            for (int i=0; i<numbers2.GetLength(0); i++){
                for (int j=0; j<numbers2.GetLength(1); j++){
                    Console.WriteLine(numbers2[i, j]);
                }
            }
        }
    }
}