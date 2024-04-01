public class Solution {
    public int LengthOfLastWord(string s) {
        bool flag=false;
        int c=0;
      for(int i=s.Length-1;i>=0;--i){
          
        if(s[i] == ' '){
            flag = true;
        }
          else if(c>0 && flag){
              return c;
          }
        else 
        {
            flag=false;
              c++;
        }
          
      }
        return c;
    }
}