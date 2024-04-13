public class Solution {
    public int MaximalRectangle(char[][] matrix) {
        if (matrix == null || matrix.Length == 0) return 0;
        int maxArea = 0;
        int[] heights = new int[matrix[0].Length];
        
        for (int i = 0; i < matrix.Length; i++) {
            for (int j = 0; j < matrix[0].Length; j++) {
                if (matrix[i][j] == '1') {
                    heights[j]++;
                } else {
                    heights[j] = 0;
                }
            }
            maxArea = Math.Max(maxArea, maxAreaHistogram(heights));
        }
        
        return maxArea;
    }
    
    private int maxAreaHistogram(int[] heights) {
        Stack<int> stack = new Stack<int>();
        int maxArea = 0;
        int index = 0;
        
        while (index < heights.Length) {
            if (stack.Count == 0 || heights[stack.Peek()] <= heights[index]) {
                stack.Push(index++);
            } else {
                int top = stack.Pop();
                int area = heights[top] * ((stack.Count == 0) ? index : index - stack.Peek() - 1);
                maxArea = Math.Max(maxArea, area);
            }
        }
        
        while (stack.Count > 0) {
            int top = stack.Pop();
            int area = heights[top] * ((stack.Count == 0) ? index : index - stack.Peek() - 1);
            maxArea = Math.Max(maxArea, area);
        }
        
        return maxArea;
    }
}
