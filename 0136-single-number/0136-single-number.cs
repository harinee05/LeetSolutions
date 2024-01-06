public class Solution {
    public int SingleNumber(int[] nums) {
        int j=0;
        foreach(int k in nums){
            j = j^k;
        }
        return j;
    }
}