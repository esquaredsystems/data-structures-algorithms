using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_5
{
    internal class Program
    {
        static DataItem hs = new DataItem(65019, "HAFS SIDDIQUI", 3.3f);
        static DataItem am = new DataItem(64669, "ASRA MASOOD", 3.0f);
        static DataItem mh = new DataItem(65040, "ABDUL MOHIMIN", 2.6f);
        static DataItem sk = new DataItem(64930, "SHAHZAMAN KHAN", 3.2f);
        static DataItem ob = new DataItem(64901, "OMAR BAIG", 2.2f);
        static DataItem ok = new DataItem(64910, "OMAR KHAN", 2.5f);

        static void Main(string[] args)
        {
            DemoLinkedList();
            //DemoHeaderList();
            //DemoCircularList();
            //DemoDoubleList();
            Console.ReadKey();
        }

        public static void DemoLinkedList()
        {
            SingleLinkedList list = new SingleLinkedList();
            Console.WriteLine("Inserting data...");
            list.Insert(hs);
            list.Insert(am);
            list.Insert(mh);
            list.Insert(sk);
            list.Insert(ob);
            list.Insert(ok);
            Console.WriteLine("Traversing");
            list.Traverse();
            Console.WriteLine();

            Console.WriteLine("Deleting " + mh.getFullName());
            list.Delete(mh);
            Console.WriteLine("Traversing");
            list.Traverse();
            Console.WriteLine();

            Console.WriteLine("Searching for " + am.getFullName());
            Node amNode = list.Search(am);
            if (amNode != null)
            {
                Console.WriteLine("Found! Data: " + amNode.item.ToString() + "; Next node: " + amNode.next.item.ToString());
            }

            Console.WriteLine("Inserting data after " + am.getFullName());
            DataItem uk = new DataItem(13045, "UZAIR KHAN", 2.5f);
            list.InsertAfter(uk, amNode);
            list.Traverse();
            Console.WriteLine();

            Console.WriteLine("Sorting by SID...");
            list.Sort();
            list.Traverse();
            Console.WriteLine();
        }

        public static void DemoHeaderList()
        {
            Console.WriteLine("Inserting data into header linked list...");
            HeaderLinkedList list = new HeaderLinkedList();
            list.Insert(hs);
            list.Insert(am);
            list.Insert(mh);
            Console.WriteLine("Traversing");
            list.Traverse();
            Console.WriteLine();
        }

        public static void DemoCircularList()
        {
            Console.WriteLine("Inserting data into circular linked list...");
            CircularLinkedList list = new CircularLinkedList();
            list.Insert(sk);
            list.Insert(ob);
            list.Insert(ok);
            Console.WriteLine("Traversing");
            list.Traverse();
            Console.WriteLine();
        }

        public static void DemoDoubleList()
        {
            Console.WriteLine("Inserting data into double linked list...");
            DoublyLinkedList list = new DoublyLinkedList();
            list.Insert(hs);
            list.Insert(am);
            list.Insert(mh);
            list.Insert(sk);
            Console.WriteLine("Traversing");
            list.Traverse();

            Console.WriteLine("Inserting data after " + mh.getFullName());
            DoublyNode mhNode = list.Search(mh);
            if (mhNode != null)
            { 
                list.InsertAfter(ob, mhNode);
            }
            Console.WriteLine("Traversing");
            list.Traverse();

            Console.WriteLine("Inserting data before " + ob.getFullName());
            DoublyNode obNode = list.Search(ob);
            if (mhNode != null)
            {
                list.InsertBefore(ok, obNode);
            }
            Console.WriteLine("Traversing");
            list.Traverse();

            Console.WriteLine("Deleting " + am.getFullName());
            list.Delete(am);
            Console.WriteLine("Traversing");
            list.Traverse();
            Console.WriteLine();
        }
    }
}
