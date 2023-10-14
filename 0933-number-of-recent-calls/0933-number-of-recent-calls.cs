public class RecentCounter {
    Queue<int> qu = new Queue<int>();
    int c;
    public RecentCounter() {
       c=0;
    }
    
    public int Ping(int t) {
       qu.Enqueue(t);
       c++;
       while(qu.Count > 0 && (qu.Peek() > t || qu.Peek()<(t-3000))){
           qu.Dequeue();
           c--;
       }
       return c;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */