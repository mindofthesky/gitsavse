
class Solution:

    def rotateRight(self, head: Optional[ListNode], k: int) -> Optional[ListNode]:
        if not head:
            return head;
        
        length, tail = 1, head;
        while tail.next:
            print(tail);
            tail = tail.next;
            length += 1;
        
        k = k % length;
        if k == 0:
            return 0;
        
        cur = head;
        for i in range(length - k - 1):
            cur = cur.next;
        newhead = cur.next;
        cur.next = None;
        tail.next = head;
        return newhead;
