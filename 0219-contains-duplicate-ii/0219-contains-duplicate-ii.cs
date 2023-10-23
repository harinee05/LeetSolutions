public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        HashSet<int> s = new HashSet<int>();
        
        for (int i = 0; i < nums.Length; i++) {
            if (s.Contains(nums[i])) {
                return true; // Found a duplicate within distance k.
            }
            
            s.Add(nums[i]); // Add the element to the HashSet.
            
            if (s.Count > k) {
                s.Remove(nums[i - k]); // Remove elements that are beyond distance k.
            }
        }
        
        return false;
    }
}
