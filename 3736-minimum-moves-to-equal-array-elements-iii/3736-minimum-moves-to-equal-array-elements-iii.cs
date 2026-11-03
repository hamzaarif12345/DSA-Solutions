public class Solution {
    public int MinMoves(int[] nums) {
        int ans = 0;
        int max = nums[0];
        for(int i =1;i<nums.Length;i++) max = Math.Max(nums[i],max);
        foreach(int a in nums) ans+=(max-a);
        return ans;
    }
}