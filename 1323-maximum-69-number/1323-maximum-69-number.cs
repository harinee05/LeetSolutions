public class Solution {
    public int Maximum69Number (int num) {
        bool t = false;
      StringBuilder l = new StringBuilder(num.ToString());
        for(int i = 0 ; i < l.Length; i++){
            if(l[i] == '6' && !t){
                l[i] = '9';
                t = true;
            }
        }
        
        return int.Parse(l.ToString());
    }
}