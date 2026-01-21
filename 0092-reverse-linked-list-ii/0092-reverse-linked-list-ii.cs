public class Solution {
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        if (head == null || left == right) return head;
        
        // Create dummy node to handle edge case when left = 1
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        
        // Find the node before left position
        ListNode beforeLeft = dummy;
        for (int i = 1; i < left; i++) {
            beforeLeft = beforeLeft.next;
        }
        
        // Find the node at right position
        ListNode rightNode = beforeLeft;
        for (int i = left; i <= right; i++) {
            rightNode = rightNode.next;
        }
        
        // Nodes after the right position
        ListNode afterRight = rightNode.next;
        
        // Stack to reverse nodes between left and right
        Stack<ListNode> stack = new Stack<ListNode>();
        ListNode current = beforeLeft.next;
        
        // Push all nodes from left to right onto stack
        while (current != afterRight) {
            stack.Push(current);
            current = current.next;
        }
        
        // Pop from stack to reverse order
        current = beforeLeft;
        while (stack.Count > 0) {
            current.next = stack.Pop();
            current = current.next;
        }
        
        // Connect the reversed part to the rest of the list
        current.next = afterRight;
        
        return dummy.next;
    }
}