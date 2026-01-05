class Solution {
    public int maxSubarraySum(int[] arr, int k) {
        // Code here
        //int ans = int.MinValue;
        int ans;
        int sum =0;
        for(int i=0;i<k;i++){
            sum+=arr[i];
        }
        ans=sum;
        for(int i=1;i<=arr.Length -k; i++){
            sum-=arr[i-1];
            sum+=arr[i+k-1];
            ans= Math.Max(ans,sum);
        }
        return ans;
    }
}