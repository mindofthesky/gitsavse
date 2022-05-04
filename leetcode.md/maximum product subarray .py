class Solution:
    def maxProduct(self, nums: List[int]) -> int:
        
        res = max(nums);
        cmin , cmax = 1,1;
        
        for n in nums:
            if n == 0:
                cmin, cmax = 1,1;
                continue;
            tmp = cmax * n;
            cmax = max(n * cmax, n * cmin, n);
            cmin = min(tmp, n * cmin , n);
            res = max(res,cmax);
        return res;
        
