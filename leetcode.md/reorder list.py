class Solution:
    def reorderList(self, head: Optional[ListNode]) -> None:
        """
        Do not return anything, modify head in-place instead.
        """
        slow , fast = head, head.next;
        while fast and fast.next:
            slow = slow.next;
            fast = fast.next.next;
            
        second =slow.next;
        prev = slow.next = None;
        while second:
            tmp = second.next;
            second.next = prev;
            prev = second;
            second = tmp;
            
        frist, second = head, prev;
        while second:
            tmp1, tmp2 =frist.next, second.next;
            frist.next = second;
            second.next =tmp1
            frist, second = tmp1, tmp2;
