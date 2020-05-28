using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace UWAlgorithms
{
    public class BinarySearchTree
    {
        public class Node
        {
            public Node left;
            public Node right;
            public int value;
            
            public Node(int value)
            {
                this.value = value;
                left = null;
                right = null;
            }
        }

        Node root;

        // 1) Write a function that takes in a list of integers, creates a binary tree with those integers
        public BinarySearchTree(List<int> values)
        {
            root = null;
            values.Sort();

            foreach(int num in values)
            {
                insert(num);
            }

        }

        public void insert(int value)
        {
            root = InsertRecursively(value, root);
        }

        public Node InsertRecursively(int value, Node root)
        {
            if (root == null)
            {
                root = new Node(value);
                return root;
            }

            else if (value >= root.value)
            {
                root.right = InsertRecursively(value, root.right);
            }

            else
            {
                root.left = InsertRecursively(value, root.left);
            }

            return root;
        }

        // 2) Write a function that returns the in-order traversal of the tree as space-separated string.
        public string InOrder()
        {
            var sb = new StringBuilder();

            RecursiveInOrder(root, sb);

            return sb.ToString().Trim();
        }

        public void RecursiveInOrder(Node root, StringBuilder sb)
        {
            if (root != null)
            {
                RecursiveInOrder(root.left, sb);
                sb.Append(" " + root.value);
                RecursiveInOrder(root.right, sb);
            }
        }

        // 3) Write a function that returns the pre-order traversal of the tree as space-separated string.
        public string PreOrder()
        {
            var sb = new StringBuilder();

            RecursivePreOrder(root, sb);

            return sb.ToString().Trim();
        }

        public void RecursivePreOrder(Node root, StringBuilder sb)
        {
            if (root != null)
            {
                sb.Append(" " + root.value);
                RecursivePreOrder(root.left, sb);
                RecursivePreOrder(root.right, sb);
            }
        }

        // 4) Write a function that returns the post-order traversal of the tree as space-separated string.
        public string PostOrder()
        {
            var sb = new StringBuilder();

            RecursivePostOrder(root, sb);

            return sb.ToString().Trim();
        }

        public void RecursivePostOrder(Node root, StringBuilder sb)
        {

            if (root != null)
            {
                RecursivePostOrder(root.left, sb);
                RecursivePostOrder(root.right, sb);
                sb.Append(" " + root.value);
            }

        }

        // 5) Write a function that determines the height of a given tree.
        public int Height => BinaryTreeHeight(root);

        private int BinaryTreeHeight(Node root)
        {
            if(root == null)
            {
                return 0;
            }

            return 1 + Math.Max(BinaryTreeHeight(root.left), BinaryTreeHeight(root.right));
        }

        // 6) Write a function that returns the sum of all values in a tree.
        public int Sum()
        {
            return sumBinaryTree(root);
        }

        private int sumBinaryTree(Node root)
        {

            if(root == null)
            {
                return 0;
            }

            return root.value + sumBinaryTree(root.left) + sumBinaryTree(root.right);
        }

        // 7) Write a function that returns a bool indicating that a value exists (or not) in a given tree.
        public bool Contains(int value)
        {
            return ContainsValue(value, root);
        }

        private bool ContainsValue(int value, Node root)
        {
            if (root == null) return false;
            if (root.value == value) return true;
            if (root.value > value) return ContainsValue(value,root.left);
            return ContainsValue(value,root.right);
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            var mode = Console.ReadLine();
            var input = Console.ReadLine();
            var values = input.Split(new[] { ' ' }).Select(Int32.Parse).ToList();
            var tree = new BinarySearchTree(values);
            switch (mode)
            {
                case "in_order":
                    Console.WriteLine(tree.InOrder());
                    break;
                case "pre_order":
                    Console.WriteLine(tree.PreOrder());
                    break;
                case "post_order":
                    Console.WriteLine(tree.PostOrder());
                    break;
                case "height":
                    Console.WriteLine(tree.Height);
                    break;
                case "sum":
                    Console.WriteLine(tree.Sum());
                    break;
                case "contains":
                    int value = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(tree.Contains(value));
                    break;
            }
        }
}
