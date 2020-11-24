using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace UWAlgorithms
{
    // array
    // start at zero
    // index * 2 to get left index
    // index + 1 to get right index.
    // index/2 to get parent index. 
    // heapifydown
    // heapifyup
    // add 
    // extract
    // peek
    public class MinHeap<T> where T : IComparable
    { 
        private T[] heap;
        private int size;

        public MinHeap(int capacity)
        {
            heap = new T[capacity + 1];
            size = 0;
        }

        public T Peak()
        {
           return heap[1];
        }

        public void Add(T value)
        {
            heap[size++] = value;
            HeapifyUp(size);
        }

        private void HeapifyUp(int index)
        {
           if(index <= 1)
           {
                return;
           }

            var above = heap[index / 2];

            if(heap[index].CompareTo(above) >= 0)
            {

            }
        }
    }
}
