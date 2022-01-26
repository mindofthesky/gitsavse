
class Solution:

    def invertTree(self, root: Optional[TreeNode]) -> Optional[TreeNode]:
        stack = collections.deque([root]);
        
        while stack:
            node =stack.pop();
            
            if node:
                stack.append(node.left);
                stack.append(node.right);
                
                node.left, node.right = node.right, node.left;
                
        return root;
