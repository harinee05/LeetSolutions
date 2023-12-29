public class Solution {
    public int MaximizeSum(int[] nums, int k) {
        int s=0;
        Array.Sort(nums);
        while(k>0){
            s+=nums[nums.Length-1];
            nums[nums.Length-1] = nums[nums.Length-1]+1;
            k--;
        }
        return s;
    }
}