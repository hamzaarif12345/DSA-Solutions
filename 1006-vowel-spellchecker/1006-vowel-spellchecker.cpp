class Solution {
public:
    vector<string> spellchecker(vector<string>& wordlist, vector<string>& queries) {
        vector<string> ans;
        unordered_map<string, vector<string>> m;
        for(auto a: wordlist){
            string b = a;
            transform(b.begin(),b.end(), b.begin(), ::tolower);
            for(auto &c : b){
                if(c == 'a' || c=='e' || c=='i' || c=='o' || c=='u') c='*';
            }
            m[b].push_back(a);
        }
        for(auto a: queries){
            string b = a;
            transform(b.begin(),b.end(), b.begin(), ::tolower);
            for(auto &c : b){
                if(c == 'a' || c=='e' || c=='i' || c=='o' || c=='u') c='*';
            }
            //cout<<" "<< b;
            if(m.find(b) != m.end()){
                int size = ans.size();
                for(auto c: m[b]) {
                    if(c == a) {ans.push_back(a);break;}
                }
                if(size == ans.size()){
                    for(auto c: m[b]) {
                        string t1=a;
                        string t2=c;
                        transform(t1.begin(),t1.end(), t1.begin(), ::tolower);
                        transform(t2.begin(),t2.end(), t2.begin(), ::tolower);
                        if(t1 == t2) {ans.push_back(c); break;}
                    }
                }
                if(size == ans.size()){
                    ans.push_back(m[b][0]);
                }
            }
            else ans.push_back("");

        }
        return ans;

    }
};