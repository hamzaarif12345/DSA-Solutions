class Solution {
  public:
    int assignHole(vector<int>& mices, vector<int>& holes) {
        // code here
        sort(mices.begin(),mices.end());
        sort(holes.begin(),holes.end());
        int ans=0;
        for(int i =0;i<holes.size();i++){
            ans = max(ans,abs(holes[i]-mices[i]));
        }
        return ans;
    }
};