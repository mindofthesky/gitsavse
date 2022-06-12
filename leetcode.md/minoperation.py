class Solution:
    def minOperations(self, nums: List[int], x: int) -> int:
        dp = [0];
        z = 0;
        for n in nums:
            z += n;
            dp.append(z);
        look = {v:i for i,v in enumerate(dp)};
        
        y = sum(nums) - x;
        ans = -1;
        for l_val, l_idx in look.items():
            if l_val + y in look:
                ans = max(look[l_val + y] - l_idx, ans);
        if ans == -1:
            return ans;
        else:
            return len(nums) - ans;
