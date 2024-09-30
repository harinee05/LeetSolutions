public class Solution {
    public int ClimbStairs(int n) {
        if(n==2)
        return 2;
        if(n==1)
        return 1;
       int prev=2, bef_prev = 1;
       int stair = 0;
        for(int i=2;i<n;i++){
            stair = prev + bef_prev;
            bef_prev = prev;
            prev = stair;

        }
        return stair;
    }
}



