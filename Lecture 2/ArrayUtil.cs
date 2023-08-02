using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2
{
    internal class ArrayUtil
    {
        /// <summary>
        /// Traverses an array from one point to another
        /// </summary>
        /// <param name="array">Integer array</param>
        /// <param name="start">Index to start traversing from</param>
        /// <param name="end">Index to end traversing at</param>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static void Traverse(int[] array, int start, int end)
        {
            // Check boundary conditions
            if (array.Length == 0 || start >= array.Length) throw new IndexOutOfRangeException();
            if (start > end) throw new ArgumentOutOfRangeException();
            // Iterate from start to end
            for (int i = start; i <= end; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Traverse(int[] array)
        {
            Traverse(array, 0, array.Length - 1);
        }

        /// <summary>
        /// Inserts an element into an array at given index
        /// </summary>
        /// <param name="array">Integer array</param>
        /// <param name="element">The value to insert</param>
        /// <param name="index">Index at which to insert the value</param>
        /// <returns>Integer array after inserting</returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public static int[] Insert(int[] array, int element, int index)
        {
            // Check boundary conditions
            if (index >= array.Length || index < 0) throw new IndexOutOfRangeException();
            // Move existing elements from index to create space for insert
            for (int i = array.Length - 1; i > index; i--)
            {
                array[i] = array[i - 1];
            }
            array[index] = element;
            return array;
        }

        /// <summary>
        /// Deletes an element at index from an array
        /// </summary>
        /// <param name="array">Integer array</param>
        /// <param name="index">Index at which to insert the value</param>
        /// <returns>Integer array after deletion</returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public static int[] Delete(int[] array, int index)
        {
            // Check boundary conditions
            if (index >= array.Length || index < 0) throw new IndexOutOfRangeException();
            // Shift elements left from end to index
            for (int i = index; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            // Must set the last item to Null (in C# zero)
            array[array.Length - 1] = 0;
            return array;
        }

        /// <summary>
        /// Divide an array into two parts from given index
        /// </summary>
        /// <param name="array">Integer array</param>
        /// <param name="index">Index at which to split the array</param>
        /// <returns>2-D array of size two after splitting. First sub-array is the left part and second is the right part</returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public static int[][] Split(int[] array, int index)
        {
            // Check boundary conditions
            if (index >= array.Length || index < 0) throw new IndexOutOfRangeException();
            int[] sub1 = new int[index]; // First subset will contain elements from 0 to index
            int[] sub2 = new int[array.Length - index]; // Second subset will have the remaining elements
            int counter = 0;
            for (; counter < index; counter++)
            {
                sub1[counter] = array[counter];
            }
            // Reuse the same counter to continue copying in second subset
            for (; counter < array.Length; counter++)
            {
                sub2[counter - index] = array[counter];
            }
            // Return both subsets as an array
            return new int[][] { sub1, sub2 };
        }

        /// <summary>
        /// Merges two arrays into one by appending second array after the first one
        /// </summary>
        /// <param name="array1">First array to merge</param>
        /// <param name="array2">Second array to merge</param>
        /// <returns>Integer array after merger</returns>
        public static int[] Merge(int[] array1, int[] array2)
        {
            // Check for empty arrays
            if (array1.Length == 0)
            {
                return array1;
            }
            if (array2.Length == 0)
            {
                return array2;
            }
            // Create a new array by adding sizes of both
            int[] array = new int[array1.Length + array2.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                array[i] = array1[i];
            }
            for (int i = 0; i < array2.Length; i++)
            {
                array[array1.Length + i - 1] = array2[i];
            }
            return array;
        }

        /// <summary>
        /// Searches for an element in an array and returns its index
        /// </summary>
        /// <param name="array">Array to search in</param>
        /// <param name="q">Parameter</param>
        /// <returns></returns>
        public static int Search(int[] array, int q)
        {
            if (array.Length > 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == q)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        /// <summary>
        /// Returns the element with highest value in an array
        /// </summary>
        /// <param name="array">Array to search in</param>
        /// <returns></returns>
        public static int SearchMax(int[] array)
        {
            int max = 0;
            if (array.Length > 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                }
            }
            return max;
        }

        /// <summary>
        /// Searches for all elements in an array and returns their indices
        /// </summary>
        /// <param name="array">Array to search in</param>
        /// <param name="q">Parameter</param>
        /// <returns>Array of integer indices</returns>
        public static int[] SearchAll(int[] array, int q)
        {
            int[] subArray = new int[array.Length];
            int j = 0; // Index for subArray
            if (array.Length > 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == q)
                    {
                        subArray[j] = i;
                        j++;
                    }
                }
            }
            return subArray;
        }

        /// <summary>
        /// Increases size of an array
        /// </summary>
        /// <param name="array">Array to expand</param>
        /// <param name="add">Length by which to expand the array further</param>
        /// <returns>Array with increased capacity</returns>
        public static int[] Expand(int[] array, int add)
        {
            // If the number of indices to add is zero, then return the same array
            if (add <= 0)
            {
                return array;
            }
            // Create new array with additional capacity
            int[] newArray = new int[array.Length + add];
            // Copy existing elements into new array
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }

        public static int FindMemoryAddress(int baseAddress, int index, int elementSize)
        {
            if (index < 0) throw new IndexOutOfRangeException();
            return baseAddress + elementSize * index;
        }
    }
}
