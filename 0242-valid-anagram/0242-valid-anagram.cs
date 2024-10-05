public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in s) {
            if (charCount.ContainsKey(c)) {
                charCount[c]++;
            } else {
                charCount[c] = 1;
            }
        }

        foreach (char c in t) {
            if (!charCount.ContainsKey(c)) {
                return false; // Character in t not in s
            }
            charCount[c]--;
            if (charCount[c] < 0) {
                return false; // More occurrences in t than in s
            }
        }

        return true; // All counts should be zero if they are anagrams
    }
}
