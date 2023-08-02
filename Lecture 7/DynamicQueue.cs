using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_7
{
    internal class DynamicQueue
    {
        Node head, tail;

        public bool Enqueue(DataItem item)
        {
            if (head == null)
            {
                tail = new Node();
                tail.item = item;
                head = tail;
            }
            else
            {
                Node newNode = new Node();
                newNode.item = item;
                tail.next = newNode;
                tail = newNode;
            }
            return true;
        }

        public DataItem Dequeue()
        {
            DataItem item = Peek();
            head = head.next;
            return item;
        }

        public DataItem Peek()
        {
            if (head == null)
            {
                return null;
            }
            return head.item;
        }

        public bool IsEmpty()
        {
            return head != null;
        }

        public void Clear()
        {
            while (head != null)
            {
                head.item = null;
                head = head.next;
            }
        }
    }
}
