public class ListNode {
    public int Key;
    public ListNode Next;

    public ListNode(int key) {
        Key = key;
        Next = null;
    }
}

public class MyHashSet {
    ListNode start;
    ListNode end;

    public MyHashSet() {
    }
    
    public void Add(int key) {
        if (start == null) {
            start = new ListNode(key);
            end = start;
        } else if (Contains(key) == false) {
            end.Next = new ListNode(key);
            end = end.Next;
        }
    }
    
    public void Remove(int key) {
        if (Contains(key)) {
            ListNode temp = start;
            if (temp.Key == key) {
                start = temp.Next;
                if (end == temp) {
                    end = start;
                }
            } else {
                while (temp != null && temp.Next.Key != key) {
                    temp = temp.Next;
                }
                if (temp != null) {
                    temp.Next = temp.Next.Next;
                }
            }
        }
    }
    
    public bool Contains(int key) {
        if (start == null) {
            return false;
        }
        ListNode temp = start;

        while (temp.Next != null) {
            if (temp.Key == key) {
                return true;
            }
            temp = temp.Next;
        }
        return temp.Key == key;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */