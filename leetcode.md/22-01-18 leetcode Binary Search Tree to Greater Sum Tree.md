
class Solution:
    val: int = 0;
    
    def bstToGst(self, root: TreeNode) -> TreeNode:
        if root:
            self.bstToGst(root.right);
            self.val += root.val;
            root.val = self.val;
            self.bstToGst(root.left);
            
        return root;
