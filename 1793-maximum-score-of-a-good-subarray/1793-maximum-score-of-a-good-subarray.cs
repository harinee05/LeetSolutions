public class Solution {
    public int MaximumScore(int[] nums, int k) {
        int i=k;
        int l=nums[k],z=l;
        int j=k;
        while(i > 0 || j < nums.Length-1){
            if(i == 0 ||( j < nums.Length-1 && nums[i-1] <= nums[j+1])){
                j++;
            }
            else i--;
            l = Math.Min(l,Math.Min(nums[i],nums[j]));
            z = Math.Max(z,(j-i+1)*l);
        }
        
        return z;
    }
}