using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] ArrayRankTransform(int[] arr) {
        int[] copy = (int[])arr.Clone(); // Create a copy of the array
        Array.Sort(copy); // Sort the copied array

        Dictionary<int, int> ranks = new Dictionary<int, int>();
        int rank = 1;

        // Assign ranks based on sorted unique values
        for (int i = 0; i < copy.Length; i++) {
            if (!ranks.ContainsKey(copy[i])) {
                ranks[copy[i]] = rank++;
            }
        }

        // Transform the original array based on the ranks
        for (int i = 0; i < arr.Length; i++) {
            arr[i] = ranks[arr[i]];
        }

        return arr; // Return the transformed array
    }
}
