public class Solution {
    public int LongestBalanced(string s) {
        if (string.IsNullOrEmpty(s)) return 0;
        
        int maxLength = 0;
        
        // Try all substrings
        for (int i = 0; i < s.Length; i++) {
            Dictionary<char, int> freq = new Dictionary<char, int>();
            
            for (int j = i; j < s.Length; j++) {
                // Add current character to frequency map
                char current = s[j];
                if (freq.ContainsKey(current)) {
                    freq[current]++;
                } else {
                    freq.Add(current, 1);
                }
                
                // Check if all characters have same frequency
                if (freq.Count > 0) {
                    int firstCount = freq.Values.First();
                    bool allSame = freq.Values.All(count => count == firstCount);
                    
                    if (allSame) {
                        maxLength = Math.Max(maxLength, j - i + 1);
                    }
                }
            }
        }
        
        return maxLength;
    }
}