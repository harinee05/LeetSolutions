public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int x = 0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i] != val){
                nums[x] = nums[i];
                x++;
            }
        }
        return x;
    }
}