namespace AlgoTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Design.Serialization;
    using System.Net.Http.Headers;
    using System.Reflection.Metadata.Ecma335;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BinaryTreeTest
    {
        [TestMethod]
        public void testAddToTree()
        {
            var bt = new BinaryTree();

            bt.AddToTree(1);
            bt.AddToTree(0);
            bt.AddToTree(5);
            bt.AddToTree(3);

            Assert.AreEqual(bt.returnRoot().val, 1);
            Assert.AreEqual(bt.returnRoot().left.val, 0);
            Assert.AreEqual(bt.returnRoot().right.val, 5);
            Assert.AreEqual(bt.returnRoot().right.left.val, 3);
        }

        [TestMethod]
        public void testHeightOfTree()
        {
            var bt = new BinaryTree();

            bt.AddToTree(1);
            bt.AddToTree(0);
            bt.AddToTree(5);
            bt.AddToTree(3);

            Assert.AreEqual(bt.ReturnHeight(), 3);
        }

        [TestMethod]
        public void testContains()
        {
            var bt = new BinaryTree();

            bt.AddToTree(1);
            bt.AddToTree(0);
            bt.AddToTree(5);
            bt.AddToTree(3);

            Assert.AreEqual(true, bt.Contains(3));
            Assert.AreEqual(true, bt.Contains(1));
            Assert.AreEqual(true, bt.Contains(0));
            Assert.AreEqual(true, bt.Contains(5));
            Assert.AreEqual(false, bt.Contains(-1));
        }
    }

    public class Node
    {
        public int val;
        public Node left;
        public Node right;

        public Node(int val = 0, Node next = null, Node right = null)
        {
            this.val = val;
            this.left = next;
            this.right = right;
        }
    }

    public class BinaryTree
    {

        private Node root;

        public BinaryTree()
        {
            root = null;
        }

        public void AddToTree(int num)
        {
            if (root == null)
            {
                root = new Node(num);
            }
            else
            {
                root = btHelper(root, num);
            }
        }

        private Node btHelper(Node root, int num)
        {
            if(root == null)
            {
                root = new Node(num);
            }
            else if(num >= root.val)
            {
                root.right = btHelper(root.right, num);
            }
            else
            {
                root.left = btHelper(root.left, num);
            }

            return root;
        }

        public Node returnRoot()
        {
            return root;
        }

        internal int ReturnHeight()
        {
            if(root == null)
            {
                return 0;
            }
            
            return HeightHelper(root,0);
        }

        private int HeightHelper(Node root, int v)
        {
            if(root == null)
            {
                return v;
            }
            else
            {
                return Math.Max(HeightHelper(root.left, v + 1), HeightHelper(root.right, v + 1));
            }
        }

        public bool Contains(int v)
        {
            if(root == null)
            {
                return false;
            }

            return ContainsHelper(root, v);
        }

        private bool ContainsHelper(Node root, int v)
        {
            if(root == null)
            {
                return false;
            }
            else if(v > root.val)
            {
                return ContainsHelper(root.right, v);
            }
            else if(v < root.val)
            {
                return ContainsHelper(root.left, v);
            }
            else
            {
                return true;
            }
        }
    }
}
