using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList myLinkedList = new SingleLinkedList();
            DataItem hs = new DataItem(65019, "HAFS SIDDIQUI", 3.3f);
            DataItem am = new DataItem(64669, "ASRA MASOOD", 3.0f);
            DataItem mh = new DataItem(65040, "ABDUL MOHIMIN", 2.6f);
            DataItem sk = new DataItem(64930, "SHAHZAMAN KHAN", 3.2f);
            DataItem ob = new DataItem(64901, "OMAR BAIG", 2.2f);
            DataItem ok = new DataItem(64910, "OMAR KHAN", 2.5f);

            Console.WriteLine("Inserting data...");
            myLinkedList.Insert(hs);
            myLinkedList.Insert(am);
            myLinkedList.Insert(mh);
            myLinkedList.Insert(sk);
            myLinkedList.Insert(ob);
            myLinkedList.Insert(ok);
            Console.WriteLine("Traversing");
            myLinkedList.Traverse();
            Console.WriteLine();

            Console.WriteLine("Deleting " + mh.getFullName());
            myLinkedList.Delete(mh);
            Console.WriteLine("Traversing");
            myLinkedList.Traverse();
            Console.WriteLine();

            Console.WriteLine("Searching for " + am.getFullName());
            Node amNode = myLinkedList.Search(am);
            if (amNode != null )
            {
                Console.WriteLine("Found! Data: " + amNode.item.ToString() + "; Next node: " + amNode.next.item.ToString());
            }
            Console.WriteLine();

            Console.WriteLine("Inserting data after " + am.getFullName());
            DataItem uk = new DataItem(13045, "UZAIR KHAN", 2.2f);
            myLinkedList.InsertAfter(uk, amNode);
            Console.WriteLine("Traversing");
            myLinkedList.Traverse();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
