using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_7
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
            //DemoArrayStack();
            //DemoDynamicStack();
            //DemoArrayQueue();
            DemoDynamicQueue();
            DemoEquationAnalyzer();

            Console.ReadKey();
        }

        private static void DemoArrayStack()
        {
            ArrayStack stack = new ArrayStack(7);
            stack.Push(hs);
            stack.Push(am);
            stack.Push(ob);
            Console.WriteLine("The top element is: " + stack.Peek().ToString());
            DataItem popped = stack.Pop();
            Console.WriteLine("Popped out: " + popped.ToString());
            Console.WriteLine("The top element is now: " + stack.Peek().ToString());
            popped = stack.Pop();
            Console.WriteLine("Popped out: " + popped.ToString());
            Console.WriteLine("The top element is now: " + stack.Peek().ToString());
            popped = stack.Pop();
            Console.WriteLine("Popped out: " + popped.ToString());
            if (stack.Peek() == null)
            {
                Console.WriteLine("Stack is empty!");
            }
            Console.WriteLine();
        }

        private static void DemoDynamicStack() 
        {
            DynamicStack stack = new DynamicStack();
            stack.Push(hs);
            stack.Push(am);
            stack.Push(ob);
            Console.WriteLine("The top element is: " + stack.Peek().ToString());
            DataItem popped = stack.Pop();
            Console.WriteLine("Popped out: " + popped.ToString());
            Console.WriteLine("The top element is now: " + stack.Peek().ToString());
            popped = stack.Pop();
            Console.WriteLine("Popped out: " + popped.ToString());
            Console.WriteLine("The top element is now: " + stack.Peek().ToString());
            popped = stack.Pop();
            Console.WriteLine("Popped out: " + popped.ToString());
            if (stack.Peek() == null)
            {
                Console.WriteLine("Stack is empty!");
            }
            Console.WriteLine();
        }

        private static void DemoArrayQueue()
        {
            ArrayQueue queue = new ArrayQueue(7);
            Console.WriteLine("Enquing: " + hs.ToString());
            queue.Enqueue(hs);
            Console.WriteLine("Enquing: " + am.ToString());
            queue.Enqueue(am);
            Console.WriteLine("Enquing: " + mh.ToString());
            queue.Enqueue(mh);
            Console.WriteLine("Enquing: " + sk.ToString());
            queue.Enqueue(sk);
            Console.WriteLine("The earliest element is: " + queue.Peek().ToString());
            DataItem dequeued = queue.Dequeue();
            Console.WriteLine("Dequeued: " + dequeued.ToString());
            Console.WriteLine("The earliest element is: " + queue.Peek().ToString());
            dequeued = queue.Dequeue();
            Console.WriteLine("Dequeued: " + dequeued.ToString());
            Console.WriteLine("The earliest element is: " + queue.Peek().ToString());
            dequeued = queue.Dequeue();
            Console.WriteLine("Dequeued: " + dequeued.ToString());
            Console.WriteLine("The earliest element is: " + queue.Peek().ToString());
            dequeued = queue.Dequeue();
            Console.WriteLine("Dequeued: " + dequeued.ToString());
            if (queue.Peek() == null)
            {
                Console.WriteLine("Queue is empty!");
            }

            Console.WriteLine();
        }

        private static void DemoDynamicQueue()
        {
            DynamicQueue queue = new DynamicQueue();
            Console.WriteLine("Enquing: " + hs.ToString());
            queue.Enqueue(hs);
            Console.WriteLine("Enquing: " + am.ToString());
            queue.Enqueue(am);
            Console.WriteLine("Enquing: " + mh.ToString());
            queue.Enqueue(mh);
            Console.WriteLine("Enquing: " + sk.ToString());
            queue.Enqueue(sk);
            Console.WriteLine("The earliest element is: " + queue.Peek().ToString());
            DataItem dequeued = queue.Dequeue();
            Console.WriteLine("Dequeued: " + dequeued.ToString());
            Console.WriteLine("The earliest element is: " + queue.Peek().ToString());
            dequeued = queue.Dequeue();
            Console.WriteLine("Dequeued: " + dequeued.ToString());
            Console.WriteLine("The earliest element is: " + queue.Peek().ToString());
            dequeued = queue.Dequeue();
            Console.WriteLine("Dequeued: " + dequeued.ToString());
            Console.WriteLine("The earliest element is: " + queue.Peek().ToString());
            dequeued = queue.Dequeue();
            Console.WriteLine("Dequeued: " + dequeued.ToString());
            if (queue.Peek() == null)
            {
                Console.WriteLine("Queue is empty!");
            }

            Console.WriteLine();
        }

        private static void DemoEquationAnalyzer()
        {
            string[] equations = {
                "ab*(ac-bd)+[c+{3a(b+1)-d}]",
                "{a+[b-c])*(d+e)}",
                "{(x+y)*[a/(b-c)]}",
                "{[a/(b-c)]",
                "[{()}]"
            };
            foreach (string eq in equations)
            {
                Console.WriteLine("Is: " + eq + " balanced? " + EquationAnalyzer.AreParenthesisBalanced(eq));
            }
            Console.WriteLine();
        }
    }
}