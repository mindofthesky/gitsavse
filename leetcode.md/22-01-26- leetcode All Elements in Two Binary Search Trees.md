
class Solution:
    def inorder(self, root, cur):
        if not root:
            return
        self.inorder(root.left, cur)
        cur.append(root.val)
        self.inorder(root.right, cur)

    def getAllElements(self, root1: TreeNode, root2: TreeNode) -> List[int]:
        list1, list2, ans = deque(), deque(), []

        self.inorder(root1, list1)
        self.inorder(root2, list2)

        while list1 and list2:
                ans.append(list1.popleft() if list1[0] < list2[0] else list2.popleft())
                
        return ans + list(list1) + list(list2)
