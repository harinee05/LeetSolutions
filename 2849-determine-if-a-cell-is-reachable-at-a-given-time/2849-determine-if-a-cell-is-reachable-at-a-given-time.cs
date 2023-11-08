public class Solution {
    public bool IsReachableAtTime(int sx, int sy, int fx, int fy, int t) {
         int dist = Math.Max(Math.Abs(fy-sy),Math.Abs(fx-sx));
        if(dist == 0 && t == 1)
            return false;
        else
            return dist <= t;
    
    }
}