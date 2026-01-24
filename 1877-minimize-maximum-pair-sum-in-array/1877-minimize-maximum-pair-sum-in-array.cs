public class Solution {
    public int MinPairSum(int[] nums) {
        // In-place sort (quicksort/intsort hybrid)
        Array.Sort(nums);
        
        int maxPairSum = int.MinValue;
        int n = nums.Length;
        
        // Loop optimized: calculate only half the pairs
        int half = n >> 1; // Bitwise division by 2
        
        // Unroll loop for better performance on modern CPUs
        for (int i = 0; i < half; i++) {
            int pairSum = nums[i] + nums[n - 1 - i];
            if (pairSum > maxPairSum) {
                maxPairSum = pairSum;
            }
        }
        
        return maxPairSum;
    }
}