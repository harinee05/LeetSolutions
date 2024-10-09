public class Solution {
    public int MinSwaps(string s) {
        int open=0,close=0;
        if(s=="" || s=="[]")
            return 0;
        for(int i=0;i<s.Length;i++){
            if(s[i]=='[') open++;
            else{
                if(open > 0)
                open--;
                else close++;
            }
            }

        return (close+1)/2;
    }
}