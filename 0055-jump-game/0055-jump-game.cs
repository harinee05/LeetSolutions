public class Solution {
    public bool CanJump(int[] nums) {
        if (nums.Length == 0) return false; // Edge case for empty array
        if (nums.Length == 1) return true; // If there's only one element, we can "jump" to the end

        int curFar = 0;
        for (int i = 0; i < nums.Length - 1; i++) {
            if (i > curFar) return false; // If we can't reach this index, return false
            curFar = Math.Max(curFar, i + nums[i]); // Update the furthest we can reach
            if (curFar >= nums.Length - 1) return true; // If we can reach or exceed the last index, return true
        }
        return false; // If we finish the loop without being able to reach the end
    }
}
