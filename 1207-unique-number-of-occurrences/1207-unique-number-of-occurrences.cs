public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int, int> occurrences = new Dictionary<int, int>();

        foreach (var num in arr) {
            if (occurrences.ContainsKey(num)) {
                occurrences[num]++;
            } else {
                occurrences[num] = 1;
            }
        }

        HashSet<int> uniqueOccurrences = new HashSet<int>(occurrences.Values);

        return occurrences.Count == uniqueOccurrences.Count;
    }
}
