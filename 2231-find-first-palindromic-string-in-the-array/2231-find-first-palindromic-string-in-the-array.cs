public class Solution {
    public string FirstPalindrome(string[] words) 
=> words.FirstOrDefault(x=>x == string.Concat(x.Reverse()))??"";
}