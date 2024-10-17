public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double maxAvg = double.MinValue; // Initialize to the smallest possible value
        double currentSum = 0;

        // Calculate the sum of the first 'k' elements
        for (int i = 0; i < k; i++) {
            currentSum += nums[i];
        }
        
        maxAvg = currentSum / k; // Calculate the average of the first 'k' elements

        // Slide the window over the rest of the array
        for (int i = k; i < nums.Length; i++) {
            currentSum += nums[i] - nums[i - k]; // Update the sum by adding the new element and removing the oldest
            double currentAvg = currentSum / k; // Calculate the new average
            maxAvg = Math.Max(maxAvg, currentAvg); // Update maxAvg if the current average is greater
        }

        return maxAvg; // Return the maximum average found
    }
}
