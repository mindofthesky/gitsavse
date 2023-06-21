class Solution:
    def minCost(self, nums: List[int], cost: List[int]) -> int:
        def cal_cost(l):
            total_cost = 0
            for i , x in enumerate(nums):
                total_cost += abs(l-x) * cost[i]

            return total_cost

        left = min(nums)
        right = max(nums)
        mid = (left + right) // 2

        while left < right:
            if cal_cost(mid) < cal_cost(mid+1):
                right = mid
            
            else:
                left = mid + 1
            
            mid = (left + right) // 2
        
        return cal_cost(left)
