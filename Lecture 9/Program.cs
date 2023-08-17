using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_9
{
    internal class Program
    {
        static int x = 0;
        static void Main(string[] args)
        {
            int[] array = { 11864, 12807, 13045, 13826, 64669, 64901, 64910, 64930, 64946, 64967, 65019, 65040, 65051, 65073, 65139, 65144, 65187 };

            int random = new Random().Next(array.Length);
            Console.WriteLine($"Searching for {array[random]}");
            
            SearchPartial(array, array[random]);
            int index = SearchBinary(array, 0, array.Length, array[random]);
            if (index >= 0)
            {
                Console.WriteLine($"The element was found at {index}");
            }
            else
            {
                Console.WriteLine("Not found!");
            }

            Console.ReadKey();
        }

        public static int SearchLinear(int[] array, int q)
        {
            for (int i = 0; i < array.Length; i++)
            { 
                if (array[i] == q)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int SearchPartial(int[] array, int q)
        {
            // Get a cutoff value to split the array from
            int cutoff = (int) Math.Ceiling((float)array.Length / 2);
            int start = 0;  
            int end = array.Length;
            if (q < array[cutoff])
            {
                end = cutoff;
            }
            else
            {
                start = cutoff;
            }
            Console.WriteLine($"Iterating from {start} to {end}");
            for (int i = start; i < end; i++)
            {
                if (array[i] == q)
                {
                    Console.WriteLine($"Found at {i}");
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Sorts an array using Binary search algorithm
        /// </summary>
        /// <param name="array">Sorted integer array</param>
        /// <param name="start">starting index</param>
        /// <param name="end">Ending index</param>
        /// <param name="q">Search query</param>
        /// <returns></returns>
        public static int SearchBinary(int[] array, int start, int end, int q)
        {
            int difference = end - start;
            Console.WriteLine($"The search space is from {start} to {end}");
            if (difference > 1)
            {
                int cutoff = start + (int)Math.Ceiling((float)(difference) / 2);
                if (q < array[cutoff])
                {
                    end = cutoff;
                }
                else
                {
                    start = cutoff;
                }
                return SearchBinary(array, start, end, q);
            }
            else if (array[start] == q)
            {
                return start;
            }
            else if (array[end] == q)
            {
                return end;
            }
            return -1;
        }
    }
}
