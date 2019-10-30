namespace MyTree
{
    class TreeNode<T>
    {
        public TreeNode(T data)
        {
            Data = data;
        }

        public TreeNode(T data, TreeNode<T> left, TreeNode<T> right)
        {
            Data = data;
            Left = left;
            Right = right;
        }

        public T Data { get; set; }

        public TreeNode<T> Left { get; set; }

        public TreeNode<T> Right { get; set; }
    }
}
