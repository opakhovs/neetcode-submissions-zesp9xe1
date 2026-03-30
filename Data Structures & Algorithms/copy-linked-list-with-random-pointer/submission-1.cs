/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if (head == null) {
            return head;
        }
        Dictionary<Node, int> oldNodes = new Dictionary<Node, int>();
        Dictionary<int, Node> newNodes = new Dictionary<int, Node>();
        int index = 0;

        Node temp = head;
        while (temp != null) {
            oldNodes[temp] = index;
            newNodes[index] = new Node(temp.val);
            temp = temp.next;
            index++;
        }

        Node newHead = newNodes[0];
        while (head != null) {
            int nodeIndex = oldNodes[head];
            Node newTemp = newNodes[nodeIndex];
            if (head.next != null) {
                int nextIndex = oldNodes[head.next];
                newTemp.next = newNodes[nextIndex];
            }
            if (head.random != null) {
                int randomIndex = oldNodes[head.random];
                newTemp.random = newNodes[randomIndex];
            }

            head = head.next;
        }
        
        return newHead;
    }
}
