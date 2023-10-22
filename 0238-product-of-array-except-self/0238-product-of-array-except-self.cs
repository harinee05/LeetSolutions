public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] res = new int[nums.Length];
            int t= 1;

            for (int i = 0; i < nums.Length; i++)
            {
                res[i] = t;
                t *= nums[i];
            }
        
            t = 1;
            for (int i = res.Length - 1; i >= 0; i--)
            {
                res[i] =res[i]*t;
                t*= nums[i];
            }

            return res;
    }
}