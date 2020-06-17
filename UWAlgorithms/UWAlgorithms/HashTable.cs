
namespace UWAlgorithms
{
    using System;
    using System.Linq;

    public abstract class HashTableBase
    {
        protected int Size { get; set; }

        protected int Count { get; set; } = 0;

        public double LoadFactor => (double)Count / Size;

        public abstract void Add(string key, string value);

        public abstract void Delete(string key);

        public abstract string Lookup(string key);

        public int Hash(string key)
        {
            return key.ToCharArray().Sum(c => (int)c);
        }

        public int Index(int val)
        {
            return val % Size;
        }
    }

    public class ProbingHashTable : HashTableBase
    {

        string[,] hashBuckets;

        public ProbingHashTable()
        {
            Size = 10;
            Count = 0;
            hashBuckets = new string[Size, 2];

            for(int i = 0; i < Size; i ++)
            {
                hashBuckets[i,0] = null;
                hashBuckets[i,1] = null;
            }
        }

        public override void Add(string key, string value)
        {
            if (LoadFactor >= .75)
            {
                Size = Size * 2;
                Count = 0;

                var temp = hashBuckets;

                hashBuckets = new string[Size, 2];

                for (int i = 0; i < Size/2; i++)
                {
                    if (temp[i, 0] != null)
                    {
                        InsertHelper(temp[i, 0], temp[i, 1]);
                    }
                }

                InsertHelper(key, value);
            }
            else
            {
                InsertHelper(key, value);
            }
        }

        void InsertHelper(string key, string value)
        {
            var hashIndex = Hash(key) % Size;

            while (hashBuckets[hashIndex, 0] != null && hashBuckets[hashIndex, 0] != key)
            {
                hashIndex++;
                hashIndex = hashIndex % Size;
            }

            if (hashBuckets[hashIndex, 0] == null)
            {
                hashBuckets[hashIndex, 0] = key;
                hashBuckets[hashIndex, 1] = value;
                Count++;
            }
        }

        public override void Delete(string key)
        {
            var hashIndex = Hash(key) % Size;

            while (hashBuckets[hashIndex, 0] != null)
            {
                if (hashBuckets[hashIndex, 0] == key)
                {
                    hashBuckets[hashIndex, 0] = null;
                    hashBuckets[hashIndex, 1] = null;

                    Count--;
                }

                hashIndex++;
                hashIndex = hashIndex % Size;
            }
        }

        public override string Lookup(string key)
        {
            var hashIndex = Hash(key) % Size;

            while (hashBuckets[hashIndex, 0] != null)
            {
                if (hashBuckets[hashIndex, 0] == key)
                {
                    return hashBuckets[hashIndex, 1];
                }

                hashIndex++;
                hashIndex = hashIndex % Size;
            }

            return string.Empty;
        }
    }

    public class ChainingHashTable : UWAlgorithms.HashTableBase
    {
        LinkedList[] BucketsArray; 

        public ChainingHashTable()
        {
            Size = 10;
            Count = 0;
            BucketsArray = new LinkedList[10];
            
            for(int i = 0; i < BucketsArray.Length; i ++)
            {
                BucketsArray[i] = new LinkedList();
            }
        }

        public override void Add(string key, string value)
        {
            var hashIndex = 0;

            if (LoadFactor >= 1.5)
            {
                Size = Size * 2;
                Count = 0;

                var temp = BucketsArray;

                BucketsArray = new LinkedList[Size];
                
                for (int i = 0; i < BucketsArray.Length; i++)
                {
                    BucketsArray[i] = new LinkedList();
                }

                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i] != null)
                    {
                        var current = temp[i].head;

                        while (current != null)
                        {
                            hashIndex = Hash(current.Key) % Size;
                            BucketsArray[hashIndex].Add(current.Key, current.Value);
                            Count++;

                            current = current.Pointer;
                        }
                    }
                }

                hashIndex = Hash(key) % Size;

                BucketsArray[hashIndex].Add(key, value);
                Count++;
            }

            else
            {
                hashIndex = Hash(key) % Size;

                if (BucketsArray[hashIndex] == null)
                {
                    BucketsArray[hashIndex] = new LinkedList(key, value);
                    Count++;
                }

                else
                {
                    if (BucketsArray[hashIndex].Lookup(key) == string.Empty)
                    {
                        BucketsArray[hashIndex].Add(key, value);
                        Count++;
                    }
                }
            }
        }

        public override void Delete(string key)
        {
            var hashIndex = Hash(key) % Size;

            if (BucketsArray[hashIndex] == null)
            {
                return;
            }
            else
            {
                if (BucketsArray[hashIndex].Delete(key)) Count--;
            }
        }

        public override string Lookup(string key)
        {
            var hashIndex = Hash(key) % Size;

            if (BucketsArray[hashIndex] == null)
            {
                return string.Empty;
            }

            else
            {
                return BucketsArray[hashIndex].Lookup(key);
            }
        }
    }

    class LinkedList
    {

        public Node head;

        public class Node
        {
            public string Key { get; set; }
            public string Value { get; set; }
            public Node Pointer { get; set; }

            public Node(string key, string value)
            {
                Key = key;
                Value = value;
                Pointer = null;
            }
        }

        public LinkedList(string key, string value)
        {
            head.Key = key;
            head.Value = value;
            head.Pointer = null;
        }

        public LinkedList()
        {
            head = null;
        }

        public void Add(string key, string value)
        {
            var current = head;
            
            if (head == null)
            {
                head = new Node(key, value);
            }
            else
            {
                while (current.Pointer != null)
                {
                    current = current.Pointer;
                }

                current.Pointer = new Node(key, value);
            }
        }

        public string Lookup(string key)
        {
            var current = head;
           
            while(current != null)
            {
                if (current.Key == key)
                    return current.Value;

                current = current.Pointer;
            }

            return string.Empty;
        }

        public bool Delete(string key)
        {
            var current = head;
            Node prev = null;

            if(head != null && head.Key == key)
            { 
                head = current.Pointer;
                return true;
            }

            else
            {
                while(current != null)
                {
                    if(current.Key == key)
                    {
                        prev.Pointer = current.Pointer;
                        return true;
                    }

                    prev = current;
                    current = current.Pointer;
                }
            }

            return false;            
        }
    }
}
