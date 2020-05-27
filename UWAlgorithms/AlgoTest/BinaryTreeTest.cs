namespace AlgoTest
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BinaryTreeTest
    {
        public int BinaryTreeOperations()
        {
            var headNode = CreateMyTree();
            return 0;
        }

        private int ComputeTreeHeight(TreeNode head)
        {
            if(head == null)
            {
                return 0;
            }

            return 1 +  Math.Max(ComputeTreeHeight(head.rightNode), ComputeTreeHeight(head.rightNode));
        }

        private void InorderTraversal(TreeNode root)
        {
            if(root == null)
            {
                return;
            }

            InorderTraversal(root.leftNode);
            Console.WriteLine(root.value);
            InorderTraversal(root.rightNode);
        }

        private void PreOrderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine(root.value);
            PreOrderTraversal(root.leftNode);
            PreOrderTraversal(root.rightNode);
        }

        private void PostOrderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            PostOrderTraversal(root.leftNode);
            PostOrderTraversal(root.rightNode);
            Console.WriteLine(root.value);
        }

        private int getNumberOfNodes(TreeNode root)
        {
            if(root == null)
            {
                return 0;
            }

            if (root.leftNode == null && root.rightNode == null)
            {
                return 1;
            }

            return (getNumberOfNodes(root.leftNode) + getNumberOfNodes(root.rightNode));
        }

        private TreeNode CreateMyTree()
        {
            var intList = new List<int>();

            var head = new TreeNode(intList);

            // left subtree
            head.leftNode.value = 7;
            head.leftNode.leftNode.value = 11;
            head.leftNode.rightNode.value = 22;
            head.leftNode.leftNode.value = 11;
            head.leftNode.leftNode.leftNode.value = 52;

            // right subtree
            head.rightNode.value = 4;
            head.rightNode.leftNode.value = 1;
            head.rightNode.rightNode.value = 8;

            return new TreeNode();
        }

        internal class TreeNode
        {
            public int value;
            public TreeNode leftNode;
            public TreeNode rightNode;

            public TreeNode()
            {
                value = 0;
                leftNode = null;
                rightNode = null;
            }

            public TreeNode(List<int> value)
            {
                value = value;
                leftNode = null;
                rightNode = null;
            }
        }
    }
}
