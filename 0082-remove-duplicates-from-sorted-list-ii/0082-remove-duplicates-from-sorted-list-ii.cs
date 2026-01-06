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
    public ListNode DeleteDuplicates(ListNode head) {
        if (head == null) return null;

        ListNode dummy = new ListNode(0);
        ListNode l1 = dummy;
        ListNode temp = head;

        while (temp != null) {
            if (temp.next != null && temp.val == temp.next.val) {
                while (temp.next != null && temp.val == temp.next.val)
                    temp = temp.next;

                temp = temp.next; 
            } 
            else {
                l1.next = temp;
                l1 = l1.next;
                temp = temp.next;
                l1.next = null; 
            }
        }
        return dummy.next;
    }
}
