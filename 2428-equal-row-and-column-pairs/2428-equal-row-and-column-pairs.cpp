class Solution {
public:
    int equalPairs(vector<vector<int>>& grid) {
        // unordered_map<string,int> m1, m2;
        vector<string> v1,v2;
        int ans=0;
        for(auto a : grid){
            string s="";
            for(auto b : a){
                s= s+ to_string(b)+" ";
            }
            v1.push_back(s);
            
        }
        for(int i=0;i<grid.size();i++){
            string s="";
            for(int j=0;j<grid.size(); j++){
                s= s+ to_string(grid[j][i]) + " ";
            }
            v2.push_back(s);
        }

        for(auto a : v1){
            for(auto b : v2) {
                if(a == b) ans++;
            }
        }
        return ans;
    }
};