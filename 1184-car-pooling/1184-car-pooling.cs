using System;
using System.Collections.Generic;

public class Solution {
    public bool CarPooling(int[][] trips, int capacity) {
        // Create a list to store the changes in passenger count at each point.
        List<int[]> events = new List<int[]>();

        foreach (var trip in trips) {
            int numPassengers = trip[0];
            int start = trip[1];
            int end = trip[2];
            events.Add(new int[] { start, numPassengers }); // Adding passengers at start
            events.Add(new int[] { end, -numPassengers });  // Removing passengers at end
        }

        // Sort the events. If two events have the same position, the removal of passengers (-numPassengers)
        // should come before the addition of passengers (numPassengers) to avoid exceeding capacity.
        events.Sort((a, b) => {
            if (a[0] == b[0]) {
                return a[1] - b[1];
            }
            return a[0] - b[0];
        });

        int currentPassengers = 0;
        foreach (var e in events) {
            currentPassengers += e[1];
            if (currentPassengers > capacity) {
                return false;
            }
        }

        return true;
    }
}
