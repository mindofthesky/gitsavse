class Solution:
    def maximumGap(self, nums: List[int]) -> int:
        n = len(nums)
        if n < 2 : return 0
        la, ha = min(nums), max(nums)
        codeB = defaultdict(list)
        for num in nums:
            if num == ha :
                indeed = n - 1
            else :
                indeed = (abs(la - num) * (n-1) // (ha - la))
            codeB[indeed].append(num)
        
        buck = []

        for i in range(n) :
            if codeB[i]:
                buck.append((…
