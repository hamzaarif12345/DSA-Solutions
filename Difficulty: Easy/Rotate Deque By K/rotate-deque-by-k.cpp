class Solution {
  public:
    void rotateDeque(deque<int>& dq, int type, int k) {
        // code here
        if(type == 1){
            while(k--){
                int a = dq.back();
                dq.pop_back();
                dq.push_front(a);
            }
        }
        else {
            while(k--){
                int a = dq.front();
                dq.pop_front();
                dq.push_back(a);
            }
        }
    }
};