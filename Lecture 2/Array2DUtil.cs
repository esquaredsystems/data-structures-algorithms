using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lecture_2
{
    internal class Array2DUtil
    {
        /// <summary>
        /// Traverses an array from one point to another
        /// </summary>
        /// <param name="array"></param>
        /// <param name="columnStart"></param>
        /// <param name="columnEnd"></param>
        /// <param name="rowStart"></param>
        /// <param name="rowEnd"></param>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public static void Traverse(int[,] array, int columnStart, int columnEnd, int rowStart, int rowEnd)
        {
            // Check boundary conditions
            if (columnStart < 0 || columnEnd >= array.GetLength(0)) throw new IndexOutOfRangeException();
            if (rowStart < 0 || rowEnd >= array.GetLength(1)) throw new IndexOutOfRangeException();
            // Iterate from columnStart to columnEnd
            for (int i = columnStart; i <= columnEnd; i++)
            {
                for (int j = rowStart; j <= rowEnd; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void Traverse(int[,] array)
        {
            Traverse(array, 0, array.GetLength(0) - 1, 0, array.GetLength(1) - 1);
        }

        /// <summary>
        /// Inserts an element into an array at given column and row indices
        /// </summary>
        /// <param name="array"></param>
        /// <param name="element"></param>
        /// <param name="columnIndex"></param>
        /// <param name="rowIndex"></param>
        /// <returns>Integer array after inserting</returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public static int[,] Insert(int[,] array, int element, int columnIndex, int rowIndex)
        {
            // Check boundary conditions
            if (columnIndex < 0 || columnIndex >= array.GetLength(0)) throw new IndexOutOfRangeException();
            if (rowIndex < 0 || rowIndex >= array.GetLength(1)) throw new IndexOutOfRangeException();
            // Move existing elements from index to create space for insert
            for (int i = array.GetLength(1) - 1; i > rowIndex; i--)
            {
                array[columnIndex, i] = array[columnIndex, i - 1];
            }
            array[columnIndex, rowIndex] = element;
            return array;
        }

        /// <summary>
        /// Deletes an element at index from an array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="element"></param>
        /// <param name="columnIndex"></param>
        /// <param name="rowIndex"></param>
        /// <returns>Integer array after deletion</returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public static int[,] Delete(int[,] array, int element, int columnIndex, int rowIndex)
        {
            // Check boundary conditions
            if (columnIndex < 0 || columnIndex >= array.GetLength(0)) throw new IndexOutOfRangeException();
            if (rowIndex < 0 || rowIndex >= array.GetLength(1)) throw new IndexOutOfRangeException();
            // Move existing elements from index to create space for insert
            for (int i = rowIndex; i < array.GetLength(1) - 1; i++)
            {
                array[columnIndex, i] = array[columnIndex, i + 1];
            }
            array[columnIndex, rowIndex] = 0;
            return array;
        }

        public static int[] Search(int[,] array, int q)
        {
            if (array.GetLength(0) > 0 && array.GetLength(0) > 0)
            {
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    for (int j = 0;  j < array.GetLength(1); j++)
                    {
                        if (array[i, j] == q)
                        {
                            return new int[] { i, j };
                        }
                    }
                }
            }
            return null;
        }

        public static int[,] ExpandRows(int[,] array, int add)
        {
            // If the number of indices to add is zero, then return the same array
            if (add <= 0)
            {
                return array;
            }
            // Create new array with additional capacity
            int[,] newArray = new int[array.GetLength(0), array.GetLength(1) + add];
            // Copy existing elements into new array
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    newArray[i, j] = array[i, j];
                }
            }
            return newArray;
        }

        public static int[,] ExpandColumns(int[,] array, int add)
        {
            // If the number of indices to add is zero, then return the same array
            if (add <= 0)
            {
                return array;
            }
            // Create new array with additional capacity
            int[,] newArray = new int[array.GetLength(0) + add, array.GetLength(1)];
            // Copy existing elements into new array
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    newArray[i, j] = array[i, j];
                }
            }
            return newArray;
        }

        public static int FindMemoryAddress(int baseAddress, int rowIndex, int columnIndex, int rows, int columns, int elementSize, bool rowMajor)
        {
            if (rowIndex < 0 || columnIndex < 0) throw new IndexOutOfRangeException();
            int memoryAddress;
            if (rowMajor)
            {
                memoryAddress = baseAddress + elementSize * (rows * columnIndex + rowIndex);
            }
            else
            {
                memoryAddress = baseAddress + elementSize * (columns * rowIndex + columnIndex);
            }
            return memoryAddress;
        }

    }
}
