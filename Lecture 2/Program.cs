using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2
{
    internal class Program
    {
        static void DemoArrays()
        {
            int[] array = new int[8];
            // Insert operation
            Console.WriteLine("Demonstrating insert...");
            array = ArrayUtil.Insert(array, 1, 0);
            array = ArrayUtil.Insert(array, 2, 1);
            array = ArrayUtil.Insert(array, 3, 2);
            array = ArrayUtil.Insert(array, 4, 3);
            array = ArrayUtil.Insert(array, 5, 4);
            array = ArrayUtil.Insert(array, 6, 5);
            ArrayUtil.Traverse(array, 2, 4);  // Should print 3, 4, 5
            array = ArrayUtil.Insert(array, 9, 3);
            ArrayUtil.Traverse(array); // Should print 1, 2, 3, 9, 4, 5, 6, ...

            // Delete operation
            Console.WriteLine("Demonstrating delete...");
            array = ArrayUtil.Delete(array, 3);
            ArrayUtil.Traverse(array); // Should print 1, 2, 3, 4, 5, 6, ...

            // Search operations
            Console.WriteLine("Demonstrating search...");
            // Search for element's index
            int a = ArrayUtil.Search(array, 4);
            Console.WriteLine("Value 4 is at index: " + a); // Should print 3
            // Search for maximum value
            int max = ArrayUtil.SearchMax(array);
            Console.WriteLine("Highest value is: " + max); // Should print 6
            // Search for all matching indices
            array = ArrayUtil.Insert(array, 10, 3);
            array = ArrayUtil.Insert(array, 10, 5);
            array = ArrayUtil.Insert(array, 10, 7);
            int[] sub = ArrayUtil.SearchAll(array, 10);
            Console.WriteLine("Indices of value 10");
            ArrayUtil.Traverse(sub); // Should print 3, 5, 7, ...

            // Split operation
            Console.WriteLine("Demonstrating split...");
            int[][] parts = ArrayUtil.Split(array, 4);
            ArrayUtil.Traverse(parts[0]); // Should print 1, 2, 3, 10
            ArrayUtil.Traverse(parts[1]); // Should print 4, 10, 5, 10

            // Merge operation
            Console.WriteLine("Demonstrating merge...");
            int[] merged = ArrayUtil.Merge(array, parts[1]);
            ArrayUtil.Traverse(merged); // Should print 1, 2, 3, ..., 4, 5, 6, ...

            // Expand operation
            Console.WriteLine("Demonstrating expansion...");
            int[] expanded = ArrayUtil.Expand(array, 3);
            Console.WriteLine(expanded.Length); // Should print 11

            // Find memory
            Console.WriteLine("Demonstrating finding memory addresses...");
            Console.WriteLine(ArrayUtil.FindMemoryAddress(1000, 3, 8));
        }

        static void Demo2DArrays()
        {
            int[,] sids =
            {
                {101, 102, 103, 104, 105, 0, 0, 0},
                {201, 202, 203, 204, 205, 206, 207, 208},
                {301, 302, 303, 304, 305, 306, 0, 0},
                {401, 402, 403, 404, 405, 406, 407, 0}
            };

            string[,] names =
            {
                {"Ali", "Nabeel", "Irtiza", "Wasim", "Talha", null, null, null},
                {"Sidra", "Uzair", "Shamsher", "Kanwal", "Shahzeb", "Noman", "Waqas", "Sajida"},
                {"Parkash", "Khalid", "Iqbal", "Saqib", "Hareem", "Jehan", null, null},
                {"Azfar", "Maimoona", "Seema", "Joseph", "Ather", "Safwan", "Sana", null}
            };
            float[,] cgpas =
            {
                {2.8f, 2.6f, 3.6f, 3.7f, 2.1f, 0.0f, 0.0f, 0.0f},
                {3.0f, 3.5f, 2.9f, 1.9f, 3.8f, 2.7f, 3.4f, 3.7f},
                {3.7f, 2.8f, 1.8f, 3.0f, 2.4f, 1.9f, 0.0f, 0.0f},
                {3.6f, 3.0f, 2.5f, 2.6f, 1.9f, 3.4f, 2.9f, 0.0f}
            };
            // Traverse entire array
            Console.WriteLine("Demonstrating traverse...");
            Array2DUtil.Traverse(sids);
            // Traverse a subset of array, 3 columns and 4 rows
            Array2DUtil.Traverse(sids, 0, 2, 1, 5);

            // Insert operation
            Console.WriteLine("Demonstrating insert...");
            Array2DUtil.Insert(sids, 307, 2, 6);
            Array2DUtil.Traverse(sids);

            // Delete operation

            // Search operations
            Console.WriteLine("Demonstrating search...");
            int[] indices = Array2DUtil.Search(sids, 304);
            Console.WriteLine("Value 304 was found at Column:" + indices[0] + ", Row:" + indices[1]);

            // Expand operation
            Console.WriteLine("Demonstrating expansion...");
            int[,] expanded = Array2DUtil.ExpandRows(sids, 2);
            Array2DUtil.Traverse(expanded);
            expanded = Array2DUtil.ExpandColumns(sids, 2);
            Array2DUtil.Traverse(expanded);

            // Find memory
            int address = Array2DUtil.FindMemoryAddress(4040, 1, 1, sids.GetLength(1), sids.GetLength(0), 8, false);
            Console.WriteLine(address);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*** Arrays ***");
            DemoArrays();
            Console.WriteLine("\n\n*** 2-D Arrays ***");
            Demo2DArrays();
            Console.ReadKey();
        }
    }
}
