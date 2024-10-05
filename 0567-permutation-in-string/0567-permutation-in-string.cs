public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        int s1Length = s1.Length;
        int s2Length = s2.Length;

        if (s1Length > s2Length)
            return false;

        // Count characters in s1
        Dictionary<char, int> s1Count = new Dictionary<char, int>();
        foreach (char c in s1)
        {
            if (s1Count.ContainsKey(c))
                s1Count[c]++;
            else
                s1Count[c] = 1;
        }

        // Sliding window for s2
        Dictionary<char, int> s2Count = new Dictionary<char, int>();
        for (int i = 0; i < s1Length; i++)
        {
            char c = s2[i];
            if (s2Count.ContainsKey(c))
                s2Count[c]++;
            else
                s2Count[c] = 1;
        }

        // Check the first window
        if (Matches(s1Count, s2Count))
            return true;

        // Slide the window over s2
        for (int i = s1Length; i < s2Length; i++)
        {
            // Add the next character in the window
            char addChar = s2[i];
            if (s2Count.ContainsKey(addChar))
                s2Count[addChar]++;
            else
                s2Count[addChar] = 1;

            // Remove the character that is sliding out of the window
            char removeChar = s2[i - s1Length];
            if (s2Count[removeChar] == 1)
                s2Count.Remove(removeChar);
            else
                s2Count[removeChar]--;

            // Check if the current window matches
            if (Matches(s1Count, s2Count))
                return true;
        }

        return false;
    }

    private bool Matches(Dictionary<char, int> count1, Dictionary<char, int> count2)
    {
        if (count1.Count != count2.Count)
            return false;

        foreach (var kvp in count1)
        {
            if (!count2.TryGetValue(kvp.Key, out int count) || count != kvp.Value)
                return false;
        }
        return true;
    }
}