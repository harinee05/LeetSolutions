public class Solution {
    public int KthGrammar(int n, int k) {
        if (n == 1) return 0;
        int l = 1 << (n - 2);
        //Console.WriteLine(KthGrammar(n-1,k));
        //Console.WriteLine( 1 - KthGrammar(n - 1, k - l));
        if (k <= l) return KthGrammar(n - 1, k);
        else return 1 - KthGrammar(n - 1, k - l);
    }
}