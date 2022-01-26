class Solution:

    def firstMissingPositive(self, nums: List[int]) -> int:
        nums.append(0);
        N = len(nums);
        
        for i in range(N):
            if nums[i] < 0 or nums[i] > N:
                nums[i] = 0;
        temp = nums[0];
        
        for i in range(N):
            if nums[i] > 0:
                nums[nums[i] % N - 1] += N;
        if nums[0] == temp: return 1;
        
        for i in range(N):
            if nums[i] // N == 0:
                return i + 1;
        return N;
