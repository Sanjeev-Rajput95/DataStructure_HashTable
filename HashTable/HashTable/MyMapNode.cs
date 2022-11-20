using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class MyMapNode<K,V>
    {
        public readonly int size;
        public readonly LinkedList<KeyValue<K, V>>[] items;

        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }

        protected int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }

        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }

        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V> { Key = key, Value = value };
            linkedList.AddLast(item);
        }

        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            bool itemFound = false;
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                linkedList.Remove(foundItem);
                Console.WriteLine($"\n Removed : index {key} \n \n ");
            }
        }
        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }

        public void FreqOfWords(string[] arr, int arrLength)
        {
            bool[] visited = new bool[arrLength];
            for (int i = 0; i < arrLength; i++)
            {
                if (visited[i] == true)
                {
                    continue;
                }

                int count = 1;
                for (int j = i + 1; j < arrLength; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        visited[j] = true;
                        count++;
                    }
                }
                Console.WriteLine(arr[i] + " => repeated " + count + " times ");
            }
        }
    }

    public struct KeyValue<K, V>
    {
        public K Key { get; set; }
        public V Value { get; set; }
    }
}
