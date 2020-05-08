using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            while(current.next != null)
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


    }
}
