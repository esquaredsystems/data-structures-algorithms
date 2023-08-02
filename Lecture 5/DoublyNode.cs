using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_5
{
    internal class DoublyNode
    {
        public DataItem item;
        public DoublyNode next;
        public DoublyNode previous;

        public bool HasNext() { return next != null; }
    }
}
