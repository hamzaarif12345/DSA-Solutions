public class Solution {
    public int MinMoves2(int[] nums) {
        Array.Sort(nums);
        int ans =0;
        int l = nums.Length/2;
        foreach(int a in nums){
            ans+= Math.Abs(a-nums[l]);
        }
        return ans;
    }
}