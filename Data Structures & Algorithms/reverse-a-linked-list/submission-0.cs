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
    public ListNode ReverseList(ListNode head) {
    
        if(head is null)
            return null;

        ListNode node = new (head.val, null);
    
        while(head.next != null)
        {
            var temp = head.next;
            node = new (head.next.val, node);
            head = temp;
        }

        return node;
    }
}
