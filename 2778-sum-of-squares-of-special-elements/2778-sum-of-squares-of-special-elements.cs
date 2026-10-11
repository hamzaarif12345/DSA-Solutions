public class Solution {
    public int SumOfSquares(int[] nums) {
        int ans =0;
        int l = nums.Length;
        for(int i =0;i < l; i++){
            if(l%(i+1) == 0) ans+=nums[i]*nums[i];
        }return ans;
    }
}