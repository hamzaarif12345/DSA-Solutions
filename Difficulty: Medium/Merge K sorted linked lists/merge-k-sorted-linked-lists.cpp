/*
class Node {
  public:
    int data;
    Node* next;

    Node(int x){
        data = x;
        next = NULL;
    }
};
*/

class Solution {
  public:
    Node* mergeKLists(vector<Node*>& arr) {
        // code here
        vector<int> v;
        for(auto a: arr){
            Node * temp =a;
            while(temp != nullptr){
                v.push_back(temp->data);
                temp=temp->next;
            }
            
        }
        sort(v.begin(),v.end());
        Node * t = new Node(v[0]);
        Node * h=t;
        for(int i=1;i<v.size();i++){
            Node *t2 = new Node(v[i]);
            t->next=t2;
            t=t->next;
        }
        return h;
    }
};