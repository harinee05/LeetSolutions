public class Solution {
    public int NumKLenSubstrNoRepeats(string s, int m) {
        if(s==" " || s.Length<m){
            return 0;
        }
        int c=0;
        HashSet<char> k = new HashSet<char>();
        int i=0,j=0;
        while(j<s.Length){
            if(k.Contains(s[j])){
                k.Remove(s[i++]);
            }
            else{
                k.Add(s[j++]);
            }
            if(k.Count == m){
                c+=1;
                k.Remove(s[i++]);
            }
        }
        return c;
    }
}