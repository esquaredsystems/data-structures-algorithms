using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_7
{
    internal class DynamicStack
    {
        private DoublyNode top;

        public bool Push(DataItem item)
        {
            DoublyNode node = new DoublyNode();
            node.item = item;
            node.previous = top;
            top = node;
            return true;
        }

        public DataItem Peek()
        {
            if (top == null)
            {
                return null;
            }
            return top.item;
        }

        public DataItem Pop()
        {
            DataItem item = Peek();
            top = top.previous;
            return item;
        }

        public bool IsEmpty()
        {
            return top != null;
        }

        public void Clear()
        {
            while (top != null)
            {
                top.item = null;
                top = top.previous;
            }
        }
    }
}
