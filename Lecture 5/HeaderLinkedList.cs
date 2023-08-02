using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_5
{
    internal class HeaderLinkedList
    {
        // Head is the last inserted node
        Node start, head;

        public void Traverse()
        {
            Node pointer = start;
            while (pointer != null)
            {
                Console.WriteLine(pointer.item.ToString());
                pointer = pointer.next;
            }
        }

        public bool Insert(DataItem item)
        {
            // If this is the first node, then initialize
            if (start == null)
            {
                start = new Node();
                start.item = item;
                start.next = null;
                head = start;
            }
            else
            {
                // No need for iteration when we already have a head node
                head.next = new Node(); // Create a new node on head's pointer
                head.next.item = item;  // Set the item object
                head = head.next;   // The head will now become the newly inserted node at head's pointer
            }
            return true;
        }
    }
}
