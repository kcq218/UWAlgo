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
    public class MinHeap<T>: Comparer<T>
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

            if(heap[index]. < above)
            {

            }
        }

        public override int Compare([AllowNull] T x, [AllowNull] T y)
        {
            if (x.CompareTo(y) > 0)
            {
                return x.Length.CompareTo(y.Length);
            }
            else if (x.Height.CompareTo(y.Height) != 0)
            {
                return x.Height.CompareTo(y.Height);
            }
            else if (x.Width.CompareTo(y.Width) != 0)
            {
                return x.Width.CompareTo(y.Width);
            }
            else
            {
                return 0;
            }
        }
    }
}
