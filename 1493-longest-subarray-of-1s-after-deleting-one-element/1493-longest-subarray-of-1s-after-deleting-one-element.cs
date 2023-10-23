public class Solution {
    public int LongestSubarray(int[] nums) {
    int maxLen = 0; // Initialize the maximum length of the subarray.
    int left = 0; // Initialize the left pointer.
    bool allowDeletion = true; // Initialize a flag to allow one deletion.

    for (int right = 0; right < nums.Length; right++) {
        if (nums[right] == 0) {
            if (allowDeletion) {
                allowDeletion = false; // Disallow further deletions.
            } else {
                while (nums[left] == 1) {
                    left++; // Move the left pointer past the first 0.
                }
                left++; // Move the left pointer past the first 0 (one allowed deletion).
            }
        }

        // Update the maximum length of the subarray.
        maxLen = Math.Max(maxLen, right - left + 1);
    }

    return maxLen-1;
}
    }
    