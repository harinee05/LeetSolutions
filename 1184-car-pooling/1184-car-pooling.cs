using System;
using System.Collections.Generic;

public class Solution {
    public bool CarPooling(int[][] trips, int capacity) {
    // Initialize an array to track the number of passengers at each point
    int[] passengerChanges = new int[1001]; // Assuming the maximum point is 1000 (based on problem constraints)

    // Update the array with the passenger changes for each trip
    foreach (var trip in trips) {
        int numPassengers = trip[0];
        int start = trip[1];
        int end = trip[2];

        passengerChanges[start] += numPassengers;
        passengerChanges[end] -= numPassengers;
    }

    // Track the current number of passengers in the car
    int currentPassengers = 0;

    // Iterate through the array to check if the capacity is exceeded at any point
    for (int i = 0; i < passengerChanges.Length; i++) {
        currentPassengers += passengerChanges[i];
        if (currentPassengers > capacity) {
            return false;
        }
    }

    return true;
}

    }
