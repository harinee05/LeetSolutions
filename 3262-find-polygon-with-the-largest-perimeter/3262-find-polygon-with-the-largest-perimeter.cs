public class Solution {
    public long LargestPerimeter(int[] nums) {
        Array.Sort(nums);
        long finalSum = 0;
        long ans =-1;
        foreach( int i in nums){
            if(i < finalSum){
                ans=i +finalSum;
            }
            finalSum += i;
        }
        return ans;
    }
}