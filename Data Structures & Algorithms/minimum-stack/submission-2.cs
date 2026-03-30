public class LinkedL
{
    public int val;
    public int minSoFar;
    public LinkedL next;

    public LinkedL(int val, int minSoFar)
    {
        this.val = val;
        this.minSoFar = minSoFar;
    }
}

public class MinStack
{
    private LinkedL head;

    public MinStack()
    {
    }

    public void Push(int val)
    {
        if (head == null)
        {
            head = new LinkedL(val, val);
        }
        else
        {
            LinkedL node = new LinkedL(val, Math.Min(val, head.minSoFar));
            node.next = head;
            head = node;
        }
    }

    public void Pop()
    {
        if (head != null)
        {
            head = head.next;
        }
    }

    public int Top()
    {
        if (head == null)
            return -1;

        return head.val;
    }

    public int GetMin()
    {
        if (head == null)
            return -1;

        return head.minSoFar;
    }
}