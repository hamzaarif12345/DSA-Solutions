public class Solution
{
    public int MinimumDeletions(int[] nums)
    {
        int ans = int.MaxValue;
        int min = int.MaxValue;
        int max = int.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
            min = Math.Min(nums[i], min);
            max = Math.Max(nums[i], max);
        }

        int m1 = 0;
        int m2 = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == min)
                m1 = i;

            if (nums[i] == max)
                m2 = i;
        }

        int ans1 = Math.Max(m1, m2) + 1;

        int ans2 = m1 + 1 + (nums.Length - m2);

        int ans3 = m2 + 1 + (nums.Length - m1);

        int ans4 = nums.Length - Math.Min(m1, m2);

        ans = Math.Min(ans1,
                Math.Min(ans2,
                Math.Min(ans3, ans4)));

        return ans;
    }
}