using System.Collections.Generic;

namespace UWAlgorithms
{
    // attempt 2 at Hashmaps

    class LinearProbing
    {
        //have buckets
        public LinearProbing(int capacity)
        {

        }
    }

    public class HashMap<K, V>
    {
        private int size;
        private int capacity;
        private List<HashBucket<K,V>> buckets;
        public HashMap(int capacity)
        {
            this.capacity = capacity;
            size = 0;

            buckets = new List<HashBucket<K,V>>();

            for (int i = 0; i < capacity; i++)
            {
                buckets.Add(null);
            }
        }

        // so index = k.getHashCode % capacity
        // if( hahsBucket(index)[K] = K
        // update value
        // while hashbucket[index] not null
        // if key is the same update value
        // or else index++ and rehash
        // if hashbuckets[index] == null
        // create new hashbucket with key and value
        // take care of loadfactor.

        public void add(K key,V Value)
        {
            if (size / capacity >= .75)
            {
                var tempbuckets = buckets;

                capacity = capacity * 2;
                buckets = new List<HashBucket<K, V>>();

                for (int i = 0; i < capacity; i++)
                {
                    buckets[i] = null;
                }

                foreach (var item in tempbuckets)
                {
                    if(item != null)
                    {
                        AddHelper(item.key, item.value);
                    }
                }
            }
            else
            {
                AddHelper(key, Value);
            }
        }

        void AddHelper(K key, V Value)
        {
            var index = key.GetHashCode() % capacity;

            while (buckets[index] != null)
            {
                if (buckets[index].key.Equals(key))
                {
                    buckets[index].value = Value;

                    return;
                }
                else
                {
                    index++;
                    index = key.GetHashCode() % capacity;
                }
            }

            buckets[index] = new HashBucket<K, V>(key, Value);
            size++;
        }
        public HashBucket<K,V> Get(K Key)
        {
            foreach (var bucket in buckets)
            {
                if(bucket != null)
                {
                    if(bucket.key.Equals(Key))
                    {
                        return bucket;
                    }
                }    
            }

            return null;
        }

        public bool Exist(K key)
        {
            return Get(key) != null;
        }

        public void Remove(K key)
        {
            for (int i = 0; i < capacity; i++)
            {
                if(buckets[i] != null && buckets[i].key.Equals(key))
                {
                    buckets[i] = null;
                }
            }
        }
    }

    public class HashBucket<K,V>
    {
        public K key;
        public V value;

        public HashBucket(K Key, V Value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
