public class Solution {
    public int MaximumGain(string s, int x, int y) {
        // Determine the high priority pair and its corresponding score
        char firstChar = x > y ? 'a' : 'b';
        char secondChar = x > y ? 'b' : 'a';
        int highScore = Math.Max(x, y);
        int lowScore = Math.Min(x, y);

        // Stack to help in removing pairs
        Stack<char> stack = new Stack<char>();
        int score = 0;

        // First pass to remove high priority pairs
        foreach (char c in s) {
            if (stack.Count > 0 && stack.Peek() == firstChar && c == secondChar) {
                stack.Pop();
                score += highScore;
            } else {
                stack.Push(c);
            }
        }

        // Prepare for the second pass to remove low priority pairs
        s = new string(stack.ToArray());
        stack.Clear();

        // Second pass to remove low priority pairs
        for (int i = s.Length - 1; i >= 0; i--) {
            char c = s[i];
            if (stack.Count > 0 && stack.Peek() == secondChar && c == firstChar) {
                stack.Pop();
                score += lowScore;
            } else {
                stack.Push(c);
            }
        }

        return score;
    }
}
