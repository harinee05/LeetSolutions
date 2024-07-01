public class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {
       for (var i = 2; i < arr.Length; i++) {
            if ((arr[i] & arr[i - 1] & arr[i - 2] & 1) == 1) {
                return true;
            }
        }
        return false;
    }
}