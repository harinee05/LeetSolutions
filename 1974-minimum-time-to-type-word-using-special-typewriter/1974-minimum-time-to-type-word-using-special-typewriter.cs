public class Solution {
    public int MinTimeToType(string s) {
    
       int s1 = Math.Abs((int)s[0] - (int)'a');
        int s2 = Math.Min(26-s1,s1);
        for(int i=1;i<s.Length;i++){
            s1=Math.Abs((int)s[i] - (int)s[i-1]);
            s2 += Math.Min(26-s1,s1);
            Console.WriteLine(s2);
        }
        return s2+s.Length;
    }
}