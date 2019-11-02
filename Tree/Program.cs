using System;

namespace MyTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>();

            tree.Add(149);
            tree.Add(120);
            tree.Add(250);
            tree.Add(110);
            tree.Add(130);
            tree.Add(200);
            tree.Add(260);
            tree.Add(100);
            tree.Add(115);
            tree.Add(125);
            tree.Add(140);
            tree.Add(190);
            tree.Add(210);
            tree.Add(255);
            tree.Add(270);
            tree.Add(124);
            tree.Add(126);
            tree.Add(123);
            tree.Add(135);
            tree.Add(150);
            tree.Add(136);

            Console.WriteLine("Количество элементов в дереве = {0}", tree.Count);
            Console.WriteLine();

            Console.WriteLine("Результат обхода в ширину:");
            tree.GetAroundInWidth(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("Результат обхода в глубину:");
            tree.GetAroundInDepth(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("Результат обхода в глубину рекурсивно:");
            tree.GetAroundInDepthRecursively(Console.WriteLine);
            Console.WriteLine();

            int number1 = 250;
            int number2 = 66;

            if (tree.Search(number1))
            {
                Console.WriteLine("В дереве присутсвует элемент {0}", number1);
            }
            else
            {
                Console.WriteLine("В дереве отсутсвует элемент {0}", number1);
            }

            if (tree.Search(number2))
            {
                Console.WriteLine("В дереве присутсвует элемент {0}", number2);
            }
            else
            {
                Console.WriteLine("В дереве отсутсвует элемент {0}", number2);
            }

            if (tree.Remove(number1))
            {
                Console.WriteLine("Элемент {0} был удален", number1);
            }
            else
            {
                Console.WriteLine("Элемент {0} не был удален", number1);
            }

            int number3 = 123;

            if (tree.Remove(number3))
            {
                Console.WriteLine("Элемент {0} был удален", number3);
            }
            else
            {
                Console.WriteLine("Элемент {0} не был удален", number3);
            }

            int number4 = 135;

            if (tree.Remove(number4))
            {
                Console.WriteLine("Элемент {0} был удален", number4);
            }
            else
            {
                Console.WriteLine("Элемент {0} не был удален", number4);
            }

            Console.WriteLine("Количество элементов в дереве = {0}", tree.Count);
            Console.WriteLine();

            Console.WriteLine("Результат обхода в ширину:");
            tree.GetAroundInWidth(Console.WriteLine);

            Console.ReadKey();
        }
    }
}
