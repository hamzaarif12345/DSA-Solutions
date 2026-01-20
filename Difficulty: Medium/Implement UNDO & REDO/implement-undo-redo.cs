class Solution {
    StringBuilder s = new StringBuilder("");
    Stack<char> st = new Stack<char>(); 
    
    public void append(char x) {
        s.Append(x);
    }
    
    public void undo() {
        if (s.Length == 0) return;
        
        int l = s.Length;
        char lastChar = s[l - 1];
        st.Push(lastChar);        
        s.Remove(l - 1, 1);       
    }
    
    public void redo() {
        if (st.Count == 0) return;
        
        s.Append(st.Pop());
    }
    
    public string read() {
        return s.ToString();
    }
}