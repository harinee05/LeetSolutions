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
    public ListNode MiddleNode(ListNode head) {
        ListNode n = head;
        ListNode m = head;
        while(m!=null && m.next!=null){
            n=n.next;
            m=m.next.next;
        }
        return n;
    }
}