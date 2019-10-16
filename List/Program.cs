using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();

            list.AddFirst(5);
            list.AddFirst(4);
            list.AddFirst(2);
            list.AddFirst(1);
            list.Add(2, 3);

            SinglyLinkedList<int> listCopy = list.Copy();

            Console.WriteLine("Количество элементов в списке {0} = {1}", list, list.Count);
            Console.WriteLine();

            Console.WriteLine("Первый элемент списка {0} = {1}", list, list.GetFirstElementValue());
            Console.WriteLine();

            Console.WriteLine("Элемент под индексом три в списке {0} = {1}", list, list.GetValue(3));
            Console.WriteLine();

            Console.Write("Cписок {0} теперь равен ", list);
            list.SetValue(2, 8);
            Console.Write(list);
            Console.WriteLine();

            Console.Write("Cписок {0} теперь равен ", list);
            list.Remove(3);
            Console.Write(list);
            Console.WriteLine();

            Console.Write("Cписок {0} теперь равен ", list);
            list.RemoveByValue(8);
            Console.Write(list);
            Console.WriteLine();

            Console.Write("Cписок {0} теперь равен ", list);
            list.Reverse();
            Console.Write(list);
            Console.WriteLine();

            Console.Write("Cписок {0} до изменений: {1}", list, listCopy);

            Console.ReadKey();
        }
    }
}
