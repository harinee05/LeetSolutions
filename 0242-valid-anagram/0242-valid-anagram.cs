public class Solution {
    public bool IsAnagram(string s, string t) {
        s = String.Concat(s.OrderBy(c=>c));
        t = String.Concat(t.OrderBy(c=>c));
        return s==t;

    }
}