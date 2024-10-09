public class Solution {
    public int MinSwaps(string s) {
        Stack<char> mins = new Stack<char>();
        int imbal =0;
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
                    imbal++;
            }
            }

        return (imbal+1)/2;
    }
}