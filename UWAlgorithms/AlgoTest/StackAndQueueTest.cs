using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTest
{
    [TestClass]
    public class StackAndQueueTest
    {
        [TestMethod]
        public void testRPC()
        {
        }

        public void ReversePolishCalculator()
        {
            var stack = new Stack<double>();
            while (true)
            {
                var input = Console.ReadLine().Trim();
                if (input == "+")
                {
                    stack.Push(stack.Pop() + stack.Pop());
                }
                else if (input == "*")
                {
                    stack.Push(stack.Pop() * stack.Pop());
                }
                else if (input == "//")
                {
                    stack.Push(stack.Pop() / stack.Pop());
                }
                else
                {
                    int result = int.Parse(input);
                    stack.Push(result);
                }
            }
        }

        [TestMethod]
        public void testStack()
        {
            var stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);

            var peek = stack.Peek();

            Assert.AreEqual(peek, 20);
            stack.Pop();
            Assert.AreEqual(10, stack.Peek());
        }

        [TestMethod]
        public void testQ()
        {
            var q = new Queue();
            q.Enqueue(10);

            var peek = q.Peek();

            Assert.AreEqual(peek, 10);
            q.Dequeue();
            Assert.AreEqual(-1, q.Peek());
        }

        public int removeMax(Stack<int> values)
        {
            var workQueue = new Queue<int>();
            var biggest = 0;

            for(int i = 0; i < values.Count; i++)
            {
                var num = values.Pop();

                if(num > biggest)
                {
                    biggest = num;
                }

                workQueue.Enqueue(num);
            }

            for (int x = 0; x < values.Count; x++)
            {

                var num = workQueue.Dequeue();

                if(num != biggest)
                {
                    values.Push(num);
                }
            }

            return biggest;
        }
    }

    public class Stack
    {
        public class Node
        {
            public int data;
            public Node next;

            public Node(int data = 0, Node next = null)
            {
                this.data = data;
                this.next = next;
            }
        }

        private Node head;
        private int size;
        public Stack()
        {
            head = null;
            size = 0;
        }

        public int Peek()
        {
            if(size == 0)
            {
                return -1;
            }
            else
            {
                return head.data;
            }
        }

        public void push(int value)
        {
            if(head == null)
            {
                head = new Node(value);
            }
            else
            {
                var temp = new Node(value);
                temp.next = head;
                head = temp;
            }

            size++;
        }

        public int pop()
        {
            if(size == 0)
            {
                return -1;
            }
            else
            {
                var temp = head;
                head = head.next;
                size--;
                return temp.data;
            }
        }
    }

    public class Queue
    {
        public class Node
        {
            public int data;
            public Node next;

            public Node(int data = 0, Node next = null)
            {
                this.data = data;
                this.next = next;
            }
        }

        private Node head;
        private Node tail;
        private int size;
        public Queue()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int Peek()
        {
            if (size == 0)
            {
                return -1;
            }
            else
            {
                return head.data;
            }
        }

        public void Enqueue(int value)
        {
            if (head == null)
            {
                head = new Node(value);
                tail = head;
            }
            else
            {
                var temp = new Node(value);
                tail.next = temp;
                tail = temp;
            }

            size++;
        }

        public int Dequeue()
        {
            if (size == 0)
            {
                return -1;
            }
            else
            {
                var temp = head;
                head = head.next;
                size--;

                if(head == null)
                {
                    tail = null;
                }

                return temp.data;                
            }
        }
    }
}
