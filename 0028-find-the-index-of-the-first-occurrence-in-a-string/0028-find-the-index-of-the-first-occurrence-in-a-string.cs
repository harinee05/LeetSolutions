public class Solution {
   public int StrStr(string haystack, string needle) {
       int m = needle.Length;
       int n = haystack.Length;
       if (m > n) {
           return -1;
       }
       for (int i = 0; i <= n - m; i++) {
           if (needle == haystack.Substring(i, m)) {
               return i;
           }
       }
       return -1;
   }
}
