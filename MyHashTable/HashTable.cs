using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyHashTable
{
    class HashTable<T> : ICollection<T>
    {
        private readonly List<T>[] items;
        private int modCount = 0;

        public HashTable(int size)
        {
            if (size < 1)
            {
                throw new ArgumentException("Размер не может быть меньше единицы.", nameof(size));
            }

            items = new List<T>[size];
        }

        public int Count { get; private set; }

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            int index = GetIndex(item);

            if (items[index] == null)
            {
                items[index] = new List<T>();
            }

            items[index].Add(item);

            Count++;

            modCount++;
        }

        public void Clear()
        {
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = null;
            }

            Count = 0;

            modCount++;
        }

        public bool Contains(T item)
        {
            int index = GetIndex(item);

            if (items[index] == null)
            {
                return false;
            }

            return items[index].Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), $"Свойство {nameof(array)} имеет значение null.");
            }

            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(arrayIndex), $"Значение параметра {nameof(arrayIndex)} меньше 0.");
            }

            if (array.Length - arrayIndex < Count)
            {
                throw new ArgumentException("Число элементов в исходной коллекции больше доступного места от положения, " +
                    $"заданного значением параметра {nameof(arrayIndex)}, до конца массива назначения {nameof(array)}.", nameof(array));
            }

            int index = arrayIndex;

            foreach (T item in this)
            {
                array[index] = item;

                index++;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            int oldModCount = modCount;

            foreach (List<T> row in items)
            {
                if (row == null)
                {
                    continue;
                }

                foreach (T tableItem in row)
                {
                    if (oldModCount != modCount)
                    {
                        throw new InvalidOperationException("Список был изменен.");
                    }

                    yield return tableItem;
                }
            }
        }

        public bool Remove(T item)
        {
            int index = GetIndex(item);

            if (items[index] == null)
            {
                return false;
            }

            if (items[index].Remove(item))
            {
                if (items[index].Count == 0)
                {
                    items[index] = null;
                }

                modCount++;

                return true;
            }

            return false;
        }

        private int GetIndex(T item)
        {
            return (item == null) ? 0 : Math.Abs(item.GetHashCode() % items.Length);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (List<T> row in items)
            {
                sb.Append("[ ");

                if (row == null)
                {
                    sb.Append(']')
                        .Append(Environment.NewLine);

                    continue;
                }

                foreach (T tableItem in row)
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
