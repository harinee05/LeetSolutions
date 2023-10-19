/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        ListNode x = head;
         List<int> n = new List<int>();
        while(x!=null){
            n.Add(x.val);
            //Console.WriteLine(x.val);
            x=x.next;
        }     
        for(int i=0;i<n.Count/2;i++){
            if(n[i] != n[n.Count-1 -i]){
                //d =  true;
                return false;
            }

    }

    
    return true;
    }
}