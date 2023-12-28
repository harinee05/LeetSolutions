public class Solution {
    public int SumOfDigits(int[] nums) {
         int sum = 0;
        int min = nums.Min();

        do
        {
            sum += min % 10;
            min /= 10;
        } while (min > 0);

        return sum % 2 == 0 ? 1 : 0;
    }
}