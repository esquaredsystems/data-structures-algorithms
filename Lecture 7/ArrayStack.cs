using Lecture_7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_7
{
    internal class ArrayStack
    {
        private DataItem[] array;
        private int size = 0;

        public ArrayStack(int size) 
        {
            array = new DataItem[size];
        }

        public bool Push(DataItem item) 
        {
            if (size == array.Length) { throw new StackOverflowException(); }
            array[size++] = item;
            return true;
        }

        public DataItem Peek()
        {
            if (IsEmpty())
            {
                return null;
            }
            return array[size - 1];
        }

        public DataItem Pop() 
        {
            DataItem item = Peek();
            if (item == null) { throw new IndexOutOfRangeException(); }
            array[--size] = null;
            return item;
        }

        public bool IsEmpty()
        {
            return (size == 0);
        }

        public void Clear()
        {
            array = new DataItem[0];
        }
    }
}
