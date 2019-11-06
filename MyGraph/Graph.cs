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

            bool[] visited = new bool[graph.GetLength(0)];

            Queue<int> queue = new Queue<int>();

            int notVisitedIndex = 0;
            bool isReturn = false;

            while (!isReturn)
            {
                for (int i = notVisitedIndex; i < visited.Length; i++)
                {
                    if (!visited[i])
                    {
                        notVisitedIndex = i;
                        isReturn = false;

                        break;
                    }

                    isReturn = true;
                }

                queue.Enqueue(notVisitedIndex);

                visited[notVisitedIndex] = true;

                if (!isReturn)
                {
                    while (queue.Count != 0)
                    {
                        int element = queue.Dequeue();

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
            }
        }

        public void GetAroundInDepth(Action<int> action)
        {
            if (graph == null)
            {
                return;
            }

            bool[] visited = new bool[graph.GetLength(0)];

            Stack<int> stack = new Stack<int>();

            int notVisitedIndex = 0;
            bool isReturn = false;

            while (!isReturn)
            {
                for (int i = notVisitedIndex; i < visited.Length; i++)
                {
                    if (!visited[i])
                    {
                        notVisitedIndex = i;
                        isReturn = false;

                        break;
                    }

                    isReturn = true;
                }

                stack.Push(notVisitedIndex);

                visited[notVisitedIndex] = true;

                if (!isReturn)
                {
                    while (stack.Count != 0)
                    {
                        int element = stack.Pop();

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

        public void GetAroundInDepthRecursively(Action<int> action)
        {
            if (graph == null)
            {
                return;
            }

            int notVisitedIndex = 0;
            bool isReturn = false;
            bool[] visited = new bool[graph.GetLength(0)];

            while (!isReturn)
            {
                visited = GetAroundInDepthRecursively(action, visited, notVisitedIndex);

                for (int i = notVisitedIndex; i < visited.Length; i++)
                {
                    if (!visited[i])
                    {
                        notVisitedIndex = i;
                        isReturn = false;

                        break;
                    }

                    isReturn = true;
                }
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
