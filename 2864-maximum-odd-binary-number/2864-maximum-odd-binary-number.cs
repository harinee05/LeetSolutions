public class Solution {
    public string MaximumOddBinaryNumber(string s) {
               int cx = s.Count(c => c == '1');
        if (cx == 0)
        {
            return new string('0', s.Length);
        }

        return new string('1', cx - 1) + new string('0', s.Length - cx) + new string('1', 1);

    }
}