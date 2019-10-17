using System;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> numbers = new MyList<int>();

            for (int i = 0; i < 50; i++)
            {
                numbers.Add((i + 1) * 2);
            }

            Console.WriteLine("Количество элементов в списке {0} = {1}", numbers, numbers.Count);
            Console.WriteLine();

            int number = 8;

            if (numbers.Contains(number))
            {
                Console.WriteLine("Список содержит число {0}", number);
            }
            else
            {
                Console.WriteLine("Список не содержит число {0}", number);
            }

            Console.WriteLine();

            Console.WriteLine("Индекс числа 30 = {0}", numbers.IndexOf(30));
            Console.WriteLine();

            numbers.Insert(1, 3);

            Console.WriteLine("Теперь список равен: {0}", numbers);
            Console.WriteLine();

            numbers.Remove(2);

            Console.WriteLine("Теперь список равен: {0}", numbers);
            Console.WriteLine();

            numbers.RemoveAt(5);

            Console.WriteLine("Теперь список равен: {0}", numbers);
            Console.WriteLine();

            int[] newNumbers = new int[51];

            newNumbers[0] = 1;

            numbers.CopyTo(newNumbers, 1);

            Console.WriteLine("Новый массив, содержащий список: {0}", string.Join(", ", newNumbers));
            Console.WriteLine();

            numbers.Clear();
            numbers.Add(99);

            Console.WriteLine("Теперь список равен: {0}", numbers);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
