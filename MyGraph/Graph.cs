using System;
using System.Collections.Generic;

namespace MyGraph
{
    class Graph
    {
        private int[,] graph;

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
            if (graph == null)
            {
                return;
            }

            int length = graph.GetLength(0);
            bool[] visited = new bool[length];
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < length; i++)
            {
                if (visited[i])
                {
                    continue;
                }

                queue.Enqueue(i);

                visited[i] = true;

                while (queue.Count != 0)
                {
                    int element = queue.Dequeue();

                    action(element);

                    for (int j = 0; j < length; j++)
                    {
                        if (j == element)
                        {
                            continue;
                        }

                        if (graph[element, j] == 1)
                        {
                            if (!visited[j])
                            {
                                visited[j] = true;

                                queue.Enqueue(j);
                            }
                        }
                    }
                }
            }
        }

        public void GetAroundInDepth(Action<int> action)
        {
            if (graph == null)
            {
                return;
            }

            int length = graph.GetLength(0);
            bool[] visited = new bool[length];
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < length; i++)
            {
                if (visited[i])
                {
                    continue;
                }

                stack.Push(i);

                visited[i] = true;

                while (stack.Count != 0)
                {
                    int element = stack.Pop();

                    action(element);

                    for (int j = length - 1; j >= 0; j--)
                    {
                        if (j == element)
                        {
                            continue;
                        }

                        if (graph[element, j] == 1)
                        {
                            if (!visited[j])
                            {
                                visited[j] = true;

                                stack.Push(j);
                            }
                        }
                    }
                }
            }
        }

        public void GetAroundInDepthRecursively(Action<int> action)
        {
            if (graph == null)
            {
                return;
            }

            bool[] visited = new bool[graph.GetLength(0)];

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                if (visited[i])
                {
                    continue;
                }

                visited = GetAroundInDepthRecursively(action, visited, i);
            }
        }

        private bool[] GetAroundInDepthRecursively(Action<int> action, bool[] visited, int element)
        {
            bool[] newVisited = visited;
            newVisited[element] = true;

            action(element);

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                if (i == element)
                {
                    continue;
                }

                if (graph[element, i] == 1)
                {
                    if (!visited[i])
                    {
                        newVisited[i] = true;

                        GetAroundInDepthRecursively(action, newVisited, i);
                    }
                }
            }

            return newVisited;
        }
    }
}
