using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lecture_3
{
    internal class Sorting
    {
        static void Main(string[] args)
        {
            Sorting obj = new Sorting();
            // obj.BubbleSort(new int[] { 2, 8, 5, 3, 9, 4, 1 });
            obj.SelectionSort(new int[] { 6, 5, 4, 3, 2, 1 });
            // obj.InsertionSort(new int[] { 6, 5, 4, 3, 2, 1 });
            Console.ReadKey();
        }

        public int[] BubbleSort(int[] array)
        {
            // Repeat for index 1 to n-1
            for (int i = 1; i < array.Length; i++)
            {
                Console.WriteLine("The array is: ");
                foreach (var item in array)
                    Console.Write(item + " ");
                Console.WriteLine();
                // Repeat for index 0 to n-2
                for (int j = 0;  j < array.Length - 1; j++)
                {
                    // Swap if the right neighbour is higher
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        Console.WriteLine($"At [i, j]: [{i}, {j}], swapping {array[j]} with {array[j + 1]}");
                    }
                }
                Console.WriteLine();
            }
            return array;
        }

        public int[] SelectionSort(int[] array)
        {
            // Repeat for index 1 to n-1
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("The array is: ");
                foreach (var item in array)
                    Console.Write(item + " ");
                Console.WriteLine("\n");
                // Assume the current element as the minimum
                int indexOfMin = i;
                // Repeat for index i+1 to n-1
                for (int j = i + 1; j < array.Length; j++)
                    // Set current minimum to lower value
                    if (array[j] < array[indexOfMin])
                        indexOfMin = j;
                // If there's need to swap, then do
                if (indexOfMin != i)
                {
                    int temp = array[i];
                    array[i] = array[indexOfMin];
                    array[indexOfMin] = temp;
                    Console.WriteLine($"At [i, j]: [{i}, {indexOfMin}], swapping {array[i]} with {array[indexOfMin]}");
                }
            }
            return array;
        }

        public int[] InsertionSort(int[] array)
        {
            for (int i = 0; i< array.Length; i++)
            {
                int j = i;
                while (j > 0)
                {
                    if (array[j - 1] > array[j])
                    { 
                        int temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                        Console.WriteLine($"At [i, j]: [{i}, {j}], swapping {array[j]} with {array[j - 1]}");
                    }
                    j--;
                }
                Console.WriteLine("The array is: ");
                foreach (var item in array)
                    Console.Write(item + " ");
                Console.WriteLine();
            }
            return array;
        }

        public int[] MergeSort(int[] array)
        {
            // TODO:
            return array;
        }

        public int[] QuickSort(int[] array)
        {
            // TODO:
            return array;
        }
    }
}
