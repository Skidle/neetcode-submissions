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
    public ListNode ReverseList(ListNode head) {
        ListNode current = head;
        ListNode nextPointer = current == null ? null : current.next;
        ListNode prevPointer = null;

        while (current != null)
        {
            nextPointer = current.next;
            current.next = prevPointer;

            //

            prevPointer = current;
            current = nextPointer;
        }

        return prevPointer;
    }
}
