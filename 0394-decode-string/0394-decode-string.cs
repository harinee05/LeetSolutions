using System.Text.RegularExpressions;
public class Solution {
    public string DecodeString(string s) {
        string regex = @"(?'count'\d+)\[(?'str'\w+)\]";
        string rs = Regex.Replace(s, regex, 
			m => string.Concat(Enumerable.Repeat(m.Groups["str"].Value, int.Parse(m.Groups["count"].Value))));
        return (Regex.IsMatch(rs, regex)) ? DecodeString(rs) : rs;
    }
}