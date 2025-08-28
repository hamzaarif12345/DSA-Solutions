class Solution {
  public:
    int maxOnes(vector<int>& arr, int k) {
        // code here
        int c=0;
        int i=0; int j=0;
        int ans = 0;
        while(j < arr.size()){
            if(arr[j]==0) c++;
            while(c > k){
                if(arr[i]==0) c--;
                i++;
            }
            j++;
            ans=max(ans,j-i);
        }return ans;
    }
};
