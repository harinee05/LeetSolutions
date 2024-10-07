public class Solution {
    public int MinLength(string s) {
        Stack<char> res = new Stack<char>();
        foreach(char c in s){
            if(res.Count>0){
                char i=res.Peek();
            if((i=='A' && c=='B') ||(i=='C'&& c=='D')){
                res.Pop();
            continue;
            }
            }
            res.Push(c);
        }
return res.Count;
       
    }
}