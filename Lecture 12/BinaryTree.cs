using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_12
{
    internal class BinaryTree
    {
        public TreeNode root;

        /// <summary>
        /// Inserts a DataItem object to the first available place
        /// </summary>
        /// <param name="root"></param>
        /// <param name="item"></param>
        public TreeNode InsertFast(TreeNode root, DataItem item)
        {
            if (root == null)
            {
                root = new TreeNode(item);
            }
            else
            {
                if (root.left == null) 
                {
                    root.left = new TreeNode(item);
                }
                else if (root.right == null)
                {
                    root.right = new TreeNode(item);
                }
                else
                {
                    InsertFast(root.left, item);
                }
            }
            return root;
        }

        /// <summary>
        /// Inserts a DataItem object while respecting tree completeness
        /// </summary>
        /// <param name="root"></param>
        /// <param name="item"></param>
        public TreeNode InsertComplete(TreeNode root, DataItem item)
        {
            if (root == null)
            {
                root = new TreeNode(item);
            }
            else
            {
                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(root);
                while (queue.Count > 0)
                {
                    TreeNode current = queue.Dequeue();
                    if (current.left == null)
                    {
                        current.left = new TreeNode(item);
                        return root;
                    }
                    else
                    {
                        queue.Enqueue(current.left);
                    }
                    if (current.right == null)
                    {
                        current.right = new TreeNode(item);
                        return root;
                    }
                    else
                    {
                        queue.Enqueue(current.right);
                    }
                }
            }
            return root;
        }

        public TreeNode InsertOrdered(TreeNode root, DataItem item)
        {
            if (root == null)
            {
                root = new TreeNode();
                root.item = item;
                return root;
            }
            TreeNode node = root;
            TreeNode parent = root;
            bool left = false;
            while (node != null)
            {
                parent = node;
                // If item < root root then go left, otherwise go right
                if (node.item.CompareTo(item) < 0)
                {
                    left = true;
                    node = node.left;
                }
                else
                {
                    left = false;
                    node = node.right;
                }
            }
            node = new TreeNode();
            node.item = item;
            if (left)
            {
                parent.left = node;
            }
            else
            {
                parent.right = node;
            }
            return root;
        }

        /// <summary>
        /// In order traversal, starting from the root passed on
        /// </summary>
        /// <param name="root"></param>
        public void TraverseInorder(TreeNode root)
        {
            if (root != null)
            {
                TraverseInorder(root.left);
                Console.WriteLine(root.item.getStudentId());
                TraverseInorder(root.right);
            }
        }

        /// <summary>
        /// Pre-order traversal, starting from the root passed on
        /// </summary>
        /// <param name="root"></param>
        public void TraversePreorder(TreeNode root)
        {
            if (root != null)
            {
                Console.WriteLine(root.item.getStudentId());
                TraversePreorder(root.left);
                TraversePreorder(root.right);
            }
        }

        /// <summary>
        /// Post-order traversal, starting from the root passed on
        /// </summary>
        /// <param name="root"></param>
        public void TraversePostorder(TreeNode root)
        {
            if (root != null)
            {
                TraversePostorder(root.left);
                TraversePostorder(root.right);
                Console.WriteLine(root.item.getStudentId());
            }
        }

        public int GetHeight(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int leftDepth = GetHeight(root.left);
            int rightDepth = GetHeight(root.right);
            return 1 + (leftDepth > rightDepth ? leftDepth: rightDepth);
        }

        public TreeNode DeleteLeaf(TreeNode root, DataItem item)
        {
            if (root == null)
            {
                return null;
            }
            TreeNode left = root.left;
            TreeNode right = root.right;
            bool isParent = false;
            // If left child's item matches and it's a leaf, then remove from parent
            if (left != null && left.item.Equals(item))
            {
                if (left.left == null && left.right == null)
                {
                    root.left = null;
                    Console.WriteLine($"{item.getStudentId()} deleted.");
                    return root;
                }
                else
                {
                    isParent = true;
                }
            }
            // If right child's item matches and it's a leaf, then remove from parent
            if (right != null && right.item.Equals(item))
            {
                if (right.left == null && right.right == null)
                {
                    root.right = null;
                    Console.WriteLine($"{item.getStudentId()} deleted.");
                    return root;
                }
                else
                {
                    isParent = true;
                }
            }
            if (isParent)
            {
                Console.WriteLine($"{item.getStudentId()} is a parent node. Not deleting.");
            }
            else
            {
                // Recursively delete from left and right sub-trees
                DeleteLeaf(left, item);
                DeleteLeaf(right, item);
            }
            return root;
        }

        /// <summary>
        /// Search for a Node using BFS
        /// </summary>
        /// <param name="root"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public TreeNode BreadthFirstSearch(TreeNode root, DataItem item)
        {
            TreeNode node = root;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                node = queue.Dequeue();
                //Console.WriteLine($"Dequeued {node.item.getStudentId()}");
                if (node.item.Equals(item))
                {
                    return node;
                }
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
            return null;
        }

        /// <summary>
        /// Search for a Node using DFS
        /// </summary>
        /// <param name="root"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public TreeNode DepthFirstSearch(TreeNode root, DataItem item)
        {
            if (root == null)
            {
                return null;
            }
            if (root.item.Equals (item))
            {
                return root;
            }
            TreeNode found = DepthFirstSearch(root.left, item);
            if (found == null)
            {
                found = DepthFirstSearch(root.right, item);
            }
            return found;
        }

        public void Delete(TreeNode root, DataItem item)
        {
            // Find the target node in tree using any traversing method
            
            // If the target node was not found, then return
            
            // Find the deepest rightmost node

            // Swap the target node with the deepest rightmost node
            
            // Finally, delete the target node (you can reuse DeleteLeaf here)
        }

    }
}
