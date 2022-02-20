class Solution:
    def recoverTree(self, root: Optional[TreeNode]) -> None:
        """
        Do not return anything, modify root in-place instead.
        """
        self.tmp = [];
        
        def dfs(node):
            if not node: return
            
            dfs(node.left);
            self.tmp.append(node);
            dfs(node.right);
        
        dfs(root);
        
        
        srt = sorted(n.val for n in self.tmp);
        
        for i in range(len(srt)):
            self.tmp[i].val = srt[i];
