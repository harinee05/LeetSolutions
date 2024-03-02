public class Solution {
    public int[] SortedSquares(int[] nums) {
    List<int> squared = (from num in nums select num * num).ToList();
        squared = squared.OrderBy(n => n).ToList();
        foreach( var i in squared){
            Console.WriteLine(i);
        }
        return squared.ToArray();
    }
}