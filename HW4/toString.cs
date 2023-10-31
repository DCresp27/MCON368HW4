namespace HW4;

public partial class ListNode
{
    public int? Value;
    public ListNode? Next;

    public ListNode(int value)
    {
        Value = value;
        Next = null;
    }
}

public class LinkedList
{
    private ListNode Head;

    public LinkedList(ListNode node)
    {
        Head = node;
    }
    
    public override string? ToString()
    {
        return ToStringRecursive(Head);
    }

    private string? ToStringRecursive(ListNode current)
    {
        if (current.Next == null)
        {
            return current.Value.ToString(); // Base case: the last element in the list
        }
        else
        {
            return current.Value + " -> " + ToStringRecursive(current.Next);
        }
    }
}
