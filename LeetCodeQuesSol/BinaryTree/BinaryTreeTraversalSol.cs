using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.BinaryTree
{
    public class BinaryTreeTraversalSol
    {
        /// <summary>
        /// Problem link: https://leetcode.com/problems/binary-tree-preorder-traversal/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        //NLR
        public IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> result = [];
            if (root == null) return result;
            Stack<TreeNode> temp = new();

            temp.Push(root);

            while(temp.TryPeek(out TreeNode? _))
            {
                var node = temp.Pop();
                result.Add(node.val);

                if(node.right != null)
                {
                    temp.Push(node.right);
                }
                if(node.left != null)
                {
                    temp.Push(node.left);
                }
            }

            return result;
        }

        /// <summary>
        /// Problem link: https://leetcode.com/problems/binary-tree-inorder-traversal/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        //LNR
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> result = [];
            if (root == null) return result;
            Stack<TreeNode> temp = new();

            var current = root;

            while(current != null || temp.TryPeek(out var _))
            {
                while(current != null)
                {
                    temp.Push(current);
                    current = current.left;
                }

                current = temp.Pop();
                result.Add(current.val);

                current = current.right;
            }

            return result;
        }

        /// <summary>
        /// Problem link: https://leetcode.com/problems/binary-tree-postorder-traversal/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        //LRN
        public IList<int> PostorderTraversal(TreeNode root)
        {
            IList<int> result = [];
            if (root == null) return result;
            Stack<TreeNode> temp = new();

            var current = root;
            TreeNode? lastVisisted = null;

            while (current != null || temp.TryPeek(out var _))
            {
                while (current != null)
                {
                    temp.Push(current);
                    current = current.left;
                }

                temp.TryPeek(out var top);

                if(top?.right != null && lastVisisted != top.right)
                {
                    current = top.right;
                }
                else
                {
                    lastVisisted = temp.Pop();
                    result.Add(lastVisisted.val);
                }
            }

            return result;

        }

        /// <summary>
        /// Problem link: https://leetcode.com/problems/binary-tree-level-order-traversal/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> result = [];

            if (root == null) return result;

            Queue<TreeNode> qu = new();

            qu.Enqueue(root);

            while(qu.Count > 0)
            {
                int levelSize = qu.Count;

                IList<int> tempResult = [];

                for(int i=0; i<levelSize; i++)
                {
                    var node = qu.Dequeue();
                    tempResult.Add(node.val);

                    if(node.left != null)
                    {
                        qu.Enqueue(node.left);

                    }
                    if (node.right != null)
                    {
                        qu.Enqueue(node.right);

                    }
                }

                result.Add(tempResult);
            }

            return result;
        }
    }
}
