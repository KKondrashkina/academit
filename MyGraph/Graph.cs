using System;
using System.Collections.Generic;

namespace MyGraph
{
    class Graph
    {
        private int[,] graph;
        private bool[] visited;

        public Graph(int[,] graph)
        {
            if (graph.GetLength(0) != graph.GetLength(1))
            {
                throw new ArgumentException("Массив должен быть квадратным.", nameof(graph));
            }

            this.graph = graph;
        }

        public void GetAroundInWidth(Action<int> action)
        {
            visited = new bool[graph.GetLength(0)];

            if (graph == null)
            {
                return;
            }

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(0);

            visited[0] = true;

            int element;

            while (queue.Count != 0)
            {
                element = queue.Dequeue();

                action(element);

                for (int i = 0; i < visited.Length; i++)
                {
                    if (i == element)
                    {
                        continue;
                    }

                    if (graph[element, i] == 1)
                    {
                        if (!visited[i])
                        {
                            visited[i] = true;

                            queue.Enqueue(i);
                        }
                    }
                }
            }
        }

        public void GetAroundInDepth(Action<int> action)
        {
            visited = new bool[graph.GetLength(0)];

            if (graph == null)
            {
                return;
            }

            Stack<int> stack = new Stack<int>();

            stack.Push(0);

            visited[0] = true;

            int element;

            while (stack.Count != 0)
            {
                element = stack.Pop();

                action(element);

                for (int i = visited.Length - 1; i >= 0; i--)
                {
                    if (i == element)
                    {
                        continue;
                    }

                    if (graph[element, i] == 1)
                    {
                        if (!visited[i])
                        {
                            visited[i] = true;

                            stack.Push(i);
                        }
                    }
                }
            }
        }
    }
}
