using System;
using System.Collections.Generic;

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

        }

        public void insert(int value)
        {
            root = InsertRecursively(value, root);
        }

        public Node InsertRecursively(int value, Node root)
        {
            if (root == null)
            {
                return new Node(value);
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
            return "";
        }

        // 3) Write a function that returns the pre-order traversal of the tree as space-separated string.
        public string PreOrder()
        {
            return "";
        }

        // 4) Write a function that returns the post-order traversal of the tree as space-separated string.
        public string PostOrder()
        {
            return "";
        }

        // 5) Write a function that determines the height of a given tree.
        public int Height => 0;

        // 6) Write a function that returns the sum of all values in a tree.
        public int Sum()
        {
            return 0;
        }

        // 7) Write a function that returns a bool indicating that a value exists (or not) in a given tree.
        public bool Contains(int value)
        {
            return false;
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
