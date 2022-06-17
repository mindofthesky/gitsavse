class Solution:
    def minCameraCover(self, root: Optional[TreeNode]) -> int:
        self.out = 0;
        def dfs(node):
            if not node:
                return False,True;
            c1,m1 = dfs(node.left);
            c2,m2 = dfs(node.right);
                
            camera, monitor = False, False;
            
            if c1 or c2:
                monitor = True;
            if not m1 or not m2:
                camera = True;
                self.out += 1;
                monitor = True;
            return camera, monitor;
        c, m = dfs(root);
        if not m:return self.out + 1;
        return self.out;
