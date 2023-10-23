public class Solution {
    public int MaxArea(int[] height) {
        int l=0,r=height.Length-1;
        int ma=0;
        int area=0;
        while(l<r){
            area = (r-l)*Math.Min(height[l],height[r]);
            if(ma< area){ ma = area; }
            if(height[l]> height[r]) r--;
            else l++;
        }
        return ma;
    }
}