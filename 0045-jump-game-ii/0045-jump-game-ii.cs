public class Solution {
   public int Jump(int[] nums) {
       int jumps = 0, curEnd = 0, nextEnd = 0;
       
       for (int i = 0; i < nums.Length - 1; i++) {
           nextEnd = Math.Max(nextEnd, i + nums[i]);
           
           if (i == curEnd) {
               jumps++;
               curEnd = nextEnd;
           }
       }
       
       return jumps;
   }
}
