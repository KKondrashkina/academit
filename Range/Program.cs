using System;

namespace Range
{
    class Program
    {
        static void Main(string[] args)
        {
            Range range1 = new Range(45.6, 89.34);

            double length = range1.GetLength();
            double number1 = 34.3;
            double number2 = 62.234;

            Console.WriteLine("Длина диапазона {0} - {1} = {2}", range1.From, range1.To, length);

            if (range1.IsInside(number1))
            {
                Console.WriteLine("Число {0} входит в диапазон", number1);
            }
            else
            {
                Console.WriteLine("Число {0} не входит в диапазон", number1);
            }

            if (range1.IsInside(number2))
            {
                Console.WriteLine("Число {0} входит в диапазон", number2);
            }
            else
            {
                Console.WriteLine("Число {0} не входит в диапазон", number2);
            }

            WriteAboutRanges(range1, new Range(50.1, 82.2));
            WriteAboutRanges(range1, new Range(32.4, 97.7));
            WriteAboutRanges(range1, new Range(91.2, 93.3));
            WriteAboutRanges(range1, new Range(41.3, 42.4));
            WriteAboutRanges(range1, new Range(75.6, 99.9));
            WriteAboutRanges(range1, new Range(21.8, 54.67));
            WriteAboutRanges(range1, new Range(45.6, 72.9));
            WriteAboutRanges(range1, new Range(58.9, 89.34));
            WriteAboutRanges(range1, new Range(45.6, 89.34));
            WriteAboutRanges(range1, new Range(89.34, 92.7));
            WriteAboutRanges(range1, new Range(39.8, 45.6));

            Console.ReadKey();
        }

        public static void WriteAboutRanges(Range range1, Range range2)
        {
            Console.Write("Пересечение диапазонов {0} — {1} и {2} — {3} = ", range1.From, range1.To, range2.From, range2.To);
            Console.WriteLine(range1.GetIntersection(range2));

            Console.Write("Объединение диапазонов {0} — {1} и {2} — {3} = ", range1.From, range1.To, range2.From, range2.To);

            Range[] range = range1.GetUnion(range2);

            Console.Write(range[0]);

            if (range.Length > 1)
            {
                Console.Write(" и {0}", range[1]);
            }

            Console.WriteLine();            

            Console.Write("Разность диапазонов {0} — {1} и {2} — {3} = ", range1.From, range1.To, range2.From, range2.To);

            range = range1.GetDifference(range2);

            if (range.Length > 0)
            {
                Console.Write(range[0]);

                if (range.Length > 1)
                {
                    Console.Write(" и {0}", range[1]);
                }
            }

            Console.WriteLine(); 
            
            Console.WriteLine();
        }
    }
}
