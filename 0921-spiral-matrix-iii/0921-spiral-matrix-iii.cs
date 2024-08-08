public class Solution {
    public int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart) {
int[][] result = new int[rows * cols][];
        int currentRow = rStart, currentCol = cStart, deltaRow = 0, deltaCol = 1, steps = 0, count = 0;
        while (count < rows * cols) {
            for (int i = 0; i < steps / 2 + 1; i++) {
                if (currentRow >= 0 && currentRow < rows && currentCol >= 0 && currentCol < cols)
                    result[count++] = new int[] { currentRow, currentCol };
                currentRow += deltaRow;
                currentCol += deltaCol;
            }
            if (deltaCol == 1) { // right
                deltaCol = 0;
                deltaRow = 1;
            }
            else if (deltaRow == 1) { // down
                deltaRow = 0;
                deltaCol = -1;
            }
            else if (deltaCol == -1) { // left
                deltaCol = 0;
                deltaRow = -1;
            }
            else if (deltaRow == -1) { // up
                deltaRow = 0;
                deltaCol = 1;
            }
            steps++;
        }
        return result;
    }
}