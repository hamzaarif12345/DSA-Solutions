class Solution {
public:
    int canBeTypedWords(string text, string brokenLetters) {
        string s = "";
        int ans = 1; // start with 1 word
        for(auto a : text){
            if(isspace(a)) {
                ans++;
                bool f=false;
                for(auto b : s){
                    for(auto c : brokenLetters) {
                        if(c == b) {f=true; break;} // break only if match found
                    }
                    if(f) break;
                }
                if(f) ans--;
                s="";
            } else {
                s += a;
            }
        }

        // process last word
        bool f=false;
        for(auto b : s){
            for(auto c : brokenLetters) {
                if(c == b) {f=true; break;}
            }
            if(f) break;
        }
        if(f) ans--;

        return ans;
    }
};
