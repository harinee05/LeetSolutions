public class Solution {
    public int ArrayPairSum(int[] nums) {
        Array.Sort(nums);
        int maxS=0;
        for(int i=0;i<nums.Length;i+=2){
            maxS+=nums[i];
        }
        return maxS;
    }
}