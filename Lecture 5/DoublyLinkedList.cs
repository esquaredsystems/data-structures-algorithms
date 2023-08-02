using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_5
{
    internal class DoublyLinkedList
    {
        DoublyNode start;

        public void Traverse()
        {
            DoublyNode pointer = start;   // Declare a node which will traverse
            // Keep moving until the node is null
            while (pointer != null)
            {
                Console.WriteLine(pointer.item.ToString());
                pointer = pointer.next; // Set the node to next node of current node
            }
        }

        public bool Insert(DataItem item)
        {
            // If this is the first node, then initialize
            if (start == null)
            {
                start = new DoublyNode();
                start.item = item;
                start.next = null;
                start.previous = null;
            }
            else
            {
                DoublyNode  pointer = start;
                // Traverse until next is null, i.e. the node is at the last node
                while (pointer.HasNext())
                {
                    pointer = pointer.next;
                }
                DoublyNode newNode = new DoublyNode();  // Create a new node object
                newNode.item = item;
                newNode.previous = pointer; // Set the pointer as previous node of new node
                pointer.next = newNode; // Set the new node as next node of pointer
            }
            return true;
        }

        public bool InsertAfter(DataItem item, DoublyNode after)
        {
            // If this is the first node, then initialize
            if (start == null)
            {
                return Insert(item);
            }
            DoublyNode newNode = new DoublyNode();  // Create a new node object
            newNode.item = item;    // Set the data for new node
            newNode.next = after.next;  // This new node will link to the node which "after" was linked to
            after.next = newNode;   // after will now link to this new node
            newNode.previous = after;
            return true;
        }

        public bool InsertBefore(DataItem item, DoublyNode before)
        {
            // Instead of writing everything again, simply call InsertAfter on previous pointer of before
            return InsertAfter(item, before.previous);
        }

        public bool Delete(DataItem item)
        {
            // Initialize a node
            DoublyNode node = start;
            while (node.HasNext())
            {
                // Match data not of current, but with the next node
                bool matches = node.next.item.Equals(item);
                if (matches)
                {
                    // First, check if this is the last node?
                    if (!node.next.HasNext())
                    {
                        node.next = null;
                    }
                    // Otherwise delete the node by pulling the next node's data and link
                    else
                    {
                        DoublyNode nextLink = node.next.next;
                        node.next = nextLink;
                    }
                    return true;
                }
                node = node.next;
            }
            return false;
        }

        public DoublyNode Search(DataItem item)
        {
            DoublyNode node = start;
            while (node != null)
            {
                if (node.item.Equals(item))
                {
                    return node;
                }
                node = node.next;
            }
            return null;
        }
    }
}
