using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Summing up numbers...");
            Console.WriteLine(Recursion.SumOfNumbers(4));
            Console.WriteLine(Recursion.SumOfNumbers(5));
            Console.WriteLine(Recursion.SumOfNumbers(6));
            Console.WriteLine(Recursion.SumOfNumbers(100));

            Console.WriteLine("Generating Fibonacci series using iteration...");
            int range = 50;
            Recursion.FibonacciSeriesIterative(range);
            Console.WriteLine("\nGenerating Fibonacci series using recursion...");
            Recursion.FibonacciSeriesRecursive(range);

            Console.WriteLine();
            Recursion.TowerOfHanoi(3);

            string path = "C:\\Users\\Owais\\Downloads";
            Queue<string> dirs = Recursion.GetDirectories(path, new Queue<string>());
            Console.WriteLine($"There are {dirs.Count} files and directories.");
            while (dirs.Count > 0)
            {
                Console.WriteLine(dirs.Dequeue());
            }
            Console.ReadKey();
        }
    }
}
