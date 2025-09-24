class SpecialQueue {
public:
    queue<int> q;          // To maintain normal queue order
    multiset<int> ms;      // To track min and max efficiently

    void enqueue(int x) {
        q.push(x);
        ms.insert(x);
    }

    void dequeue() {
        int a = q.front();
        q.pop();
        ms.erase(ms.find(a)); // Erase only one occurrence
    }

    int getFront() {
        return q.front();
    }

    int getMin() {
        return *ms.begin(); // First element = smallest
    }

    int getMax() {
        return *prev(ms.end()); // Last element = largest
        // or: return *--ms.end();
    }
};
