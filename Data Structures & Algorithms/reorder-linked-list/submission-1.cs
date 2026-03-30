/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution
{
    private ListNode left;

    public void ReorderList(ListNode head)
    {
        if (head == null || head.next == null)
            return;

        // 1. Find middle
        ListNode slow = head;
        ListNode fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        // 2. Start left pointer from head
        left = head;

        // 3. Recurse from middle to end
        ReorderFromTail(slow);
    }

    private bool ReorderFromTail(ListNode right)
    {
        if (right == null)
            return true;

        if (!ReorderFromTail(right.next))
            return false;

        // Stop conditions:
        // 1) odd length: left == right
        // 2) even length: left.next == right
        if (left == right || left.next == right)
        {
            right.next = null;
            return false;
        }

        ListNode nextLeft = left.next;
        left.next = right;
        right.next = nextLeft;
        left = nextLeft;

        return true;
    }
}