using System;
using System.Collections.Generic;

namespace MyTree
{
    class Tree<T>
    {
        private TreeNode<T> root;

        public Tree()
        {
            
        }

        public int Count { get; private set; }

        public void Add(T item)
        {
            TreeNode<T> newElement = new TreeNode<T>(item);

            if (root == null)
            {
                root = newElement;

                Count++;

                return;
            }

            TreeNode<T> currentNode = root;

            while (true)
            {
                if (item.CompareTo(currentNode.Data) < 0)
                {
                    if (currentNode.Left == null)
                    {
                        currentNode.Left = newElement;

                        Count++;

                        return;
                    }

                    currentNode = currentNode.Left;
                }
                else
                {
                    if (currentNode.Right == null)
                    {
                        currentNode.Right = newElement;

                        Count++;

                        return;
                    }

                    currentNode = currentNode.Right;
                }
            }
        }

        public bool Search(T item)
        {
            TreeNode<T> currentNode = root;

            while (true)
            {
                int comparisonResult = item.CompareTo(currentNode.Data);

                if (comparisonResult == 0)
                {
                    return true;
                }

                if (comparisonResult < 0)
                {
                    if (currentNode.Left == null)
                    {
                        return false;
                    }

                    currentNode = currentNode.Left;
                }
                else
                {
                    if (currentNode.Right == null)
                    {
                        return false;
                    }

                    currentNode = currentNode.Right;
                }
            }
        }

        public TreeNode<T> SearchParent(T item)
        {
            TreeNode<T> currentNode = root;

            while (true)
            {
                int comparisonResult = item.CompareTo(currentNode.Data);

                if (currentNode.Left != null && item.CompareTo(currentNode.Left.Data) == 0)
                {
                    return currentNode;
                }

                if (currentNode.Right != null && item.CompareTo(currentNode.Right.Data) == 0)
                {
                    return currentNode;
                }

                if (comparisonResult < 0)
                {
                    if (currentNode.Left == null)
                    {
                        return null;
                    }

                    currentNode = currentNode.Left;
                }
                else
                {
                    if (currentNode.Right == null)
                    {
                        return null;
                    }

                    currentNode = currentNode.Right;
                }
            }
        }

        public bool Remove(T item)
        {
            TreeNode<T> parent = SearchParent(item);
            TreeNode<T> currentNode;
            bool isLeft = false;

            if (parent.Left != null && item.CompareTo(parent.Left.Data) == 0)
            {
                currentNode = parent.Left;
                isLeft = true;
            }
            else
            {
                currentNode = parent.Right;
            }


            if (currentNode == null)
            {
                return false;
            }

            if (currentNode.Left == null && currentNode.Right == null)
            {
                if (isLeft)
                {
                    parent.Left = null;
                }
                else
                {
                    parent.Right = null;
                }
            }
            else if (currentNode.Left == null && currentNode.Right != null)
            {
                if (isLeft)
                {
                    parent.Left = currentNode.Right;
                }
                else
                {
                    parent.Right = currentNode.Right;
                }
            }
            else if (currentNode.Left != null && currentNode.Right == null)
            {
                if (isLeft)
                {
                    parent.Left = currentNode.Left;
                }
                else
                {
                    parent.Right = currentNode.Left;
                }
            }
            else
            {
                TreeNode<T> newCurrentNode = currentNode.Right;
                TreeNode<T> newParent = currentNode;

                while (newCurrentNode.Left != null)
                {
                    newParent = newCurrentNode;
                    newCurrentNode = newCurrentNode.Left;
                }

                currentNode.Data = newCurrentNode.Data;

                if (newCurrentNode.Right != null)
                {
                    newCurrentNode.Data = newCurrentNode.Right.Data;

                    newCurrentNode.Right = null;
                }
                else
                {
                    newParent.Left = null;
                }
            }

            Count--;

            return true;
        }

        private static void GetAroundInWidth(TreeNode<T> node, Action<T> action)
        {
            if(node==null)
            {
                return;
            }

            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();

            do
            {
                action(node.Data);

                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }

                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }

                node = queue.Dequeue();
            }
            while (queue.Count != 0);

            action(node.Data);
        }

        private static void GetAroundInDepth(TreeNode<T> node, Action<T> action)
        {
            if (node == null)
            {
                return;
            }

            Stack<TreeNode<T>> stack = new Stack<TreeNode<T>>();

            while (node != null || stack.Count != 0)
            {
                if (stack.Count != 0)
                {
                    node = stack.Pop();
                }

                while (node != null)
                {
                    action(node.Data);

                    if (node.Right != null)
                    {
                        stack.Push(node.Right);
                    }

                    node = node.Left;
                }
            }
        }

        private static void GetAroundInDepthRecursively(TreeNode<T> node, Action<T> action)
        {
            if (node == null)
            {
                return;
            }

            action(node.Data);

            if (node.Left != null)
            {
                GetAroundInDepthRecursively(node.Left, action);
            }

            if (node.Right != null)
            {
                GetAroundInDepthRecursively(node.Right, action);
            }
        }

        public void GetAroundInWidth(Action<T> action)
        {
            GetAroundInWidth(root,action);
        }

        public void GetAroundInDepth(Action<T> action)
        {
            GetAroundInDepth(root, action);
        }

        public void GetAroundInDepthRecursively(Action<T> action)
        {
            GetAroundInDepthRecursively(root, action);
        }
    }
}
