using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_13
{
    internal class Program
    {
        static DataItem[] items;

        static void Main(string[] args)
        {
            DataItem hs = new DataItem(5019, "HAFS SIDDIQUI", 3.3f);
            DataItem am = new DataItem(4669, "ASRA MASOOD", 3.0f);
            DataItem mh = new DataItem(5040, "ABDUL MOHIMIN", 2.6f);
            DataItem sk = new DataItem(4930, "SHAHZAMAN KHAN", 3.2f);
            DataItem ob = new DataItem(4901, "OMAR BAIG", 2.2f);
            DataItem ok = new DataItem(4910, "OMAR KHAN", 2.5f);
            DataItem jr = new DataItem(5144, "JAWAD RAZA", 2.6f);
            items = new DataItem[] {hs, am, mh, sk, ob, ok, jr};
            items = MergeSort(0, items.Length - 1);
            foreach (DataItem item in items)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        static DataItem[] MergeSort(int lower, int upper)
        {
            if (lower < upper)
            {
                int mid = (lower + upper) / 2;
                DataItem[] left = MergeSort(lower, mid);
                DataItem[] right = MergeSort(mid + 1, upper);
                return Merge(left, right);
            }
            return new DataItem[] { items[lower] };
        }

        static DataItem[] Merge(DataItem[] left, DataItem[] right)
        {
            DataItem[] merged = new DataItem[left.Length + right.Length];
            int i = 0, l = 0, r = 0;
            // Run for the items which match in length
            while(l < left.Length && r < right.Length)
            {
                if (left[l].CompareTo(right[r]) > 0)
                {
                    merged[i] = left[l++];
                }
                else
                {
                    merged[i] = right[r++];
                }
                i++;
            }
            // Copy remaining items from left
            while(l < left.Length)
            {
                merged[i++] = left[l++];
            }
            // Copy remaining items from right
            while (r < right.Length)
            {
                merged[i++] = right[r++];
            }
            return merged;
        }
    }
}
