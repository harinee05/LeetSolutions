public class Solution {
    public int[] FrequencySort(int[] nums) {
     return nums
            .GroupBy(x => x) // Group by value
            .OrderBy(group => group.Count()) // Order by frequency
            .ThenByDescending(group => group.Key) // Then by value in descending order
            .SelectMany(group => group).ToArray(); // Flatten the groups
    }
}