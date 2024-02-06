public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var res = new Dictionary<string, List<string>>();
        
        foreach (string word in strs) {
            string key = String.Concat(word.OrderBy(c => c));
            Console.Write(key);
            if (!res.ContainsKey(key)) {
                res[key] = new List<string>();
            }
            res[key].Add(word);
        }
        
        return res.Values.ToList<IList<string>>();
    }
}