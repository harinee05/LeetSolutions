public class Solution {
    public int Jump(int[] nums) {
        int jumps=0;
        int far=0,currentEnd=0;
        for(int i=0;i<nums.Length-1;i++){
            far = Math.Max(far,i+nums[i]);
            if(i==currentEnd){
                jumps++;
                currentEnd = far;
            }
        }
        return jumps;
    }
}