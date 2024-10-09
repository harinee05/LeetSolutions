public class Solution {
    public int MinSwaps(string s) {
        Stack<char> mins = new Stack<char>();
        
        if(s=="" || s=="[]")
            return 0;
        for(int i=0;i<s.Length;i++){
            if(s[i]=='[') mins.Push(s[i]);
            else{
                if(mins.Count > 0)
                {
                   
                    mins.Pop();
                   
                }
                 else
                    continue;
            }
            }

        return (mins.Count+1)/2;
    }
}