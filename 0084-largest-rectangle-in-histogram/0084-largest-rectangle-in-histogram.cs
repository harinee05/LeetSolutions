public class Solution {
    public int LargestRectangleArea(int[] heights) {
        Stack<int> stack = new Stack<int>();
    int maxArea = 0;

    // First pass: Calculate the area of rectangles formed by the bars
    for (int index = 0; index < heights.Length; index++) {
        while (stack.Count > 0 && heights[stack.Peek()] > heights[index]) {
            int top = stack.Pop();
            int area = heights[top] * ((stack.Count == 0) ? index : index - stack.Peek() - 1);
            maxArea = Math.Max(maxArea, area);
        }
        stack.Push(index);
    }

    // Second pass: Handle any remaining bars in the stack
    while (stack.Count > 0) {
        int top = stack.Pop();
        int area = heights[top] * ((stack.Count == 0) ? heights.Length : heights.Length - stack.Peek() - 1);
        maxArea = Math.Max(maxArea, area);
    }

    return maxArea;
    }
}
               
               
               