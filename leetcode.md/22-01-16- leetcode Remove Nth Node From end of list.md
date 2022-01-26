

class Solution:

    def removeNthFromEnd(self, head: Optional[ListNode], n: int) -> Optional[ListNode]:
        fool = ListNode(0, head);
        left = fool;
        right = head;
        
        while n > 0 and right:
            right = right.next;
            n -= 1;
            
        while right:
            left = left.next;
            right = right.next;
        
        left.next = left.next.next;
        return fool.next;
