public class LinkedL {
    public int val;
    public LinkedL next;

    public LinkedL(int val) {
        this.val = val;
    }
}

public class MinStack {
    LinkedL l;

    public MinStack() {
        
    }
    
    public void Push(int val) {
        LinkedL temp = new LinkedL(val);
        temp.next = l;
        l = temp;
    }
    
    public void Pop() {
        if (l != null) {
            l = l.next;
        }
    }
    
    public int Top() {
        if (l != null) {
            return l.val;
        }

        return -1;
    }
    
    public int GetMin() {
        int min = int.MaxValue;
        LinkedL temp = l;

        while (temp != null) {
            if (temp.val < min) {
                min = temp.val;
            }
            temp = temp.next;
        }

        return min;
    }
}
