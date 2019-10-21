using System;

namespace MyHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable<string> table = new HashTable<string>(40);

            for (int i = 0; i < 30; i++)
            {
                table.Add($"{i}");
            }

            Console.WriteLine(table);
            Console.WriteLine("Количество элементов в таблице = {0}", table.Count);
            Console.WriteLine();

            string number = "15";

            if (table.Contains(number))
            {
                Console.WriteLine("Таблица содержит число {0}", number);
            }
            else
            {
                Console.WriteLine("Таблица не содержит число {0}", number);
            }

            Console.WriteLine();

            table.Remove("17");
            table.Remove("5");

            Console.WriteLine("Теперь таблица равна:");
            Console.WriteLine(table);
            Console.WriteLine();

            string[] newTable = new string[30];

            table.CopyTo(newTable, 0);

            Console.WriteLine("Список с копией масива: ");
            Console.WriteLine(string.Join(", ", newTable));
            Console.WriteLine();

            table.Clear();

            Console.WriteLine("Теперь таблица равна:");
            Console.WriteLine(table);
            Console.WriteLine();
        }
    }
}
