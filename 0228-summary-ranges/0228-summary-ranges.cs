public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        IList<string> ranges = new List<string>();
        if (nums.Length == 0) return ranges;

        int start = nums[0];
        int end = nums[0];

        for (int i = 1; i <= nums.Length; i++) {
            if (i == nums.Length || nums[i] != end + 1) {
                AddRange(ranges, start, end);
                if (i < nums.Length) {
                    start = nums[i];
                    end = nums[i];
                }
            } else {
                end++;
            }
        }

        return ranges;
    }

    private void AddRange(IList<string> ranges, int start, int end) {
        if (start == end) {
            ranges.Add(start.ToString());
        } else {
            ranges.Add($"{start}->{end}");
        }
    }
}
