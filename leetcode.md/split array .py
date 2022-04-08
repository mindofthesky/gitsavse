class Solution:
    def splitArray(self, nums: List[int], m: int) -> int:
        def canSplit(largest):
            sub = 0
            cur = 0
            for n in nums:
                cur += n
                if cur > largest:
                    sub += 1
                    cur = n
            return sub + 1 <= m
        
        i, j = max(nums), sum(nums)
        res = j
        while i <= j:
            mid = i + ((j - i) // 2)
            if canSplit(mid):
                res = mid
                j = mid - 1
            else:
                i = mid + 1
        return res
