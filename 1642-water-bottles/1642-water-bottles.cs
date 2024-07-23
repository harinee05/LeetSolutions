public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        int totalBottles = numBottles;

        while (numBottles >= numExchange) {
            int exchangedBottles = numBottles / numExchange; // Bottles we can exchange for new full ones
            int remainingBottles = numBottles % numExchange; // Remaining bottles after exchange
            numBottles = exchangedBottles + remainingBottles; // New total of bottles
            totalBottles += exchangedBottles; // Add only the exchanged (new) bottles to the total
        }

        return totalBottles;
    }
}

