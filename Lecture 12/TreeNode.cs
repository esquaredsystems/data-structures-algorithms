using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lecture_12
{
    internal class TreeNode
    {
        public DataItem item;
        public TreeNode left;
        public TreeNode right;

        public TreeNode() { }

        public TreeNode(DataItem item)
        {
            this.item = item;
        }

        public bool HasLeft() { return left != null; }
        public bool HasRight() { return right != null; }
    }
}
