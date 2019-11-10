using System;
using System.Collections.Generic;

namespace MyTree
{
    class Tree<T>
    {
        private TreeNode<T> root;
        private Comparer<T> comparer;

        public Tree()
        {
            comparer = null;
        }

        public Tree(Comparer<T> comparer)
        {
            this.comparer = comparer;
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
                int comparisonResult = GetComparisonResult(item, currentNode);

                if (comparisonResult < 0)
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
            if (Count == 0)
            {
                return false;
            }

            TreeNode<T> currentNode = root;

            while (true)
            {
                int comparisonResult = GetComparisonResult(item, currentNode);

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
            if (Count == 0)
            {
                return null;
            }

            TreeNode<T> currentNode = root;
            TreeNode<T> parent = null;

            while (true)
            {
                if (currentNode == null)
                {
                    return null;
                }

                int comparisonResult = GetComparisonResult(item, currentNode);

                if (comparisonResult == 0)
                {
                    return parent;
                }

                parent = currentNode;

                if (comparisonResult < 0)
                {
                    currentNode = currentNode.Left;
                }
                else
                {
                    currentNode = currentNode.Right;
                }
            }
        }

        public bool Remove(T item)
        {
            TreeNode<T> parent = SearchParent(item);
            TreeNode<T> currentNode;
            bool isLeft = false;

            if (parent == null)
            {
                currentNode = root;
            }
            else
            {
                int comparisonResult = GetComparisonResult(item, parent.Left);

                if (parent.Left != null && comparisonResult == 0)
                {
                    currentNode = parent.Left;
                    isLeft = true;
                }
                else
                {
                    currentNode = parent.Right;
                }
            }

            if (currentNode == null)
            {
                return false;
            }

            if (currentNode.Left == null && currentNode.Right == null)
            {
                if (currentNode == root)
                {
                    root = null;
                }
                else
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
            }
            else if (currentNode.Left == null && currentNode.Right != null)
            {
                if (currentNode == root)
                {
                    root = currentNode.Right;
                }
                else
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
            }
            else if (currentNode.Left != null && currentNode.Right == null)
            {
                if (currentNode == root)
                {
                    root = currentNode.Left;
                }
                else
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

        public void GetAroundInWidth(Action<T> action)
        {
            if (Count == 0)
            {
                return;
            }

            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();

            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                TreeNode<T> node = queue.Dequeue();

                action(node.Data);

                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }

                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
            }
        }

        public void GetAroundInDepth(Action<T> action)
        {
            if (Count == 0)
            {
                return;
            }

            Stack<TreeNode<T>> stack = new Stack<TreeNode<T>>();

            stack.Push(root);

            while (stack.Count != 0)
            {
                TreeNode<T> node = stack.Pop();

                action(node.Data);

                if (node.Right != null)
                {
                    stack.Push(node.Right);
                }

                if (node.Left != null)
                {
                    stack.Push(node.Left);
                }
            }
        }

        public void GetAroundInDepthRecursively(TreeNode<T> node, Action<T> action)
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

        public void GetAroundInDepthRecursively(Action<T> action)
        {
            GetAroundInDepthRecursively(root, action);
        }

        private int GetComparisonResult(T item, TreeNode<T> node)
        {
            if (item == null)
            {
                if (node.Data == null)
                {
                    return 0;
                }

                return -1;
            }

            if (node.Data == null)
            {
                return 1;
            }

            IComparable<T> convertedItem = (IComparable<T>)item;

            return (comparer != null) ? comparer.Compare(item, node.Data) : convertedItem.CompareTo(node.Data);
        }
    }
}
