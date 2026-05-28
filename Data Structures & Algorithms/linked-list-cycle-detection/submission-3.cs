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
    public bool HasCycle(ListNode head) {
    
    var r = head;
    var l = head;

    while(r != null && r.next != null)
    {
        l = l.next;
        r = r.next.next;
        
        if (l.Equals(r))
            return true;
    }
    
    return false;
    }
}
