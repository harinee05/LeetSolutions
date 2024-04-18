public class Solution {
    public bool IsPowerOfFour(int n) {
       if(n==0) return false;
        while(n%4==0){
            return IsPowerOfFour(n/4);
        }
        
        return n==1;
    }     
}