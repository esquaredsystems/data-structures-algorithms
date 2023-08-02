using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Maker
{
    internal class Program
    {
        static int[] sids = { 11864,    12807,  13045,  13826,  64669,  64901,  64910,  64930,  64946,  64967,  65019,  65040,  65051,  65073,  65139,  65144,  65187 };
        static float[] cgpas = { 2.5f,  2.5f,   2.5f,   2.6f,   2.8f,   2.9f,   2.5f,   2.5f,   2.4f,   3.1f,   2.9f,   2.9f,   2.6f,   2.5f,   2.5f,   2.5f,   2.5f };

        /// <summary>
        /// Reduces an array till the valid values only
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static int[] ReduceArray(int[] array)
        {
            // Search for the last non-zero value from right to left
            int lastZero = 0;
            for (int i = array.Length - 1; i > 0; i--)
            {
                if (array[i] == 0)
                    lastZero = i;
                else
                    break;
            }
            int[] newArray = new int[lastZero];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }

        static int[][] SplitByCGPA(float[] array, float q)
        {
            int m = 0, n = 0;
            int[] left = new int[array.Length];
            int[] right = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= q)
                { left[m++] = i; }
                else
                { right[n++] = i; }
            }
            left = ReduceArray(left);
            right = ReduceArray(right);
            return new int[][] { left, right };
        }

        static void Main(string[] args)
        {
            int perGroup = 3;
            // Split the main array into two classes by CGPA
            int[][] classes = SplitByCGPA(cgpas, 2.8f);
            int[] classM = classes[0];
            int[] classN = classes[1];
            // Find out the number of students per group
            int rem = sids.Length % perGroup;
            // Final array containing groups
            int[,] groups = null;
            // Determine the dimensions of groups array
            if (rem == 0)
            {
                groups = new int[sids.Length / perGroup, perGroup];
            }
            else
            {
                float div = (float)sids.Length / (float)perGroup;
                groups = new int[(int)Math.Ceiling(div), perGroup];
            }
            bool hasLonelyGroup = (rem == 1);
            int m = 0, n = 0;
            for (int i = 0; i < sids.Length; i++) {
                int groupIndex = 0;
                if (m < classM.Length)
                {
                    groups[i, groupIndex++] = sids[classM[m++]];
                }
                while (n < classN.Length && groupIndex < groups.GetLength(1))
                {
                    groups[i, groupIndex++] = sids[classN[n++]];
                }
            }
            // Handle the case of single student in a group. If so, then make 2 groups of 2 students
            if (hasLonelyGroup)
            {
                groups[groups.GetLength(0) - 1, 1] = groups[groups.GetLength(0) - 2, 2];
                groups[groups.GetLength(0) - 2, 2] = 0;
            }
            // Print
            for(int i = 0; i < groups.GetLength(0); i++)
            {
                for (int j = 0; j < groups.GetLength(1); j++)
                {
                    Console.Write(groups[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
