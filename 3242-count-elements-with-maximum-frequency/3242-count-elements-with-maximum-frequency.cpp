class Solution {
public:
    int maxFrequencyElements(vector<int>& nums) {
        unordered_map<int,int> m;
        for(auto a: nums ) m[a]++;
        int max =0;
        for( auto a: m) {if(a.second > max) max=a.second;}
        int ans=0;
        for(auto a: m){
            if(a.second==max) ans += max;
        }
        return ans;

    }
};