using System;

namespace MyGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] graphArray1 =
            {
                {0,1,1,0,0,0,0,0,0,0,0 },
                {1,0,0,1,1,0,0,0,0,0,0 },
                {1,0,0,0,0,1,1,0,0,0,0 },
                {0,1,0,0,0,0,0,1,1,0,0 },
                {0,1,0,0,0,0,0,0,0,1,1 },
                {0,0,1,0,0,0,0,0,0,0,0 },
                {0,0,1,0,0,0,0,0,0,0,0 },
                {0,0,0,1,0,0,0,0,0,0,0 },
                {0,0,0,1,0,0,0,0,0,0,0 },
                {0,0,0,0,1,0,0,0,0,0,0 },
                {0,0,0,0,1,0,0,0,0,0,0 }
            };

            Graph graph1 = new Graph(graphArray1);

            graph1.GetAroundInWidth(Console.WriteLine);

            Console.WriteLine();

            graph1.GetAroundInDepth(Console.WriteLine);

            Console.WriteLine();

            graph1.GetAroundInDepthRecursively(Console.WriteLine);

            Console.WriteLine();

            int[,] graphArray2 =
            {
                {0,1,1,0,0,0,0,0,0,0,0 },
                {1,0,0,1,1,0,0,0,0,0,0 },
                {1,0,0,0,0,1,1,0,0,0,0 },
                {0,1,0,0,0,0,0,0,0,0,0 },
                {0,1,0,0,0,0,0,0,0,0,0 },
                {0,0,1,0,0,0,0,0,0,0,0 },
                {0,0,1,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0,1,0 },
                {0,0,0,0,0,0,0,0,1,0,1 },
                {0,0,0,0,0,0,0,0,0,1,0 }
            };

            Graph graph2 = new Graph(graphArray2);

            graph2.GetAroundInWidth(Console.WriteLine);

            Console.WriteLine();

            graph2.GetAroundInDepth(Console.WriteLine);

            Console.WriteLine();

            graph2.GetAroundInDepthRecursively(Console.WriteLine);

            Console.ReadKey();
        }
    }
}
