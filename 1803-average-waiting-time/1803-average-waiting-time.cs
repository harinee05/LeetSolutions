public class Solution {
    public double AverageWaitingTime(int[][] customers) {
        
        double sum =0;
        double finalSum = 0;
        double av =0;
        for(int i=0;i<customers.Length;i++){
            if(i==0 || sum < customers[i][0])
                {
                    sum = customers[i][1]+customers[i][0];
                    finalSum = sum - customers[i][0];
                }
           else{
           sum=sum+customers[i][1];  
           finalSum= Math.Abs(sum - customers[i][0]);
           }
           av+=finalSum;
           Console.WriteLine(finalSum);
        }
        return av/customers.Length;
    }
}