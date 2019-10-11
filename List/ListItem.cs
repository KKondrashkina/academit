﻿namespace List
{
    class ListItem<T>
    {
        private T data;
        private ListItem<T> next;

        public ListItem(T data)
        {
            Data = data;
        }

        public ListItem(T data, ListItem<T> next)
        {
            Data = data;
            Next = next;
        }

        public T Data { get; set; }

        public ListItem<T> Next { get; set; }
    }
}