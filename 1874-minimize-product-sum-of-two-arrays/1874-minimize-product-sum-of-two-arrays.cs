public class Solution {
    public int MinProductSum(int[] nums1, int[] nums2) {
        Array.Sort(nums1);
        nums2 = nums2.OrderByDescending(c => c).ToArray();
        int s=0;
        for(int i=0;i<nums1.Length;i++){
            s+=nums1[i]*nums2[i];
        }
        return s;
    }
}

