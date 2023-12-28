public class Solution {
    public int MinimumSum(int num) {
        int[] digits = new int[4];
        int x=num,i=0;
        while(x>0){
            digits[i] = x%10;
            i++;
            x=x/10;
        }
        Array.Sort(digits);
        return ((digits[2]+digits[3])+10*(digits[1]+digits[0]));
    }
}