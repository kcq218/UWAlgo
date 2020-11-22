using System;

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
    public class MinHeap<T>
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
            HeapifyUp(size, value);
        }

        private void HeapifyUp(int index, T value)
        {
           if(index == 0)
           {
                return;
           }

            var above = heap[index / 2];

            if(value )
        }
    }
}
