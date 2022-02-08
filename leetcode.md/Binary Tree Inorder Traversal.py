class Solution:
    def inorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        res = [];
        stack = [];
        
        while stack or root:
            if root:
                stack.append(root);
                root = root.left;
            else:
                data = stack.pop();
                res.append(data.val);
                root = data.right;
        return res;
