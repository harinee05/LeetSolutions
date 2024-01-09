public class Solution {
    public int DifferenceOfSum(int[] nums) {
        
        int x=0,y=0;
        int z=0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]> 9 ){
                x = nums[i];
                z += nums[i];
                while(x>0){
                    y = (x%10)+y;
                    x=x/10;
                }
                
            }
        }
        return Math.Abs(y-z);
    }
}