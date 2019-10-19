using System;
using System.Text;

namespace List
{
    class SinglyLinkedList<T>
    {
        private ListItem<T> head;

        public int Count { get; private set; }

        public T GetFirstElementValue()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Ошибка! Список пуст.");
            }

            return head.Data;
        }

        public T GetValue(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new IndexOutOfRangeException("Индекс выходит за пределы списка.");
            }

            return GetItem(index).Data;
        }

        public T SetValue(int index, T value)
        {
            if (index >= Count || index < 0)
            {
                throw new IndexOutOfRangeException("Индекс выходит за пределы списка.");
            }

            ListItem<T> currentItem = GetItem(index);

            T oldValue = currentItem.Data;
            currentItem.Data = value;

            return oldValue;
        }

        public T Remove(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new IndexOutOfRangeException("Индекс выходит за пределы списка.");
            }

            if (index == 0)
            {
                T oldHeadValue = head.Data;

                head = head.Next;

                Count--;

                return oldHeadValue;
            }

            ListItem<T> currentItem = GetItem(index - 1);

            T oldValue = currentItem.Next.Data;
            currentItem.Next = currentItem.Next.Next;

            Count--;

            return oldValue;
        }

        public void AddFirst(T value)
        {
            ListItem<T> newElement = new ListItem<T>(value);

            newElement.Next = head;
            head = newElement;

            Count++;
        }

        public void Add(int index, T value)
        {
            if (index > Count || index < 0)
            {
                throw new IndexOutOfRangeException("Индекс выходит за пределы списка.");
            }

            if (index == 0)
            {
                AddFirst(value);
            }
            else
            {
                ListItem<T> newElement = new ListItem<T>(value);
                ListItem<T> currentItem = GetItem(index - 1);

                newElement.Next = currentItem.Next;
                currentItem.Next = newElement;

                Count++;
            }
        }

        public bool RemoveByValue(T value)
        {
            ListItem<T> currentItem = head;
            ListItem<T> previousItem = currentItem;

            int counter = Count;

            while (counter != 0)
            {
                counter--;

                if (currentItem.Data.Equals(value))
                {
                    if (counter == 0)
                    {
                        RemoveFirst();

                        return true;
                    }

                    previousItem.Next = previousItem.Next.Next;
                    Count--;

                    return true;
                }

                previousItem = currentItem;
                currentItem = currentItem.Next;
            }

            return false;
        }

        public T RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Ошибка! Список пуст.");
            }

            T oldValue = head.Data;

            head = head.Next;

            Count--;

            return oldValue;
        }

        public void Reverse()
        {
            if (Count == 0)
            {
                return;
            }

            ListItem<T> currentItem = head;
            ListItem<T> nextItem = head.Next;

            currentItem.Next = null;

            ListItem<T> newList = currentItem;

            while (nextItem != null)
            {
                currentItem = nextItem;
                nextItem = nextItem.Next;
                currentItem.Next = newList;
                newList = currentItem;
            }

            head = newList;
        }

        public SinglyLinkedList<T> Copy()
        {
            if (Count == 0)
            {
                return new SinglyLinkedList<T>();
            }

            SinglyLinkedList<T> newList = new SinglyLinkedList<T>();

            newList.Count = Count;

            ListItem<T> currentItem = head;
            ListItem<T> newHead = new ListItem<T>(head.Data);
            ListItem<T> newCurrentItem = newHead;

            for (int i = 1; i < Count; i++)
            {
                currentItem = currentItem.Next;
                newCurrentItem.Next = new ListItem<T>(currentItem.Data);
                newCurrentItem = newCurrentItem.Next;
            }

            newList.head = newHead;

            return newList;
        }

        private ListItem<T> GetItem(int index)
        {
            ListItem<T> currentItem = head;

            for (int i = 0; i < index; i++)
            {
                currentItem = currentItem.Next;
            }

            return currentItem;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            ListItem<T> currentItem = head;

            sb.Append("{ ");

            for (int i = 0; i < Count; i++)
            {
                sb.Append(currentItem.Data)
                    .Append(", ");

                currentItem = currentItem.Next;
            }

            sb.Remove(sb.Length - 2, 1)
                .Append('}');

            return sb.ToString();
        }
    }
}
