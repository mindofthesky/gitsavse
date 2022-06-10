class Solution:
    def checkSubarraySum(self, nums: List[int], k: int) -> bool:
        remain = { 0 : -1};
        total = 0;
        
        for i, n in enumerate(nums):
            total += n;
            r = total % k;
            if r not in remain:
                remain[r] = i;
            elif i - remain[r] > 1:
                return True;
        return False;
