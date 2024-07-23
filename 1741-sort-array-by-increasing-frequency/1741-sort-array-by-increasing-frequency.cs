public class Solution {
    public int[] FrequencySort(int[] nums) {
     var result = nums
            .GroupBy(x => x) // Group by value
            .OrderBy(group => group.Count()) // Order by frequency
            .ThenByDescending(group => group.Key) // Then by value in descending order
            .SelectMany(group => group); // Flatten the groups

        // Convert to array and return
        return result.ToArray();
    }
}