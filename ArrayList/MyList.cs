using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArrayList
{
    class MyList<T> : IList<T>
    {
        private T[] items = new T[10];
        private int modCount = 0;

        public MyList()
        {
            Capacity = items.Length;
        }

        public MyList(int capacity)
        {
            Capacity = capacity;
            items = new T[capacity];
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException("Индекс выходит за границы списка.");
                }

                return items[index];
            }

            set
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException("Индекс выходит за границы списка.");
                }

                items[index] = value;

                modCount++;
            }
        }

        public int Capacity { get; set; }

        public int Count { get; private set; }

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            if (Count >= items.Length)
            {
                IncreaseCapacity();
            }

            items[Count] = item;

            Count++;

            modCount++;
        }

        public void Clear()
        {
            Count = 0;

            modCount++;
        }

        public bool Contains(T item)
        {
            if (IndexOf(item) == -1)
            {
                return false;
            }

            return true;
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
                throw new ArgumentException(nameof(array), "Число элементов в исходной коллекции больше доступного места от положения, " +
                    $"заданного значением параметра {nameof(arrayIndex)}, до конца массива назначения {nameof(array)}.");
            }

            Array.Copy(items, 0, array, arrayIndex, Count);
        }

        public IEnumerator<T> GetEnumerator()
        {
            int oldModCount = modCount;

            for (int i = 0; i < Count; ++i)
            {
                if (oldModCount != modCount)
                {
                    throw new InvalidOperationException("Список был изменен.");
                }

                yield return items[i];
            }
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Equals(item, items[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index > Count)
            {
                throw new IndexOutOfRangeException("Индекс выходит за границы списка.");
            }

            if (Count >= items.Length)
            {
                IncreaseCapacity();
            }

            Array.Copy(items, index, items, index + 1, Count - index);

            items[index] = item;

            Count++;

            modCount++;
        }

        public bool Remove(T item)
        {
            int index = IndexOf(item);

            if (index != -1)
            {
                RemoveAt(index);

                modCount++;

                return true;
            }

            return false;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException("Индекс выходит за границы списка.");
            }

            Array.Copy(items, index + 1, items, index, Count - 1 - index);

            Count--;

            modCount++;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void IncreaseCapacity()
        {
            Array.Resize(ref items, items.Length * 2);

            Capacity = items.Length;
        }

        public void TrimExcess()
        {
            T[] old = items;
            items = new T[Count];
            Array.Copy(old, 0, items, 0, Count);

            Capacity = items.Length;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Count; i++)
            {
                sb.Append(items[i])
                  .Append(", ");
            }

            sb.Remove(sb.Length - 2, 1);

            return sb.ToString();
        }
    }
}
