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

        public List<int> MergeSortedList(List<int> listToBeMerged, List<int> ListToBeMerged2)
        {
            var mergedList = new List<int>();

            foreach(var num in listToBeMerged)
            {
                mergedList.Add(num);
            }

            foreach(var num in ListToBeMerged2)
            {
                mergedList.Add(num);
            }

            return bubbleSort(mergedList);
        }

        private List<int> bubbleSort(List<int> inputLiist)
        {
            var isSorted = false;
            var track = false;

            while(isSorted == false)
            {
                for(int i = 0; i < inputLiist.Count - 1; i++)
                {
                    if(inputLiist[i] > inputLiist[i + 1])
                    {
                        var temp = inputLiist[i + 1];
                        inputLiist[i + 1] = inputLiist[i];
                        inputLiist[i] = temp;
                        track = true;            
                    }
                }

                if(track == false)
                {
                    isSorted = true;
                }
            }

            return inputLiist;
        }

    }
}
