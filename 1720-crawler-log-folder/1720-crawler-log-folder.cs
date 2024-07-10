public class Solution {
    public int MinOperations(string[] logs) {
        int c=0;
        foreach(string s in logs){
            if(s.Contains("../")){
                c--;
                if(c<0) c=0;
            }
            if(s.Contains("./")) continue;
            else
            c++;
        }
        
        return c;
    }
}