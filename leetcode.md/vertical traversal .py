class Solution:
    def verticalTraversal(self, root: Optional[TreeNode]) -> List[List[int]]:
        lookup = defaultdict(list);
        def dfs(node, x,y):
            if not node: return;
            
            heappush(lookup[x] , (-y, node.val));
            dfs(node.left, x-1, y-1);
            dfs(node.right, x+1, y-1);
            
        dfs(root, 0,0);
        
        out = [];
        
        for k, v in sorted(lookup.items()):
            tmp = [];
            while v:
                cand = heappop(v);
                tmp.append(cand[1]);
            out.append(tmp);
        
        return out;
