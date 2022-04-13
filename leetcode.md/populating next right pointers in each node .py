
class Solution:
    def connect(self, node: 'Optional[Node]') -> 'Optional[Node]':
        cur, nexts =node, node.left if node else None;
        
        while cur and nexts:
            cur.left.next = cur.right;
            if cur.next:
                cur.right.next = cur.next.left;
                
            
            cur = cur.next;
            if not cur:
                cur = nexts;
                nexts = cur.left;
        return node;
