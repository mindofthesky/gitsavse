class Solution:
    def convertBST(self, root: TreeNode) -> TreeNode:
        
        def dfs(node, carry):
            if not node: return carry;
            carry = dfs(node.right,carry);
            carry += node.val;
            node.val = carry;
            carry = dfs(node.left, carry);
            return carry;
        dfs(root,0);
        return root;
