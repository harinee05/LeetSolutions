public class Solution {
    public int ClimbStairs(int n) {
        if(n==2)
        return 2;
        if(n==1)
        return 1;
        int[] stair = new int[n+1];
        stair[0] = 1;
        stair[1] = 2;
        for(int i=2;i<n;i++){
            stair[i] = stair[i-2]+stair[i-1];
            Console.WriteLine(stair[i]);
        }
        return stair[n-1];
    }
}



