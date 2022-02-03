class Solution:
    def partition(self, head: Optional[ListNode], x: int) -> Optional[ListNode]:
        left , right = ListNode(), ListNode();
        tail1, tail2 = left , right;
        
        while head:
            if head.val < x:
                tail1.next = head;
                tail1 = tail1.next;
            else:
                tail2.next =head;
                tail2 = tail2.next;
            head = head.next;
        
        tail1.next = right.next;
        tail2.next = None;
        return left.next;
