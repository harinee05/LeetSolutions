public class Solution {
    public bool IsPalindrome(int x) {
        int j=x;
        int d =0;
        int c=0;
        while(j>0){
            d = j%10;
            c = c * 10 + d;
            j=j/10;
        }
        //Console.WriteLine(d+" "+ c);
        return (c==x);
    }
}