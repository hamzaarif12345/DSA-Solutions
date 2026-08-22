public class Solution {
    public bool CheckDivisibility(int n) {
        int sod = 0;
        int pod = 1;
        int m = n;
        while(m > 0){
            sod+=m%10;
            pod*=m%10;
            m/=10;
        }
        return (n%(sod + pod) == 0);
    }
}