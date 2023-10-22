public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];
            int temp = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = temp;
                temp *= nums[i];
            }
        
            temp = 1;
            for (int i = result.Length - 1; i >= 0; i--)
            {
                result[i] =result[i]*    temp;
                temp *= nums[i];
            }

            return result;
    }
}