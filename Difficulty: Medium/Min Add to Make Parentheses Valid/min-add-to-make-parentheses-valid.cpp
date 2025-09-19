class Solution {
  public:
    int minParentheses(string& s) {
        // code here
        stack<char> st;
        for(auto a : s){
            if(st.empty()) st.push(a);
            else if (st.top() == '(' && a == ')') st.pop();
            else st.push(a);
        }
        return st.size();
    }
};