using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_5
{
    internal class SingleLinkedList
    {
        // Keeps only the starting node
        Node start;

        /// <summary>
        /// Traverses the linked list starting from start node until no new nodes are linked
        /// </summary>
        public void Traverse()
        {            
            Node pointer = start;   // Declare a node which will traverse
            // Keep moving until the node is null
            while (pointer != null)
            {
                Console.WriteLine(pointer.item.ToString());
                pointer = pointer.next; // Set the node to next node of current node
            }
        }

        /// <summary>
        /// Performs Insert (append at the end) operation by traversing to the last node
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Insert(DataItem item)
        {
            // If this is the first node, then initialize
            if (start == null)
            {
                start = new Node();
                start.item = item;
                start.next = null;
            }
            else
            {
                Node pointer = start;
                // Traverse until next is null, i.e. the node is at the last node
                while(pointer.HasNext())
                {
                    pointer = pointer.next;
                }
                Node newNode = new Node();  // Create a new node object
                newNode.item = item;
                pointer.next = newNode; // Set the new node as next node of node
            }
            return true;
        }

        /// <summary>
        /// Performs Insert operation after given node
        /// </summary>
        /// <param name="item"></param>
        /// <param name="after"></param>
        /// <returns></returns>
        public bool InsertAfter(DataItem item, Node after)
        {
            // If this is the first node, then initialize
            if (start == null)
            {
                return Insert(item);
            }
            Node newNode = new Node();  // Create a new node object
            newNode.item = item;    // Set the data for new node
            newNode.next = after.next;  // This new node will link to the node which "after" was linked to
            after.next = newNode;   // after will now link to this new node
            return true;
        }

        /// <summary>
        /// Performs Delete operation by matching the data item
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Delete(DataItem item)
        {
            // Initialize a node
            Node node = start;
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
                        Node nextLink = node.next.next;
                        node.next = nextLink;
                    }
                    return true;
                }
                node = node.next;
            }
            return false;
        }

        /// <summary>
        /// Traverses the whole list and searches for the node matching the item in parameter
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public Node Search(DataItem item)
        {
            Node node = start;
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

        public void Sort()
        {
            // Get the size of Linked List
            int size = 0;
            Node pointer = start;
            while (pointer != null)
            {
                size++;
                pointer = pointer.next;
            }
            // Outer loop for bubble sort to run n-1 times
            for (int i = 0; i < size - 1; i++)
            {
                pointer = start;
                // Instead of an index, we keep traversing until next pointer is null
                while (pointer.next != null)
                {
                    // Match the SIDs
                    if (pointer.item.getStudentId() > pointer.next.item.getStudentId())
                    {
                        // Swap
                        DataItem temp = pointer.item;
                        pointer.item = pointer.next.item;
                        pointer.next.item = temp;
                    }
                    pointer = pointer.next;
                }
            }
        }

        public bool InsertSorted(DataItem item)
        {
            // TODO: If the array is already empty, then simply insert
            // Otherwise traverse until current element is less than or equal to the item's SID
                // Call InsertAfter and pass on this data and the current node
            return true;
        }
    }
}
