public class Solution {
    public int FindSpecialInteger(int[] arr) {
        var dict = new Dictionary<int, int>();
        foreach (var i in arr)
        {
            if (!dict.ContainsKey(i))
            {
                dict.Add(i, 0);
            }
            dict[i]++;
            
            if (dict[i] > arr.Length / 4) 
            {
                return i;
            }
        }

        return -1;      
    }
}