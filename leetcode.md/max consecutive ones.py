class Solution:
    def findMaxConsecutiveOnes(self, nums: List[int]) -> int:
        l, out = 0,0

        for r , n in enumerate(nums):
            if n == 0 :
                l = r + 1
            out = max(out, r -l + 1)
        return out
