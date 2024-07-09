public class Solution {
    public int FindTheWinner(int n, int k) {
       Queue<int> circle = new Queue<int>();
       for(int i=1;i<=n;i++){
        circle.Enqueue(i);
       }
       while(circle.Count > 1)
{
  for(var i =1;i<k;i++){
        circle.Enqueue(circle.Dequeue());
}     
circle.Dequeue();
       }
       return circle.Peek();
    }
}