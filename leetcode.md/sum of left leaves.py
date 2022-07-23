class Solution:
    def sumOfLeftLeaves(self, root: Optional[TreeNode]) -> int:
        self.total = 0;
        
        def dfs(node, left):
            if not node:
                return;
            dfs(node.left,True);
            dfs(node.right, False);
            
            if not node.left and not node.right and left:
                self.total += node.val;
        dfs(root, False);
        
        return self.total;
