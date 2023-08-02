using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_5
{
    internal class DoublyHeaderLinkedList
    {
        DoublyNode start;   // Start
        DoublyNode head;    // Head

        /// <summary>
        /// Traverses the linked list starting from start node to head
        /// </summary>
        public void Traverse()
        {
            // Declare a node which will traverse from start node
            // Keep moving until the node is null
            while (true)
            {
                // Write to console
                // Set the node to next node of current node
            }
        }

        /// <summary>
        /// Traverses the linked list starting from head node to start
        /// </summary>
        public void Reverse()
        {
            // Declare a node which will traverse from head node
            // Keep moving until the node is null
            while (true)
            {
                // Write to console
                // Set the node to previous node of current node
            }
        }

        /// <summary>
        /// Inserts a new node at the head
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Insert(DataItem item) 
        {
            // If this is the first node, then initialize
            if (start == null)
            {
                // Create a new node
                // Set head = start
            }
            else
            {
                // No need for iteration when we already have a head node
                // Create a new node on head's pointer
                // Set the item object
                // Set next and preivous
            }
            return false;
        }

        /// <summary>
        /// Performs Insert operation after given node
        /// </summary>
        /// <param name="item"></param>
        /// <param name="after"></param>
        /// <returns></returns>
        public bool InsertAfter(DataItem item, DoublyNode after) 
        {
            // If this is the first node, then initialize
            // Create a new node object
            // Set the data for new node
            // Set next and previous pointers
            return false;
        }

        /// <summary>
        /// Performs Insert operation before given node
        /// </summary>
        /// <param name="item"></param>
        /// <param name="before"></param>
        /// <returns></returns>
        public bool InsertBefore(DataItem item, DoublyNode before)
        {
            // Call InsertAfter with appropriate parameters
            return false;
        }

        /// <summary>
        /// Performs Delete operation by matching the data item
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Delete(DataItem item)
        {
            // Initialize pointer
            // Iterate until the target item is found
            while (true)
            {
                // Match data with the next node
                // Delink the target node by setting next and previous pointers
            }
        }

        /// <summary>
        /// Deletes the first (start) node
        /// </summary>
        /// <returns></returns>
        public bool DeleteFirst()
        {
            return false;
        }

        /// <summary>
        /// Deletes the last (head) node
        /// </summary>
        /// <returns></returns>
        public bool DeleteLast()
        {
            return false;
        }

        /// <summary>
        /// Traverses the whole list and searches for the node matching the item in parameter
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public DoublyNode Search(DataItem item)
        {
            return null;
        }

        /// <summary>
        /// Should not be called outside this class
        /// </summary>
        /// <param name="option"></param>
        private void Sort(string option)
        {
            switch(option)
            {
                case "NAME":
                    break;
                case "CGPA":
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Sort the list by SID
        /// </summary>
        public void SortBySID()
        {
            Sort("SID");
        }

        /// <summary>
        /// Sort the list by Name
        /// </summary>
        public void SortByName()
        {
            Sort("NAME");
        }

        /// <summary>
        /// Sort the list by CGPA
        /// </summary>
        public void SortByCGPA()
        {
            Sort("CGPA");
        }

        /// <summary>
        /// Resets the list to an empty one
        /// </summary>
        public void Clear() 
        {
            start = head = null;
        }

        /// <summary>
        /// Get the number of nodes
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return -1;
        }
    }
}
