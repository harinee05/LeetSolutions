public class Solution {
    public int IslandPerimeter(int[][] grid) {
        int perim = 0;   
        for(int i=0; i<grid.Length; i++){
            for(int j=0; j<grid[i].Length; j++){
                if(grid[i][j] == 1){
                    perim += 4;
                    if(i > 0 && grid[i-1][j] == 1) perim--; // Check above
                    if(i < grid.Length-1 && grid[i+1][j] == 1) perim--; // Check below
                    if(j > 0 && grid[i][j-1] == 1) perim--; // Check left
                    if(j < grid[i].Length-1 && grid[i][j+1] == 1) perim--; // Check right
                }
            }
        }
        return perim;
    }
}
