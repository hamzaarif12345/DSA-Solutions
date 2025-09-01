class Solution {
public:
    int sumOfModes(vector<int>& arr, int k) {
        unordered_map<int,int> m;
        int mo = INT_MAX;

        auto mode = [&]() {
            for (auto &a : m) {
                if (mo == INT_MAX || 
                    a.second > m[mo] || 
                    (a.second == m[mo] && a.first < mo)) {
                    mo = a.first;
                }
            }
        };

        int sum = 0;
        int i = 0, j = k;

        // first window
        for (int i1 = 0; i1 < k; i1++) {
            m[arr[i1]]++;
        }
        mode();
        sum += mo;

        // sliding window
        while (j < arr.size()) {
            m[arr[i]]--;  // remove left
            if (m[arr[i]] == 0) m.erase(arr[i]);
            i++;

            m[arr[j]]++;  // add right
            j++;

            // check if current mode is still valid
            if (mo == INT_MAX || !m.count(mo) || 
                m[arr[j-1]] >= m[mo] || arr[i-1] == mo) {
                mo = INT_MAX;   // force recomputation
                mode();
            }

            sum += mo;
        }

        return sum;
    }
};
