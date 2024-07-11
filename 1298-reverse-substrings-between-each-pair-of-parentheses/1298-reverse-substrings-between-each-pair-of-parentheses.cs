public class Solution {
    public string ReverseParentheses(string s) {
    Stack<int> stack = new Stack<int>();
    char[] arr = s.ToCharArray();

    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] == '(') {
            stack.Push(i);
        } else if (arr[i] == ')') {
            int start = stack.Pop();
            Array.Reverse(arr, start + 1, i - start - 1); // Reverse the substring between start and i
        }
    }

    // Build the result string excluding the parentheses
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] != '(' && arr[i] != ')') {
            sb.Append(arr[i]);
        }
    }

    return sb.ToString();
}
}