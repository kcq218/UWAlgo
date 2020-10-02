using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTest
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void AddToBeginning()
        {
            var list = new LinkedList();
            list.AddToFirst(0);
            list.AddToFirst(2);

            Assert.AreEqual(2, list.Get(0));
        }

        [TestMethod]
        public void AddToEnd()
        {
            var list = new LinkedList();
            list.AddToEnd(0);
            list.AddToEnd(2);

            Assert.AreEqual(2, list.Get(1));
        }

        [TestMethod]
        public void Remove()
        {
            var list = new LinkedList();
            list.AddToEnd(0);
            list.AddToEnd(2);
            var result = list.Remove(1);

            Assert.AreEqual(result, 2);
            Assert.AreEqual(0, list.Get(0));
        }
    }

    internal class LinkedList
    {
        public class Node
        {
            public int value;
            public Node next;

            public Node(int value = 0, Node next = null)
            {
                this.value = value;
                this.next = next;
            }
        }

        private Node head;
        private Node tail;
        private int size;

        public LinkedList()
        {
            head = null;
            size = 0;
        }

        internal void AddToFirst(int v)
        {
            if(head == null)
            {
                head = new Node(v);
                tail = head;
            }
            else
            {
                var temp = new Node(v, head);
                head = temp;
            }
            size++;
        }

        internal int Get(int v)
        {
            if(v > size)
            {
                return -1;
            }
            var temp = head;
            for(int i = 0; i < v; i++)
            {
                temp = temp.next;
            }

            return temp.value;
        }

        internal void AddToEnd(int v)
        {
            if (head == null)
            {
                head = new Node(v);
                tail = head;
            }
            else
            {
                var temp = new Node(v);
                tail.next = temp;
                tail = temp;
            }
            size++;
        }

        internal int Remove(int v)
        {
            if(v >= size)
            {
                return -1;
            }


            if(head == tail)
            {
                var num = head.value;
                head = null;
                tail = null;
                return num;
            }


            var temp = head;
            for (int i = 0; i < v - 1; i++)
            {
                temp = temp.next;
            }

            var num = temp.next.value;

            temp.next = temp.next.next;
            if(temp.next == null)
            {
                tail = temp;
            }

            return num;
        }
    }
}