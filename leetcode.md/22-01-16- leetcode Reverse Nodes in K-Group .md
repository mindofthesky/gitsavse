python leetcode Discuss 참조 자료 
이것보다 복잡한 알고리즘은 코테에서 좋겠지만 이런 미친 최적화 코드는 좀 고민이된다 

좀더 많은 코드를 참조해서 생각해봐야겠다 

class Solution:
    def reverseKGroup(self, head: Optional[ListNode], k: int) -> Optional[ListNode]:
        count, node = 1, head
        while node and count < k:
            node = node.next
            count += 1
        if not node:
            return head

        node.next = self.reverseKGroup(node.next, k)
        p, q = head, head.next
        while head != node:
            p.next = q.next
            q.next = head
            head, q = q, p.next
        return head
