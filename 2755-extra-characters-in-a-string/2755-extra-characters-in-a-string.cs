public class Solution {
    public int MinExtraChar(string s, string[] dictionary) {
          HashSet<string> dictSet = new HashSet<string>(dictionary);
        int n = s.Length;
        int[] dp = new int[n + 1];
for (int i = 1; i <= n; i++) {
            dp[i] = i; 
            }// Maximum extra characters if no valid segmentation
        for (int i = 1; i <= n; i++) {
            // Check all substrings ending at i
            for (int j = 0; j < i; j++) {
                string substring = s.Substring(j, i - j);
                if (dictSet.Contains(substring)) {
                    dp[i] = Math.Min(dp[i], dp[j]); // No extra characters if substring is in dictionary
                }
            }
            // Update dp[i] for the case where we have an extra character
            dp[i] = Math.Min(dp[i], dp[i - 1] + 1);
        }

        return dp[n]; // Return the minimum extra characters for the whole string
    }

}