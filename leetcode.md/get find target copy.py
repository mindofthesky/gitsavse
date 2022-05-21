class Solution:
    def getTargetCopy(self, original: TreeNode, cloned: TreeNode, target: TreeNode) -> TreeNode:
        
        def dfs(node1, node2):
            if not node1:
                return None;
            elif node1 == target:
                return node2
            return dfs(node1.left, node2.left) or dfs(node1.right, node2.right);
        return dfs(original, cloned);
