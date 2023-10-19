public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0) return "";

        string pref = strs[0];
        for (int i=1; i<strs.Length; i++)
        {
            while(strs[i].IndexOf(pref) != 0)
            {
                pref = pref[..^1];
                if (string.IsNullOrEmpty(pref)) return "";
            }
        }
        return pref;
    }
}