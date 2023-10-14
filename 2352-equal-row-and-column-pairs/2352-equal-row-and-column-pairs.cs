public class Solution {
    public int EqualPairs(int[][] grid) {
        int c=0,x=0;
        for(int i=0;i<grid.Length;i++){
            for(int j=0;j<grid[i].Length;j++){
                int k=0;
                c=0;
            while(k<grid.Length){
                if(grid[i][k] == grid[k][j]){
                c++;
                }
                k++;
            }
        if(c==grid[i].Length) x++;
            }
        }
        return x;
    }
}