public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        int totalBottles = 0;
        while(numBottles >= numExchange){
           totalBottles += numExchange;
           numBottles-=numExchange;
           numBottles++;
        }
        return totalBottles+numBottles;
    }
}