namespace HW4;

public class TreeSearch
{
    private class TreeNode
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
    
    private TreeNode Root;

    public TreeSearch()
    {
        Root = null;
    }

    public Boolean Search(int target)
    {
        TreeNode? resultNode =  SearchRecursive(Root, target);
        if (resultNode == null)
            return false;
        if (resultNode.Value.Equals(target))
            return false;
        return false;
    }

    private TreeNode? SearchRecursive(TreeNode? node, int target)
    {
        if (node == null)
        {
            return null;
        }

        if (node.Value == target)
        {
            return node;
        }

        TreeNode? leftResult = SearchRecursive(node.Left, target);
        TreeNode? rightResult = SearchRecursive(node.Right, target);

        return leftResult ?? rightResult;
    }
}