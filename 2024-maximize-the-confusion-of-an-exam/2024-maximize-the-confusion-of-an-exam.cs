public class Solution {
    public int MaxConsecutiveAnswers(string answerKey, int k) {
        int tc=0,fc=0, mc=0;
        int l=0,r=0;
        while(r<answerKey.Length){
            if(answerKey[r]=='T'){
                tc++;
            }
            else{
                fc++;
            }
             if (Math.Min(tc, fc) > k) {
                if (answerKey[l] == 'T') {
                    tc--;
                } else {
                    fc--;
                }
                l++;
            }
            
            mc = Math.Max(mc, r - l + 1);
            
            r++;
        }
        
        return mc;
        }
}