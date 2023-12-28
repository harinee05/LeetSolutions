public class Solution {
    public int BalancedStringSplit(string s) {
        int r=0,l=0,c=0;
        for(int x=0;x<s.Length;x++){
            if(s[x]=='R')
            {
                r++;
            }
            else{
                l++;
            }
            if(l-r==0){
                c++;
                l=0;
                r=0;
            }
                }
    return c;
    }
}