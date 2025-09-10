class Solution {
  public:
    string largestSwap(string &s) {
    int n = s.size();
    int p = 0;

    while (p < n) {
        // find the max digit on the right of p
        char m = s[p];
        int index = p;
        for (int i = p + 1; i < n; i++) {
            if (s[i] >= m) {  // >= ensures we pick the last occurrence
                m = s[i];
                index = i;
            }
        }

        // if right-side max is bigger, swap and break
        if (s[p] < m) {
            swap(s[p], s[index]);
            break;
        }
        p++;
    }

    return s;
}





};