public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        HashSet<string> wordSet = new HashSet<string>(wordDict);   
        bool[] dp = new bool[s.Length + 1];
        dp[0] = true; // Empty string is always breakable

        for (int i = 1; i <= s.Length; i++) {
            for (int j = 0; j < i; j++) {
                if (dp[j] && wordSet.Contains(s.Substring(j, i - j))) {
                    dp[i] = true;
                    break; // No need to check further for this 'i'
                }
            }
        }

        return dp[s.Length]; // The last element indicates if the entire string is breakable
    }
}
