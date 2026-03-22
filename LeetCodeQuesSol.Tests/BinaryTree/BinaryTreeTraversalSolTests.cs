using System.Collections.Generic;
using Xunit;
using LeetCodeQuesSol.BinaryTree;

namespace LeetCodeQuesSol.Tests.BinaryTree
{
    public class BinaryTreeTraversalSolTests        
    {
        private TreeNode Node(int val, TreeNode left = null, TreeNode right = null) => new TreeNode(val, left, right);

        [Fact]
        public void PreorderTraversal_EmptyTree_ReturnsEmptyList()
        {
            var sol = new BinaryTreeTraversalSol();
            var result = sol.PreorderTraversal(null);
            Assert.Empty(result);
        }

        [Fact]
        public void PreorderTraversal_SingleNode_ReturnsRoot()
        {
            var sol = new BinaryTreeTraversalSol();
            var root = Node(1);
            var result = sol.PreorderTraversal(root);
            Assert.Equal(new List<int> { 1 }, result);
        }

        [Fact]
        public void PreorderTraversal_LeftSkewedTree()
        {
            var sol = new BinaryTreeTraversalSol();
            var root = Node(1, Node(2, Node(3)));
            var result = sol.PreorderTraversal(root);
            Assert.Equal(new List<int> { 1, 2, 3 }, result);
        }

        [Fact]
        public void PreorderTraversal_RightSkewedTree()
        {
            var sol = new BinaryTreeTraversalSol();
            var root = Node(1, null, Node(2, null, Node(3)));
            var result = sol.PreorderTraversal(root);
            Assert.Equal(new List<int> { 1, 2, 3 }, result);
        }

        [Fact]
        public void PreorderTraversal_BalancedTree()
        {
            var sol = new BinaryTreeTraversalSol();
            var root = Node(1, Node(2), Node(3));
            var result = sol.PreorderTraversal(root);
            Assert.Equal(new List<int> { 1, 2, 3 }, result);
        }

        [Fact]
        public void InorderTraversal_EmptyTree_ReturnsEmptyList()
        {
            var sol = new BinaryTreeTraversalSol();
            var result = sol.InorderTraversal(null);
            Assert.Empty(result);
        }

        [Fact]
        public void InorderTraversal_SingleNode_ReturnsRoot()
        {
            var sol = new BinaryTreeTraversalSol();
            var root = Node(1);
            var result = sol.InorderTraversal(root);
            Assert.Equal(new List<int> { 1 }, result);
        }

        [Fact]
        public void InorderTraversal_LeftSkewedTree()
        {
            var sol = new BinaryTreeTraversalSol();
            var root = Node(1, Node(2, Node(3)));
            var result = sol.InorderTraversal(root);
            Assert.Equal(new List<int> { 3, 2, 1 }, result);
        }

        [Fact]
        public void InorderTraversal_RightSkewedTree()
        {
            var sol = new BinaryTreeTraversalSol();
            var root = Node(1, null, Node(2, null, Node(3)));
            var result = sol.InorderTraversal(root);
            Assert.Equal(new List<int> { 1, 2, 3 }, result);
        }

        [Fact]
        public void InorderTraversal_BalancedTree()
        {
            var sol = new BinaryTreeTraversalSol();
            var root = Node(2, Node(1), Node(3));
            var result = sol.InorderTraversal(root);
            Assert.Equal(new List<int> { 1, 2, 3 }, result);
        }

        [Fact]
        public void PostorderTraversal_EmptyTree_ReturnsEmptyList()
        {
            var sol = new BinaryTreeTraversalSol();
            var result = sol.PostorderTraversal(null);
            Assert.Empty(result);
        }

        [Fact]
        public void PostorderTraversal_SingleNode_ReturnsRoot()
        {
            var sol = new BinaryTreeTraversalSol();
            var root = Node(1);
            var result = sol.PostorderTraversal(root);
            Assert.Equal(new List<int> { 1 }, result);
        }

        [Fact]
        public void PostorderTraversal_LeftSkewedTree()
        {
            var sol = new BinaryTreeTraversalSol();
            var root = Node(1, Node(2, Node(3)));
            var result = sol.PostorderTraversal(root);
            Assert.Equal(new List<int> { 3, 2, 1 }, result);
        }

        [Fact]
        public void PostorderTraversal_RightSkewedTree()
        {
            var sol = new BinaryTreeTraversalSol();
            var root = Node(1, null, Node(2, null, Node(3)));
            var result = sol.PostorderTraversal(root);
            Assert.Equal(new List<int> { 3, 2, 1 }, result);
        }

        [Fact]
        public void PostorderTraversal_BalancedTree()
        {
            var sol = new BinaryTreeTraversalSol();
            var root = Node(2, Node(1), Node(3));
            var result = sol.PostorderTraversal(root);
            Assert.Equal(new List<int> { 1, 3, 2 }, result);
        }
        
        [Fact]
        public void LevelOrder_EmptyTree_ReturnsEmptyList()
        {
            var sol = new BinaryTreeTraversalSol();
            var result = sol.LevelOrder(null);
            Assert.Empty(result);
        }

        [Fact]
        public void LevelOrder_SingleNode_ReturnsRoot()
        {
            var sol = new BinaryTreeTraversalSol();
            var root = Node(1);
            var result = sol.LevelOrder(root);
            Assert.Equal(new List<IList<int>> { new List<int> { 1 } }, result);
        }

        [Fact]
        public void LevelOrder_LeftSkewedTree()
        {
            var sol = new BinaryTreeTraversalSol();
            var root = Node(1, Node(2, Node(3)));
            var result = sol.LevelOrder(root);
            Assert.Equal(new List<IList<int>> {
                new List<int> { 1 },
                new List<int> { 2 },
                new List<int> { 3 }
            }, result);
        }

        [Fact]
        public void LevelOrder_RightSkewedTree()
        {
            var sol = new BinaryTreeTraversalSol();
            var root = Node(1, null, Node(2, null, Node(3)));
            var result = sol.LevelOrder(root);
            Assert.Equal(new List<IList<int>> {
                new List<int> { 1 },
                new List<int> { 2 },
                new List<int> { 3 }
            }, result);
        }

        [Fact]
        public void LevelOrder_BalancedTree()
        {
            var sol = new BinaryTreeTraversalSol();
            var root = Node(2, Node(1), Node(3));
            var result = sol.LevelOrder(root);
            Assert.Equal(new List<IList<int>> {
                new List<int> { 2 },
                new List<int> { 1, 3 }
            }, result);
        }

        [Fact]
        public void LevelOrder_MultiLevelTree()
        {
            var sol = new BinaryTreeTraversalSol();
            var root = Node(1, Node(2, Node(4), Node(5)), Node(3));
            var result = sol.LevelOrder(root);
            Assert.Equal(new List<IList<int>> {
                new List<int> { 1 },
                new List<int> { 2, 3 },
                new List<int> { 4, 5 }
            }, result);
        }
    }
}
