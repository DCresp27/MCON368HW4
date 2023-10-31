namespace HW4;

public class CCListNode
{
    public int Value;
    public CCListNode Next;

    public CCListNode(int value)
    {
        Value = value;
        Next = null;
    }
}

public class CircularLinkedList
{
    private CCListNode Sentinel;

    public CircularLinkedList()
    {
        Sentinel = new CCListNode(-1); // Create a sentinel node with a dummy value
        Sentinel.Next = Sentinel;    // Point the sentinel node to itself to indicate an empty list
    }

    public void Add(int value)
    {
        CCListNode newNode = new CCListNode(value);

        // Find the last node and adjust pointers to insert the new node
        CCListNode last = GetLastNode();
        newNode.Next = Sentinel;
        last.Next = newNode;
    }

    private CCListNode GetLastNode()
    {
        CCListNode current = Sentinel;
        while (current.Next != Sentinel)
        {
            current = current.Next;
        }
        return current;
    }

    public int Size()
    {
        return SizeRecursive(Sentinel.Next);
    }

    private int SizeRecursive(CCListNode current)
    {
        if (current == Sentinel)
        {
            return 0; // Base case: Reached the sentinel node, indicating end of list
        }
        else
        {
            return 1 + SizeRecursive(current.Next);
        }
    }
}