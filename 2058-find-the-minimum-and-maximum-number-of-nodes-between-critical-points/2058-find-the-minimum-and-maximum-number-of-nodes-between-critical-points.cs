public class Solution {
    public int[] NodesBetweenCriticalPoints(ListNode head) {
        int[] ans = { -1, -1 };
        List<int> l = new List<int>();

        ListNode prev = head;
        ListNode temp = head.next;
        int a = 1;

        while (temp != null && temp.next != null) {
            if ((temp.val > prev.val && temp.val > temp.next.val) ||
                (temp.val < prev.val && temp.val < temp.next.val)) {
                l.Add(a);
            }

            prev = temp;
            temp = temp.next;
            a++;
        }

        if (l.Count < 2)
            return ans;

        int min = int.MaxValue;

        for (int i = 1; i < l.Count; i++) {
            min = Math.Min(min, l[i] - l[i - 1]);
        }

        int max = l[l.Count - 1] - l[0];

        ans[0] = min;
        ans[1] = max;

        return ans;
    }
}