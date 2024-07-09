public class Solution {
    public double AverageWaitingTime(int[][] customers) {
        
        double sum = customers[0][0]+customers[0][1];
        double finalSum = sum - customers[0][0];
        foreach(var i in customers.Skip(1)){
            
            if(sum < i[0]){
                sum = i[0]+i[1];
            }
            else{
            sum+=i[1];
            }
            finalSum += sum - i[0];
        }
        return finalSum/customers.Length;
    }
}

// for(int i=0;i<customers.Length;i++){
//             if(i==0 || sum < customers[i][0])
//                 {
//                     sum = customers[i][1]+customers[i][0];
                   
//                 }
//            else{
//            sum=sum+customers[i][1];  
          
//            }
//           finalSum += sum - customers[i][0];