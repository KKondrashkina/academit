using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyHashTable
{
    class HashTable<T> : ICollection<T>
    {
        private List<T>[] items;

        public HashTable(int size)
        {
            items = new List<T>[size];
        }

        public int Count { get; private set; }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(T item)
        {
            int index = Math.Abs(item.GetHashCode() % items.Length);

            if (items[index] == null)
            {
                items[index] = new List<T>();
            }

            items[index].Add(item);

            Count++;
        }

        public void Clear()
        {
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = null;
            }

            Count = 0;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null)
                {
                    continue;
                }

                foreach (T tableItem in items[i])
                {
                    if (tableItem.Equals(item))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array.Length - arrayIndex < Count)
            {
                throw new ArgumentException("Размер массива слишком мал.", nameof(array));
            }

            int index = 0;

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null)
                {
                    continue;
                }

                for (int j = 0; j < items[i].Count; j++)
                {
                    array[arrayIndex + index] = items[i][j];

                    index++;
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null)
                {
                    continue;
                }

                foreach (T tableItem in items[i])
                {
                    yield return tableItem;
                }
            }
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null)
                {
                    continue;
                }

                if (items[i].Remove(item))
                {
                    if (items[i].Count == 0)
                    {
                        items[i] = null;
                    }

                    return true;
                }
            }

            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < items.Length; i++)
            {
                sb.Append("[ ");

                if (items[i] == null)
                {
                    sb.Append(']')
                        .Append(Environment.NewLine);

                    continue;
                }

                foreach (T tableItem in items[i])
                {
                    sb.Append(tableItem)
                        .Append(", ");
                }

                sb.Remove(sb.Length - 2, 1)
                    .Append(']')
                        .Append(Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}
