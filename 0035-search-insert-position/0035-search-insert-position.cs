public class Solution {
    public int SearchInsert(int[] nums, int target) {
        return SearchInsertHelper(nums, target, 0, nums.Length - 1);
    }

    private int SearchInsertHelper(int[] nums, int target, int left, int right) {
        if (left > right) {
            return left; // This is the insertion point
        }

        int mid = left + (right - left) / 2;

        if (nums[mid] == target) {
            return mid; // Target found
        } else if (nums[mid] < target) {
            return SearchInsertHelper(nums, target, mid + 1, right); // Search right half
        } else {
            return SearchInsertHelper(nums, target, left, mid - 1); // Search left half
        }
    }
}
