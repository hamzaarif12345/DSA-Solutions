class Solution {
    public int findKRotation(int[] arr) {
        // code here
        int[] arr2 = (int[])arr.Clone();

        Array.Sort(arr2);
        int a = arr2[0];
        int j = 0;
        for(int i =0;i<arr.Length;i++){
            if(arr[i] == a){ j = i; break;}
        }
        return j;
    }
}
