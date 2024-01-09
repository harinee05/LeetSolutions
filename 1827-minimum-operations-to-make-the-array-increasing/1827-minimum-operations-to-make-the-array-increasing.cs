public class Solution {
    public int MinOperations(int[] nums) {
        int sums = 0;
        for(int i=0;i<nums.Length-1;i++){
            if(nums[i]< nums[i+1]){
                continue;
            }
            else{
                
                sums+=nums[i]+1- nums[i+1];
                nums[i+1] = nums[i]+1;
            }
        }
        return sums;
    }
}