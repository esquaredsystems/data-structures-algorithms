using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_12
{
    internal class Program
    {
        static DataItem hs = new DataItem(5019, "HAFS SIDDIQUI", 3.3f);
        static DataItem am = new DataItem(4669, "ASRA MASOOD", 3.0f);
        static DataItem mh = new DataItem(5040, "ABDUL MOHIMIN", 2.6f);
        static DataItem sk = new DataItem(4930, "SHAHZAMAN KHAN", 3.2f);
        static DataItem ob = new DataItem(4901, "OMAR BAIG", 2.2f);
        static DataItem ok = new DataItem(4910, "OMAR KHAN", 2.5f);
        static DataItem jr = new DataItem(5144, "JAWAD RAZA", 2.6f);

        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();
            bt.root = new TreeNode(hs);
            bt.root.left = new TreeNode(am);
            bt.root.right = new TreeNode(mh);
            bt.root.left.left = new TreeNode(sk);
            bt.root.left.right = new TreeNode(ob);
            bt.root.right.left = new TreeNode(ok);
            bt.root.right.right = new TreeNode(jr);
            Console.WriteLine("Traversing In-order...");
            bt.TraverseInorder(bt.root);
            Console.WriteLine("Traversing Pre-order...");
            bt.TraversePreorder(bt.root);
            Console.WriteLine("Traversing Post-order...");
            bt.TraversePostorder(bt.root);
            Console.WriteLine($"Tree height is {bt.GetHeight(bt.root)}");

            bt = new BinaryTree();
            Console.WriteLine("Inserting efficiently...");
            bt.root = bt.InsertFast(bt.root, hs);
            bt.root = bt.InsertFast(bt.root, am);
            bt.root = bt.InsertFast(bt.root, mh);
            bt.root = bt.InsertFast(bt.root, sk);
            bt.root = bt.InsertFast(bt.root, ob);
            bt.root = bt.InsertFast(bt.root, ok);
            bt.root = bt.InsertFast(bt.root, jr);
            bt.TraverseInorder(bt.root);
            Console.WriteLine($"Tree height is {bt.GetHeight(bt.root)}");

            bt = new BinaryTree();
            Console.WriteLine("Inserting with completeness...");
            bt.root = bt.InsertComplete(bt.root, hs);
            bt.root = bt.InsertComplete(bt.root, am);
            bt.root = bt.InsertComplete(bt.root, mh);
            bt.root = bt.InsertComplete(bt.root, sk);
            bt.root = bt.InsertComplete(bt.root, ob);
            bt.root = bt.InsertComplete(bt.root, ok);
            bt.root = bt.InsertComplete(bt.root, jr);
            bt.TraverseInorder(bt.root);
            Console.WriteLine($"Tree height is {bt.GetHeight(bt.root)}");

            bt = new BinaryTree();
            Console.WriteLine("Inserting ordered...");
            bt.root = bt.InsertOrdered(bt.root, hs);
            bt.root = bt.InsertOrdered(bt.root, am);
            bt.root = bt.InsertOrdered(bt.root, mh);
            bt.root = bt.InsertOrdered(bt.root, sk);
            bt.root = bt.InsertOrdered(bt.root, ob);
            bt.root = bt.InsertOrdered(bt.root, ok);
            bt.root = bt.InsertOrdered(bt.root, jr);
            bt.TraverseInorder(bt.root);
            Console.WriteLine($"Tree height is {bt.GetHeight(bt.root)}");

            Console.WriteLine("Searching using BFS...");
            TreeNode found = bt.BreadthFirstSearch(bt.root, mh);
            if (found != null)
            {
                Console.WriteLine($"Node found! {found.item}");
            }
            Console.WriteLine("Searching using DFS...");
            found = bt.DepthFirstSearch(bt.root, sk);
            if (found != null)
            {
                Console.WriteLine($"Node found! {found.item}");
            }

            Console.WriteLine("Deleting leaves...");
            bt.DeleteLeaf(bt.root, jr);

            Console.WriteLine("Searching using BFS...");
            found = bt.BreadthFirstSearch(bt.root, jr);
            if (found != null)
            {
                Console.WriteLine($"Node found: {found.item}");
            }
            else
            {
                Console.WriteLine("Node not found!");
            }

            Console.ReadKey();
        }
    }
}
