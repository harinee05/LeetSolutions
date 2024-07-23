public class Solution {
    public int PassThePillow(int n, int time) {
     if((time / (n-1)) %2==0){
        return (time % (n-1))+1;
     }
     return n-(time % (n-1));
    }
}