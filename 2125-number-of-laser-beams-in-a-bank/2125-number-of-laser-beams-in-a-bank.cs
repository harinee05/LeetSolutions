public class Solution {
    public int NumberOfBeams(string[] bank) {
        List<int> b = new List<int>();
        int c=0,x=0,y=0;
        for(int i=0;i<bank.Length;i++){
            c=0;
            for(int j=0;j<bank[i].Length;j++){
                if(bank[i][j]=='1'){
                    c++;
                }
            }
            if(c>0){
                y+=x*c;
                //Console.WriteLine(y+" "+x);
                x=c;
             }
        }
     return y;   
    }
}