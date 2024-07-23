public class Solution {
    public int PassThePillow(int n, int time) {
     int d = -1;
     int rounds = time / (n-1);
     int extra = time % (n-1);
     if(rounds %2==0){
        return extra+1;
     }
     return n-extra;
    }
}