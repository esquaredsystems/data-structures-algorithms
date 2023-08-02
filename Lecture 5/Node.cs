using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_5
{
    internal class Node
    {
        public DataItem item;
        public Node next;

        public bool HasNext() { return next != null; }
    }
}
