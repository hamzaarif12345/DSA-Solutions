public class Solution {
    public List<int> maxOfSubarrays(int[] arr, int k)
{
    List<int> ans = new List<int>();

    if (arr == null || arr.Length == 0 || k <= 0)
        return ans;

    int n = arr.Length;
    int max = int.MinValue;

    // 1️⃣ Find max of first window
    for (int i = 0; i < k; i++)
    {
        max = Math.Max(max, arr[i]);
    }

    ans.Add(max);

    for (int i = k; i < n; i++)
    {
        // Case 1: new element is greater than current max
        if (arr[i] >= max)
        {
            max = arr[i];
        }
        // Case 2: outgoing element was the max → recompute
        else if (arr[i - k] == max)
        {
            max = int.MinValue;
            for (int j = i - k + 1; j <= i; j++)
            {
                max = Math.Max(max, arr[j]);
            }
        }
        // Case 3: max remains unchanged

        ans.Add(max);
    }

    return ans;
}


}
