

public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        var result = new List<int>();
        if (s.Length < p.Length) return result;

        var pCount = new Dictionary<char, int>();
        var sCount = new Dictionary<char, int>();

        // Count frequency of characters in p
        foreach (char c in p) {
            if (pCount.ContainsKey(c)) {
                pCount[c]++;
            } else {
                pCount[c] = 1;
            }
        }

        // Initialize the first window in s
        for (int i = 0; i < p.Length; i++) {
            if (sCount.ContainsKey(s[i])) {
                sCount[s[i]]++;
            } else {
                sCount[s[i]] = 1;
            }
        }

        // Check if the first window is an anagram
        if (AreDictionariesEqual(pCount, sCount)) {
            result.Add(0);
        }

        // Slide the window across s
        for (int i = p.Length; i < s.Length; i++) {
            // Add the next character in the window
            if (sCount.ContainsKey(s[i])) {
                sCount[s[i]]++;
            } else {
                sCount[s[i]] = 1;
            }

            // Remove the character going out of the window
            char outgoingChar = s[i - p.Length];
            if (sCount[outgoingChar] == 1) {
                sCount.Remove(outgoingChar);
            } else {
                sCount[outgoingChar]--;
            }

            // Check if the current window is an anagram
            if (AreDictionariesEqual(pCount, sCount)) {
                result.Add(i - p.Length + 1);
            }
        }

        return result;
    }

    private bool AreDictionariesEqual(Dictionary<char, int> dict1, Dictionary<char, int> dict2) {
        if (dict1.Count != dict2.Count) return false;

        foreach (var kvp in dict1) {
            if (!dict2.ContainsKey(kvp.Key) || dict2[kvp.Key] != kvp.Value) {
                return false;
            }
        }
        return true;
    }
}