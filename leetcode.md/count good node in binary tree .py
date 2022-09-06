class Solution:
    def goodNodes(self, root: TreeNode) -> int:
        self.out =  0;
        
        def dfs(node, mx):
            if not node : return;
            
            if node.val >= mx:
                self.out += 1;
            mx= max(mx, node.val);
            dfs(node.left, mx);
            dfs(node.right, mx);
        
        dfs(root, float('-inf'));
        return self.out;
