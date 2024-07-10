public class Solution {
    public int[] RearrangeArray(int[] nums) {
       var positives = nums.Where(n => n > 0).ToArray();
        var negatives = nums.Where(n => n < 0).ToArray();

        // Combine positive and negative numbers, alternating between them
        int[] result = positives.Zip(negatives, (p, n) => new { p, n })
                                .SelectMany(x => new[] { x.p, x.n })
                                .ToArray();

        // Handle cases where the number of positives or negatives is odd
        if (positives.Length % 2 != 0) {
            result = result.Concat(positives.Skip(result.Length)).ToArray();
        }
        if (negatives.Length % 2 != 0) {
            result = result.Concat(negatives.Skip(result.Length)).ToArray();
        }

        return result;
    }
}