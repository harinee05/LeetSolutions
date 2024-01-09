public class Solution {
    public int MinimumSum(int num) {
        int[] splitn= new int[4];
        int i=0;
        while(num>0){
            splitn[i] = num % 10;
            ++i;
            num /= 10;
        }
        Array.Sort(splitn);
        return 10*(splitn[0]+splitn[1])+ splitn[2]+splitn[3];
    }
}