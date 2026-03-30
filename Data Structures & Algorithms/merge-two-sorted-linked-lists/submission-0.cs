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
 
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode head;
        if (list1 != null && list1?.value <= list2?.value) {
            head = list1;
            list1 = list1.next;
        } else {
            head = list2;
            list2 = list2.next;
        }
        ListNode nextNode = head;
        while (list1 != null && list2 != null) {
            if (list1 == null || list1?.value <= list2?.value)
            {
                nextNode.next = list2;
                list2 = list2.next;
            }
            else if (list2 == null)
            {
                nextNode.next = list1;
                list1 = list1.next;
            }
        }
        return head;
    }
}