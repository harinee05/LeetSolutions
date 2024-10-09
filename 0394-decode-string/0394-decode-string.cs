using System;
using System.Collections.Generic;
using System.Text;

public class Solution {
    public string DecodeString(string s) {
        Stack<int> countStack = new Stack<int>();
        Stack<string> stringStack = new Stack<string>();
        StringBuilder currentString = new StringBuilder();
        int currentNumber = 0;

        foreach (char c in s) {
            if (char.IsDigit(c)) {
                // Build the current number
                currentNumber = currentNumber * 10 + (c - '0');
            } else if (c == '[') {
                // Push the current number and string onto their respective stacks
                countStack.Push(currentNumber);
                stringStack.Push(currentString.ToString());
                // Reset for the next segment
                currentNumber = 0;
                currentString.Clear();
            } else if (c == ']') {
                // Pop from the stacks and build the decoded string
                string prevString = stringStack.Pop();
                int repeatCount = countStack.Pop();
                currentString = new StringBuilder(prevString + currentString.ToString().Repeat(repeatCount));
            } else {
                // Append the current character to the current string
                currentString.Append(c);
            }
        }

        return currentString.ToString();
    }
}

public static class StringExtensions {
    public static string Repeat(this string str, int count) {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < count; i++) {
            result.Append(str);
        }
        return result.ToString();
    }
}
