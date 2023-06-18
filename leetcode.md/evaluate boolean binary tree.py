class Solution:
    def evaluateTree(self, root: Optional[TreeNode]) -> bool:

        def dfs(root):
            if not root.left and not root.right:
                if root.val == 1:
                    return True
                elif root.val == 0:
                    return False
            left = dfs(root.left)
            right = dfs(root.right)
            if root.val == 2:
                return left or right
            elif root.val == 3:
                return left and right
        return dfs(root)
