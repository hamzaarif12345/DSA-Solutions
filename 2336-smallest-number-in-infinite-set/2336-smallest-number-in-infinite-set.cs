public class SmallestInfiniteSet {
    SortedSet<int> set;
    public SmallestInfiniteSet() {
        set = new SortedSet<int>();
        for(int i =1;i<1001;i++) set.Add(i);
    }
    
    public int PopSmallest() {
        int min = set.Min;
        set.Remove(min);
        return min;
    }
    
    public void AddBack(int num) {
        set.Add(num);
    }
}

/**
 * Your SmallestInfiniteSet object will be instantiated and called as such:
 * SmallestInfiniteSet obj = new SmallestInfiniteSet();
 * int param_1 = obj.PopSmallest();
 * obj.AddBack(num);
 */