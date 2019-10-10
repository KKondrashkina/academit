using System;
using System.Text;

namespace List
{
    class SinglyLinkedList<T>
    {
        private ListItem<T> head;
        private int count;

        public int GetCount()
        {
            return count;
        }

        public T GetFirstElementValue()
        {
            return head.Data;
        }

        public T GetValueByIndex(int index)
        {
            if (index >= count || index < 0)
            {
                throw new ArgumentException("Индекс выходит за пределы списка.");
            }

            ListItem<T> currentItem = head;

            for (int i = 0; i < index; i++)
            {
                currentItem = currentItem.Next;
            }

            return currentItem.Data;
        }

        public T SetValueByIndex(int index, T value)
        {
            if (index >= count || index < 0)
            {
                throw new ArgumentException("Индекс выходит за пределы списка.");
            }

            ListItem<T> currentItem = head;

            for (int i = 0; i < index; i++)
            {
                currentItem = currentItem.Next;
            }

            T oldValue = currentItem.Data;
            currentItem.Data = value;

            return oldValue;
        }

        public T RemoveByIndex(int index)
        {
            if (index >= count || index < 0)
            {
                throw new ArgumentException("Индекс выходит за пределы списка.");
            }

            ListItem<T> currentItem = head;

            for (int i = 0; i < index - 1; i++)
            {
                currentItem = currentItem.Next;
            }

            T oldValue = currentItem.Next.Data;
            currentItem.Next = currentItem.Next.Next;

            count--;

            return oldValue;
        }

        public void AddFirst(T value)
        {
            ListItem<T> newElement = new ListItem<T>(value);

            newElement.Next = head;
            head = newElement;

            count++;
        }

        public void AddByIndex(int index, T value)
        {
            if (index >= count || index < 0)
            {
                throw new ArgumentException("Индекс выходит за пределы списка.");
            }

            ListItem<T> newElement = new ListItem<T>(value);
            ListItem<T> currentItem = head;

            for (int i = 0; i < index - 1; i++)
            {
                currentItem = currentItem.Next;
            }

            newElement.Next = currentItem.Next;
            currentItem.Next = newElement;

            count++;
        }

        public bool RemoveByValue(T value)
        {
            ListItem<T> currentItem = head;
            ListItem<T> previousItem = currentItem;

            while (currentItem.Next != null)
            {
                if (currentItem.Data.Equals(value))
                {
                    previousItem.Next = previousItem.Next.Next;

                    count--;

                    return true;
                }

                previousItem = currentItem;
                currentItem = currentItem.Next;
            }

            return false;
        }

        public T RemoveFirst()
        {
            T oldValue = head.Data;

            head = head.Next;

            count--;

            return oldValue;
        }

        public void Expand()
        {
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
            SinglyLinkedList<T> newList = new SinglyLinkedList<T>();

            newList.count = count;

            newList.AddFirst(head.Data);

            ListItem<T> currentItem = head;

            for (int i = 1; currentItem.Next != null; i++)
            {
                currentItem = currentItem.Next;

                newList.AddByIndex(i, currentItem.Data);
            }

            return newList;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            ListItem<T> currentItem = head;

            while (currentItem.Next != null)
            {
                sb.Append(currentItem.Data)
                  .Append(", ");

                currentItem = currentItem.Next;
            }

            sb.Append(currentItem.Data);

            return sb.ToString();
        }
    }
}
