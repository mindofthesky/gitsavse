역순 연결 리스트



class Solution:
   
   def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:
       
       node, prev = head,None;
        
        while node:
            next, node.next = node.next, prev
            prev, node = node, next;
            
        return prev;
