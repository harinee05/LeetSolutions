using System;
using System.Collections.Generic;

public class Solution {
    public string DecodeString(string s) {
        Stack<char> st = new Stack<char>();
        foreach (char c in s) {
            if (c != ']') {
                st.Push(c);
            } else {
                string subst = "";
                while (st.Peek() != '[') {
                    subst = st.Pop() + subst;
                }
                st.Pop(); // Remove '['

                // Now we need to get the number
                string numStr = "";
                while (st.Count > 0 && char.IsDigit(st.Peek())) {
                    numStr = st.Pop() + numStr;
                }
                int count = int.Parse(numStr);

                // Repeat the substring 'count' times
                string decoded = "";
                for (int i = 0; i < count; i++) {
                    decoded += subst;
                }

                // Push the decoded string back to the stack
                foreach (char d in decoded) {
                    st.Push(d);
                }
            }
        }

        // Build the final result
        string result = "";
        while (st.Count > 0) {
            result = st.Pop() + result;
        }

        return result;
    }
}
