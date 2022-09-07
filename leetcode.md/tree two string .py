class Solution:
    def tree2str(self, root: Optional[TreeNode]) -> str:
        
        res = []; 
        
        def pre(root):
            if not root:
                return
            res.append("(");
            res.append(str(root.val));

            if not root.left and root.right:
                res.append("()")
            pre(root.left);
            pre(root.right);
            res.append(")");
        pre(root)
        return "".join(res)[1:-1];
