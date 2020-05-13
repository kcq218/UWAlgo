using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace UWAlgorithms
{
    // 
    public class LinkedList
    {
        private Node head;
        private int length;
        public LinkedList()
        {
            head.value = 0;
            head.next = null;
            length = 1;
        }


        public void add(int input)
        {
            var current = head;
            while (current.next != null)
            {
                current = current.next;
            }

            current.next = new Node();
            current.next.value = input;
            length++;
        }

        public int Length()
        {
            return length;
        }


        internal class Node
        {
            public int value;
            public Node next;
            int size = 0;
            public Node()
            {
                this.value = 0;
                this.next = null;
            }

            public static implicit operator LinkedListNode<object>(Node v)
            {
                throw new NotImplementedException();
            }
        }

        public void ReversePrint(LinkedList<int> inputLinkedList)
        {
            var stack = new Stack<int>();
            var current = inputLinkedList.First;
            stack.Push(current.Value);

            while(current.Next != null)
            {
                current = current.Next;

                stack.Push(current.Value);
            }

            while(stack.Count != 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }

        public List<int> MergeSortedList(List<int> list1, List<int> list2)
        {
            var mergedList = new List<int>();

            foreach(var num in list1)
            {
                mergedList.Add(num);
            }

            foreach(var num in list2)
            {
                mergedList.Add(num);
            }

            return bubbleSort(mergedList);
        }

        /**
         * Initialize pointer
         * previous pointer, and current pointer, next pointer
         * while curr is not null
         * save next pointer
         * reverse point current to previous
         * previous node becomes current
         * current becomes node we saved
         * prev will point to head at end
         * **/
        public void reverse(LinkedList<int> inputList)
        {
            Node prev = null;
            var current = inputList.First;

            while(current.Next != null)
            {
                var next = current.Next;

                current.Next = prev;

                prev = current;

                current = next;
            }
        }

        private List<int> bubbleSort(List<int> inputList)
        {
            var isSorted = false;
            var track = false;

            while(isSorted == false)
            {
                for(int i = 0; i < inputList.Count - 1; i++)
                {
                    if(inputList[i] > inputList[i + 1])
                    {
                        var temp = inputList[i + 1];
                        inputList[i + 1] = inputList[i];
                        inputList[i] = temp;
                        track = true;            
                    }
                }

                if(track == false)
                {
                    isSorted = true;
                }
            }

            return inputList;
        }

    }
}
