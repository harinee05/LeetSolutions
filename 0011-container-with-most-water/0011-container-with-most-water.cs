public class Solution {
    public int MaxArea(int[] height) {
        int maxArea = 0;
        int maxHeight =0, maxWidth =0;
        int i=0,j=height.Length-1;
        while(i<j){
            
            maxArea = Math.Max(maxArea,(j-i)*Math.Min(height[j],height[i]));
            if(height[i]<=height[j]) i++;
            else j--;
        }
    return maxArea;
    }

}