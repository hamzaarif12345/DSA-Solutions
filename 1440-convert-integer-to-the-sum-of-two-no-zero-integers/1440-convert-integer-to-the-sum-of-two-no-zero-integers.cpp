class Solution {
public:
    bool nz(int a){
        string s=to_string(a);
        for(auto a: s) if(a == '0') return false;
        return true;
    }
    vector<int> getNoZeroIntegers(int n) {
        if(n==2) return {1,1};
        int j=2;
        while(j < n){
            if(nz(j) && nz(n-j)) return {j,(n-j)};
            j++;

        }
        return {-1,-1};
    }
};