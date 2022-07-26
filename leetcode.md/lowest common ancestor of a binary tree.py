class Solution:
    def lowestCommonAncestor(self, root: 'TreeNode', p: 'TreeNode', q: 'TreeNode') -> 'TreeNode':
        self.ans = None;
        def dfs(node):
            if not node:
                return False;
            left = dfs(node.left);
            right = dfs(node.right);
            cur = node == p or node == q;
            if (left and right) or (cur and right) or (cur and left):
                self.ans = node;
                return;
            return left or right or cur;
        dfs(root);
        return self.ans;
