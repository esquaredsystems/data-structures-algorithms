using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_11
{
    internal class Recursion
    {
        /// <summary>
        /// Sums up numbers from 1 to n
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int SumOfNumbers(int n)
        {
            return Add(n, n - 1);
        }

        private static int Add(int sum, int next)
        {
            /* The WRONG way. Because the recursion does not first reach the simplest subproblem
             * Instead, it almost acts like a loop running backwards
             */
            //sum += next--;
            //if (next > 0)
            //{
            //    return Add(sum, next);
            //}
            //return sum;

            /* CORRECT way. Here, the calculation does not even begin until we reach the simplest
             * Subproblem, i.e. Add(2, 1)
             */
            if (next > 0)
            {
                return Add(sum, next - 1) + next;
            }
            return sum;
        }

        public static void FibonacciSeriesRecursive(int range)
        {
            for (int i = 1; i <= range; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
        }

        public static void FibonacciSeriesIterative(int range)
        {
            int n1 = 0, n2 = 1;
            Console.Write(n2 + " ");
            for (int i = 1; i < range; i++)
            {
                int fib = n1 + n2;
                Console.Write(fib + " ");
                n1 = n2;
                n2 = fib;
            }
        }

        private static int Fibonacci(int n)
        {
            // Since first 2 numbers are 1
            if (n <= 2)
            {
                return 1;
            }
            // Return sum of Previous Fibonacci number and the one before it
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public static void TowerOfHanoi(int n)
        {
            // Initiate 3 arrays, Source, Target, Buffer
            // Source will contain initial state
            SolveTowerOfHanoi(3, 'A', 'B', 'C');
        }

        private static void SolveTowerOfHanoi(int n, char source, char buffer, char target)
        {
            // Termination conditions
            if (n == 1)
            {
                Console.WriteLine($"Moving {n} from {source} to {target}");
                return;
            }
            SolveTowerOfHanoi(n - 1, source, target, buffer);
            Console.WriteLine($"Moving {n} from {source} to {target}");
            SolveTowerOfHanoi(n - 1, buffer, source, target);
        }

        /// <summary>
        /// Returns list of directories and sub-directories in a path. This method does not include Files.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public static Queue<string> GetDirectories(string path, Queue<string> list)
        {
            // Fetch all sub directories in the path
            string[] dirs = Directory.GetDirectories(path);
            // First, add the subdirectories to the queue
            foreach (string dir in dirs)
            {
                list.Enqueue(dir);
            }
            // Now for each sub-directory, recursively call this method
            foreach (string dir in dirs)
            {
                FileAttributes fileAttributes = File.GetAttributes(dir);
                if ((fileAttributes & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    list = GetDirectories(dir, list);
                }
            }
            return list;
        }
    }
}
