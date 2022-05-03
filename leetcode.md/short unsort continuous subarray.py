class Solution:
    def findUnsortedSubarray(self, nums: List[int]) -> int:
        stack = [];
        n = len(nums);
        l, mx = n, float('-inf');
        
        for i, N in enumerate(nums):
            while stack and stack[-1][1] > N:
                cand = stack.pop();
                l = min(l,cand[0]);
                mx = max(mx, cand[1]);
            stack.append((i,N));
        if l == n : return 0;
        r = 0 
        for i in range(n-1, -1, -1):
            if nums[i] < mx:
                r = i;
                break;
        return r-l+1;
