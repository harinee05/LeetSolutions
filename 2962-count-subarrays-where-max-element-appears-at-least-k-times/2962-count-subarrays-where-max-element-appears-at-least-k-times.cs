public class Solution {
    public long CountSubarrays(int[] nums, int k) {
       int max = (int)nums[0];
foreach (int value in nums) 
{
  if (value > max) 
  max = (int)value;
}
        int kCount=0;
        long subCount =0;
        int start=0;
        for(int e=0;e<nums.Length;e++){
            if(nums[e]==max){
                kCount++;
            }
            while(kCount==k){
                if(nums[start]==max){
                    kCount--;
                }
                start++;
            }
            subCount+=start;
        }
        return subCount;
    }
}
