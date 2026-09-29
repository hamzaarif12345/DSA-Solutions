public class Solution {
    public string Evaluate(string s, IList<IList<string>> knowledge) {

        string ans = "";

        Dictionary<string, string> d = new Dictionary<string, string>();

        // Store knowledge in dictionary
        for (int j = 0; j < knowledge.Count; j++) {
            d[knowledge[j][0]] = knowledge[j][1];
        }

        int i = 0;

        while (i < s.Length) {

            string temp = "";

            if (s[i] == '(') {

                i++;

                while (s[i] != ')') {
                    temp += s[i];
                    i++;
                }

                if (d.ContainsKey(temp))
                    ans += d[temp];
                else
                    ans += "?";

                i++;
            }
            else {
                ans += s[i];
                i++;
            }
        }

        return ans;
    }
}