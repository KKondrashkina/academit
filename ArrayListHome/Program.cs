using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ArrayListHome
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> file = ReadFileInList("file.txt");

            foreach (string line in file)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine();

            List<int> numbers1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.Write("Список ");

            foreach (int number in numbers1)
            {
                Console.Write("{0} ", number);
            }

            Console.Write("без четных чисел: ");

            RemoveEvenNumbers(numbers1);

            foreach (int number in numbers1)
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();

            List<int> numbers2 = new List<int> { 1, 2, 3, 4, 2, 3, 5, 6, 7, 5, 8, 9, 7, 1, 10, 3 };
            List<int> numbers3 = RemoveDuplicate(numbers2);

            Console.Write("Список ");

            foreach (int number in numbers2)
            {
                Console.Write("{0} ", number);
            }

            Console.Write("без повтора чисел: ");

            foreach (int number in numbers3)
            {
                Console.Write("{0} ", number);
            }

            Console.ReadKey();
        }

        public static List<string> ReadFileInList(string readPath)
        {
            List<string> file = new List<string>();

            if (File.Exists(readPath))
            {
                using (StreamReader reader = new StreamReader(readPath, Encoding.GetEncoding(1251)))
                {
                    string currentLine;

                    while ((currentLine = reader.ReadLine()) != null)
                    {
                        file.Add(currentLine);
                    }
                }
            }

            return file;
        }

        public static void RemoveEvenNumbers(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count(); i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    numbers.RemoveAt(i);

                    i--;
                }
            }
        }

        public static List<int> RemoveDuplicate(List<int> numbers)
        {
            List<int> newNumbersList = new List<int>();

            for (int i = 0; i < numbers.Count(); i++)
            {
                if (!newNumbersList.Contains(numbers[i]))
                {
                    newNumbersList.Add(numbers[i]);
                }

            }

            return newNumbersList;
        }
    }
}
