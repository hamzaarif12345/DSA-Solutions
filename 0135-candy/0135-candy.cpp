class Solution {
public:
    int candy(vector<int>& ratings) {
        int ans=0;
        vector<int> v (ratings.size(),1);
        //v[0]=1;
        for(int i=1;i<ratings.size();i++){
            if(ratings[i] > ratings[i-1] && (v[i]==v[i-1] || v[i] < v[i-1])) v[i]=v[i-1]+1;
        }
        //v.back();
        for(int i=ratings.size()-1;i > 0 ; i--){
            if(ratings[i-1] > ratings[i] && (v[i-1]==v[i] || v[i-1] < v[i])) v[i-1]=v[i]+1;
        }
        for(auto a: v) ans+=a;
        return ans;
    }
};