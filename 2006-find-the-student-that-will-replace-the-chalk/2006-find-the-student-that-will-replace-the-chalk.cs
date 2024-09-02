public class Solution {
    public int ChalkReplacer(int[] chalk, int k) {
        long totalChalk = 0;
        foreach (var c in chalk) {
            totalChalk += c;
        }

        int remainingChalk = (int)(k % totalChalk);
        for(int i=0;i<chalk.Length;i++){
            remainingChalk -= chalk[i];
            if(remainingChalk<0) return i;
        }
        return 0;
        }
}
