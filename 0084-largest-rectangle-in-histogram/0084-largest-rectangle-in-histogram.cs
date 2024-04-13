public class Solution {
    public int LargestRectangleArea(int[] heights) 
        //Stack<int> stack = new Stack<int>();
   // int maxArea = 0;

    //for(int i=0;i<heights.Length;i++){
             
       // while(stack.Count >0 && heights[stack.Peek()]!=height[i]){
            //if(stack.Peek() > heights[i]){
              //  int t = stack.Pop();
               // int area = 
          //  }
               //stack.Push(heights[i]);
       
    {
        
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

               