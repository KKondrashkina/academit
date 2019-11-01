using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayList
{
    class MyList<T> : IList<T>
    {
        private T[] items;
        private int modCount = 0;

        public MyList()
        {
            items = new T[10];

            Capacity = items.Length;
        }

        public MyList(int capacity)
        {
            if (capacity < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity), "Вместимость не может быть меньше единицы.");
            }

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

        public int Capacity
        {
            get
            {
                return items.Length;
            }
            set
            {
                if (value < Count)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Вместимость не может быть меньше количества элементов в списке.");
                }

                if (value == items.Length)
                {
                    return;
                }

                if (Count > 0)
                {
                    Array.Resize(ref items, value);
                }
            }
        }

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
            return items.Contains(item);
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
            Array.Resize(ref items, Count);

            Capacity = items.Length;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("[ ");

            for (int i = 0; i < Count; i++)
            {
                sb.Append(items[i])
                  .Append(", ");
            }

            if (Count != 0)
            {
                sb.Remove(sb.Length - 2, 1);
            }

            sb.Append(']');

            return sb.ToString();
        }
    }
}
