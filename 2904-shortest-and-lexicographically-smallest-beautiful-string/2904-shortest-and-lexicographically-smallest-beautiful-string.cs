public class Solution {
    public string ShortestBeautifulSubstring(string s, int k) {
        int len = s.Length;
        int x = 0, y = 0;
        int c = 0;
        string ans = "";
        
        while(y < len) {
            // Count '1' characters (compare with character '1', not integer 1)
            if (s[y] == '1') c++;
            
            // When we have k ones, try to shrink the window
            while(c >= k) {
                string current = s.Substring(x, y - x + 1);
                
                // Update answer if it's empty, or current is shorter, or same length but lexicographically smaller
                if (ans == "" || current.Length < ans.Length || 
                    (current.Length == ans.Length && current.CompareTo(ans) < 0)) {
                    ans = current;
                }
                
                // Shrink window from left
                if(s[x] == '1') c--;
                x++;
            }
            
            y++;
        }
        
        return ans;
    }
}