using System;

namespace MyGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] graphArray =
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

            Graph graph = new Graph(graphArray);

            graph.GetAroundInWidth(Console.WriteLine);

            Console.WriteLine();

            graph.GetAroundInDepth(Console.WriteLine);

            Console.ReadKey();
        }
    }
}
