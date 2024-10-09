public class Solution {
    public int MinAddToMakeValid(string s) {
        int bal=0,finalBal=0;
        foreach(char c in s){
            if(c=='('){
                bal++;
            }
            else if(bal<=0){
                 finalBal++;
            }
            else
            bal--;
          }
        return bal+finalBal;
    }
}