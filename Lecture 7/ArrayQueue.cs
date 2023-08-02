using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_7
{
    internal class ArrayQueue
    {
        private DataItem[] array;
        private int head;

        public ArrayQueue(int size)
        {
            array = new DataItem[size];
            head = -1;
        }

        public bool Enqueue(DataItem item)
        {
            if (head == array.Length - 1) { throw new StackOverflowException(); }
            for (int i = head + 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = item;
            head++;
            return true;
        }

        public DataItem Dequeue()
        {
            DataItem item = Peek();
            if (item == null) { throw new IndexOutOfRangeException(); }
            array[head--] = null;
            return item;
        }

        public DataItem Peek()
        {
            if (head >= 0) 
            {
                return array[head];
            }
            return null;
        }

        public bool IsEmpty()
        {
            return head < 0;
        }

        public void Clear()
        {
            for(int i=0; i<array.Length; i++) 
            { 
                array[i] = null;
                head = -1;
            }
        }
    }
}
