class Solution:
    def rightSideView(self, root: Optional[TreeNode]) -> List[int]:
        l = defaultdict(int);
        def dfs(node,h):
            if not node: return;
            if h not in l :
                l[h] = node.val;
            dfs(node.right, h + 1);
            dfs(node.left, h + 1);
        
        dfs(root,0);
        
        return l.values()
