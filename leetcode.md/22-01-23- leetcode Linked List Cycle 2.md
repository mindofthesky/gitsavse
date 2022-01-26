# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution:

    def detectCycle(self, head: Optional[ListNode]) -> Optional[ListNode]:
        slow, fast = head, head;
        while fast and fast.next:
            slow = slow.next;
            fast = fast.next.next;
            if fast == slow: break;
        else:
            return None;
        
        if not fast.next or not fast.next.next: return;
        
        slow2 = head;
        
        while slow2 != fast:
            slow2 = slow2.next;
            fast = fast.next;
        return slow2;
