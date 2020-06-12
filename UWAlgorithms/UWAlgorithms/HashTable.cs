using System;
using System.Collections.Generic;
using System.Text;

namespace UWAlgorithms
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Runtime.CompilerServices;

    abstract class HashTableBase
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

    class ProbingHashTable : HashTableBase
    {

        public override void Add(string key, string value)
        {
            
            throw new NotImplementedException();
        }

        public override void Delete(string key)
        {
            throw new NotImplementedException();
        }

        public override string Lookup(string key)
        {
            throw new NotImplementedException();
        }
    }

    class ChainingHashTable : HashTableBase
    {
        string[,] hashBuckets;

        public ChainingHashTable()
        {
            Size = 10;
            hashBuckets = new string[Size, 2];
        }

        // check size of table
        // if over.75 rehash and get a bigger table
        // hash key to get index.
        // go to index
        // check if index is occupied if it is move to next avai
        public override void Add(string key, string value)
        {
            if(LoadFactor > (3/4))
            {

            }
            
            var hashIndex = Hash(key) % Size;
            
            while(hashBuckets[hashIndex,0] != null && hashBuckets[hashIndex,0] != key)
            {
                hashIndex++;
                hashIndex = hashIndex % Size;
            }

            if(hashBuckets[hashIndex,0] == null )
            {
                hashBuckets[hashIndex,0] = key;
                hashBuckets[hashIndex,1] = value;
                Count++;
            }            
        }

        public override void Delete(string key)
        {
            throw new NotImplementedException();
        }

        public override string Lookup(string key)
        {
            throw new NotImplementedException();
        }
    }

    class LinkedList
    {
        public class Node
        {
            public string Key { get; set; }
            public string Value { get; set; }
            public Node Pointer { get; set; }

            public Node(string key, string value)
            {
                Key = key;
                Value = value;
            }
        }

        public void Add(string key, string value)
        {
            throw new NotImplementedException();
        }

        public string Lookup(string key)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string key)
        {
            throw new NotImplementedException();
        }
    }
}
