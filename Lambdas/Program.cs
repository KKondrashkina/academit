using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>
            {
               new Person("Александр", 14),
               new Person ("Василина", 10),
               new Person("Сергей", 23),
               new Person("Екатерина", 21),
               new Person("Александр", 34),
               new Person ("Алина", 37),
               new Person ("Дмитрий", 45),
               new Person ("Ольга", 44)
            };

            var names = persons
                .Select(x => x.Name)
                .Distinct();

            Console.WriteLine("Уникальные имена:");
            Console.WriteLine(string.Join(", ", names));
            Console.WriteLine();

            double averageAge = persons
                .Where(x => x.Age < 18)
                .Average(x => x.Age);

            Console.WriteLine("Средний возраст людей младше 18 лет: {0}", averageAge);
            Console.WriteLine();

            Dictionary<string, double> personsByName = persons
                .GroupBy(x => x.Name)
                .ToDictionary(x => x.Key, x => x.Average(y => y.Age));

            Console.WriteLine("Имена и средний возраст:");
            Console.WriteLine(string.Join(", ", personsByName));
            Console.WriteLine();

            string[] middleAgedPersons = persons
                .Where(x => x.Age >= 20 && x.Age <= 45)
                .OrderByDescending(x => x.Age)
                .Select(x => x.Name)
                .ToArray();

            Console.WriteLine("Люди возраста от 20 до 45:");
            Console.WriteLine(string.Join(", ", middleAgedPersons));
            Console.WriteLine();

            Console.WriteLine("Введите число — нужное кол-во корней:");

            bool isIntNumber1 = false;
            int rootsCount = 0;

            while (!isIntNumber1)
            {
                isIntNumber1 = int.TryParse(Console.ReadLine(), out rootsCount);
                if (!isIntNumber1)
                {
                    Console.WriteLine("Введите корректное значение");
                }
            }

            Console.WriteLine();

            foreach (double root in GetSquareRoot())
            {
                if (rootsCount == 0)
                {
                    break;
                }

                Console.WriteLine(root);

                rootsCount--;
            }

            Console.WriteLine();

            Console.WriteLine("Введите число — нужное кол-во чисел Фибоначчи:");

            bool isIntNumber2 = false;
            int fibonacciNumbersCount = 0;

            while (!isIntNumber2)
            {
                isIntNumber2 = int.TryParse(Console.ReadLine(), out fibonacciNumbersCount);
                if (!isIntNumber2)
                {
                    Console.WriteLine("Введите корректное значение");
                }
            }

            Console.WriteLine();

            foreach (int number in GetFibonacciNumber())
            {
                if (fibonacciNumbersCount == 0)
                {
                    break;
                }

                Console.WriteLine(number);

                fibonacciNumbersCount--;
            }

            Console.ReadKey();
        }

        public static IEnumerable GetSquareRoot()
        {
            int number = 0;

            while (true)
            {
                yield return Math.Sqrt(number);

                number++;
            }
        }

        public static IEnumerable GetFibonacciNumber()
        {
            yield return 0;
            yield return 1;

            int previousNumber1 = 0;
            int previousNumber2 = 1;

            while (true)
            {
                int number = previousNumber1 + previousNumber2;

                yield return number;

                previousNumber1 = previousNumber2;
                previousNumber2 = number;
            }
        }
    }
}
