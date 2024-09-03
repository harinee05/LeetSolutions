public class Solution {
    public int MaxProfit(int[] prices) {
        int min = prices[0];
        int p=0;
        foreach(var x in prices){
            p = Math.Max(p, x-min);
            min = Math.Min(min,x);
        }
    return p;
    }
}