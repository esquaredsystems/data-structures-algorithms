﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_5
{
    internal class CircularLinkedList
    {
        // Head is the last inserted node
        Node start, head;

        public void Traverse()
        {
            Node pointer = start;
            // Traversing is slightly different
            if (start != null) {
                do
                {
                    Console.WriteLine(pointer.item.ToString());
                    pointer = pointer.next;
                } while (pointer != start); // Stop when pointer is back at start node
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
                head.next = new Node();
                head.next.item = item;
                head = head.next;
                head.next = start;  // The head should link back to start
            }
            return true;
        }
    }
}
