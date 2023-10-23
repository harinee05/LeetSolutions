public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int l=0,r=0,m=0;
        var final = new HashSet<char>();
        while(r<s.Length){

            if(!final.Contains(s[r])){
                final.Add(s[r]);
                r++; 
                m = Math.Max(m,final.Count);
            }
            else{
                final.Remove(s[l]);
                l++;
            }
        }
        return m;
    }
}