class Solution:
    def connect(self, root: 'Node') -> 'Node':
        
        leftmost = root;
        
        while leftmost:
            cur = leftmost;
            leftmost = None;
            pre = None;
            
            while cur:
                if cur.left:
                    if not leftmost:
                        leftmost = cur.left;
                    if pre:
                        pre.next = cur.left;
                    
                    pre = cur.left;
                if cur.right:
                    if not leftmost:
                        leftmost = cur.right;
                    if pre:
                        pre.next = cur.right;
                    
                    pre = cur.right;
                cur =cur.next;
        
        return root;
