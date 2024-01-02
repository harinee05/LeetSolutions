public class Solution {
    public string MakeSmallestPalindrome(string s) {
        bool change = false;
        int i=0,j=s.Length-1;
        while(i<=j){
            if(s[i]==s[j]){
                i++;
                j--;
            }
            else{
                if(s[i] > s[j])
                s = s.Remove(i, 1).Insert(i, s[j].ToString());
                else s = s.Remove(j, 1).Insert(j, s[i].ToString());

                change = true;
                i++;
                j--;
            }
        }
        if(change) return MakeSmallestPalindrome(s);
        return s;
    }
}
