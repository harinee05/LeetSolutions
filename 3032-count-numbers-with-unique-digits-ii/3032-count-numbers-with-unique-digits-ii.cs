public class Solution {
   
    public int NumberCount(int a, int b) => Enumerable
        .Range(a, b - a + 1)
        .Select(item => item.ToString())
        .Count(item => item.Length == item.Distinct().Count());
}
