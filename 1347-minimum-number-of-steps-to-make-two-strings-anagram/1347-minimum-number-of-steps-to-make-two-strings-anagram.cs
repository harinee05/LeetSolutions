public class Solution {
   public int MinSteps(string s, string t) {
       Dictionary<char, int> sMap = new Dictionary<char, int>();
       Dictionary<char, int> tMap = new Dictionary<char, int>();
       
       foreach (var c in s) {
           if (!sMap.ContainsKey(c)) {
               sMap[c] = 0;
           }
           sMap[c]++;
       }
       
       foreach (var c in t) {
           if (!tMap.ContainsKey(c)) {
               tMap[c] = 0;
           }
           tMap[c]++;
       }
       
       int count = 0;
       foreach (var key in sMap.Keys) {
           if (tMap.ContainsKey(key)) {
               count += Math.Abs(sMap[key] - tMap[key]);
           } else {
               count += sMap[key];
           }
       }
       
       foreach (var key in tMap.Keys) {
           if (!sMap.ContainsKey(key)) {
               count += tMap[key];
           }
       }
       
       return count / 2; // divide by 2 because each operation counts twice
   }
}