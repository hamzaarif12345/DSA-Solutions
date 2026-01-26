public class Solution {
    public IList<IList<int>> MinimumAbsDifference(int[] arr) {
        IList<IList<int>> ans = new List<IList<int>>();
        Array.Sort(arr);
        int min = int.MaxValue;
        for (int i = 1; i < arr.Length; i++) {
            min = Math.Min(min, arr[i] - arr[i - 1]);
        }
        for (int i = 1; i < arr.Length; i++) {
            if (arr[i] - arr[i - 1] == min) {
                ans.Add(new List<int> { arr[i - 1], arr[i] });
            }
        }
        return ans;
    }
}