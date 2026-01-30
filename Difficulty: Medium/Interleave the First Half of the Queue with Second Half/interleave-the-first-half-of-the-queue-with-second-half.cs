public class Solution {
    public void rearrangeQueue(Queue<int> q) {
        int n = q.Count;
        if (n % 2 != 0) return; // Handle odd length if needed
        
        // Create new queues
        Queue<int> q1 = new Queue<int>();
        Queue<int> q2 = new Queue<int>();
        
        // First half to q1
        for (int i = 0; i < n / 2; i++) {
            q1.Enqueue(q.Dequeue());
        }
        
        // Second half to q2
        for (int i = 0; i < n / 2; i++) {
            q2.Enqueue(q.Dequeue());
        }
        
        // Interleave elements
        for (int i = 0; i < n / 2; i++) {
            q.Enqueue(q1.Dequeue());
            q.Enqueue(q2.Dequeue());
        }
    }
}